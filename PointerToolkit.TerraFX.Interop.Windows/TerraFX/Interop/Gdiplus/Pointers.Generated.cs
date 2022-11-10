using PointerToolkit;
using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Gdiplus;

public static unsafe class Pointers
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static CastPtr<TerraFX.Interop.Gdiplus.IImageBytes, TerraFX.Interop.Windows.IUnknown> __cast(TerraFX.Interop.Gdiplus.IImageBytes* ptr) => *(CastPtr<TerraFX.Interop.Gdiplus.IImageBytes, TerraFX.Interop.Windows.IUnknown>*)&ptr;
}
