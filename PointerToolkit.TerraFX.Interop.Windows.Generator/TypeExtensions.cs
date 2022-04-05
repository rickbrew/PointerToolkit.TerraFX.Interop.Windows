using System;
using System.Collections.Generic;
using System.Linq;

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
}
