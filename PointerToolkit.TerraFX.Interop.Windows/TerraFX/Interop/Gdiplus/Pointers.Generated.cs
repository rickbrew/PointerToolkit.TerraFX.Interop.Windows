using PointerToolkit;
using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Gdiplus;

public static unsafe class Pointers
{
    [Obsolete("The __cast methods have major performance consequences at build time. Switch to casting directly to the PIImageBytes struct.", false)]
    public static PIImageBytes __cast(TerraFX.Interop.Gdiplus.IImageBytes* p) => (PIImageBytes)p;
}
