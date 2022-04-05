using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using TerraFX.Interop.Windows;

namespace PointerToolkit.TerraFX.Interop.Windows.Generator;

public static class Program
{
    public static int Main(string[] args)
    {
        try
        {
            MainImpl(args[0]);
            return 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine();
            Console.WriteLine("*** Unhandled Exception: " + ex.ToString());
            return Marshal.GetHRForException(ex);
        }
    }

    public static void MainImpl(string outputDirPath)
    {
        Console.WriteLine($"TerraFX.Interop.Windows.Pointers generator, outputting to {outputDirPath}");

        Assembly terraFxDll = typeof(global::TerraFX.Interop.Windows.Windows).Assembly;

        Type[] types = terraFxDll.GetTypes();

        Type[] comStructTypes = types
            .Where(type => typeof(IUnknown.Interface).IsAssignableFrom(type))
            .Where(type => type.IsValueType)
            .OrderBy(type => type.FullName, StringComparer.OrdinalIgnoreCase)
            .ToArray();

        Dictionary<Type, Type> comStructToInterfaceMap = comStructTypes
            .Select(type => new KeyValuePair<Type, Type>(type, terraFxDll.GetType(type.FullName + "+Interface", true)!))
            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

        Dictionary<Type, Type> interfaceToComStructMap = comStructToInterfaceMap
            .ToDictionary(kvp => kvp.Value, kvp => kvp.Key);

        Dictionary<Type, Type> comStructToBaseType = new();
        foreach (Type comStructType in comStructTypes)
        {
            if (comStructType == typeof(IUnknown))
            {
                continue;
            }

            Type interfaceType = comStructToInterfaceMap[comStructType];
            Type baseInterfaceType = interfaceType.GetDirectBaseInterfaces().Single();
            Type baseComStructType = interfaceToComStructMap[baseInterfaceType];
            comStructToBaseType.Add(comStructType, baseComStructType);
        }

        Dictionary<Type, List<Type>> comStructToDerivedTypes = new();
        foreach ((Type comStructType, Type baseComStructType) in comStructToBaseType)
        {
            if (!comStructToDerivedTypes.TryGetValue(baseComStructType, out List<Type>? derivedTypes))
            {
                derivedTypes = new(1);
                comStructToDerivedTypes.Add(baseComStructType, derivedTypes);
            }

            derivedTypes.Add(comStructType);
        }

        Dictionary<Type, HashSet<Type>> comStructToAllDerivedTypes = new();
        foreach (Type comStructType in comStructTypes)
        {
            Type? type = comStructType;
            while (type != null)
            {
                if (comStructToBaseType.TryGetValue(type, out Type? baseType))
                {
                    if (!comStructToAllDerivedTypes.TryGetValue(baseType, out HashSet<Type>? allDerivedFromBaseType))
                    {
                        allDerivedFromBaseType = new();
                        comStructToAllDerivedTypes.Add(baseType, allDerivedFromBaseType);
                    }

                    allDerivedFromBaseType.Add(comStructType);
                }

                type = baseType;
            }
        }

        Dictionary<Type, List<Type>> comStructToBaseTypes = new();
        foreach (Type comStructType in comStructToBaseType.Keys)
        {
            if (!comStructToBaseTypes.TryGetValue(comStructType, out List<Type>? baseTypes))
            {
                baseTypes = new(1);
                comStructToBaseTypes.Add(comStructType, baseTypes);
            }

            Type derivedType = comStructType;
            while (comStructToBaseType.TryGetValue(derivedType, out Type? baseType))
            {
                baseTypes.Add(baseType);
                derivedType = baseType;
            }
        }

        string[] namespaces = types.Select(t => t.Namespace!)
            .Distinct(StringComparer.Ordinal)
            .ToArray();

        // AssemblyInfo.Generated.cs
        GenerateFile(
            Path.Combine(outputDirPath, "AssemblyInfo.Generated.cs"),
            delegate (TextWriter writer)
            {
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Reflection;");
                writer.WriteLine("using System.Runtime.Versioning;");
                writer.WriteLine();
                writer.WriteLine("[assembly: AssemblyTitle(\"TerraFX.Interop.Windows.Pointers\")]");
                writer.WriteLine("[assembly: AssemblyMetadata(\"IsTrimmable\", \"True\")]");

                writer.WriteLine($"[assembly: AssemblyVersion(\"{terraFxDll.GetName().Version!}\")]");

                AssemblyFileVersionAttribute? assemblyFileVersion = terraFxDll.GetCustomAttribute<AssemblyFileVersionAttribute>();
                if (assemblyFileVersion != null)
                {
                    writer.WriteLine($"[assembly: AssemblyFileVersion(\"{assemblyFileVersion.Version}\")]");
                }

                AssemblyInformationalVersionAttribute? assemblyInformationalVersion = terraFxDll.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
                if (assemblyInformationalVersion != null)
                {
                    writer.WriteLine($"[assembly: AssemblyInformationalVersion(\"{assemblyInformationalVersion.InformationalVersion}\")]");
                }

                writer.WriteLine("[assembly: SupportedOSPlatform(\"windows\")]");
            });

        // Pointers.Generated.cs
        foreach (string @namespace in namespaces)
        {
            Type[] nsComStructTypes = comStructTypes
                .Where(t => string.Equals(@namespace, t.Namespace))
                .OrderBy(t => t.FullName, StringComparer.OrdinalIgnoreCase)
                .ToArray();

            if (nsComStructTypes.Length == 0)
            {
                continue;
            }

            string filePath;
            {
                List<string> filePathComponents = new();
                filePathComponents.Add(outputDirPath);
                filePathComponents.AddRange(@namespace.Split('.') ?? Array.Empty<string>());
                filePathComponents.Add("Pointers.Generated.cs");
                filePath = Path.Combine(filePathComponents.ToArray());
            }

            GenerateFile(
                filePath,
                delegate (TextWriter writer)
                {
                    writer.WriteLine("using PointerToolkit;");
                    writer.WriteLine("using System;");
                    writer.WriteLine("using System.Runtime.CompilerServices;");
                    writer.WriteLine();
                    writer.WriteLine($"namespace {@namespace};");
                    writer.WriteLine();
                    writer.WriteLine("public static unsafe class Pointers");
                    writer.WriteLine("{");

                    bool isFirst = true;
                    foreach (Type comStructType in nsComStructTypes)
                    {
                        List<string> castPtrTypeParamsList;
                        if (comStructToBaseTypes.TryGetValue(comStructType, out List<Type>? baseTypes))
                        {
                            castPtrTypeParamsList = new(1 + baseTypes.Count);
                            castPtrTypeParamsList.Add(comStructType.FullName!);
                            foreach (Type baseType in baseTypes)
                            {
                                castPtrTypeParamsList.Add(baseType.FullName!);
                            }
                        }
                        else
                        {
                            castPtrTypeParamsList = new(1);
                            castPtrTypeParamsList.Add(comStructType.FullName!);
                        }

                        string castPtrTypeParams = string.Join(", ", castPtrTypeParamsList);

                        if (!isFirst)
                        {
                            writer.WriteLine();
                        }
                        isFirst = false;

                        writer.WriteLine("    [MethodImpl(MethodImplOptions.AggressiveInlining)]");
                        writer.WriteLine($"    public static CastPtr<{castPtrTypeParams}> __cast({comStructType.FullName}* ptr) => *(CastPtr<{castPtrTypeParams}>*)&ptr;");
                    }

                    writer.WriteLine("}");
                });
        }        
    }

    public static void GenerateFile(string filePath, Action<TextWriter> writeCallback)
    {
        Console.Write($"{filePath} ... ");

        using MemoryStream stream = new MemoryStream();
        using (TextWriter writer = new StreamWriter(stream, Encoding.UTF8, leaveOpen: true))
        {
            writeCallback(writer);
        }

        byte[] newBytes = stream.GetBuffer();
        Array.Resize(ref newBytes, checked((int)stream.Length));

        if (File.Exists(filePath))
        {
            byte[] oldBytes = File.ReadAllBytes(filePath);

            if (oldBytes.SequenceEqual(newBytes))
            {
                // don't write anything
                Console.WriteLine("unchanged");
                return;
            }
        }

        string dirPath = Path.GetDirectoryName(filePath)!;
        Directory.CreateDirectory(dirPath);

        File.WriteAllBytes(filePath, newBytes);
        Console.WriteLine();
    }
}
