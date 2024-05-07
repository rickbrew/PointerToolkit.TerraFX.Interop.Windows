using PointerToolkit;
using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Gdiplus;

public static unsafe class Pointers
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static PIImageBytes __cast(TerraFX.Interop.Gdiplus.IImageBytes* p) => (PIImageBytes)p;
}
