using PointerToolkit;
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Gdiplus;

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIImageBytes
{
    private readonly TerraFX.Interop.Gdiplus.IImageBytes* p;

    public TerraFX.Interop.Gdiplus.IImageBytes* Get() => this.p;

    public static implicit operator PIImageBytes(TerraFX.Interop.Gdiplus.IImageBytes* p) => *(PIImageBytes*)&p;
    public static implicit operator TerraFX.Interop.Gdiplus.IImageBytes*(PIImageBytes p) => (TerraFX.Interop.Gdiplus.IImageBytes*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIImageBytes p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIImageBytes p) => p.p;
}
