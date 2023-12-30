using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;

namespace PointerToolkit.TerraFX.Interop.Windows.Generator;

public static class TypeExtensions
{
    public static Type[] GetDirectBaseInterfaces(this Type type)
    {
        Type[] allInterfaces = type.GetInterfaces();

        IEnumerable<Type> excludedTypes = allInterfaces.SelectMany(t => t.GetInterfaces());

        if (type.BaseType != null)
        {
            excludedTypes = excludedTypes.Concat(type.BaseType.GetInterfaces());
        }

        return allInterfaces.Except(excludedTypes).ToArray();
    }

    public static bool? IsObsolete(this Type type, [NotNullWhen(true)] out string? message, bool inherit = true)
    {
        try
        {
            ObsoleteAttribute? attribute = type.GetCustomAttribute<ObsoleteAttribute>(inherit);
            if (attribute is null)
            {
                message = null;
                return false;
            }

            message = attribute.Message;
            return true;
        }
        catch (Exception)
        {
            message = null;
            return null;
        }
    }
}
