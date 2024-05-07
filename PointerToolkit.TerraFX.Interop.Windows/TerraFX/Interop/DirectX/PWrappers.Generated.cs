using PointerToolkit;
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PD3D11On12CreatorID
{
    private readonly TerraFX.Interop.DirectX.D3D11On12CreatorID* p;

    public TerraFX.Interop.DirectX.D3D11On12CreatorID* Get() => this.p;

    public static implicit operator PD3D11On12CreatorID(TerraFX.Interop.DirectX.D3D11On12CreatorID* p) => *(PD3D11On12CreatorID*)&p;
    public static implicit operator TerraFX.Interop.DirectX.D3D11On12CreatorID*(PD3D11On12CreatorID p) => (TerraFX.Interop.DirectX.D3D11On12CreatorID*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PD3D11On12CreatorID p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PD3D11On12CreatorID p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PD3D9On12CreatorID
{
    private readonly TerraFX.Interop.DirectX.D3D9On12CreatorID* p;

    public TerraFX.Interop.DirectX.D3D9On12CreatorID* Get() => this.p;

    public static implicit operator PD3D9On12CreatorID(TerraFX.Interop.DirectX.D3D9On12CreatorID* p) => *(PD3D9On12CreatorID*)&p;
    public static implicit operator TerraFX.Interop.DirectX.D3D9On12CreatorID*(PD3D9On12CreatorID p) => (TerraFX.Interop.DirectX.D3D9On12CreatorID*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PD3D9On12CreatorID p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PD3D9On12CreatorID p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PDirectMLPyTorchCreatorID
{
    private readonly TerraFX.Interop.DirectX.DirectMLPyTorchCreatorID* p;

    public TerraFX.Interop.DirectX.DirectMLPyTorchCreatorID* Get() => this.p;

    public static implicit operator PDirectMLPyTorchCreatorID(TerraFX.Interop.DirectX.DirectMLPyTorchCreatorID* p) => *(PDirectMLPyTorchCreatorID*)&p;
    public static implicit operator TerraFX.Interop.DirectX.DirectMLPyTorchCreatorID*(PDirectMLPyTorchCreatorID p) => (TerraFX.Interop.DirectX.DirectMLPyTorchCreatorID*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PDirectMLPyTorchCreatorID p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PDirectMLPyTorchCreatorID p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PDirectMLTensorFlowCreatorID
{
    private readonly TerraFX.Interop.DirectX.DirectMLTensorFlowCreatorID* p;

    public TerraFX.Interop.DirectX.DirectMLTensorFlowCreatorID* Get() => this.p;

    public static implicit operator PDirectMLTensorFlowCreatorID(TerraFX.Interop.DirectX.DirectMLTensorFlowCreatorID* p) => *(PDirectMLTensorFlowCreatorID*)&p;
    public static implicit operator TerraFX.Interop.DirectX.DirectMLTensorFlowCreatorID*(PDirectMLTensorFlowCreatorID p) => (TerraFX.Interop.DirectX.DirectMLTensorFlowCreatorID*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PDirectMLTensorFlowCreatorID p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PDirectMLTensorFlowCreatorID p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1AnalysisTransform
{
    private readonly TerraFX.Interop.DirectX.ID2D1AnalysisTransform* p;

    public TerraFX.Interop.DirectX.ID2D1AnalysisTransform* Get() => this.p;

    public static implicit operator PID2D1AnalysisTransform(TerraFX.Interop.DirectX.ID2D1AnalysisTransform* p) => *(PID2D1AnalysisTransform*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1AnalysisTransform*(PID2D1AnalysisTransform p) => (TerraFX.Interop.DirectX.ID2D1AnalysisTransform*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1AnalysisTransform p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1AnalysisTransform p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Bitmap
{
    private readonly TerraFX.Interop.DirectX.ID2D1Bitmap* p;

    public TerraFX.Interop.DirectX.ID2D1Bitmap* Get() => this.p;

    public static implicit operator PID2D1Bitmap(TerraFX.Interop.DirectX.ID2D1Bitmap* p) => *(PID2D1Bitmap*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Bitmap*(PID2D1Bitmap p) => (TerraFX.Interop.DirectX.ID2D1Bitmap*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Image*(PID2D1Bitmap p) => (TerraFX.Interop.DirectX.ID2D1Image*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1Bitmap p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Bitmap p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Bitmap p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Bitmap1
{
    private readonly TerraFX.Interop.DirectX.ID2D1Bitmap1* p;

    public TerraFX.Interop.DirectX.ID2D1Bitmap1* Get() => this.p;

    public static implicit operator PID2D1Bitmap1(TerraFX.Interop.DirectX.ID2D1Bitmap1* p) => *(PID2D1Bitmap1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Bitmap1*(PID2D1Bitmap1 p) => (TerraFX.Interop.DirectX.ID2D1Bitmap1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Bitmap*(PID2D1Bitmap1 p) => (TerraFX.Interop.DirectX.ID2D1Bitmap*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Image*(PID2D1Bitmap1 p) => (TerraFX.Interop.DirectX.ID2D1Image*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1Bitmap1 p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Bitmap1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Bitmap1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1BitmapBrush
{
    private readonly TerraFX.Interop.DirectX.ID2D1BitmapBrush* p;

    public TerraFX.Interop.DirectX.ID2D1BitmapBrush* Get() => this.p;

    public static implicit operator PID2D1BitmapBrush(TerraFX.Interop.DirectX.ID2D1BitmapBrush* p) => *(PID2D1BitmapBrush*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1BitmapBrush*(PID2D1BitmapBrush p) => (TerraFX.Interop.DirectX.ID2D1BitmapBrush*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Brush*(PID2D1BitmapBrush p) => (TerraFX.Interop.DirectX.ID2D1Brush*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1BitmapBrush p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1BitmapBrush p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1BitmapBrush p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1BitmapBrush1
{
    private readonly TerraFX.Interop.DirectX.ID2D1BitmapBrush1* p;

    public TerraFX.Interop.DirectX.ID2D1BitmapBrush1* Get() => this.p;

    public static implicit operator PID2D1BitmapBrush1(TerraFX.Interop.DirectX.ID2D1BitmapBrush1* p) => *(PID2D1BitmapBrush1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1BitmapBrush1*(PID2D1BitmapBrush1 p) => (TerraFX.Interop.DirectX.ID2D1BitmapBrush1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1BitmapBrush*(PID2D1BitmapBrush1 p) => (TerraFX.Interop.DirectX.ID2D1BitmapBrush*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Brush*(PID2D1BitmapBrush1 p) => (TerraFX.Interop.DirectX.ID2D1Brush*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1BitmapBrush1 p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1BitmapBrush1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1BitmapBrush1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1BitmapRenderTarget
{
    private readonly TerraFX.Interop.DirectX.ID2D1BitmapRenderTarget* p;

    public TerraFX.Interop.DirectX.ID2D1BitmapRenderTarget* Get() => this.p;

    public static implicit operator PID2D1BitmapRenderTarget(TerraFX.Interop.DirectX.ID2D1BitmapRenderTarget* p) => *(PID2D1BitmapRenderTarget*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1BitmapRenderTarget*(PID2D1BitmapRenderTarget p) => (TerraFX.Interop.DirectX.ID2D1BitmapRenderTarget*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1RenderTarget*(PID2D1BitmapRenderTarget p) => (TerraFX.Interop.DirectX.ID2D1RenderTarget*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1BitmapRenderTarget p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1BitmapRenderTarget p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1BitmapRenderTarget p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1BlendTransform
{
    private readonly TerraFX.Interop.DirectX.ID2D1BlendTransform* p;

    public TerraFX.Interop.DirectX.ID2D1BlendTransform* Get() => this.p;

    public static implicit operator PID2D1BlendTransform(TerraFX.Interop.DirectX.ID2D1BlendTransform* p) => *(PID2D1BlendTransform*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1BlendTransform*(PID2D1BlendTransform p) => (TerraFX.Interop.DirectX.ID2D1BlendTransform*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1ConcreteTransform*(PID2D1BlendTransform p) => (TerraFX.Interop.DirectX.ID2D1ConcreteTransform*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1TransformNode*(PID2D1BlendTransform p) => (TerraFX.Interop.DirectX.ID2D1TransformNode*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1BlendTransform p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1BlendTransform p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1BorderTransform
{
    private readonly TerraFX.Interop.DirectX.ID2D1BorderTransform* p;

    public TerraFX.Interop.DirectX.ID2D1BorderTransform* Get() => this.p;

    public static implicit operator PID2D1BorderTransform(TerraFX.Interop.DirectX.ID2D1BorderTransform* p) => *(PID2D1BorderTransform*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1BorderTransform*(PID2D1BorderTransform p) => (TerraFX.Interop.DirectX.ID2D1BorderTransform*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1ConcreteTransform*(PID2D1BorderTransform p) => (TerraFX.Interop.DirectX.ID2D1ConcreteTransform*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1TransformNode*(PID2D1BorderTransform p) => (TerraFX.Interop.DirectX.ID2D1TransformNode*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1BorderTransform p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1BorderTransform p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1BoundsAdjustmentTransform
{
    private readonly TerraFX.Interop.DirectX.ID2D1BoundsAdjustmentTransform* p;

    public TerraFX.Interop.DirectX.ID2D1BoundsAdjustmentTransform* Get() => this.p;

    public static implicit operator PID2D1BoundsAdjustmentTransform(TerraFX.Interop.DirectX.ID2D1BoundsAdjustmentTransform* p) => *(PID2D1BoundsAdjustmentTransform*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1BoundsAdjustmentTransform*(PID2D1BoundsAdjustmentTransform p) => (TerraFX.Interop.DirectX.ID2D1BoundsAdjustmentTransform*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1TransformNode*(PID2D1BoundsAdjustmentTransform p) => (TerraFX.Interop.DirectX.ID2D1TransformNode*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1BoundsAdjustmentTransform p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1BoundsAdjustmentTransform p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Brush
{
    private readonly TerraFX.Interop.DirectX.ID2D1Brush* p;

    public TerraFX.Interop.DirectX.ID2D1Brush* Get() => this.p;

    public static implicit operator PID2D1Brush(TerraFX.Interop.DirectX.ID2D1Brush* p) => *(PID2D1Brush*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Brush*(PID2D1Brush p) => (TerraFX.Interop.DirectX.ID2D1Brush*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1Brush p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Brush p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Brush p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1ColorContext
{
    private readonly TerraFX.Interop.DirectX.ID2D1ColorContext* p;

    public TerraFX.Interop.DirectX.ID2D1ColorContext* Get() => this.p;

    public static implicit operator PID2D1ColorContext(TerraFX.Interop.DirectX.ID2D1ColorContext* p) => *(PID2D1ColorContext*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1ColorContext*(PID2D1ColorContext p) => (TerraFX.Interop.DirectX.ID2D1ColorContext*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1ColorContext p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1ColorContext p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1ColorContext p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1ColorContext1
{
    private readonly TerraFX.Interop.DirectX.ID2D1ColorContext1* p;

    public TerraFX.Interop.DirectX.ID2D1ColorContext1* Get() => this.p;

    public static implicit operator PID2D1ColorContext1(TerraFX.Interop.DirectX.ID2D1ColorContext1* p) => *(PID2D1ColorContext1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1ColorContext1*(PID2D1ColorContext1 p) => (TerraFX.Interop.DirectX.ID2D1ColorContext1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1ColorContext*(PID2D1ColorContext1 p) => (TerraFX.Interop.DirectX.ID2D1ColorContext*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1ColorContext1 p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1ColorContext1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1ColorContext1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1CommandList
{
    private readonly TerraFX.Interop.DirectX.ID2D1CommandList* p;

    public TerraFX.Interop.DirectX.ID2D1CommandList* Get() => this.p;

    public static implicit operator PID2D1CommandList(TerraFX.Interop.DirectX.ID2D1CommandList* p) => *(PID2D1CommandList*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1CommandList*(PID2D1CommandList p) => (TerraFX.Interop.DirectX.ID2D1CommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Image*(PID2D1CommandList p) => (TerraFX.Interop.DirectX.ID2D1Image*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1CommandList p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1CommandList p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1CommandList p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1CommandSink
{
    private readonly TerraFX.Interop.DirectX.ID2D1CommandSink* p;

    public TerraFX.Interop.DirectX.ID2D1CommandSink* Get() => this.p;

    public static implicit operator PID2D1CommandSink(TerraFX.Interop.DirectX.ID2D1CommandSink* p) => *(PID2D1CommandSink*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1CommandSink*(PID2D1CommandSink p) => (TerraFX.Interop.DirectX.ID2D1CommandSink*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1CommandSink p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1CommandSink p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1CommandSink1
{
    private readonly TerraFX.Interop.DirectX.ID2D1CommandSink1* p;

    public TerraFX.Interop.DirectX.ID2D1CommandSink1* Get() => this.p;

    public static implicit operator PID2D1CommandSink1(TerraFX.Interop.DirectX.ID2D1CommandSink1* p) => *(PID2D1CommandSink1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1CommandSink1*(PID2D1CommandSink1 p) => (TerraFX.Interop.DirectX.ID2D1CommandSink1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1CommandSink*(PID2D1CommandSink1 p) => (TerraFX.Interop.DirectX.ID2D1CommandSink*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1CommandSink1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1CommandSink1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1CommandSink2
{
    private readonly TerraFX.Interop.DirectX.ID2D1CommandSink2* p;

    public TerraFX.Interop.DirectX.ID2D1CommandSink2* Get() => this.p;

    public static implicit operator PID2D1CommandSink2(TerraFX.Interop.DirectX.ID2D1CommandSink2* p) => *(PID2D1CommandSink2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1CommandSink2*(PID2D1CommandSink2 p) => (TerraFX.Interop.DirectX.ID2D1CommandSink2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1CommandSink1*(PID2D1CommandSink2 p) => (TerraFX.Interop.DirectX.ID2D1CommandSink1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1CommandSink*(PID2D1CommandSink2 p) => (TerraFX.Interop.DirectX.ID2D1CommandSink*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1CommandSink2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1CommandSink2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1CommandSink3
{
    private readonly TerraFX.Interop.DirectX.ID2D1CommandSink3* p;

    public TerraFX.Interop.DirectX.ID2D1CommandSink3* Get() => this.p;

    public static implicit operator PID2D1CommandSink3(TerraFX.Interop.DirectX.ID2D1CommandSink3* p) => *(PID2D1CommandSink3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1CommandSink3*(PID2D1CommandSink3 p) => (TerraFX.Interop.DirectX.ID2D1CommandSink3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1CommandSink2*(PID2D1CommandSink3 p) => (TerraFX.Interop.DirectX.ID2D1CommandSink2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1CommandSink1*(PID2D1CommandSink3 p) => (TerraFX.Interop.DirectX.ID2D1CommandSink1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1CommandSink*(PID2D1CommandSink3 p) => (TerraFX.Interop.DirectX.ID2D1CommandSink*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1CommandSink3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1CommandSink3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1CommandSink4
{
    private readonly TerraFX.Interop.DirectX.ID2D1CommandSink4* p;

    public TerraFX.Interop.DirectX.ID2D1CommandSink4* Get() => this.p;

    public static implicit operator PID2D1CommandSink4(TerraFX.Interop.DirectX.ID2D1CommandSink4* p) => *(PID2D1CommandSink4*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1CommandSink4*(PID2D1CommandSink4 p) => (TerraFX.Interop.DirectX.ID2D1CommandSink4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1CommandSink3*(PID2D1CommandSink4 p) => (TerraFX.Interop.DirectX.ID2D1CommandSink3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1CommandSink2*(PID2D1CommandSink4 p) => (TerraFX.Interop.DirectX.ID2D1CommandSink2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1CommandSink1*(PID2D1CommandSink4 p) => (TerraFX.Interop.DirectX.ID2D1CommandSink1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1CommandSink*(PID2D1CommandSink4 p) => (TerraFX.Interop.DirectX.ID2D1CommandSink*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1CommandSink4 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1CommandSink4 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1CommandSink5
{
    private readonly TerraFX.Interop.DirectX.ID2D1CommandSink5* p;

    public TerraFX.Interop.DirectX.ID2D1CommandSink5* Get() => this.p;

    public static implicit operator PID2D1CommandSink5(TerraFX.Interop.DirectX.ID2D1CommandSink5* p) => *(PID2D1CommandSink5*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1CommandSink5*(PID2D1CommandSink5 p) => (TerraFX.Interop.DirectX.ID2D1CommandSink5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1CommandSink4*(PID2D1CommandSink5 p) => (TerraFX.Interop.DirectX.ID2D1CommandSink4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1CommandSink3*(PID2D1CommandSink5 p) => (TerraFX.Interop.DirectX.ID2D1CommandSink3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1CommandSink2*(PID2D1CommandSink5 p) => (TerraFX.Interop.DirectX.ID2D1CommandSink2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1CommandSink1*(PID2D1CommandSink5 p) => (TerraFX.Interop.DirectX.ID2D1CommandSink1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1CommandSink*(PID2D1CommandSink5 p) => (TerraFX.Interop.DirectX.ID2D1CommandSink*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1CommandSink5 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1CommandSink5 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1ComputeInfo
{
    private readonly TerraFX.Interop.DirectX.ID2D1ComputeInfo* p;

    public TerraFX.Interop.DirectX.ID2D1ComputeInfo* Get() => this.p;

    public static implicit operator PID2D1ComputeInfo(TerraFX.Interop.DirectX.ID2D1ComputeInfo* p) => *(PID2D1ComputeInfo*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1ComputeInfo*(PID2D1ComputeInfo p) => (TerraFX.Interop.DirectX.ID2D1ComputeInfo*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1RenderInfo*(PID2D1ComputeInfo p) => (TerraFX.Interop.DirectX.ID2D1RenderInfo*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1ComputeInfo p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1ComputeInfo p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1ComputeTransform
{
    private readonly TerraFX.Interop.DirectX.ID2D1ComputeTransform* p;

    public TerraFX.Interop.DirectX.ID2D1ComputeTransform* Get() => this.p;

    public static implicit operator PID2D1ComputeTransform(TerraFX.Interop.DirectX.ID2D1ComputeTransform* p) => *(PID2D1ComputeTransform*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1ComputeTransform*(PID2D1ComputeTransform p) => (TerraFX.Interop.DirectX.ID2D1ComputeTransform*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Transform*(PID2D1ComputeTransform p) => (TerraFX.Interop.DirectX.ID2D1Transform*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1TransformNode*(PID2D1ComputeTransform p) => (TerraFX.Interop.DirectX.ID2D1TransformNode*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1ComputeTransform p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1ComputeTransform p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1ConcreteTransform
{
    private readonly TerraFX.Interop.DirectX.ID2D1ConcreteTransform* p;

    public TerraFX.Interop.DirectX.ID2D1ConcreteTransform* Get() => this.p;

    public static implicit operator PID2D1ConcreteTransform(TerraFX.Interop.DirectX.ID2D1ConcreteTransform* p) => *(PID2D1ConcreteTransform*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1ConcreteTransform*(PID2D1ConcreteTransform p) => (TerraFX.Interop.DirectX.ID2D1ConcreteTransform*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1TransformNode*(PID2D1ConcreteTransform p) => (TerraFX.Interop.DirectX.ID2D1TransformNode*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1ConcreteTransform p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1ConcreteTransform p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1DCRenderTarget
{
    private readonly TerraFX.Interop.DirectX.ID2D1DCRenderTarget* p;

    public TerraFX.Interop.DirectX.ID2D1DCRenderTarget* Get() => this.p;

    public static implicit operator PID2D1DCRenderTarget(TerraFX.Interop.DirectX.ID2D1DCRenderTarget* p) => *(PID2D1DCRenderTarget*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DCRenderTarget*(PID2D1DCRenderTarget p) => (TerraFX.Interop.DirectX.ID2D1DCRenderTarget*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1RenderTarget*(PID2D1DCRenderTarget p) => (TerraFX.Interop.DirectX.ID2D1RenderTarget*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1DCRenderTarget p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1DCRenderTarget p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1DCRenderTarget p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Device
{
    private readonly TerraFX.Interop.DirectX.ID2D1Device* p;

    public TerraFX.Interop.DirectX.ID2D1Device* Get() => this.p;

    public static implicit operator PID2D1Device(TerraFX.Interop.DirectX.ID2D1Device* p) => *(PID2D1Device*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device*(PID2D1Device p) => (TerraFX.Interop.DirectX.ID2D1Device*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1Device p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Device p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Device p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Device1
{
    private readonly TerraFX.Interop.DirectX.ID2D1Device1* p;

    public TerraFX.Interop.DirectX.ID2D1Device1* Get() => this.p;

    public static implicit operator PID2D1Device1(TerraFX.Interop.DirectX.ID2D1Device1* p) => *(PID2D1Device1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device1*(PID2D1Device1 p) => (TerraFX.Interop.DirectX.ID2D1Device1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device*(PID2D1Device1 p) => (TerraFX.Interop.DirectX.ID2D1Device*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1Device1 p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Device1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Device1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Device2
{
    private readonly TerraFX.Interop.DirectX.ID2D1Device2* p;

    public TerraFX.Interop.DirectX.ID2D1Device2* Get() => this.p;

    public static implicit operator PID2D1Device2(TerraFX.Interop.DirectX.ID2D1Device2* p) => *(PID2D1Device2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device2*(PID2D1Device2 p) => (TerraFX.Interop.DirectX.ID2D1Device2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device1*(PID2D1Device2 p) => (TerraFX.Interop.DirectX.ID2D1Device1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device*(PID2D1Device2 p) => (TerraFX.Interop.DirectX.ID2D1Device*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1Device2 p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Device2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Device2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Device3
{
    private readonly TerraFX.Interop.DirectX.ID2D1Device3* p;

    public TerraFX.Interop.DirectX.ID2D1Device3* Get() => this.p;

    public static implicit operator PID2D1Device3(TerraFX.Interop.DirectX.ID2D1Device3* p) => *(PID2D1Device3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device3*(PID2D1Device3 p) => (TerraFX.Interop.DirectX.ID2D1Device3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device2*(PID2D1Device3 p) => (TerraFX.Interop.DirectX.ID2D1Device2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device1*(PID2D1Device3 p) => (TerraFX.Interop.DirectX.ID2D1Device1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device*(PID2D1Device3 p) => (TerraFX.Interop.DirectX.ID2D1Device*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1Device3 p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Device3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Device3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Device4
{
    private readonly TerraFX.Interop.DirectX.ID2D1Device4* p;

    public TerraFX.Interop.DirectX.ID2D1Device4* Get() => this.p;

    public static implicit operator PID2D1Device4(TerraFX.Interop.DirectX.ID2D1Device4* p) => *(PID2D1Device4*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device4*(PID2D1Device4 p) => (TerraFX.Interop.DirectX.ID2D1Device4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device3*(PID2D1Device4 p) => (TerraFX.Interop.DirectX.ID2D1Device3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device2*(PID2D1Device4 p) => (TerraFX.Interop.DirectX.ID2D1Device2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device1*(PID2D1Device4 p) => (TerraFX.Interop.DirectX.ID2D1Device1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device*(PID2D1Device4 p) => (TerraFX.Interop.DirectX.ID2D1Device*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1Device4 p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Device4 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Device4 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Device5
{
    private readonly TerraFX.Interop.DirectX.ID2D1Device5* p;

    public TerraFX.Interop.DirectX.ID2D1Device5* Get() => this.p;

    public static implicit operator PID2D1Device5(TerraFX.Interop.DirectX.ID2D1Device5* p) => *(PID2D1Device5*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device5*(PID2D1Device5 p) => (TerraFX.Interop.DirectX.ID2D1Device5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device4*(PID2D1Device5 p) => (TerraFX.Interop.DirectX.ID2D1Device4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device3*(PID2D1Device5 p) => (TerraFX.Interop.DirectX.ID2D1Device3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device2*(PID2D1Device5 p) => (TerraFX.Interop.DirectX.ID2D1Device2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device1*(PID2D1Device5 p) => (TerraFX.Interop.DirectX.ID2D1Device1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device*(PID2D1Device5 p) => (TerraFX.Interop.DirectX.ID2D1Device*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1Device5 p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Device5 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Device5 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Device6
{
    private readonly TerraFX.Interop.DirectX.ID2D1Device6* p;

    public TerraFX.Interop.DirectX.ID2D1Device6* Get() => this.p;

    public static implicit operator PID2D1Device6(TerraFX.Interop.DirectX.ID2D1Device6* p) => *(PID2D1Device6*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device6*(PID2D1Device6 p) => (TerraFX.Interop.DirectX.ID2D1Device6*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device5*(PID2D1Device6 p) => (TerraFX.Interop.DirectX.ID2D1Device5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device4*(PID2D1Device6 p) => (TerraFX.Interop.DirectX.ID2D1Device4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device3*(PID2D1Device6 p) => (TerraFX.Interop.DirectX.ID2D1Device3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device2*(PID2D1Device6 p) => (TerraFX.Interop.DirectX.ID2D1Device2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device1*(PID2D1Device6 p) => (TerraFX.Interop.DirectX.ID2D1Device1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device*(PID2D1Device6 p) => (TerraFX.Interop.DirectX.ID2D1Device*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1Device6 p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Device6 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Device6 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Device7
{
    private readonly TerraFX.Interop.DirectX.ID2D1Device7* p;

    public TerraFX.Interop.DirectX.ID2D1Device7* Get() => this.p;

    public static implicit operator PID2D1Device7(TerraFX.Interop.DirectX.ID2D1Device7* p) => *(PID2D1Device7*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device7*(PID2D1Device7 p) => (TerraFX.Interop.DirectX.ID2D1Device7*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device6*(PID2D1Device7 p) => (TerraFX.Interop.DirectX.ID2D1Device6*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device5*(PID2D1Device7 p) => (TerraFX.Interop.DirectX.ID2D1Device5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device4*(PID2D1Device7 p) => (TerraFX.Interop.DirectX.ID2D1Device4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device3*(PID2D1Device7 p) => (TerraFX.Interop.DirectX.ID2D1Device3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device2*(PID2D1Device7 p) => (TerraFX.Interop.DirectX.ID2D1Device2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device1*(PID2D1Device7 p) => (TerraFX.Interop.DirectX.ID2D1Device1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Device*(PID2D1Device7 p) => (TerraFX.Interop.DirectX.ID2D1Device*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1Device7 p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Device7 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Device7 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1DeviceContext
{
    private readonly TerraFX.Interop.DirectX.ID2D1DeviceContext* p;

    public TerraFX.Interop.DirectX.ID2D1DeviceContext* Get() => this.p;

    public static implicit operator PID2D1DeviceContext(TerraFX.Interop.DirectX.ID2D1DeviceContext* p) => *(PID2D1DeviceContext*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext*(PID2D1DeviceContext p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1RenderTarget*(PID2D1DeviceContext p) => (TerraFX.Interop.DirectX.ID2D1RenderTarget*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1DeviceContext p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1DeviceContext p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1DeviceContext p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1DeviceContext1
{
    private readonly TerraFX.Interop.DirectX.ID2D1DeviceContext1* p;

    public TerraFX.Interop.DirectX.ID2D1DeviceContext1* Get() => this.p;

    public static implicit operator PID2D1DeviceContext1(TerraFX.Interop.DirectX.ID2D1DeviceContext1* p) => *(PID2D1DeviceContext1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext1*(PID2D1DeviceContext1 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext*(PID2D1DeviceContext1 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1RenderTarget*(PID2D1DeviceContext1 p) => (TerraFX.Interop.DirectX.ID2D1RenderTarget*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1DeviceContext1 p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1DeviceContext1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1DeviceContext1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1DeviceContext2
{
    private readonly TerraFX.Interop.DirectX.ID2D1DeviceContext2* p;

    public TerraFX.Interop.DirectX.ID2D1DeviceContext2* Get() => this.p;

    public static implicit operator PID2D1DeviceContext2(TerraFX.Interop.DirectX.ID2D1DeviceContext2* p) => *(PID2D1DeviceContext2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext2*(PID2D1DeviceContext2 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext1*(PID2D1DeviceContext2 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext*(PID2D1DeviceContext2 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1RenderTarget*(PID2D1DeviceContext2 p) => (TerraFX.Interop.DirectX.ID2D1RenderTarget*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1DeviceContext2 p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1DeviceContext2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1DeviceContext2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1DeviceContext3
{
    private readonly TerraFX.Interop.DirectX.ID2D1DeviceContext3* p;

    public TerraFX.Interop.DirectX.ID2D1DeviceContext3* Get() => this.p;

    public static implicit operator PID2D1DeviceContext3(TerraFX.Interop.DirectX.ID2D1DeviceContext3* p) => *(PID2D1DeviceContext3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext3*(PID2D1DeviceContext3 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext2*(PID2D1DeviceContext3 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext1*(PID2D1DeviceContext3 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext*(PID2D1DeviceContext3 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1RenderTarget*(PID2D1DeviceContext3 p) => (TerraFX.Interop.DirectX.ID2D1RenderTarget*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1DeviceContext3 p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1DeviceContext3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1DeviceContext3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1DeviceContext4
{
    private readonly TerraFX.Interop.DirectX.ID2D1DeviceContext4* p;

    public TerraFX.Interop.DirectX.ID2D1DeviceContext4* Get() => this.p;

    public static implicit operator PID2D1DeviceContext4(TerraFX.Interop.DirectX.ID2D1DeviceContext4* p) => *(PID2D1DeviceContext4*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext4*(PID2D1DeviceContext4 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext3*(PID2D1DeviceContext4 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext2*(PID2D1DeviceContext4 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext1*(PID2D1DeviceContext4 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext*(PID2D1DeviceContext4 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1RenderTarget*(PID2D1DeviceContext4 p) => (TerraFX.Interop.DirectX.ID2D1RenderTarget*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1DeviceContext4 p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1DeviceContext4 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1DeviceContext4 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1DeviceContext5
{
    private readonly TerraFX.Interop.DirectX.ID2D1DeviceContext5* p;

    public TerraFX.Interop.DirectX.ID2D1DeviceContext5* Get() => this.p;

    public static implicit operator PID2D1DeviceContext5(TerraFX.Interop.DirectX.ID2D1DeviceContext5* p) => *(PID2D1DeviceContext5*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext5*(PID2D1DeviceContext5 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext4*(PID2D1DeviceContext5 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext3*(PID2D1DeviceContext5 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext2*(PID2D1DeviceContext5 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext1*(PID2D1DeviceContext5 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext*(PID2D1DeviceContext5 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1RenderTarget*(PID2D1DeviceContext5 p) => (TerraFX.Interop.DirectX.ID2D1RenderTarget*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1DeviceContext5 p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1DeviceContext5 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1DeviceContext5 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1DeviceContext6
{
    private readonly TerraFX.Interop.DirectX.ID2D1DeviceContext6* p;

    public TerraFX.Interop.DirectX.ID2D1DeviceContext6* Get() => this.p;

    public static implicit operator PID2D1DeviceContext6(TerraFX.Interop.DirectX.ID2D1DeviceContext6* p) => *(PID2D1DeviceContext6*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext6*(PID2D1DeviceContext6 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext6*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext5*(PID2D1DeviceContext6 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext4*(PID2D1DeviceContext6 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext3*(PID2D1DeviceContext6 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext2*(PID2D1DeviceContext6 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext1*(PID2D1DeviceContext6 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext*(PID2D1DeviceContext6 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1RenderTarget*(PID2D1DeviceContext6 p) => (TerraFX.Interop.DirectX.ID2D1RenderTarget*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1DeviceContext6 p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1DeviceContext6 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1DeviceContext6 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1DeviceContext7
{
    private readonly TerraFX.Interop.DirectX.ID2D1DeviceContext7* p;

    public TerraFX.Interop.DirectX.ID2D1DeviceContext7* Get() => this.p;

    public static implicit operator PID2D1DeviceContext7(TerraFX.Interop.DirectX.ID2D1DeviceContext7* p) => *(PID2D1DeviceContext7*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext7*(PID2D1DeviceContext7 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext7*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext6*(PID2D1DeviceContext7 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext6*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext5*(PID2D1DeviceContext7 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext4*(PID2D1DeviceContext7 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext3*(PID2D1DeviceContext7 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext2*(PID2D1DeviceContext7 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext1*(PID2D1DeviceContext7 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DeviceContext*(PID2D1DeviceContext7 p) => (TerraFX.Interop.DirectX.ID2D1DeviceContext*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1RenderTarget*(PID2D1DeviceContext7 p) => (TerraFX.Interop.DirectX.ID2D1RenderTarget*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1DeviceContext7 p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1DeviceContext7 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1DeviceContext7 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1DrawInfo
{
    private readonly TerraFX.Interop.DirectX.ID2D1DrawInfo* p;

    public TerraFX.Interop.DirectX.ID2D1DrawInfo* Get() => this.p;

    public static implicit operator PID2D1DrawInfo(TerraFX.Interop.DirectX.ID2D1DrawInfo* p) => *(PID2D1DrawInfo*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DrawInfo*(PID2D1DrawInfo p) => (TerraFX.Interop.DirectX.ID2D1DrawInfo*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1RenderInfo*(PID2D1DrawInfo p) => (TerraFX.Interop.DirectX.ID2D1RenderInfo*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1DrawInfo p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1DrawInfo p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1DrawingStateBlock
{
    private readonly TerraFX.Interop.DirectX.ID2D1DrawingStateBlock* p;

    public TerraFX.Interop.DirectX.ID2D1DrawingStateBlock* Get() => this.p;

    public static implicit operator PID2D1DrawingStateBlock(TerraFX.Interop.DirectX.ID2D1DrawingStateBlock* p) => *(PID2D1DrawingStateBlock*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DrawingStateBlock*(PID2D1DrawingStateBlock p) => (TerraFX.Interop.DirectX.ID2D1DrawingStateBlock*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1DrawingStateBlock p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1DrawingStateBlock p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1DrawingStateBlock p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1DrawingStateBlock1
{
    private readonly TerraFX.Interop.DirectX.ID2D1DrawingStateBlock1* p;

    public TerraFX.Interop.DirectX.ID2D1DrawingStateBlock1* Get() => this.p;

    public static implicit operator PID2D1DrawingStateBlock1(TerraFX.Interop.DirectX.ID2D1DrawingStateBlock1* p) => *(PID2D1DrawingStateBlock1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DrawingStateBlock1*(PID2D1DrawingStateBlock1 p) => (TerraFX.Interop.DirectX.ID2D1DrawingStateBlock1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DrawingStateBlock*(PID2D1DrawingStateBlock1 p) => (TerraFX.Interop.DirectX.ID2D1DrawingStateBlock*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1DrawingStateBlock1 p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1DrawingStateBlock1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1DrawingStateBlock1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1DrawTransform
{
    private readonly TerraFX.Interop.DirectX.ID2D1DrawTransform* p;

    public TerraFX.Interop.DirectX.ID2D1DrawTransform* Get() => this.p;

    public static implicit operator PID2D1DrawTransform(TerraFX.Interop.DirectX.ID2D1DrawTransform* p) => *(PID2D1DrawTransform*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1DrawTransform*(PID2D1DrawTransform p) => (TerraFX.Interop.DirectX.ID2D1DrawTransform*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Transform*(PID2D1DrawTransform p) => (TerraFX.Interop.DirectX.ID2D1Transform*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1TransformNode*(PID2D1DrawTransform p) => (TerraFX.Interop.DirectX.ID2D1TransformNode*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1DrawTransform p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1DrawTransform p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Effect
{
    private readonly TerraFX.Interop.DirectX.ID2D1Effect* p;

    public TerraFX.Interop.DirectX.ID2D1Effect* Get() => this.p;

    public static implicit operator PID2D1Effect(TerraFX.Interop.DirectX.ID2D1Effect* p) => *(PID2D1Effect*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Effect*(PID2D1Effect p) => (TerraFX.Interop.DirectX.ID2D1Effect*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Properties*(PID2D1Effect p) => (TerraFX.Interop.DirectX.ID2D1Properties*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Effect p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Effect p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1EffectContext
{
    private readonly TerraFX.Interop.DirectX.ID2D1EffectContext* p;

    public TerraFX.Interop.DirectX.ID2D1EffectContext* Get() => this.p;

    public static implicit operator PID2D1EffectContext(TerraFX.Interop.DirectX.ID2D1EffectContext* p) => *(PID2D1EffectContext*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1EffectContext*(PID2D1EffectContext p) => (TerraFX.Interop.DirectX.ID2D1EffectContext*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1EffectContext p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1EffectContext p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1EffectContext1
{
    private readonly TerraFX.Interop.DirectX.ID2D1EffectContext1* p;

    public TerraFX.Interop.DirectX.ID2D1EffectContext1* Get() => this.p;

    public static implicit operator PID2D1EffectContext1(TerraFX.Interop.DirectX.ID2D1EffectContext1* p) => *(PID2D1EffectContext1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1EffectContext1*(PID2D1EffectContext1 p) => (TerraFX.Interop.DirectX.ID2D1EffectContext1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1EffectContext*(PID2D1EffectContext1 p) => (TerraFX.Interop.DirectX.ID2D1EffectContext*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1EffectContext1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1EffectContext1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1EffectContext2
{
    private readonly TerraFX.Interop.DirectX.ID2D1EffectContext2* p;

    public TerraFX.Interop.DirectX.ID2D1EffectContext2* Get() => this.p;

    public static implicit operator PID2D1EffectContext2(TerraFX.Interop.DirectX.ID2D1EffectContext2* p) => *(PID2D1EffectContext2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1EffectContext2*(PID2D1EffectContext2 p) => (TerraFX.Interop.DirectX.ID2D1EffectContext2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1EffectContext1*(PID2D1EffectContext2 p) => (TerraFX.Interop.DirectX.ID2D1EffectContext1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1EffectContext*(PID2D1EffectContext2 p) => (TerraFX.Interop.DirectX.ID2D1EffectContext*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1EffectContext2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1EffectContext2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1EffectImpl
{
    private readonly TerraFX.Interop.DirectX.ID2D1EffectImpl* p;

    public TerraFX.Interop.DirectX.ID2D1EffectImpl* Get() => this.p;

    public static implicit operator PID2D1EffectImpl(TerraFX.Interop.DirectX.ID2D1EffectImpl* p) => *(PID2D1EffectImpl*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1EffectImpl*(PID2D1EffectImpl p) => (TerraFX.Interop.DirectX.ID2D1EffectImpl*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1EffectImpl p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1EffectImpl p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1EllipseGeometry
{
    private readonly TerraFX.Interop.DirectX.ID2D1EllipseGeometry* p;

    public TerraFX.Interop.DirectX.ID2D1EllipseGeometry* Get() => this.p;

    public static implicit operator PID2D1EllipseGeometry(TerraFX.Interop.DirectX.ID2D1EllipseGeometry* p) => *(PID2D1EllipseGeometry*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1EllipseGeometry*(PID2D1EllipseGeometry p) => (TerraFX.Interop.DirectX.ID2D1EllipseGeometry*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Geometry*(PID2D1EllipseGeometry p) => (TerraFX.Interop.DirectX.ID2D1Geometry*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1EllipseGeometry p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1EllipseGeometry p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1EllipseGeometry p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Factory
{
    private readonly TerraFX.Interop.DirectX.ID2D1Factory* p;

    public TerraFX.Interop.DirectX.ID2D1Factory* Get() => this.p;

    public static implicit operator PID2D1Factory(TerraFX.Interop.DirectX.ID2D1Factory* p) => *(PID2D1Factory*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory*(PID2D1Factory p) => (TerraFX.Interop.DirectX.ID2D1Factory*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Factory p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Factory p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Factory1
{
    private readonly TerraFX.Interop.DirectX.ID2D1Factory1* p;

    public TerraFX.Interop.DirectX.ID2D1Factory1* Get() => this.p;

    public static implicit operator PID2D1Factory1(TerraFX.Interop.DirectX.ID2D1Factory1* p) => *(PID2D1Factory1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory1*(PID2D1Factory1 p) => (TerraFX.Interop.DirectX.ID2D1Factory1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory*(PID2D1Factory1 p) => (TerraFX.Interop.DirectX.ID2D1Factory*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Factory1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Factory1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Factory2
{
    private readonly TerraFX.Interop.DirectX.ID2D1Factory2* p;

    public TerraFX.Interop.DirectX.ID2D1Factory2* Get() => this.p;

    public static implicit operator PID2D1Factory2(TerraFX.Interop.DirectX.ID2D1Factory2* p) => *(PID2D1Factory2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory2*(PID2D1Factory2 p) => (TerraFX.Interop.DirectX.ID2D1Factory2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory1*(PID2D1Factory2 p) => (TerraFX.Interop.DirectX.ID2D1Factory1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory*(PID2D1Factory2 p) => (TerraFX.Interop.DirectX.ID2D1Factory*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Factory2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Factory2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Factory3
{
    private readonly TerraFX.Interop.DirectX.ID2D1Factory3* p;

    public TerraFX.Interop.DirectX.ID2D1Factory3* Get() => this.p;

    public static implicit operator PID2D1Factory3(TerraFX.Interop.DirectX.ID2D1Factory3* p) => *(PID2D1Factory3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory3*(PID2D1Factory3 p) => (TerraFX.Interop.DirectX.ID2D1Factory3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory2*(PID2D1Factory3 p) => (TerraFX.Interop.DirectX.ID2D1Factory2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory1*(PID2D1Factory3 p) => (TerraFX.Interop.DirectX.ID2D1Factory1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory*(PID2D1Factory3 p) => (TerraFX.Interop.DirectX.ID2D1Factory*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Factory3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Factory3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Factory4
{
    private readonly TerraFX.Interop.DirectX.ID2D1Factory4* p;

    public TerraFX.Interop.DirectX.ID2D1Factory4* Get() => this.p;

    public static implicit operator PID2D1Factory4(TerraFX.Interop.DirectX.ID2D1Factory4* p) => *(PID2D1Factory4*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory4*(PID2D1Factory4 p) => (TerraFX.Interop.DirectX.ID2D1Factory4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory3*(PID2D1Factory4 p) => (TerraFX.Interop.DirectX.ID2D1Factory3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory2*(PID2D1Factory4 p) => (TerraFX.Interop.DirectX.ID2D1Factory2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory1*(PID2D1Factory4 p) => (TerraFX.Interop.DirectX.ID2D1Factory1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory*(PID2D1Factory4 p) => (TerraFX.Interop.DirectX.ID2D1Factory*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Factory4 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Factory4 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Factory5
{
    private readonly TerraFX.Interop.DirectX.ID2D1Factory5* p;

    public TerraFX.Interop.DirectX.ID2D1Factory5* Get() => this.p;

    public static implicit operator PID2D1Factory5(TerraFX.Interop.DirectX.ID2D1Factory5* p) => *(PID2D1Factory5*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory5*(PID2D1Factory5 p) => (TerraFX.Interop.DirectX.ID2D1Factory5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory4*(PID2D1Factory5 p) => (TerraFX.Interop.DirectX.ID2D1Factory4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory3*(PID2D1Factory5 p) => (TerraFX.Interop.DirectX.ID2D1Factory3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory2*(PID2D1Factory5 p) => (TerraFX.Interop.DirectX.ID2D1Factory2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory1*(PID2D1Factory5 p) => (TerraFX.Interop.DirectX.ID2D1Factory1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory*(PID2D1Factory5 p) => (TerraFX.Interop.DirectX.ID2D1Factory*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Factory5 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Factory5 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Factory6
{
    private readonly TerraFX.Interop.DirectX.ID2D1Factory6* p;

    public TerraFX.Interop.DirectX.ID2D1Factory6* Get() => this.p;

    public static implicit operator PID2D1Factory6(TerraFX.Interop.DirectX.ID2D1Factory6* p) => *(PID2D1Factory6*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory6*(PID2D1Factory6 p) => (TerraFX.Interop.DirectX.ID2D1Factory6*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory5*(PID2D1Factory6 p) => (TerraFX.Interop.DirectX.ID2D1Factory5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory4*(PID2D1Factory6 p) => (TerraFX.Interop.DirectX.ID2D1Factory4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory3*(PID2D1Factory6 p) => (TerraFX.Interop.DirectX.ID2D1Factory3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory2*(PID2D1Factory6 p) => (TerraFX.Interop.DirectX.ID2D1Factory2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory1*(PID2D1Factory6 p) => (TerraFX.Interop.DirectX.ID2D1Factory1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory*(PID2D1Factory6 p) => (TerraFX.Interop.DirectX.ID2D1Factory*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Factory6 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Factory6 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Factory7
{
    private readonly TerraFX.Interop.DirectX.ID2D1Factory7* p;

    public TerraFX.Interop.DirectX.ID2D1Factory7* Get() => this.p;

    public static implicit operator PID2D1Factory7(TerraFX.Interop.DirectX.ID2D1Factory7* p) => *(PID2D1Factory7*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory7*(PID2D1Factory7 p) => (TerraFX.Interop.DirectX.ID2D1Factory7*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory6*(PID2D1Factory7 p) => (TerraFX.Interop.DirectX.ID2D1Factory6*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory5*(PID2D1Factory7 p) => (TerraFX.Interop.DirectX.ID2D1Factory5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory4*(PID2D1Factory7 p) => (TerraFX.Interop.DirectX.ID2D1Factory4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory3*(PID2D1Factory7 p) => (TerraFX.Interop.DirectX.ID2D1Factory3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory2*(PID2D1Factory7 p) => (TerraFX.Interop.DirectX.ID2D1Factory2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory1*(PID2D1Factory7 p) => (TerraFX.Interop.DirectX.ID2D1Factory1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory*(PID2D1Factory7 p) => (TerraFX.Interop.DirectX.ID2D1Factory*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Factory7 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Factory7 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Factory8
{
    private readonly TerraFX.Interop.DirectX.ID2D1Factory8* p;

    public TerraFX.Interop.DirectX.ID2D1Factory8* Get() => this.p;

    public static implicit operator PID2D1Factory8(TerraFX.Interop.DirectX.ID2D1Factory8* p) => *(PID2D1Factory8*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory8*(PID2D1Factory8 p) => (TerraFX.Interop.DirectX.ID2D1Factory8*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory7*(PID2D1Factory8 p) => (TerraFX.Interop.DirectX.ID2D1Factory7*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory6*(PID2D1Factory8 p) => (TerraFX.Interop.DirectX.ID2D1Factory6*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory5*(PID2D1Factory8 p) => (TerraFX.Interop.DirectX.ID2D1Factory5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory4*(PID2D1Factory8 p) => (TerraFX.Interop.DirectX.ID2D1Factory4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory3*(PID2D1Factory8 p) => (TerraFX.Interop.DirectX.ID2D1Factory3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory2*(PID2D1Factory8 p) => (TerraFX.Interop.DirectX.ID2D1Factory2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory1*(PID2D1Factory8 p) => (TerraFX.Interop.DirectX.ID2D1Factory1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Factory*(PID2D1Factory8 p) => (TerraFX.Interop.DirectX.ID2D1Factory*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Factory8 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Factory8 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1GdiInteropRenderTarget
{
    private readonly TerraFX.Interop.DirectX.ID2D1GdiInteropRenderTarget* p;

    public TerraFX.Interop.DirectX.ID2D1GdiInteropRenderTarget* Get() => this.p;

    public static implicit operator PID2D1GdiInteropRenderTarget(TerraFX.Interop.DirectX.ID2D1GdiInteropRenderTarget* p) => *(PID2D1GdiInteropRenderTarget*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1GdiInteropRenderTarget*(PID2D1GdiInteropRenderTarget p) => (TerraFX.Interop.DirectX.ID2D1GdiInteropRenderTarget*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1GdiInteropRenderTarget p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1GdiInteropRenderTarget p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1GdiMetafile
{
    private readonly TerraFX.Interop.DirectX.ID2D1GdiMetafile* p;

    public TerraFX.Interop.DirectX.ID2D1GdiMetafile* Get() => this.p;

    public static implicit operator PID2D1GdiMetafile(TerraFX.Interop.DirectX.ID2D1GdiMetafile* p) => *(PID2D1GdiMetafile*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1GdiMetafile*(PID2D1GdiMetafile p) => (TerraFX.Interop.DirectX.ID2D1GdiMetafile*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1GdiMetafile p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1GdiMetafile p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1GdiMetafile p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1GdiMetafile1
{
    private readonly TerraFX.Interop.DirectX.ID2D1GdiMetafile1* p;

    public TerraFX.Interop.DirectX.ID2D1GdiMetafile1* Get() => this.p;

    public static implicit operator PID2D1GdiMetafile1(TerraFX.Interop.DirectX.ID2D1GdiMetafile1* p) => *(PID2D1GdiMetafile1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1GdiMetafile1*(PID2D1GdiMetafile1 p) => (TerraFX.Interop.DirectX.ID2D1GdiMetafile1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1GdiMetafile*(PID2D1GdiMetafile1 p) => (TerraFX.Interop.DirectX.ID2D1GdiMetafile*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1GdiMetafile1 p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1GdiMetafile1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1GdiMetafile1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1GdiMetafileSink
{
    private readonly TerraFX.Interop.DirectX.ID2D1GdiMetafileSink* p;

    public TerraFX.Interop.DirectX.ID2D1GdiMetafileSink* Get() => this.p;

    public static implicit operator PID2D1GdiMetafileSink(TerraFX.Interop.DirectX.ID2D1GdiMetafileSink* p) => *(PID2D1GdiMetafileSink*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1GdiMetafileSink*(PID2D1GdiMetafileSink p) => (TerraFX.Interop.DirectX.ID2D1GdiMetafileSink*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1GdiMetafileSink p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1GdiMetafileSink p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1GdiMetafileSink1
{
    private readonly TerraFX.Interop.DirectX.ID2D1GdiMetafileSink1* p;

    public TerraFX.Interop.DirectX.ID2D1GdiMetafileSink1* Get() => this.p;

    public static implicit operator PID2D1GdiMetafileSink1(TerraFX.Interop.DirectX.ID2D1GdiMetafileSink1* p) => *(PID2D1GdiMetafileSink1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1GdiMetafileSink1*(PID2D1GdiMetafileSink1 p) => (TerraFX.Interop.DirectX.ID2D1GdiMetafileSink1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1GdiMetafileSink*(PID2D1GdiMetafileSink1 p) => (TerraFX.Interop.DirectX.ID2D1GdiMetafileSink*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1GdiMetafileSink1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1GdiMetafileSink1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Geometry
{
    private readonly TerraFX.Interop.DirectX.ID2D1Geometry* p;

    public TerraFX.Interop.DirectX.ID2D1Geometry* Get() => this.p;

    public static implicit operator PID2D1Geometry(TerraFX.Interop.DirectX.ID2D1Geometry* p) => *(PID2D1Geometry*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Geometry*(PID2D1Geometry p) => (TerraFX.Interop.DirectX.ID2D1Geometry*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1Geometry p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Geometry p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Geometry p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1GeometryGroup
{
    private readonly TerraFX.Interop.DirectX.ID2D1GeometryGroup* p;

    public TerraFX.Interop.DirectX.ID2D1GeometryGroup* Get() => this.p;

    public static implicit operator PID2D1GeometryGroup(TerraFX.Interop.DirectX.ID2D1GeometryGroup* p) => *(PID2D1GeometryGroup*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1GeometryGroup*(PID2D1GeometryGroup p) => (TerraFX.Interop.DirectX.ID2D1GeometryGroup*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Geometry*(PID2D1GeometryGroup p) => (TerraFX.Interop.DirectX.ID2D1Geometry*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1GeometryGroup p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1GeometryGroup p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1GeometryGroup p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1GeometryRealization
{
    private readonly TerraFX.Interop.DirectX.ID2D1GeometryRealization* p;

    public TerraFX.Interop.DirectX.ID2D1GeometryRealization* Get() => this.p;

    public static implicit operator PID2D1GeometryRealization(TerraFX.Interop.DirectX.ID2D1GeometryRealization* p) => *(PID2D1GeometryRealization*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1GeometryRealization*(PID2D1GeometryRealization p) => (TerraFX.Interop.DirectX.ID2D1GeometryRealization*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1GeometryRealization p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1GeometryRealization p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1GeometryRealization p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1GeometrySink
{
    private readonly TerraFX.Interop.DirectX.ID2D1GeometrySink* p;

    public TerraFX.Interop.DirectX.ID2D1GeometrySink* Get() => this.p;

    public static implicit operator PID2D1GeometrySink(TerraFX.Interop.DirectX.ID2D1GeometrySink* p) => *(PID2D1GeometrySink*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1GeometrySink*(PID2D1GeometrySink p) => (TerraFX.Interop.DirectX.ID2D1GeometrySink*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1SimplifiedGeometrySink*(PID2D1GeometrySink p) => (TerraFX.Interop.DirectX.ID2D1SimplifiedGeometrySink*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1GeometrySink p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1GeometrySink p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1GradientMesh
{
    private readonly TerraFX.Interop.DirectX.ID2D1GradientMesh* p;

    public TerraFX.Interop.DirectX.ID2D1GradientMesh* Get() => this.p;

    public static implicit operator PID2D1GradientMesh(TerraFX.Interop.DirectX.ID2D1GradientMesh* p) => *(PID2D1GradientMesh*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1GradientMesh*(PID2D1GradientMesh p) => (TerraFX.Interop.DirectX.ID2D1GradientMesh*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1GradientMesh p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1GradientMesh p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1GradientMesh p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1GradientStopCollection
{
    private readonly TerraFX.Interop.DirectX.ID2D1GradientStopCollection* p;

    public TerraFX.Interop.DirectX.ID2D1GradientStopCollection* Get() => this.p;

    public static implicit operator PID2D1GradientStopCollection(TerraFX.Interop.DirectX.ID2D1GradientStopCollection* p) => *(PID2D1GradientStopCollection*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1GradientStopCollection*(PID2D1GradientStopCollection p) => (TerraFX.Interop.DirectX.ID2D1GradientStopCollection*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1GradientStopCollection p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1GradientStopCollection p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1GradientStopCollection p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1GradientStopCollection1
{
    private readonly TerraFX.Interop.DirectX.ID2D1GradientStopCollection1* p;

    public TerraFX.Interop.DirectX.ID2D1GradientStopCollection1* Get() => this.p;

    public static implicit operator PID2D1GradientStopCollection1(TerraFX.Interop.DirectX.ID2D1GradientStopCollection1* p) => *(PID2D1GradientStopCollection1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1GradientStopCollection1*(PID2D1GradientStopCollection1 p) => (TerraFX.Interop.DirectX.ID2D1GradientStopCollection1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1GradientStopCollection*(PID2D1GradientStopCollection1 p) => (TerraFX.Interop.DirectX.ID2D1GradientStopCollection*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1GradientStopCollection1 p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1GradientStopCollection1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1GradientStopCollection1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1HwndRenderTarget
{
    private readonly TerraFX.Interop.DirectX.ID2D1HwndRenderTarget* p;

    public TerraFX.Interop.DirectX.ID2D1HwndRenderTarget* Get() => this.p;

    public static implicit operator PID2D1HwndRenderTarget(TerraFX.Interop.DirectX.ID2D1HwndRenderTarget* p) => *(PID2D1HwndRenderTarget*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1HwndRenderTarget*(PID2D1HwndRenderTarget p) => (TerraFX.Interop.DirectX.ID2D1HwndRenderTarget*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1RenderTarget*(PID2D1HwndRenderTarget p) => (TerraFX.Interop.DirectX.ID2D1RenderTarget*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1HwndRenderTarget p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1HwndRenderTarget p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1HwndRenderTarget p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Image
{
    private readonly TerraFX.Interop.DirectX.ID2D1Image* p;

    public TerraFX.Interop.DirectX.ID2D1Image* Get() => this.p;

    public static implicit operator PID2D1Image(TerraFX.Interop.DirectX.ID2D1Image* p) => *(PID2D1Image*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Image*(PID2D1Image p) => (TerraFX.Interop.DirectX.ID2D1Image*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1Image p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Image p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Image p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1ImageBrush
{
    private readonly TerraFX.Interop.DirectX.ID2D1ImageBrush* p;

    public TerraFX.Interop.DirectX.ID2D1ImageBrush* Get() => this.p;

    public static implicit operator PID2D1ImageBrush(TerraFX.Interop.DirectX.ID2D1ImageBrush* p) => *(PID2D1ImageBrush*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1ImageBrush*(PID2D1ImageBrush p) => (TerraFX.Interop.DirectX.ID2D1ImageBrush*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Brush*(PID2D1ImageBrush p) => (TerraFX.Interop.DirectX.ID2D1Brush*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1ImageBrush p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1ImageBrush p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1ImageBrush p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1ImageSource
{
    private readonly TerraFX.Interop.DirectX.ID2D1ImageSource* p;

    public TerraFX.Interop.DirectX.ID2D1ImageSource* Get() => this.p;

    public static implicit operator PID2D1ImageSource(TerraFX.Interop.DirectX.ID2D1ImageSource* p) => *(PID2D1ImageSource*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1ImageSource*(PID2D1ImageSource p) => (TerraFX.Interop.DirectX.ID2D1ImageSource*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Image*(PID2D1ImageSource p) => (TerraFX.Interop.DirectX.ID2D1Image*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1ImageSource p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1ImageSource p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1ImageSource p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1ImageSourceFromWic
{
    private readonly TerraFX.Interop.DirectX.ID2D1ImageSourceFromWic* p;

    public TerraFX.Interop.DirectX.ID2D1ImageSourceFromWic* Get() => this.p;

    public static implicit operator PID2D1ImageSourceFromWic(TerraFX.Interop.DirectX.ID2D1ImageSourceFromWic* p) => *(PID2D1ImageSourceFromWic*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1ImageSourceFromWic*(PID2D1ImageSourceFromWic p) => (TerraFX.Interop.DirectX.ID2D1ImageSourceFromWic*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1ImageSource*(PID2D1ImageSourceFromWic p) => (TerraFX.Interop.DirectX.ID2D1ImageSource*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Image*(PID2D1ImageSourceFromWic p) => (TerraFX.Interop.DirectX.ID2D1Image*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1ImageSourceFromWic p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1ImageSourceFromWic p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1ImageSourceFromWic p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Ink
{
    private readonly TerraFX.Interop.DirectX.ID2D1Ink* p;

    public TerraFX.Interop.DirectX.ID2D1Ink* Get() => this.p;

    public static implicit operator PID2D1Ink(TerraFX.Interop.DirectX.ID2D1Ink* p) => *(PID2D1Ink*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Ink*(PID2D1Ink p) => (TerraFX.Interop.DirectX.ID2D1Ink*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1Ink p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Ink p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Ink p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1InkStyle
{
    private readonly TerraFX.Interop.DirectX.ID2D1InkStyle* p;

    public TerraFX.Interop.DirectX.ID2D1InkStyle* Get() => this.p;

    public static implicit operator PID2D1InkStyle(TerraFX.Interop.DirectX.ID2D1InkStyle* p) => *(PID2D1InkStyle*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1InkStyle*(PID2D1InkStyle p) => (TerraFX.Interop.DirectX.ID2D1InkStyle*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1InkStyle p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1InkStyle p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1InkStyle p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Layer
{
    private readonly TerraFX.Interop.DirectX.ID2D1Layer* p;

    public TerraFX.Interop.DirectX.ID2D1Layer* Get() => this.p;

    public static implicit operator PID2D1Layer(TerraFX.Interop.DirectX.ID2D1Layer* p) => *(PID2D1Layer*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Layer*(PID2D1Layer p) => (TerraFX.Interop.DirectX.ID2D1Layer*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1Layer p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Layer p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Layer p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1LinearGradientBrush
{
    private readonly TerraFX.Interop.DirectX.ID2D1LinearGradientBrush* p;

    public TerraFX.Interop.DirectX.ID2D1LinearGradientBrush* Get() => this.p;

    public static implicit operator PID2D1LinearGradientBrush(TerraFX.Interop.DirectX.ID2D1LinearGradientBrush* p) => *(PID2D1LinearGradientBrush*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1LinearGradientBrush*(PID2D1LinearGradientBrush p) => (TerraFX.Interop.DirectX.ID2D1LinearGradientBrush*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Brush*(PID2D1LinearGradientBrush p) => (TerraFX.Interop.DirectX.ID2D1Brush*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1LinearGradientBrush p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1LinearGradientBrush p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1LinearGradientBrush p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1LookupTable3D
{
    private readonly TerraFX.Interop.DirectX.ID2D1LookupTable3D* p;

    public TerraFX.Interop.DirectX.ID2D1LookupTable3D* Get() => this.p;

    public static implicit operator PID2D1LookupTable3D(TerraFX.Interop.DirectX.ID2D1LookupTable3D* p) => *(PID2D1LookupTable3D*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1LookupTable3D*(PID2D1LookupTable3D p) => (TerraFX.Interop.DirectX.ID2D1LookupTable3D*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1LookupTable3D p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1LookupTable3D p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1LookupTable3D p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Mesh
{
    private readonly TerraFX.Interop.DirectX.ID2D1Mesh* p;

    public TerraFX.Interop.DirectX.ID2D1Mesh* Get() => this.p;

    public static implicit operator PID2D1Mesh(TerraFX.Interop.DirectX.ID2D1Mesh* p) => *(PID2D1Mesh*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Mesh*(PID2D1Mesh p) => (TerraFX.Interop.DirectX.ID2D1Mesh*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1Mesh p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Mesh p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Mesh p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Multithread
{
    private readonly TerraFX.Interop.DirectX.ID2D1Multithread* p;

    public TerraFX.Interop.DirectX.ID2D1Multithread* Get() => this.p;

    public static implicit operator PID2D1Multithread(TerraFX.Interop.DirectX.ID2D1Multithread* p) => *(PID2D1Multithread*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Multithread*(PID2D1Multithread p) => (TerraFX.Interop.DirectX.ID2D1Multithread*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Multithread p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Multithread p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1OffsetTransform
{
    private readonly TerraFX.Interop.DirectX.ID2D1OffsetTransform* p;

    public TerraFX.Interop.DirectX.ID2D1OffsetTransform* Get() => this.p;

    public static implicit operator PID2D1OffsetTransform(TerraFX.Interop.DirectX.ID2D1OffsetTransform* p) => *(PID2D1OffsetTransform*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1OffsetTransform*(PID2D1OffsetTransform p) => (TerraFX.Interop.DirectX.ID2D1OffsetTransform*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1TransformNode*(PID2D1OffsetTransform p) => (TerraFX.Interop.DirectX.ID2D1TransformNode*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1OffsetTransform p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1OffsetTransform p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1PathGeometry
{
    private readonly TerraFX.Interop.DirectX.ID2D1PathGeometry* p;

    public TerraFX.Interop.DirectX.ID2D1PathGeometry* Get() => this.p;

    public static implicit operator PID2D1PathGeometry(TerraFX.Interop.DirectX.ID2D1PathGeometry* p) => *(PID2D1PathGeometry*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1PathGeometry*(PID2D1PathGeometry p) => (TerraFX.Interop.DirectX.ID2D1PathGeometry*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Geometry*(PID2D1PathGeometry p) => (TerraFX.Interop.DirectX.ID2D1Geometry*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1PathGeometry p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1PathGeometry p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1PathGeometry p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1PathGeometry1
{
    private readonly TerraFX.Interop.DirectX.ID2D1PathGeometry1* p;

    public TerraFX.Interop.DirectX.ID2D1PathGeometry1* Get() => this.p;

    public static implicit operator PID2D1PathGeometry1(TerraFX.Interop.DirectX.ID2D1PathGeometry1* p) => *(PID2D1PathGeometry1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1PathGeometry1*(PID2D1PathGeometry1 p) => (TerraFX.Interop.DirectX.ID2D1PathGeometry1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1PathGeometry*(PID2D1PathGeometry1 p) => (TerraFX.Interop.DirectX.ID2D1PathGeometry*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Geometry*(PID2D1PathGeometry1 p) => (TerraFX.Interop.DirectX.ID2D1Geometry*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1PathGeometry1 p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1PathGeometry1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1PathGeometry1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1PrintControl
{
    private readonly TerraFX.Interop.DirectX.ID2D1PrintControl* p;

    public TerraFX.Interop.DirectX.ID2D1PrintControl* Get() => this.p;

    public static implicit operator PID2D1PrintControl(TerraFX.Interop.DirectX.ID2D1PrintControl* p) => *(PID2D1PrintControl*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1PrintControl*(PID2D1PrintControl p) => (TerraFX.Interop.DirectX.ID2D1PrintControl*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1PrintControl p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1PrintControl p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Properties
{
    private readonly TerraFX.Interop.DirectX.ID2D1Properties* p;

    public TerraFX.Interop.DirectX.ID2D1Properties* Get() => this.p;

    public static implicit operator PID2D1Properties(TerraFX.Interop.DirectX.ID2D1Properties* p) => *(PID2D1Properties*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Properties*(PID2D1Properties p) => (TerraFX.Interop.DirectX.ID2D1Properties*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Properties p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Properties p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1RadialGradientBrush
{
    private readonly TerraFX.Interop.DirectX.ID2D1RadialGradientBrush* p;

    public TerraFX.Interop.DirectX.ID2D1RadialGradientBrush* Get() => this.p;

    public static implicit operator PID2D1RadialGradientBrush(TerraFX.Interop.DirectX.ID2D1RadialGradientBrush* p) => *(PID2D1RadialGradientBrush*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1RadialGradientBrush*(PID2D1RadialGradientBrush p) => (TerraFX.Interop.DirectX.ID2D1RadialGradientBrush*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Brush*(PID2D1RadialGradientBrush p) => (TerraFX.Interop.DirectX.ID2D1Brush*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1RadialGradientBrush p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1RadialGradientBrush p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1RadialGradientBrush p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1RectangleGeometry
{
    private readonly TerraFX.Interop.DirectX.ID2D1RectangleGeometry* p;

    public TerraFX.Interop.DirectX.ID2D1RectangleGeometry* Get() => this.p;

    public static implicit operator PID2D1RectangleGeometry(TerraFX.Interop.DirectX.ID2D1RectangleGeometry* p) => *(PID2D1RectangleGeometry*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1RectangleGeometry*(PID2D1RectangleGeometry p) => (TerraFX.Interop.DirectX.ID2D1RectangleGeometry*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Geometry*(PID2D1RectangleGeometry p) => (TerraFX.Interop.DirectX.ID2D1Geometry*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1RectangleGeometry p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1RectangleGeometry p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1RectangleGeometry p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1RenderInfo
{
    private readonly TerraFX.Interop.DirectX.ID2D1RenderInfo* p;

    public TerraFX.Interop.DirectX.ID2D1RenderInfo* Get() => this.p;

    public static implicit operator PID2D1RenderInfo(TerraFX.Interop.DirectX.ID2D1RenderInfo* p) => *(PID2D1RenderInfo*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1RenderInfo*(PID2D1RenderInfo p) => (TerraFX.Interop.DirectX.ID2D1RenderInfo*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1RenderInfo p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1RenderInfo p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1RenderTarget
{
    private readonly TerraFX.Interop.DirectX.ID2D1RenderTarget* p;

    public TerraFX.Interop.DirectX.ID2D1RenderTarget* Get() => this.p;

    public static implicit operator PID2D1RenderTarget(TerraFX.Interop.DirectX.ID2D1RenderTarget* p) => *(PID2D1RenderTarget*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1RenderTarget*(PID2D1RenderTarget p) => (TerraFX.Interop.DirectX.ID2D1RenderTarget*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1RenderTarget p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1RenderTarget p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1RenderTarget p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Resource
{
    private readonly TerraFX.Interop.DirectX.ID2D1Resource* p;

    public TerraFX.Interop.DirectX.ID2D1Resource* Get() => this.p;

    public static implicit operator PID2D1Resource(TerraFX.Interop.DirectX.ID2D1Resource* p) => *(PID2D1Resource*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1Resource p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Resource p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Resource p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1ResourceTexture
{
    private readonly TerraFX.Interop.DirectX.ID2D1ResourceTexture* p;

    public TerraFX.Interop.DirectX.ID2D1ResourceTexture* Get() => this.p;

    public static implicit operator PID2D1ResourceTexture(TerraFX.Interop.DirectX.ID2D1ResourceTexture* p) => *(PID2D1ResourceTexture*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1ResourceTexture*(PID2D1ResourceTexture p) => (TerraFX.Interop.DirectX.ID2D1ResourceTexture*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1ResourceTexture p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1ResourceTexture p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1RoundedRectangleGeometry
{
    private readonly TerraFX.Interop.DirectX.ID2D1RoundedRectangleGeometry* p;

    public TerraFX.Interop.DirectX.ID2D1RoundedRectangleGeometry* Get() => this.p;

    public static implicit operator PID2D1RoundedRectangleGeometry(TerraFX.Interop.DirectX.ID2D1RoundedRectangleGeometry* p) => *(PID2D1RoundedRectangleGeometry*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1RoundedRectangleGeometry*(PID2D1RoundedRectangleGeometry p) => (TerraFX.Interop.DirectX.ID2D1RoundedRectangleGeometry*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Geometry*(PID2D1RoundedRectangleGeometry p) => (TerraFX.Interop.DirectX.ID2D1Geometry*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1RoundedRectangleGeometry p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1RoundedRectangleGeometry p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1RoundedRectangleGeometry p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1SimplifiedGeometrySink
{
    private readonly TerraFX.Interop.DirectX.ID2D1SimplifiedGeometrySink* p;

    public TerraFX.Interop.DirectX.ID2D1SimplifiedGeometrySink* Get() => this.p;

    public static implicit operator PID2D1SimplifiedGeometrySink(TerraFX.Interop.DirectX.ID2D1SimplifiedGeometrySink* p) => *(PID2D1SimplifiedGeometrySink*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1SimplifiedGeometrySink*(PID2D1SimplifiedGeometrySink p) => (TerraFX.Interop.DirectX.ID2D1SimplifiedGeometrySink*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1SimplifiedGeometrySink p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1SimplifiedGeometrySink p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1SolidColorBrush
{
    private readonly TerraFX.Interop.DirectX.ID2D1SolidColorBrush* p;

    public TerraFX.Interop.DirectX.ID2D1SolidColorBrush* Get() => this.p;

    public static implicit operator PID2D1SolidColorBrush(TerraFX.Interop.DirectX.ID2D1SolidColorBrush* p) => *(PID2D1SolidColorBrush*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1SolidColorBrush*(PID2D1SolidColorBrush p) => (TerraFX.Interop.DirectX.ID2D1SolidColorBrush*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Brush*(PID2D1SolidColorBrush p) => (TerraFX.Interop.DirectX.ID2D1Brush*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1SolidColorBrush p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1SolidColorBrush p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1SolidColorBrush p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1SourceTransform
{
    private readonly TerraFX.Interop.DirectX.ID2D1SourceTransform* p;

    public TerraFX.Interop.DirectX.ID2D1SourceTransform* Get() => this.p;

    public static implicit operator PID2D1SourceTransform(TerraFX.Interop.DirectX.ID2D1SourceTransform* p) => *(PID2D1SourceTransform*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1SourceTransform*(PID2D1SourceTransform p) => (TerraFX.Interop.DirectX.ID2D1SourceTransform*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Transform*(PID2D1SourceTransform p) => (TerraFX.Interop.DirectX.ID2D1Transform*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1TransformNode*(PID2D1SourceTransform p) => (TerraFX.Interop.DirectX.ID2D1TransformNode*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1SourceTransform p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1SourceTransform p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1SpriteBatch
{
    private readonly TerraFX.Interop.DirectX.ID2D1SpriteBatch* p;

    public TerraFX.Interop.DirectX.ID2D1SpriteBatch* Get() => this.p;

    public static implicit operator PID2D1SpriteBatch(TerraFX.Interop.DirectX.ID2D1SpriteBatch* p) => *(PID2D1SpriteBatch*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1SpriteBatch*(PID2D1SpriteBatch p) => (TerraFX.Interop.DirectX.ID2D1SpriteBatch*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1SpriteBatch p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1SpriteBatch p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1SpriteBatch p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1StrokeStyle
{
    private readonly TerraFX.Interop.DirectX.ID2D1StrokeStyle* p;

    public TerraFX.Interop.DirectX.ID2D1StrokeStyle* Get() => this.p;

    public static implicit operator PID2D1StrokeStyle(TerraFX.Interop.DirectX.ID2D1StrokeStyle* p) => *(PID2D1StrokeStyle*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1StrokeStyle*(PID2D1StrokeStyle p) => (TerraFX.Interop.DirectX.ID2D1StrokeStyle*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1StrokeStyle p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1StrokeStyle p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1StrokeStyle p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1StrokeStyle1
{
    private readonly TerraFX.Interop.DirectX.ID2D1StrokeStyle1* p;

    public TerraFX.Interop.DirectX.ID2D1StrokeStyle1* Get() => this.p;

    public static implicit operator PID2D1StrokeStyle1(TerraFX.Interop.DirectX.ID2D1StrokeStyle1* p) => *(PID2D1StrokeStyle1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1StrokeStyle1*(PID2D1StrokeStyle1 p) => (TerraFX.Interop.DirectX.ID2D1StrokeStyle1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1StrokeStyle*(PID2D1StrokeStyle1 p) => (TerraFX.Interop.DirectX.ID2D1StrokeStyle*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1StrokeStyle1 p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1StrokeStyle1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1StrokeStyle1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1SvgAttribute
{
    private readonly TerraFX.Interop.DirectX.ID2D1SvgAttribute* p;

    public TerraFX.Interop.DirectX.ID2D1SvgAttribute* Get() => this.p;

    public static implicit operator PID2D1SvgAttribute(TerraFX.Interop.DirectX.ID2D1SvgAttribute* p) => *(PID2D1SvgAttribute*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1SvgAttribute*(PID2D1SvgAttribute p) => (TerraFX.Interop.DirectX.ID2D1SvgAttribute*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1SvgAttribute p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1SvgAttribute p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1SvgAttribute p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1SvgDocument
{
    private readonly TerraFX.Interop.DirectX.ID2D1SvgDocument* p;

    public TerraFX.Interop.DirectX.ID2D1SvgDocument* Get() => this.p;

    public static implicit operator PID2D1SvgDocument(TerraFX.Interop.DirectX.ID2D1SvgDocument* p) => *(PID2D1SvgDocument*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1SvgDocument*(PID2D1SvgDocument p) => (TerraFX.Interop.DirectX.ID2D1SvgDocument*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1SvgDocument p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1SvgDocument p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1SvgDocument p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1SvgElement
{
    private readonly TerraFX.Interop.DirectX.ID2D1SvgElement* p;

    public TerraFX.Interop.DirectX.ID2D1SvgElement* Get() => this.p;

    public static implicit operator PID2D1SvgElement(TerraFX.Interop.DirectX.ID2D1SvgElement* p) => *(PID2D1SvgElement*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1SvgElement*(PID2D1SvgElement p) => (TerraFX.Interop.DirectX.ID2D1SvgElement*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1SvgElement p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1SvgElement p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1SvgElement p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1SvgGlyphStyle
{
    private readonly TerraFX.Interop.DirectX.ID2D1SvgGlyphStyle* p;

    public TerraFX.Interop.DirectX.ID2D1SvgGlyphStyle* Get() => this.p;

    public static implicit operator PID2D1SvgGlyphStyle(TerraFX.Interop.DirectX.ID2D1SvgGlyphStyle* p) => *(PID2D1SvgGlyphStyle*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1SvgGlyphStyle*(PID2D1SvgGlyphStyle p) => (TerraFX.Interop.DirectX.ID2D1SvgGlyphStyle*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1SvgGlyphStyle p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1SvgGlyphStyle p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1SvgGlyphStyle p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1SvgPaint
{
    private readonly TerraFX.Interop.DirectX.ID2D1SvgPaint* p;

    public TerraFX.Interop.DirectX.ID2D1SvgPaint* Get() => this.p;

    public static implicit operator PID2D1SvgPaint(TerraFX.Interop.DirectX.ID2D1SvgPaint* p) => *(PID2D1SvgPaint*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1SvgPaint*(PID2D1SvgPaint p) => (TerraFX.Interop.DirectX.ID2D1SvgPaint*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1SvgAttribute*(PID2D1SvgPaint p) => (TerraFX.Interop.DirectX.ID2D1SvgAttribute*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1SvgPaint p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1SvgPaint p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1SvgPaint p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1SvgPathData
{
    private readonly TerraFX.Interop.DirectX.ID2D1SvgPathData* p;

    public TerraFX.Interop.DirectX.ID2D1SvgPathData* Get() => this.p;

    public static implicit operator PID2D1SvgPathData(TerraFX.Interop.DirectX.ID2D1SvgPathData* p) => *(PID2D1SvgPathData*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1SvgPathData*(PID2D1SvgPathData p) => (TerraFX.Interop.DirectX.ID2D1SvgPathData*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1SvgAttribute*(PID2D1SvgPathData p) => (TerraFX.Interop.DirectX.ID2D1SvgAttribute*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1SvgPathData p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1SvgPathData p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1SvgPathData p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1SvgPointCollection
{
    private readonly TerraFX.Interop.DirectX.ID2D1SvgPointCollection* p;

    public TerraFX.Interop.DirectX.ID2D1SvgPointCollection* Get() => this.p;

    public static implicit operator PID2D1SvgPointCollection(TerraFX.Interop.DirectX.ID2D1SvgPointCollection* p) => *(PID2D1SvgPointCollection*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1SvgPointCollection*(PID2D1SvgPointCollection p) => (TerraFX.Interop.DirectX.ID2D1SvgPointCollection*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1SvgAttribute*(PID2D1SvgPointCollection p) => (TerraFX.Interop.DirectX.ID2D1SvgAttribute*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1SvgPointCollection p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1SvgPointCollection p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1SvgPointCollection p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1SvgStrokeDashArray
{
    private readonly TerraFX.Interop.DirectX.ID2D1SvgStrokeDashArray* p;

    public TerraFX.Interop.DirectX.ID2D1SvgStrokeDashArray* Get() => this.p;

    public static implicit operator PID2D1SvgStrokeDashArray(TerraFX.Interop.DirectX.ID2D1SvgStrokeDashArray* p) => *(PID2D1SvgStrokeDashArray*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1SvgStrokeDashArray*(PID2D1SvgStrokeDashArray p) => (TerraFX.Interop.DirectX.ID2D1SvgStrokeDashArray*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1SvgAttribute*(PID2D1SvgStrokeDashArray p) => (TerraFX.Interop.DirectX.ID2D1SvgAttribute*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1SvgStrokeDashArray p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1SvgStrokeDashArray p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1SvgStrokeDashArray p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1TessellationSink
{
    private readonly TerraFX.Interop.DirectX.ID2D1TessellationSink* p;

    public TerraFX.Interop.DirectX.ID2D1TessellationSink* Get() => this.p;

    public static implicit operator PID2D1TessellationSink(TerraFX.Interop.DirectX.ID2D1TessellationSink* p) => *(PID2D1TessellationSink*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1TessellationSink*(PID2D1TessellationSink p) => (TerraFX.Interop.DirectX.ID2D1TessellationSink*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1TessellationSink p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1TessellationSink p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1Transform
{
    private readonly TerraFX.Interop.DirectX.ID2D1Transform* p;

    public TerraFX.Interop.DirectX.ID2D1Transform* Get() => this.p;

    public static implicit operator PID2D1Transform(TerraFX.Interop.DirectX.ID2D1Transform* p) => *(PID2D1Transform*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Transform*(PID2D1Transform p) => (TerraFX.Interop.DirectX.ID2D1Transform*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1TransformNode*(PID2D1Transform p) => (TerraFX.Interop.DirectX.ID2D1TransformNode*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1Transform p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1Transform p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1TransformedGeometry
{
    private readonly TerraFX.Interop.DirectX.ID2D1TransformedGeometry* p;

    public TerraFX.Interop.DirectX.ID2D1TransformedGeometry* Get() => this.p;

    public static implicit operator PID2D1TransformedGeometry(TerraFX.Interop.DirectX.ID2D1TransformedGeometry* p) => *(PID2D1TransformedGeometry*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1TransformedGeometry*(PID2D1TransformedGeometry p) => (TerraFX.Interop.DirectX.ID2D1TransformedGeometry*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Geometry*(PID2D1TransformedGeometry p) => (TerraFX.Interop.DirectX.ID2D1Geometry*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1TransformedGeometry p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1TransformedGeometry p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1TransformedGeometry p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1TransformedImageSource
{
    private readonly TerraFX.Interop.DirectX.ID2D1TransformedImageSource* p;

    public TerraFX.Interop.DirectX.ID2D1TransformedImageSource* Get() => this.p;

    public static implicit operator PID2D1TransformedImageSource(TerraFX.Interop.DirectX.ID2D1TransformedImageSource* p) => *(PID2D1TransformedImageSource*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1TransformedImageSource*(PID2D1TransformedImageSource p) => (TerraFX.Interop.DirectX.ID2D1TransformedImageSource*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Image*(PID2D1TransformedImageSource p) => (TerraFX.Interop.DirectX.ID2D1Image*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1Resource*(PID2D1TransformedImageSource p) => (TerraFX.Interop.DirectX.ID2D1Resource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1TransformedImageSource p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1TransformedImageSource p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1TransformGraph
{
    private readonly TerraFX.Interop.DirectX.ID2D1TransformGraph* p;

    public TerraFX.Interop.DirectX.ID2D1TransformGraph* Get() => this.p;

    public static implicit operator PID2D1TransformGraph(TerraFX.Interop.DirectX.ID2D1TransformGraph* p) => *(PID2D1TransformGraph*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1TransformGraph*(PID2D1TransformGraph p) => (TerraFX.Interop.DirectX.ID2D1TransformGraph*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1TransformGraph p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1TransformGraph p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1TransformNode
{
    private readonly TerraFX.Interop.DirectX.ID2D1TransformNode* p;

    public TerraFX.Interop.DirectX.ID2D1TransformNode* Get() => this.p;

    public static implicit operator PID2D1TransformNode(TerraFX.Interop.DirectX.ID2D1TransformNode* p) => *(PID2D1TransformNode*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1TransformNode*(PID2D1TransformNode p) => (TerraFX.Interop.DirectX.ID2D1TransformNode*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1TransformNode p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1TransformNode p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID2D1VertexBuffer
{
    private readonly TerraFX.Interop.DirectX.ID2D1VertexBuffer* p;

    public TerraFX.Interop.DirectX.ID2D1VertexBuffer* Get() => this.p;

    public static implicit operator PID2D1VertexBuffer(TerraFX.Interop.DirectX.ID2D1VertexBuffer* p) => *(PID2D1VertexBuffer*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID2D1VertexBuffer*(PID2D1VertexBuffer p) => (TerraFX.Interop.DirectX.ID2D1VertexBuffer*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID2D1VertexBuffer p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID2D1VertexBuffer p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10Asynchronous
{
    private readonly TerraFX.Interop.DirectX.ID3D10Asynchronous* p;

    public TerraFX.Interop.DirectX.ID3D10Asynchronous* Get() => this.p;

    public static implicit operator PID3D10Asynchronous(TerraFX.Interop.DirectX.ID3D10Asynchronous* p) => *(PID3D10Asynchronous*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10Asynchronous*(PID3D10Asynchronous p) => (TerraFX.Interop.DirectX.ID3D10Asynchronous*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10DeviceChild*(PID3D10Asynchronous p) => (TerraFX.Interop.DirectX.ID3D10DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10Asynchronous p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10Asynchronous p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10BlendState
{
    private readonly TerraFX.Interop.DirectX.ID3D10BlendState* p;

    public TerraFX.Interop.DirectX.ID3D10BlendState* Get() => this.p;

    public static implicit operator PID3D10BlendState(TerraFX.Interop.DirectX.ID3D10BlendState* p) => *(PID3D10BlendState*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10BlendState*(PID3D10BlendState p) => (TerraFX.Interop.DirectX.ID3D10BlendState*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10DeviceChild*(PID3D10BlendState p) => (TerraFX.Interop.DirectX.ID3D10DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10BlendState p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10BlendState p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10BlendState1
{
    private readonly TerraFX.Interop.DirectX.ID3D10BlendState1* p;

    public TerraFX.Interop.DirectX.ID3D10BlendState1* Get() => this.p;

    public static implicit operator PID3D10BlendState1(TerraFX.Interop.DirectX.ID3D10BlendState1* p) => *(PID3D10BlendState1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10BlendState1*(PID3D10BlendState1 p) => (TerraFX.Interop.DirectX.ID3D10BlendState1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10BlendState*(PID3D10BlendState1 p) => (TerraFX.Interop.DirectX.ID3D10BlendState*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10DeviceChild*(PID3D10BlendState1 p) => (TerraFX.Interop.DirectX.ID3D10DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10BlendState1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10BlendState1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10Buffer
{
    private readonly TerraFX.Interop.DirectX.ID3D10Buffer* p;

    public TerraFX.Interop.DirectX.ID3D10Buffer* Get() => this.p;

    public static implicit operator PID3D10Buffer(TerraFX.Interop.DirectX.ID3D10Buffer* p) => *(PID3D10Buffer*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10Buffer*(PID3D10Buffer p) => (TerraFX.Interop.DirectX.ID3D10Buffer*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10Resource*(PID3D10Buffer p) => (TerraFX.Interop.DirectX.ID3D10Resource*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10DeviceChild*(PID3D10Buffer p) => (TerraFX.Interop.DirectX.ID3D10DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10Buffer p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10Buffer p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10Counter
{
    private readonly TerraFX.Interop.DirectX.ID3D10Counter* p;

    public TerraFX.Interop.DirectX.ID3D10Counter* Get() => this.p;

    public static implicit operator PID3D10Counter(TerraFX.Interop.DirectX.ID3D10Counter* p) => *(PID3D10Counter*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10Counter*(PID3D10Counter p) => (TerraFX.Interop.DirectX.ID3D10Counter*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10Asynchronous*(PID3D10Counter p) => (TerraFX.Interop.DirectX.ID3D10Asynchronous*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10DeviceChild*(PID3D10Counter p) => (TerraFX.Interop.DirectX.ID3D10DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10Counter p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10Counter p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10Debug
{
    private readonly TerraFX.Interop.DirectX.ID3D10Debug* p;

    public TerraFX.Interop.DirectX.ID3D10Debug* Get() => this.p;

    public static implicit operator PID3D10Debug(TerraFX.Interop.DirectX.ID3D10Debug* p) => *(PID3D10Debug*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10Debug*(PID3D10Debug p) => (TerraFX.Interop.DirectX.ID3D10Debug*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10Debug p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10Debug p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10DepthStencilState
{
    private readonly TerraFX.Interop.DirectX.ID3D10DepthStencilState* p;

    public TerraFX.Interop.DirectX.ID3D10DepthStencilState* Get() => this.p;

    public static implicit operator PID3D10DepthStencilState(TerraFX.Interop.DirectX.ID3D10DepthStencilState* p) => *(PID3D10DepthStencilState*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10DepthStencilState*(PID3D10DepthStencilState p) => (TerraFX.Interop.DirectX.ID3D10DepthStencilState*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10DeviceChild*(PID3D10DepthStencilState p) => (TerraFX.Interop.DirectX.ID3D10DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10DepthStencilState p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10DepthStencilState p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10DepthStencilView
{
    private readonly TerraFX.Interop.DirectX.ID3D10DepthStencilView* p;

    public TerraFX.Interop.DirectX.ID3D10DepthStencilView* Get() => this.p;

    public static implicit operator PID3D10DepthStencilView(TerraFX.Interop.DirectX.ID3D10DepthStencilView* p) => *(PID3D10DepthStencilView*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10DepthStencilView*(PID3D10DepthStencilView p) => (TerraFX.Interop.DirectX.ID3D10DepthStencilView*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10View*(PID3D10DepthStencilView p) => (TerraFX.Interop.DirectX.ID3D10View*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10DeviceChild*(PID3D10DepthStencilView p) => (TerraFX.Interop.DirectX.ID3D10DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10DepthStencilView p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10DepthStencilView p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10Device
{
    private readonly TerraFX.Interop.DirectX.ID3D10Device* p;

    public TerraFX.Interop.DirectX.ID3D10Device* Get() => this.p;

    public static implicit operator PID3D10Device(TerraFX.Interop.DirectX.ID3D10Device* p) => *(PID3D10Device*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10Device*(PID3D10Device p) => (TerraFX.Interop.DirectX.ID3D10Device*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10Device p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10Device p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10Device1
{
    private readonly TerraFX.Interop.DirectX.ID3D10Device1* p;

    public TerraFX.Interop.DirectX.ID3D10Device1* Get() => this.p;

    public static implicit operator PID3D10Device1(TerraFX.Interop.DirectX.ID3D10Device1* p) => *(PID3D10Device1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10Device1*(PID3D10Device1 p) => (TerraFX.Interop.DirectX.ID3D10Device1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10Device*(PID3D10Device1 p) => (TerraFX.Interop.DirectX.ID3D10Device*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10Device1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10Device1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10DeviceChild
{
    private readonly TerraFX.Interop.DirectX.ID3D10DeviceChild* p;

    public TerraFX.Interop.DirectX.ID3D10DeviceChild* Get() => this.p;

    public static implicit operator PID3D10DeviceChild(TerraFX.Interop.DirectX.ID3D10DeviceChild* p) => *(PID3D10DeviceChild*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10DeviceChild*(PID3D10DeviceChild p) => (TerraFX.Interop.DirectX.ID3D10DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10DeviceChild p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10DeviceChild p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10Effect
{
    private readonly TerraFX.Interop.DirectX.ID3D10Effect* p;

    public TerraFX.Interop.DirectX.ID3D10Effect* Get() => this.p;

    public static implicit operator PID3D10Effect(TerraFX.Interop.DirectX.ID3D10Effect* p) => *(PID3D10Effect*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10Effect*(PID3D10Effect p) => (TerraFX.Interop.DirectX.ID3D10Effect*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10Effect p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10Effect p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10EffectPool
{
    private readonly TerraFX.Interop.DirectX.ID3D10EffectPool* p;

    public TerraFX.Interop.DirectX.ID3D10EffectPool* Get() => this.p;

    public static implicit operator PID3D10EffectPool(TerraFX.Interop.DirectX.ID3D10EffectPool* p) => *(PID3D10EffectPool*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10EffectPool*(PID3D10EffectPool p) => (TerraFX.Interop.DirectX.ID3D10EffectPool*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10EffectPool p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10EffectPool p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10GeometryShader
{
    private readonly TerraFX.Interop.DirectX.ID3D10GeometryShader* p;

    public TerraFX.Interop.DirectX.ID3D10GeometryShader* Get() => this.p;

    public static implicit operator PID3D10GeometryShader(TerraFX.Interop.DirectX.ID3D10GeometryShader* p) => *(PID3D10GeometryShader*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10GeometryShader*(PID3D10GeometryShader p) => (TerraFX.Interop.DirectX.ID3D10GeometryShader*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10DeviceChild*(PID3D10GeometryShader p) => (TerraFX.Interop.DirectX.ID3D10DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10GeometryShader p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10GeometryShader p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10InfoQueue
{
    private readonly TerraFX.Interop.DirectX.ID3D10InfoQueue* p;

    public TerraFX.Interop.DirectX.ID3D10InfoQueue* Get() => this.p;

    public static implicit operator PID3D10InfoQueue(TerraFX.Interop.DirectX.ID3D10InfoQueue* p) => *(PID3D10InfoQueue*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10InfoQueue*(PID3D10InfoQueue p) => (TerraFX.Interop.DirectX.ID3D10InfoQueue*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10InfoQueue p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10InfoQueue p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10InputLayout
{
    private readonly TerraFX.Interop.DirectX.ID3D10InputLayout* p;

    public TerraFX.Interop.DirectX.ID3D10InputLayout* Get() => this.p;

    public static implicit operator PID3D10InputLayout(TerraFX.Interop.DirectX.ID3D10InputLayout* p) => *(PID3D10InputLayout*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10InputLayout*(PID3D10InputLayout p) => (TerraFX.Interop.DirectX.ID3D10InputLayout*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10DeviceChild*(PID3D10InputLayout p) => (TerraFX.Interop.DirectX.ID3D10DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10InputLayout p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10InputLayout p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10Multithread
{
    private readonly TerraFX.Interop.DirectX.ID3D10Multithread* p;

    public TerraFX.Interop.DirectX.ID3D10Multithread* Get() => this.p;

    public static implicit operator PID3D10Multithread(TerraFX.Interop.DirectX.ID3D10Multithread* p) => *(PID3D10Multithread*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10Multithread*(PID3D10Multithread p) => (TerraFX.Interop.DirectX.ID3D10Multithread*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10Multithread p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10Multithread p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10PixelShader
{
    private readonly TerraFX.Interop.DirectX.ID3D10PixelShader* p;

    public TerraFX.Interop.DirectX.ID3D10PixelShader* Get() => this.p;

    public static implicit operator PID3D10PixelShader(TerraFX.Interop.DirectX.ID3D10PixelShader* p) => *(PID3D10PixelShader*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10PixelShader*(PID3D10PixelShader p) => (TerraFX.Interop.DirectX.ID3D10PixelShader*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10DeviceChild*(PID3D10PixelShader p) => (TerraFX.Interop.DirectX.ID3D10DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10PixelShader p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10PixelShader p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10Predicate
{
    private readonly TerraFX.Interop.DirectX.ID3D10Predicate* p;

    public TerraFX.Interop.DirectX.ID3D10Predicate* Get() => this.p;

    public static implicit operator PID3D10Predicate(TerraFX.Interop.DirectX.ID3D10Predicate* p) => *(PID3D10Predicate*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10Predicate*(PID3D10Predicate p) => (TerraFX.Interop.DirectX.ID3D10Predicate*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10Query*(PID3D10Predicate p) => (TerraFX.Interop.DirectX.ID3D10Query*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10Asynchronous*(PID3D10Predicate p) => (TerraFX.Interop.DirectX.ID3D10Asynchronous*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10DeviceChild*(PID3D10Predicate p) => (TerraFX.Interop.DirectX.ID3D10DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10Predicate p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10Predicate p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10Query
{
    private readonly TerraFX.Interop.DirectX.ID3D10Query* p;

    public TerraFX.Interop.DirectX.ID3D10Query* Get() => this.p;

    public static implicit operator PID3D10Query(TerraFX.Interop.DirectX.ID3D10Query* p) => *(PID3D10Query*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10Query*(PID3D10Query p) => (TerraFX.Interop.DirectX.ID3D10Query*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10Asynchronous*(PID3D10Query p) => (TerraFX.Interop.DirectX.ID3D10Asynchronous*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10DeviceChild*(PID3D10Query p) => (TerraFX.Interop.DirectX.ID3D10DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10Query p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10Query p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10RasterizerState
{
    private readonly TerraFX.Interop.DirectX.ID3D10RasterizerState* p;

    public TerraFX.Interop.DirectX.ID3D10RasterizerState* Get() => this.p;

    public static implicit operator PID3D10RasterizerState(TerraFX.Interop.DirectX.ID3D10RasterizerState* p) => *(PID3D10RasterizerState*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10RasterizerState*(PID3D10RasterizerState p) => (TerraFX.Interop.DirectX.ID3D10RasterizerState*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10DeviceChild*(PID3D10RasterizerState p) => (TerraFX.Interop.DirectX.ID3D10DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10RasterizerState p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10RasterizerState p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10RenderTargetView
{
    private readonly TerraFX.Interop.DirectX.ID3D10RenderTargetView* p;

    public TerraFX.Interop.DirectX.ID3D10RenderTargetView* Get() => this.p;

    public static implicit operator PID3D10RenderTargetView(TerraFX.Interop.DirectX.ID3D10RenderTargetView* p) => *(PID3D10RenderTargetView*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10RenderTargetView*(PID3D10RenderTargetView p) => (TerraFX.Interop.DirectX.ID3D10RenderTargetView*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10View*(PID3D10RenderTargetView p) => (TerraFX.Interop.DirectX.ID3D10View*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10DeviceChild*(PID3D10RenderTargetView p) => (TerraFX.Interop.DirectX.ID3D10DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10RenderTargetView p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10RenderTargetView p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10Resource
{
    private readonly TerraFX.Interop.DirectX.ID3D10Resource* p;

    public TerraFX.Interop.DirectX.ID3D10Resource* Get() => this.p;

    public static implicit operator PID3D10Resource(TerraFX.Interop.DirectX.ID3D10Resource* p) => *(PID3D10Resource*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10Resource*(PID3D10Resource p) => (TerraFX.Interop.DirectX.ID3D10Resource*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10DeviceChild*(PID3D10Resource p) => (TerraFX.Interop.DirectX.ID3D10DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10Resource p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10Resource p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10SamplerState
{
    private readonly TerraFX.Interop.DirectX.ID3D10SamplerState* p;

    public TerraFX.Interop.DirectX.ID3D10SamplerState* Get() => this.p;

    public static implicit operator PID3D10SamplerState(TerraFX.Interop.DirectX.ID3D10SamplerState* p) => *(PID3D10SamplerState*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10SamplerState*(PID3D10SamplerState p) => (TerraFX.Interop.DirectX.ID3D10SamplerState*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10DeviceChild*(PID3D10SamplerState p) => (TerraFX.Interop.DirectX.ID3D10DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10SamplerState p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10SamplerState p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10ShaderReflection
{
    private readonly TerraFX.Interop.DirectX.ID3D10ShaderReflection* p;

    public TerraFX.Interop.DirectX.ID3D10ShaderReflection* Get() => this.p;

    public static implicit operator PID3D10ShaderReflection(TerraFX.Interop.DirectX.ID3D10ShaderReflection* p) => *(PID3D10ShaderReflection*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10ShaderReflection*(PID3D10ShaderReflection p) => (TerraFX.Interop.DirectX.ID3D10ShaderReflection*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10ShaderReflection p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10ShaderReflection p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10ShaderReflection1
{
    private readonly TerraFX.Interop.DirectX.ID3D10ShaderReflection1* p;

    public TerraFX.Interop.DirectX.ID3D10ShaderReflection1* Get() => this.p;

    public static implicit operator PID3D10ShaderReflection1(TerraFX.Interop.DirectX.ID3D10ShaderReflection1* p) => *(PID3D10ShaderReflection1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10ShaderReflection1*(PID3D10ShaderReflection1 p) => (TerraFX.Interop.DirectX.ID3D10ShaderReflection1*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10ShaderReflection1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10ShaderReflection1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10ShaderResourceView
{
    private readonly TerraFX.Interop.DirectX.ID3D10ShaderResourceView* p;

    public TerraFX.Interop.DirectX.ID3D10ShaderResourceView* Get() => this.p;

    public static implicit operator PID3D10ShaderResourceView(TerraFX.Interop.DirectX.ID3D10ShaderResourceView* p) => *(PID3D10ShaderResourceView*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10ShaderResourceView*(PID3D10ShaderResourceView p) => (TerraFX.Interop.DirectX.ID3D10ShaderResourceView*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10View*(PID3D10ShaderResourceView p) => (TerraFX.Interop.DirectX.ID3D10View*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10DeviceChild*(PID3D10ShaderResourceView p) => (TerraFX.Interop.DirectX.ID3D10DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10ShaderResourceView p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10ShaderResourceView p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10ShaderResourceView1
{
    private readonly TerraFX.Interop.DirectX.ID3D10ShaderResourceView1* p;

    public TerraFX.Interop.DirectX.ID3D10ShaderResourceView1* Get() => this.p;

    public static implicit operator PID3D10ShaderResourceView1(TerraFX.Interop.DirectX.ID3D10ShaderResourceView1* p) => *(PID3D10ShaderResourceView1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10ShaderResourceView1*(PID3D10ShaderResourceView1 p) => (TerraFX.Interop.DirectX.ID3D10ShaderResourceView1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10ShaderResourceView*(PID3D10ShaderResourceView1 p) => (TerraFX.Interop.DirectX.ID3D10ShaderResourceView*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10View*(PID3D10ShaderResourceView1 p) => (TerraFX.Interop.DirectX.ID3D10View*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10DeviceChild*(PID3D10ShaderResourceView1 p) => (TerraFX.Interop.DirectX.ID3D10DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10ShaderResourceView1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10ShaderResourceView1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10StateBlock
{
    private readonly TerraFX.Interop.DirectX.ID3D10StateBlock* p;

    public TerraFX.Interop.DirectX.ID3D10StateBlock* Get() => this.p;

    public static implicit operator PID3D10StateBlock(TerraFX.Interop.DirectX.ID3D10StateBlock* p) => *(PID3D10StateBlock*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10StateBlock*(PID3D10StateBlock p) => (TerraFX.Interop.DirectX.ID3D10StateBlock*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10StateBlock p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10StateBlock p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10SwitchToRef
{
    private readonly TerraFX.Interop.DirectX.ID3D10SwitchToRef* p;

    public TerraFX.Interop.DirectX.ID3D10SwitchToRef* Get() => this.p;

    public static implicit operator PID3D10SwitchToRef(TerraFX.Interop.DirectX.ID3D10SwitchToRef* p) => *(PID3D10SwitchToRef*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10SwitchToRef*(PID3D10SwitchToRef p) => (TerraFX.Interop.DirectX.ID3D10SwitchToRef*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10SwitchToRef p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10SwitchToRef p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10Texture1D
{
    private readonly TerraFX.Interop.DirectX.ID3D10Texture1D* p;

    public TerraFX.Interop.DirectX.ID3D10Texture1D* Get() => this.p;

    public static implicit operator PID3D10Texture1D(TerraFX.Interop.DirectX.ID3D10Texture1D* p) => *(PID3D10Texture1D*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10Texture1D*(PID3D10Texture1D p) => (TerraFX.Interop.DirectX.ID3D10Texture1D*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10Resource*(PID3D10Texture1D p) => (TerraFX.Interop.DirectX.ID3D10Resource*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10DeviceChild*(PID3D10Texture1D p) => (TerraFX.Interop.DirectX.ID3D10DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10Texture1D p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10Texture1D p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10Texture2D
{
    private readonly TerraFX.Interop.DirectX.ID3D10Texture2D* p;

    public TerraFX.Interop.DirectX.ID3D10Texture2D* Get() => this.p;

    public static implicit operator PID3D10Texture2D(TerraFX.Interop.DirectX.ID3D10Texture2D* p) => *(PID3D10Texture2D*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10Texture2D*(PID3D10Texture2D p) => (TerraFX.Interop.DirectX.ID3D10Texture2D*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10Resource*(PID3D10Texture2D p) => (TerraFX.Interop.DirectX.ID3D10Resource*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10DeviceChild*(PID3D10Texture2D p) => (TerraFX.Interop.DirectX.ID3D10DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10Texture2D p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10Texture2D p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10Texture3D
{
    private readonly TerraFX.Interop.DirectX.ID3D10Texture3D* p;

    public TerraFX.Interop.DirectX.ID3D10Texture3D* Get() => this.p;

    public static implicit operator PID3D10Texture3D(TerraFX.Interop.DirectX.ID3D10Texture3D* p) => *(PID3D10Texture3D*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10Texture3D*(PID3D10Texture3D p) => (TerraFX.Interop.DirectX.ID3D10Texture3D*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10Resource*(PID3D10Texture3D p) => (TerraFX.Interop.DirectX.ID3D10Resource*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10DeviceChild*(PID3D10Texture3D p) => (TerraFX.Interop.DirectX.ID3D10DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10Texture3D p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10Texture3D p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10VertexShader
{
    private readonly TerraFX.Interop.DirectX.ID3D10VertexShader* p;

    public TerraFX.Interop.DirectX.ID3D10VertexShader* Get() => this.p;

    public static implicit operator PID3D10VertexShader(TerraFX.Interop.DirectX.ID3D10VertexShader* p) => *(PID3D10VertexShader*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10VertexShader*(PID3D10VertexShader p) => (TerraFX.Interop.DirectX.ID3D10VertexShader*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10DeviceChild*(PID3D10VertexShader p) => (TerraFX.Interop.DirectX.ID3D10DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10VertexShader p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10VertexShader p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D10View
{
    private readonly TerraFX.Interop.DirectX.ID3D10View* p;

    public TerraFX.Interop.DirectX.ID3D10View* Get() => this.p;

    public static implicit operator PID3D10View(TerraFX.Interop.DirectX.ID3D10View* p) => *(PID3D10View*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10View*(PID3D10View p) => (TerraFX.Interop.DirectX.ID3D10View*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D10DeviceChild*(PID3D10View p) => (TerraFX.Interop.DirectX.ID3D10DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D10View p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D10View p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11Asynchronous
{
    private readonly TerraFX.Interop.DirectX.ID3D11Asynchronous* p;

    public TerraFX.Interop.DirectX.ID3D11Asynchronous* Get() => this.p;

    public static implicit operator PID3D11Asynchronous(TerraFX.Interop.DirectX.ID3D11Asynchronous* p) => *(PID3D11Asynchronous*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Asynchronous*(PID3D11Asynchronous p) => (TerraFX.Interop.DirectX.ID3D11Asynchronous*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11Asynchronous p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11Asynchronous p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11Asynchronous p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11AuthenticatedChannel
{
    private readonly TerraFX.Interop.DirectX.ID3D11AuthenticatedChannel* p;

    public TerraFX.Interop.DirectX.ID3D11AuthenticatedChannel* Get() => this.p;

    public static implicit operator PID3D11AuthenticatedChannel(TerraFX.Interop.DirectX.ID3D11AuthenticatedChannel* p) => *(PID3D11AuthenticatedChannel*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11AuthenticatedChannel*(PID3D11AuthenticatedChannel p) => (TerraFX.Interop.DirectX.ID3D11AuthenticatedChannel*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11AuthenticatedChannel p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11AuthenticatedChannel p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11AuthenticatedChannel p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11BlendState
{
    private readonly TerraFX.Interop.DirectX.ID3D11BlendState* p;

    public TerraFX.Interop.DirectX.ID3D11BlendState* Get() => this.p;

    public static implicit operator PID3D11BlendState(TerraFX.Interop.DirectX.ID3D11BlendState* p) => *(PID3D11BlendState*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11BlendState*(PID3D11BlendState p) => (TerraFX.Interop.DirectX.ID3D11BlendState*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11BlendState p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11BlendState p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11BlendState p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11BlendState1
{
    private readonly TerraFX.Interop.DirectX.ID3D11BlendState1* p;

    public TerraFX.Interop.DirectX.ID3D11BlendState1* Get() => this.p;

    public static implicit operator PID3D11BlendState1(TerraFX.Interop.DirectX.ID3D11BlendState1* p) => *(PID3D11BlendState1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11BlendState1*(PID3D11BlendState1 p) => (TerraFX.Interop.DirectX.ID3D11BlendState1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11BlendState*(PID3D11BlendState1 p) => (TerraFX.Interop.DirectX.ID3D11BlendState*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11BlendState1 p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11BlendState1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11BlendState1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11Buffer
{
    private readonly TerraFX.Interop.DirectX.ID3D11Buffer* p;

    public TerraFX.Interop.DirectX.ID3D11Buffer* Get() => this.p;

    public static implicit operator PID3D11Buffer(TerraFX.Interop.DirectX.ID3D11Buffer* p) => *(PID3D11Buffer*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Buffer*(PID3D11Buffer p) => (TerraFX.Interop.DirectX.ID3D11Buffer*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Resource*(PID3D11Buffer p) => (TerraFX.Interop.DirectX.ID3D11Resource*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11Buffer p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11Buffer p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11Buffer p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11ClassInstance
{
    private readonly TerraFX.Interop.DirectX.ID3D11ClassInstance* p;

    public TerraFX.Interop.DirectX.ID3D11ClassInstance* Get() => this.p;

    public static implicit operator PID3D11ClassInstance(TerraFX.Interop.DirectX.ID3D11ClassInstance* p) => *(PID3D11ClassInstance*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11ClassInstance*(PID3D11ClassInstance p) => (TerraFX.Interop.DirectX.ID3D11ClassInstance*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11ClassInstance p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11ClassInstance p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11ClassInstance p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11ClassLinkage
{
    private readonly TerraFX.Interop.DirectX.ID3D11ClassLinkage* p;

    public TerraFX.Interop.DirectX.ID3D11ClassLinkage* Get() => this.p;

    public static implicit operator PID3D11ClassLinkage(TerraFX.Interop.DirectX.ID3D11ClassLinkage* p) => *(PID3D11ClassLinkage*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11ClassLinkage*(PID3D11ClassLinkage p) => (TerraFX.Interop.DirectX.ID3D11ClassLinkage*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11ClassLinkage p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11ClassLinkage p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11ClassLinkage p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11CommandList
{
    private readonly TerraFX.Interop.DirectX.ID3D11CommandList* p;

    public TerraFX.Interop.DirectX.ID3D11CommandList* Get() => this.p;

    public static implicit operator PID3D11CommandList(TerraFX.Interop.DirectX.ID3D11CommandList* p) => *(PID3D11CommandList*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11CommandList*(PID3D11CommandList p) => (TerraFX.Interop.DirectX.ID3D11CommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11CommandList p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11CommandList p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11CommandList p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11ComputeShader
{
    private readonly TerraFX.Interop.DirectX.ID3D11ComputeShader* p;

    public TerraFX.Interop.DirectX.ID3D11ComputeShader* Get() => this.p;

    public static implicit operator PID3D11ComputeShader(TerraFX.Interop.DirectX.ID3D11ComputeShader* p) => *(PID3D11ComputeShader*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11ComputeShader*(PID3D11ComputeShader p) => (TerraFX.Interop.DirectX.ID3D11ComputeShader*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11ComputeShader p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11ComputeShader p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11ComputeShader p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11Counter
{
    private readonly TerraFX.Interop.DirectX.ID3D11Counter* p;

    public TerraFX.Interop.DirectX.ID3D11Counter* Get() => this.p;

    public static implicit operator PID3D11Counter(TerraFX.Interop.DirectX.ID3D11Counter* p) => *(PID3D11Counter*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Counter*(PID3D11Counter p) => (TerraFX.Interop.DirectX.ID3D11Counter*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Asynchronous*(PID3D11Counter p) => (TerraFX.Interop.DirectX.ID3D11Asynchronous*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11Counter p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11Counter p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11Counter p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11CryptoSession
{
    private readonly TerraFX.Interop.DirectX.ID3D11CryptoSession* p;

    public TerraFX.Interop.DirectX.ID3D11CryptoSession* Get() => this.p;

    public static implicit operator PID3D11CryptoSession(TerraFX.Interop.DirectX.ID3D11CryptoSession* p) => *(PID3D11CryptoSession*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11CryptoSession*(PID3D11CryptoSession p) => (TerraFX.Interop.DirectX.ID3D11CryptoSession*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11CryptoSession p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11CryptoSession p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11CryptoSession p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11Debug
{
    private readonly TerraFX.Interop.DirectX.ID3D11Debug* p;

    public TerraFX.Interop.DirectX.ID3D11Debug* Get() => this.p;

    public static implicit operator PID3D11Debug(TerraFX.Interop.DirectX.ID3D11Debug* p) => *(PID3D11Debug*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Debug*(PID3D11Debug p) => (TerraFX.Interop.DirectX.ID3D11Debug*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11Debug p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11Debug p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11DepthStencilState
{
    private readonly TerraFX.Interop.DirectX.ID3D11DepthStencilState* p;

    public TerraFX.Interop.DirectX.ID3D11DepthStencilState* Get() => this.p;

    public static implicit operator PID3D11DepthStencilState(TerraFX.Interop.DirectX.ID3D11DepthStencilState* p) => *(PID3D11DepthStencilState*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DepthStencilState*(PID3D11DepthStencilState p) => (TerraFX.Interop.DirectX.ID3D11DepthStencilState*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11DepthStencilState p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11DepthStencilState p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11DepthStencilState p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11DepthStencilView
{
    private readonly TerraFX.Interop.DirectX.ID3D11DepthStencilView* p;

    public TerraFX.Interop.DirectX.ID3D11DepthStencilView* Get() => this.p;

    public static implicit operator PID3D11DepthStencilView(TerraFX.Interop.DirectX.ID3D11DepthStencilView* p) => *(PID3D11DepthStencilView*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DepthStencilView*(PID3D11DepthStencilView p) => (TerraFX.Interop.DirectX.ID3D11DepthStencilView*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11View*(PID3D11DepthStencilView p) => (TerraFX.Interop.DirectX.ID3D11View*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11DepthStencilView p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11DepthStencilView p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11DepthStencilView p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11Device
{
    private readonly TerraFX.Interop.DirectX.ID3D11Device* p;

    public TerraFX.Interop.DirectX.ID3D11Device* Get() => this.p;

    public static implicit operator PID3D11Device(TerraFX.Interop.DirectX.ID3D11Device* p) => *(PID3D11Device*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Device*(PID3D11Device p) => (TerraFX.Interop.DirectX.ID3D11Device*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11Device p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11Device p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11Device1
{
    private readonly TerraFX.Interop.DirectX.ID3D11Device1* p;

    public TerraFX.Interop.DirectX.ID3D11Device1* Get() => this.p;

    public static implicit operator PID3D11Device1(TerraFX.Interop.DirectX.ID3D11Device1* p) => *(PID3D11Device1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Device1*(PID3D11Device1 p) => (TerraFX.Interop.DirectX.ID3D11Device1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Device*(PID3D11Device1 p) => (TerraFX.Interop.DirectX.ID3D11Device*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11Device1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11Device1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11Device2
{
    private readonly TerraFX.Interop.DirectX.ID3D11Device2* p;

    public TerraFX.Interop.DirectX.ID3D11Device2* Get() => this.p;

    public static implicit operator PID3D11Device2(TerraFX.Interop.DirectX.ID3D11Device2* p) => *(PID3D11Device2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Device2*(PID3D11Device2 p) => (TerraFX.Interop.DirectX.ID3D11Device2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Device1*(PID3D11Device2 p) => (TerraFX.Interop.DirectX.ID3D11Device1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Device*(PID3D11Device2 p) => (TerraFX.Interop.DirectX.ID3D11Device*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11Device2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11Device2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11Device3
{
    private readonly TerraFX.Interop.DirectX.ID3D11Device3* p;

    public TerraFX.Interop.DirectX.ID3D11Device3* Get() => this.p;

    public static implicit operator PID3D11Device3(TerraFX.Interop.DirectX.ID3D11Device3* p) => *(PID3D11Device3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Device3*(PID3D11Device3 p) => (TerraFX.Interop.DirectX.ID3D11Device3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Device2*(PID3D11Device3 p) => (TerraFX.Interop.DirectX.ID3D11Device2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Device1*(PID3D11Device3 p) => (TerraFX.Interop.DirectX.ID3D11Device1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Device*(PID3D11Device3 p) => (TerraFX.Interop.DirectX.ID3D11Device*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11Device3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11Device3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11Device4
{
    private readonly TerraFX.Interop.DirectX.ID3D11Device4* p;

    public TerraFX.Interop.DirectX.ID3D11Device4* Get() => this.p;

    public static implicit operator PID3D11Device4(TerraFX.Interop.DirectX.ID3D11Device4* p) => *(PID3D11Device4*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Device4*(PID3D11Device4 p) => (TerraFX.Interop.DirectX.ID3D11Device4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Device3*(PID3D11Device4 p) => (TerraFX.Interop.DirectX.ID3D11Device3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Device2*(PID3D11Device4 p) => (TerraFX.Interop.DirectX.ID3D11Device2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Device1*(PID3D11Device4 p) => (TerraFX.Interop.DirectX.ID3D11Device1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Device*(PID3D11Device4 p) => (TerraFX.Interop.DirectX.ID3D11Device*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11Device4 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11Device4 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11Device5
{
    private readonly TerraFX.Interop.DirectX.ID3D11Device5* p;

    public TerraFX.Interop.DirectX.ID3D11Device5* Get() => this.p;

    public static implicit operator PID3D11Device5(TerraFX.Interop.DirectX.ID3D11Device5* p) => *(PID3D11Device5*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Device5*(PID3D11Device5 p) => (TerraFX.Interop.DirectX.ID3D11Device5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Device4*(PID3D11Device5 p) => (TerraFX.Interop.DirectX.ID3D11Device4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Device3*(PID3D11Device5 p) => (TerraFX.Interop.DirectX.ID3D11Device3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Device2*(PID3D11Device5 p) => (TerraFX.Interop.DirectX.ID3D11Device2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Device1*(PID3D11Device5 p) => (TerraFX.Interop.DirectX.ID3D11Device1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Device*(PID3D11Device5 p) => (TerraFX.Interop.DirectX.ID3D11Device*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11Device5 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11Device5 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11DeviceChild
{
    private readonly TerraFX.Interop.DirectX.ID3D11DeviceChild* p;

    public TerraFX.Interop.DirectX.ID3D11DeviceChild* Get() => this.p;

    public static implicit operator PID3D11DeviceChild(TerraFX.Interop.DirectX.ID3D11DeviceChild* p) => *(PID3D11DeviceChild*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11DeviceChild p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11DeviceChild p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11DeviceChild p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11DeviceContext
{
    private readonly TerraFX.Interop.DirectX.ID3D11DeviceContext* p;

    public TerraFX.Interop.DirectX.ID3D11DeviceContext* Get() => this.p;

    public static implicit operator PID3D11DeviceContext(TerraFX.Interop.DirectX.ID3D11DeviceContext* p) => *(PID3D11DeviceContext*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceContext*(PID3D11DeviceContext p) => (TerraFX.Interop.DirectX.ID3D11DeviceContext*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11DeviceContext p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11DeviceContext p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11DeviceContext p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11DeviceContext1
{
    private readonly TerraFX.Interop.DirectX.ID3D11DeviceContext1* p;

    public TerraFX.Interop.DirectX.ID3D11DeviceContext1* Get() => this.p;

    public static implicit operator PID3D11DeviceContext1(TerraFX.Interop.DirectX.ID3D11DeviceContext1* p) => *(PID3D11DeviceContext1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceContext1*(PID3D11DeviceContext1 p) => (TerraFX.Interop.DirectX.ID3D11DeviceContext1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceContext*(PID3D11DeviceContext1 p) => (TerraFX.Interop.DirectX.ID3D11DeviceContext*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11DeviceContext1 p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11DeviceContext1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11DeviceContext1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11DeviceContext2
{
    private readonly TerraFX.Interop.DirectX.ID3D11DeviceContext2* p;

    public TerraFX.Interop.DirectX.ID3D11DeviceContext2* Get() => this.p;

    public static implicit operator PID3D11DeviceContext2(TerraFX.Interop.DirectX.ID3D11DeviceContext2* p) => *(PID3D11DeviceContext2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceContext2*(PID3D11DeviceContext2 p) => (TerraFX.Interop.DirectX.ID3D11DeviceContext2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceContext1*(PID3D11DeviceContext2 p) => (TerraFX.Interop.DirectX.ID3D11DeviceContext1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceContext*(PID3D11DeviceContext2 p) => (TerraFX.Interop.DirectX.ID3D11DeviceContext*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11DeviceContext2 p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11DeviceContext2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11DeviceContext2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11DeviceContext3
{
    private readonly TerraFX.Interop.DirectX.ID3D11DeviceContext3* p;

    public TerraFX.Interop.DirectX.ID3D11DeviceContext3* Get() => this.p;

    public static implicit operator PID3D11DeviceContext3(TerraFX.Interop.DirectX.ID3D11DeviceContext3* p) => *(PID3D11DeviceContext3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceContext3*(PID3D11DeviceContext3 p) => (TerraFX.Interop.DirectX.ID3D11DeviceContext3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceContext2*(PID3D11DeviceContext3 p) => (TerraFX.Interop.DirectX.ID3D11DeviceContext2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceContext1*(PID3D11DeviceContext3 p) => (TerraFX.Interop.DirectX.ID3D11DeviceContext1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceContext*(PID3D11DeviceContext3 p) => (TerraFX.Interop.DirectX.ID3D11DeviceContext*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11DeviceContext3 p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11DeviceContext3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11DeviceContext3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11DeviceContext4
{
    private readonly TerraFX.Interop.DirectX.ID3D11DeviceContext4* p;

    public TerraFX.Interop.DirectX.ID3D11DeviceContext4* Get() => this.p;

    public static implicit operator PID3D11DeviceContext4(TerraFX.Interop.DirectX.ID3D11DeviceContext4* p) => *(PID3D11DeviceContext4*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceContext4*(PID3D11DeviceContext4 p) => (TerraFX.Interop.DirectX.ID3D11DeviceContext4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceContext3*(PID3D11DeviceContext4 p) => (TerraFX.Interop.DirectX.ID3D11DeviceContext3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceContext2*(PID3D11DeviceContext4 p) => (TerraFX.Interop.DirectX.ID3D11DeviceContext2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceContext1*(PID3D11DeviceContext4 p) => (TerraFX.Interop.DirectX.ID3D11DeviceContext1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceContext*(PID3D11DeviceContext4 p) => (TerraFX.Interop.DirectX.ID3D11DeviceContext*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11DeviceContext4 p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11DeviceContext4 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11DeviceContext4 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11DomainShader
{
    private readonly TerraFX.Interop.DirectX.ID3D11DomainShader* p;

    public TerraFX.Interop.DirectX.ID3D11DomainShader* Get() => this.p;

    public static implicit operator PID3D11DomainShader(TerraFX.Interop.DirectX.ID3D11DomainShader* p) => *(PID3D11DomainShader*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DomainShader*(PID3D11DomainShader p) => (TerraFX.Interop.DirectX.ID3D11DomainShader*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11DomainShader p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11DomainShader p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11DomainShader p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11Fence
{
    private readonly TerraFX.Interop.DirectX.ID3D11Fence* p;

    public TerraFX.Interop.DirectX.ID3D11Fence* Get() => this.p;

    public static implicit operator PID3D11Fence(TerraFX.Interop.DirectX.ID3D11Fence* p) => *(PID3D11Fence*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Fence*(PID3D11Fence p) => (TerraFX.Interop.DirectX.ID3D11Fence*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11Fence p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11Fence p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11Fence p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11FunctionLinkingGraph
{
    private readonly TerraFX.Interop.DirectX.ID3D11FunctionLinkingGraph* p;

    public TerraFX.Interop.DirectX.ID3D11FunctionLinkingGraph* Get() => this.p;

    public static implicit operator PID3D11FunctionLinkingGraph(TerraFX.Interop.DirectX.ID3D11FunctionLinkingGraph* p) => *(PID3D11FunctionLinkingGraph*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11FunctionLinkingGraph*(PID3D11FunctionLinkingGraph p) => (TerraFX.Interop.DirectX.ID3D11FunctionLinkingGraph*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11FunctionLinkingGraph p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11FunctionLinkingGraph p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11GeometryShader
{
    private readonly TerraFX.Interop.DirectX.ID3D11GeometryShader* p;

    public TerraFX.Interop.DirectX.ID3D11GeometryShader* Get() => this.p;

    public static implicit operator PID3D11GeometryShader(TerraFX.Interop.DirectX.ID3D11GeometryShader* p) => *(PID3D11GeometryShader*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11GeometryShader*(PID3D11GeometryShader p) => (TerraFX.Interop.DirectX.ID3D11GeometryShader*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11GeometryShader p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11GeometryShader p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11GeometryShader p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11HullShader
{
    private readonly TerraFX.Interop.DirectX.ID3D11HullShader* p;

    public TerraFX.Interop.DirectX.ID3D11HullShader* Get() => this.p;

    public static implicit operator PID3D11HullShader(TerraFX.Interop.DirectX.ID3D11HullShader* p) => *(PID3D11HullShader*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11HullShader*(PID3D11HullShader p) => (TerraFX.Interop.DirectX.ID3D11HullShader*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11HullShader p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11HullShader p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11HullShader p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11InfoQueue
{
    private readonly TerraFX.Interop.DirectX.ID3D11InfoQueue* p;

    public TerraFX.Interop.DirectX.ID3D11InfoQueue* Get() => this.p;

    public static implicit operator PID3D11InfoQueue(TerraFX.Interop.DirectX.ID3D11InfoQueue* p) => *(PID3D11InfoQueue*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11InfoQueue*(PID3D11InfoQueue p) => (TerraFX.Interop.DirectX.ID3D11InfoQueue*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11InfoQueue p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11InfoQueue p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11InputLayout
{
    private readonly TerraFX.Interop.DirectX.ID3D11InputLayout* p;

    public TerraFX.Interop.DirectX.ID3D11InputLayout* Get() => this.p;

    public static implicit operator PID3D11InputLayout(TerraFX.Interop.DirectX.ID3D11InputLayout* p) => *(PID3D11InputLayout*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11InputLayout*(PID3D11InputLayout p) => (TerraFX.Interop.DirectX.ID3D11InputLayout*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11InputLayout p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11InputLayout p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11InputLayout p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11LibraryReflection
{
    private readonly TerraFX.Interop.DirectX.ID3D11LibraryReflection* p;

    public TerraFX.Interop.DirectX.ID3D11LibraryReflection* Get() => this.p;

    public static implicit operator PID3D11LibraryReflection(TerraFX.Interop.DirectX.ID3D11LibraryReflection* p) => *(PID3D11LibraryReflection*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11LibraryReflection*(PID3D11LibraryReflection p) => (TerraFX.Interop.DirectX.ID3D11LibraryReflection*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11LibraryReflection p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11LibraryReflection p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11Linker
{
    private readonly TerraFX.Interop.DirectX.ID3D11Linker* p;

    public TerraFX.Interop.DirectX.ID3D11Linker* Get() => this.p;

    public static implicit operator PID3D11Linker(TerraFX.Interop.DirectX.ID3D11Linker* p) => *(PID3D11Linker*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Linker*(PID3D11Linker p) => (TerraFX.Interop.DirectX.ID3D11Linker*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11Linker p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11Linker p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11LinkingNode
{
    private readonly TerraFX.Interop.DirectX.ID3D11LinkingNode* p;

    public TerraFX.Interop.DirectX.ID3D11LinkingNode* Get() => this.p;

    public static implicit operator PID3D11LinkingNode(TerraFX.Interop.DirectX.ID3D11LinkingNode* p) => *(PID3D11LinkingNode*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11LinkingNode*(PID3D11LinkingNode p) => (TerraFX.Interop.DirectX.ID3D11LinkingNode*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11LinkingNode p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11LinkingNode p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11Module
{
    private readonly TerraFX.Interop.DirectX.ID3D11Module* p;

    public TerraFX.Interop.DirectX.ID3D11Module* Get() => this.p;

    public static implicit operator PID3D11Module(TerraFX.Interop.DirectX.ID3D11Module* p) => *(PID3D11Module*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Module*(PID3D11Module p) => (TerraFX.Interop.DirectX.ID3D11Module*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11Module p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11Module p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11ModuleInstance
{
    private readonly TerraFX.Interop.DirectX.ID3D11ModuleInstance* p;

    public TerraFX.Interop.DirectX.ID3D11ModuleInstance* Get() => this.p;

    public static implicit operator PID3D11ModuleInstance(TerraFX.Interop.DirectX.ID3D11ModuleInstance* p) => *(PID3D11ModuleInstance*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11ModuleInstance*(PID3D11ModuleInstance p) => (TerraFX.Interop.DirectX.ID3D11ModuleInstance*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11ModuleInstance p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11ModuleInstance p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11Multithread
{
    private readonly TerraFX.Interop.DirectX.ID3D11Multithread* p;

    public TerraFX.Interop.DirectX.ID3D11Multithread* Get() => this.p;

    public static implicit operator PID3D11Multithread(TerraFX.Interop.DirectX.ID3D11Multithread* p) => *(PID3D11Multithread*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Multithread*(PID3D11Multithread p) => (TerraFX.Interop.DirectX.ID3D11Multithread*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11Multithread p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11Multithread p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11On12Device
{
    private readonly TerraFX.Interop.DirectX.ID3D11On12Device* p;

    public TerraFX.Interop.DirectX.ID3D11On12Device* Get() => this.p;

    public static implicit operator PID3D11On12Device(TerraFX.Interop.DirectX.ID3D11On12Device* p) => *(PID3D11On12Device*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11On12Device*(PID3D11On12Device p) => (TerraFX.Interop.DirectX.ID3D11On12Device*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11On12Device p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11On12Device p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11On12Device1
{
    private readonly TerraFX.Interop.DirectX.ID3D11On12Device1* p;

    public TerraFX.Interop.DirectX.ID3D11On12Device1* Get() => this.p;

    public static implicit operator PID3D11On12Device1(TerraFX.Interop.DirectX.ID3D11On12Device1* p) => *(PID3D11On12Device1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11On12Device1*(PID3D11On12Device1 p) => (TerraFX.Interop.DirectX.ID3D11On12Device1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11On12Device*(PID3D11On12Device1 p) => (TerraFX.Interop.DirectX.ID3D11On12Device*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11On12Device1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11On12Device1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11On12Device2
{
    private readonly TerraFX.Interop.DirectX.ID3D11On12Device2* p;

    public TerraFX.Interop.DirectX.ID3D11On12Device2* Get() => this.p;

    public static implicit operator PID3D11On12Device2(TerraFX.Interop.DirectX.ID3D11On12Device2* p) => *(PID3D11On12Device2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11On12Device2*(PID3D11On12Device2 p) => (TerraFX.Interop.DirectX.ID3D11On12Device2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11On12Device1*(PID3D11On12Device2 p) => (TerraFX.Interop.DirectX.ID3D11On12Device1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11On12Device*(PID3D11On12Device2 p) => (TerraFX.Interop.DirectX.ID3D11On12Device*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11On12Device2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11On12Device2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11On12On7
{
    private readonly TerraFX.Interop.DirectX.ID3D11On12On7* p;

    public TerraFX.Interop.DirectX.ID3D11On12On7* Get() => this.p;

    public static implicit operator PID3D11On12On7(TerraFX.Interop.DirectX.ID3D11On12On7* p) => *(PID3D11On12On7*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11On12On7*(PID3D11On12On7 p) => (TerraFX.Interop.DirectX.ID3D11On12On7*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11On12On7 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11On12On7 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11PixelShader
{
    private readonly TerraFX.Interop.DirectX.ID3D11PixelShader* p;

    public TerraFX.Interop.DirectX.ID3D11PixelShader* Get() => this.p;

    public static implicit operator PID3D11PixelShader(TerraFX.Interop.DirectX.ID3D11PixelShader* p) => *(PID3D11PixelShader*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11PixelShader*(PID3D11PixelShader p) => (TerraFX.Interop.DirectX.ID3D11PixelShader*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11PixelShader p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11PixelShader p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11PixelShader p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11Predicate
{
    private readonly TerraFX.Interop.DirectX.ID3D11Predicate* p;

    public TerraFX.Interop.DirectX.ID3D11Predicate* Get() => this.p;

    public static implicit operator PID3D11Predicate(TerraFX.Interop.DirectX.ID3D11Predicate* p) => *(PID3D11Predicate*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Predicate*(PID3D11Predicate p) => (TerraFX.Interop.DirectX.ID3D11Predicate*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Query*(PID3D11Predicate p) => (TerraFX.Interop.DirectX.ID3D11Query*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Asynchronous*(PID3D11Predicate p) => (TerraFX.Interop.DirectX.ID3D11Asynchronous*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11Predicate p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11Predicate p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11Predicate p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11Query
{
    private readonly TerraFX.Interop.DirectX.ID3D11Query* p;

    public TerraFX.Interop.DirectX.ID3D11Query* Get() => this.p;

    public static implicit operator PID3D11Query(TerraFX.Interop.DirectX.ID3D11Query* p) => *(PID3D11Query*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Query*(PID3D11Query p) => (TerraFX.Interop.DirectX.ID3D11Query*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Asynchronous*(PID3D11Query p) => (TerraFX.Interop.DirectX.ID3D11Asynchronous*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11Query p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11Query p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11Query p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11Query1
{
    private readonly TerraFX.Interop.DirectX.ID3D11Query1* p;

    public TerraFX.Interop.DirectX.ID3D11Query1* Get() => this.p;

    public static implicit operator PID3D11Query1(TerraFX.Interop.DirectX.ID3D11Query1* p) => *(PID3D11Query1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Query1*(PID3D11Query1 p) => (TerraFX.Interop.DirectX.ID3D11Query1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Query*(PID3D11Query1 p) => (TerraFX.Interop.DirectX.ID3D11Query*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Asynchronous*(PID3D11Query1 p) => (TerraFX.Interop.DirectX.ID3D11Asynchronous*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11Query1 p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11Query1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11Query1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11RasterizerState
{
    private readonly TerraFX.Interop.DirectX.ID3D11RasterizerState* p;

    public TerraFX.Interop.DirectX.ID3D11RasterizerState* Get() => this.p;

    public static implicit operator PID3D11RasterizerState(TerraFX.Interop.DirectX.ID3D11RasterizerState* p) => *(PID3D11RasterizerState*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11RasterizerState*(PID3D11RasterizerState p) => (TerraFX.Interop.DirectX.ID3D11RasterizerState*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11RasterizerState p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11RasterizerState p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11RasterizerState p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11RasterizerState1
{
    private readonly TerraFX.Interop.DirectX.ID3D11RasterizerState1* p;

    public TerraFX.Interop.DirectX.ID3D11RasterizerState1* Get() => this.p;

    public static implicit operator PID3D11RasterizerState1(TerraFX.Interop.DirectX.ID3D11RasterizerState1* p) => *(PID3D11RasterizerState1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11RasterizerState1*(PID3D11RasterizerState1 p) => (TerraFX.Interop.DirectX.ID3D11RasterizerState1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11RasterizerState*(PID3D11RasterizerState1 p) => (TerraFX.Interop.DirectX.ID3D11RasterizerState*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11RasterizerState1 p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11RasterizerState1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11RasterizerState1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11RasterizerState2
{
    private readonly TerraFX.Interop.DirectX.ID3D11RasterizerState2* p;

    public TerraFX.Interop.DirectX.ID3D11RasterizerState2* Get() => this.p;

    public static implicit operator PID3D11RasterizerState2(TerraFX.Interop.DirectX.ID3D11RasterizerState2* p) => *(PID3D11RasterizerState2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11RasterizerState2*(PID3D11RasterizerState2 p) => (TerraFX.Interop.DirectX.ID3D11RasterizerState2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11RasterizerState1*(PID3D11RasterizerState2 p) => (TerraFX.Interop.DirectX.ID3D11RasterizerState1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11RasterizerState*(PID3D11RasterizerState2 p) => (TerraFX.Interop.DirectX.ID3D11RasterizerState*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11RasterizerState2 p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11RasterizerState2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11RasterizerState2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11RefDefaultTrackingOptions
{
    private readonly TerraFX.Interop.DirectX.ID3D11RefDefaultTrackingOptions* p;

    public TerraFX.Interop.DirectX.ID3D11RefDefaultTrackingOptions* Get() => this.p;

    public static implicit operator PID3D11RefDefaultTrackingOptions(TerraFX.Interop.DirectX.ID3D11RefDefaultTrackingOptions* p) => *(PID3D11RefDefaultTrackingOptions*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11RefDefaultTrackingOptions*(PID3D11RefDefaultTrackingOptions p) => (TerraFX.Interop.DirectX.ID3D11RefDefaultTrackingOptions*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11RefDefaultTrackingOptions p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11RefDefaultTrackingOptions p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11RefTrackingOptions
{
    private readonly TerraFX.Interop.DirectX.ID3D11RefTrackingOptions* p;

    public TerraFX.Interop.DirectX.ID3D11RefTrackingOptions* Get() => this.p;

    public static implicit operator PID3D11RefTrackingOptions(TerraFX.Interop.DirectX.ID3D11RefTrackingOptions* p) => *(PID3D11RefTrackingOptions*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11RefTrackingOptions*(PID3D11RefTrackingOptions p) => (TerraFX.Interop.DirectX.ID3D11RefTrackingOptions*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11RefTrackingOptions p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11RefTrackingOptions p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11RenderTargetView
{
    private readonly TerraFX.Interop.DirectX.ID3D11RenderTargetView* p;

    public TerraFX.Interop.DirectX.ID3D11RenderTargetView* Get() => this.p;

    public static implicit operator PID3D11RenderTargetView(TerraFX.Interop.DirectX.ID3D11RenderTargetView* p) => *(PID3D11RenderTargetView*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11RenderTargetView*(PID3D11RenderTargetView p) => (TerraFX.Interop.DirectX.ID3D11RenderTargetView*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11View*(PID3D11RenderTargetView p) => (TerraFX.Interop.DirectX.ID3D11View*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11RenderTargetView p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11RenderTargetView p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11RenderTargetView p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11RenderTargetView1
{
    private readonly TerraFX.Interop.DirectX.ID3D11RenderTargetView1* p;

    public TerraFX.Interop.DirectX.ID3D11RenderTargetView1* Get() => this.p;

    public static implicit operator PID3D11RenderTargetView1(TerraFX.Interop.DirectX.ID3D11RenderTargetView1* p) => *(PID3D11RenderTargetView1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11RenderTargetView1*(PID3D11RenderTargetView1 p) => (TerraFX.Interop.DirectX.ID3D11RenderTargetView1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11RenderTargetView*(PID3D11RenderTargetView1 p) => (TerraFX.Interop.DirectX.ID3D11RenderTargetView*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11View*(PID3D11RenderTargetView1 p) => (TerraFX.Interop.DirectX.ID3D11View*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11RenderTargetView1 p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11RenderTargetView1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11RenderTargetView1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11Resource
{
    private readonly TerraFX.Interop.DirectX.ID3D11Resource* p;

    public TerraFX.Interop.DirectX.ID3D11Resource* Get() => this.p;

    public static implicit operator PID3D11Resource(TerraFX.Interop.DirectX.ID3D11Resource* p) => *(PID3D11Resource*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Resource*(PID3D11Resource p) => (TerraFX.Interop.DirectX.ID3D11Resource*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11Resource p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11Resource p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11Resource p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11SamplerState
{
    private readonly TerraFX.Interop.DirectX.ID3D11SamplerState* p;

    public TerraFX.Interop.DirectX.ID3D11SamplerState* Get() => this.p;

    public static implicit operator PID3D11SamplerState(TerraFX.Interop.DirectX.ID3D11SamplerState* p) => *(PID3D11SamplerState*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11SamplerState*(PID3D11SamplerState p) => (TerraFX.Interop.DirectX.ID3D11SamplerState*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11SamplerState p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11SamplerState p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11SamplerState p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11ShaderReflection
{
    private readonly TerraFX.Interop.DirectX.ID3D11ShaderReflection* p;

    public TerraFX.Interop.DirectX.ID3D11ShaderReflection* Get() => this.p;

    public static implicit operator PID3D11ShaderReflection(TerraFX.Interop.DirectX.ID3D11ShaderReflection* p) => *(PID3D11ShaderReflection*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11ShaderReflection*(PID3D11ShaderReflection p) => (TerraFX.Interop.DirectX.ID3D11ShaderReflection*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11ShaderReflection p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11ShaderReflection p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11ShaderResourceView
{
    private readonly TerraFX.Interop.DirectX.ID3D11ShaderResourceView* p;

    public TerraFX.Interop.DirectX.ID3D11ShaderResourceView* Get() => this.p;

    public static implicit operator PID3D11ShaderResourceView(TerraFX.Interop.DirectX.ID3D11ShaderResourceView* p) => *(PID3D11ShaderResourceView*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11ShaderResourceView*(PID3D11ShaderResourceView p) => (TerraFX.Interop.DirectX.ID3D11ShaderResourceView*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11View*(PID3D11ShaderResourceView p) => (TerraFX.Interop.DirectX.ID3D11View*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11ShaderResourceView p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11ShaderResourceView p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11ShaderResourceView p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11ShaderResourceView1
{
    private readonly TerraFX.Interop.DirectX.ID3D11ShaderResourceView1* p;

    public TerraFX.Interop.DirectX.ID3D11ShaderResourceView1* Get() => this.p;

    public static implicit operator PID3D11ShaderResourceView1(TerraFX.Interop.DirectX.ID3D11ShaderResourceView1* p) => *(PID3D11ShaderResourceView1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11ShaderResourceView1*(PID3D11ShaderResourceView1 p) => (TerraFX.Interop.DirectX.ID3D11ShaderResourceView1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11ShaderResourceView*(PID3D11ShaderResourceView1 p) => (TerraFX.Interop.DirectX.ID3D11ShaderResourceView*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11View*(PID3D11ShaderResourceView1 p) => (TerraFX.Interop.DirectX.ID3D11View*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11ShaderResourceView1 p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11ShaderResourceView1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11ShaderResourceView1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11ShaderTrace
{
    private readonly TerraFX.Interop.DirectX.ID3D11ShaderTrace* p;

    public TerraFX.Interop.DirectX.ID3D11ShaderTrace* Get() => this.p;

    public static implicit operator PID3D11ShaderTrace(TerraFX.Interop.DirectX.ID3D11ShaderTrace* p) => *(PID3D11ShaderTrace*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11ShaderTrace*(PID3D11ShaderTrace p) => (TerraFX.Interop.DirectX.ID3D11ShaderTrace*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11ShaderTrace p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11ShaderTrace p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11ShaderTraceFactory
{
    private readonly TerraFX.Interop.DirectX.ID3D11ShaderTraceFactory* p;

    public TerraFX.Interop.DirectX.ID3D11ShaderTraceFactory* Get() => this.p;

    public static implicit operator PID3D11ShaderTraceFactory(TerraFX.Interop.DirectX.ID3D11ShaderTraceFactory* p) => *(PID3D11ShaderTraceFactory*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11ShaderTraceFactory*(PID3D11ShaderTraceFactory p) => (TerraFX.Interop.DirectX.ID3D11ShaderTraceFactory*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11ShaderTraceFactory p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11ShaderTraceFactory p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11SwitchToRef
{
    private readonly TerraFX.Interop.DirectX.ID3D11SwitchToRef* p;

    public TerraFX.Interop.DirectX.ID3D11SwitchToRef* Get() => this.p;

    public static implicit operator PID3D11SwitchToRef(TerraFX.Interop.DirectX.ID3D11SwitchToRef* p) => *(PID3D11SwitchToRef*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11SwitchToRef*(PID3D11SwitchToRef p) => (TerraFX.Interop.DirectX.ID3D11SwitchToRef*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11SwitchToRef p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11SwitchToRef p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11Texture1D
{
    private readonly TerraFX.Interop.DirectX.ID3D11Texture1D* p;

    public TerraFX.Interop.DirectX.ID3D11Texture1D* Get() => this.p;

    public static implicit operator PID3D11Texture1D(TerraFX.Interop.DirectX.ID3D11Texture1D* p) => *(PID3D11Texture1D*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Texture1D*(PID3D11Texture1D p) => (TerraFX.Interop.DirectX.ID3D11Texture1D*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Resource*(PID3D11Texture1D p) => (TerraFX.Interop.DirectX.ID3D11Resource*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11Texture1D p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11Texture1D p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11Texture1D p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11Texture2D
{
    private readonly TerraFX.Interop.DirectX.ID3D11Texture2D* p;

    public TerraFX.Interop.DirectX.ID3D11Texture2D* Get() => this.p;

    public static implicit operator PID3D11Texture2D(TerraFX.Interop.DirectX.ID3D11Texture2D* p) => *(PID3D11Texture2D*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Texture2D*(PID3D11Texture2D p) => (TerraFX.Interop.DirectX.ID3D11Texture2D*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Resource*(PID3D11Texture2D p) => (TerraFX.Interop.DirectX.ID3D11Resource*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11Texture2D p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11Texture2D p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11Texture2D p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11Texture2D1
{
    private readonly TerraFX.Interop.DirectX.ID3D11Texture2D1* p;

    public TerraFX.Interop.DirectX.ID3D11Texture2D1* Get() => this.p;

    public static implicit operator PID3D11Texture2D1(TerraFX.Interop.DirectX.ID3D11Texture2D1* p) => *(PID3D11Texture2D1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Texture2D1*(PID3D11Texture2D1 p) => (TerraFX.Interop.DirectX.ID3D11Texture2D1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Texture2D*(PID3D11Texture2D1 p) => (TerraFX.Interop.DirectX.ID3D11Texture2D*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Resource*(PID3D11Texture2D1 p) => (TerraFX.Interop.DirectX.ID3D11Resource*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11Texture2D1 p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11Texture2D1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11Texture2D1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11Texture3D
{
    private readonly TerraFX.Interop.DirectX.ID3D11Texture3D* p;

    public TerraFX.Interop.DirectX.ID3D11Texture3D* Get() => this.p;

    public static implicit operator PID3D11Texture3D(TerraFX.Interop.DirectX.ID3D11Texture3D* p) => *(PID3D11Texture3D*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Texture3D*(PID3D11Texture3D p) => (TerraFX.Interop.DirectX.ID3D11Texture3D*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Resource*(PID3D11Texture3D p) => (TerraFX.Interop.DirectX.ID3D11Resource*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11Texture3D p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11Texture3D p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11Texture3D p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11Texture3D1
{
    private readonly TerraFX.Interop.DirectX.ID3D11Texture3D1* p;

    public TerraFX.Interop.DirectX.ID3D11Texture3D1* Get() => this.p;

    public static implicit operator PID3D11Texture3D1(TerraFX.Interop.DirectX.ID3D11Texture3D1* p) => *(PID3D11Texture3D1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Texture3D1*(PID3D11Texture3D1 p) => (TerraFX.Interop.DirectX.ID3D11Texture3D1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Texture3D*(PID3D11Texture3D1 p) => (TerraFX.Interop.DirectX.ID3D11Texture3D*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11Resource*(PID3D11Texture3D1 p) => (TerraFX.Interop.DirectX.ID3D11Resource*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11Texture3D1 p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11Texture3D1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11Texture3D1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11TracingDevice
{
    private readonly TerraFX.Interop.DirectX.ID3D11TracingDevice* p;

    public TerraFX.Interop.DirectX.ID3D11TracingDevice* Get() => this.p;

    public static implicit operator PID3D11TracingDevice(TerraFX.Interop.DirectX.ID3D11TracingDevice* p) => *(PID3D11TracingDevice*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11TracingDevice*(PID3D11TracingDevice p) => (TerraFX.Interop.DirectX.ID3D11TracingDevice*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11TracingDevice p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11TracingDevice p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11UnorderedAccessView
{
    private readonly TerraFX.Interop.DirectX.ID3D11UnorderedAccessView* p;

    public TerraFX.Interop.DirectX.ID3D11UnorderedAccessView* Get() => this.p;

    public static implicit operator PID3D11UnorderedAccessView(TerraFX.Interop.DirectX.ID3D11UnorderedAccessView* p) => *(PID3D11UnorderedAccessView*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11UnorderedAccessView*(PID3D11UnorderedAccessView p) => (TerraFX.Interop.DirectX.ID3D11UnorderedAccessView*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11View*(PID3D11UnorderedAccessView p) => (TerraFX.Interop.DirectX.ID3D11View*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11UnorderedAccessView p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11UnorderedAccessView p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11UnorderedAccessView p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11UnorderedAccessView1
{
    private readonly TerraFX.Interop.DirectX.ID3D11UnorderedAccessView1* p;

    public TerraFX.Interop.DirectX.ID3D11UnorderedAccessView1* Get() => this.p;

    public static implicit operator PID3D11UnorderedAccessView1(TerraFX.Interop.DirectX.ID3D11UnorderedAccessView1* p) => *(PID3D11UnorderedAccessView1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11UnorderedAccessView1*(PID3D11UnorderedAccessView1 p) => (TerraFX.Interop.DirectX.ID3D11UnorderedAccessView1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11UnorderedAccessView*(PID3D11UnorderedAccessView1 p) => (TerraFX.Interop.DirectX.ID3D11UnorderedAccessView*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11View*(PID3D11UnorderedAccessView1 p) => (TerraFX.Interop.DirectX.ID3D11View*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11UnorderedAccessView1 p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11UnorderedAccessView1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11UnorderedAccessView1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11VertexShader
{
    private readonly TerraFX.Interop.DirectX.ID3D11VertexShader* p;

    public TerraFX.Interop.DirectX.ID3D11VertexShader* Get() => this.p;

    public static implicit operator PID3D11VertexShader(TerraFX.Interop.DirectX.ID3D11VertexShader* p) => *(PID3D11VertexShader*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11VertexShader*(PID3D11VertexShader p) => (TerraFX.Interop.DirectX.ID3D11VertexShader*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11VertexShader p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11VertexShader p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11VertexShader p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11VideoContext
{
    private readonly TerraFX.Interop.DirectX.ID3D11VideoContext* p;

    public TerraFX.Interop.DirectX.ID3D11VideoContext* Get() => this.p;

    public static implicit operator PID3D11VideoContext(TerraFX.Interop.DirectX.ID3D11VideoContext* p) => *(PID3D11VideoContext*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11VideoContext*(PID3D11VideoContext p) => (TerraFX.Interop.DirectX.ID3D11VideoContext*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11VideoContext p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11VideoContext p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11VideoContext p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11VideoContext1
{
    private readonly TerraFX.Interop.DirectX.ID3D11VideoContext1* p;

    public TerraFX.Interop.DirectX.ID3D11VideoContext1* Get() => this.p;

    public static implicit operator PID3D11VideoContext1(TerraFX.Interop.DirectX.ID3D11VideoContext1* p) => *(PID3D11VideoContext1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11VideoContext1*(PID3D11VideoContext1 p) => (TerraFX.Interop.DirectX.ID3D11VideoContext1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11VideoContext*(PID3D11VideoContext1 p) => (TerraFX.Interop.DirectX.ID3D11VideoContext*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11VideoContext1 p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11VideoContext1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11VideoContext1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11VideoContext2
{
    private readonly TerraFX.Interop.DirectX.ID3D11VideoContext2* p;

    public TerraFX.Interop.DirectX.ID3D11VideoContext2* Get() => this.p;

    public static implicit operator PID3D11VideoContext2(TerraFX.Interop.DirectX.ID3D11VideoContext2* p) => *(PID3D11VideoContext2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11VideoContext2*(PID3D11VideoContext2 p) => (TerraFX.Interop.DirectX.ID3D11VideoContext2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11VideoContext1*(PID3D11VideoContext2 p) => (TerraFX.Interop.DirectX.ID3D11VideoContext1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11VideoContext*(PID3D11VideoContext2 p) => (TerraFX.Interop.DirectX.ID3D11VideoContext*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11VideoContext2 p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11VideoContext2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11VideoContext2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11VideoContext3
{
    private readonly TerraFX.Interop.DirectX.ID3D11VideoContext3* p;

    public TerraFX.Interop.DirectX.ID3D11VideoContext3* Get() => this.p;

    public static implicit operator PID3D11VideoContext3(TerraFX.Interop.DirectX.ID3D11VideoContext3* p) => *(PID3D11VideoContext3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11VideoContext3*(PID3D11VideoContext3 p) => (TerraFX.Interop.DirectX.ID3D11VideoContext3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11VideoContext2*(PID3D11VideoContext3 p) => (TerraFX.Interop.DirectX.ID3D11VideoContext2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11VideoContext1*(PID3D11VideoContext3 p) => (TerraFX.Interop.DirectX.ID3D11VideoContext1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11VideoContext*(PID3D11VideoContext3 p) => (TerraFX.Interop.DirectX.ID3D11VideoContext*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11VideoContext3 p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11VideoContext3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11VideoContext3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11VideoDecoder
{
    private readonly TerraFX.Interop.DirectX.ID3D11VideoDecoder* p;

    public TerraFX.Interop.DirectX.ID3D11VideoDecoder* Get() => this.p;

    public static implicit operator PID3D11VideoDecoder(TerraFX.Interop.DirectX.ID3D11VideoDecoder* p) => *(PID3D11VideoDecoder*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11VideoDecoder*(PID3D11VideoDecoder p) => (TerraFX.Interop.DirectX.ID3D11VideoDecoder*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11VideoDecoder p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11VideoDecoder p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11VideoDecoder p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11VideoDecoderOutputView
{
    private readonly TerraFX.Interop.DirectX.ID3D11VideoDecoderOutputView* p;

    public TerraFX.Interop.DirectX.ID3D11VideoDecoderOutputView* Get() => this.p;

    public static implicit operator PID3D11VideoDecoderOutputView(TerraFX.Interop.DirectX.ID3D11VideoDecoderOutputView* p) => *(PID3D11VideoDecoderOutputView*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11VideoDecoderOutputView*(PID3D11VideoDecoderOutputView p) => (TerraFX.Interop.DirectX.ID3D11VideoDecoderOutputView*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11View*(PID3D11VideoDecoderOutputView p) => (TerraFX.Interop.DirectX.ID3D11View*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11VideoDecoderOutputView p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11VideoDecoderOutputView p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11VideoDecoderOutputView p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11VideoDevice
{
    private readonly TerraFX.Interop.DirectX.ID3D11VideoDevice* p;

    public TerraFX.Interop.DirectX.ID3D11VideoDevice* Get() => this.p;

    public static implicit operator PID3D11VideoDevice(TerraFX.Interop.DirectX.ID3D11VideoDevice* p) => *(PID3D11VideoDevice*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11VideoDevice*(PID3D11VideoDevice p) => (TerraFX.Interop.DirectX.ID3D11VideoDevice*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11VideoDevice p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11VideoDevice p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11VideoDevice1
{
    private readonly TerraFX.Interop.DirectX.ID3D11VideoDevice1* p;

    public TerraFX.Interop.DirectX.ID3D11VideoDevice1* Get() => this.p;

    public static implicit operator PID3D11VideoDevice1(TerraFX.Interop.DirectX.ID3D11VideoDevice1* p) => *(PID3D11VideoDevice1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11VideoDevice1*(PID3D11VideoDevice1 p) => (TerraFX.Interop.DirectX.ID3D11VideoDevice1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11VideoDevice*(PID3D11VideoDevice1 p) => (TerraFX.Interop.DirectX.ID3D11VideoDevice*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11VideoDevice1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11VideoDevice1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11VideoDevice2
{
    private readonly TerraFX.Interop.DirectX.ID3D11VideoDevice2* p;

    public TerraFX.Interop.DirectX.ID3D11VideoDevice2* Get() => this.p;

    public static implicit operator PID3D11VideoDevice2(TerraFX.Interop.DirectX.ID3D11VideoDevice2* p) => *(PID3D11VideoDevice2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11VideoDevice2*(PID3D11VideoDevice2 p) => (TerraFX.Interop.DirectX.ID3D11VideoDevice2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11VideoDevice1*(PID3D11VideoDevice2 p) => (TerraFX.Interop.DirectX.ID3D11VideoDevice1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11VideoDevice*(PID3D11VideoDevice2 p) => (TerraFX.Interop.DirectX.ID3D11VideoDevice*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11VideoDevice2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11VideoDevice2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11VideoProcessor
{
    private readonly TerraFX.Interop.DirectX.ID3D11VideoProcessor* p;

    public TerraFX.Interop.DirectX.ID3D11VideoProcessor* Get() => this.p;

    public static implicit operator PID3D11VideoProcessor(TerraFX.Interop.DirectX.ID3D11VideoProcessor* p) => *(PID3D11VideoProcessor*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11VideoProcessor*(PID3D11VideoProcessor p) => (TerraFX.Interop.DirectX.ID3D11VideoProcessor*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11VideoProcessor p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11VideoProcessor p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11VideoProcessor p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11VideoProcessorEnumerator
{
    private readonly TerraFX.Interop.DirectX.ID3D11VideoProcessorEnumerator* p;

    public TerraFX.Interop.DirectX.ID3D11VideoProcessorEnumerator* Get() => this.p;

    public static implicit operator PID3D11VideoProcessorEnumerator(TerraFX.Interop.DirectX.ID3D11VideoProcessorEnumerator* p) => *(PID3D11VideoProcessorEnumerator*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11VideoProcessorEnumerator*(PID3D11VideoProcessorEnumerator p) => (TerraFX.Interop.DirectX.ID3D11VideoProcessorEnumerator*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11VideoProcessorEnumerator p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11VideoProcessorEnumerator p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11VideoProcessorEnumerator p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11VideoProcessorEnumerator1
{
    private readonly TerraFX.Interop.DirectX.ID3D11VideoProcessorEnumerator1* p;

    public TerraFX.Interop.DirectX.ID3D11VideoProcessorEnumerator1* Get() => this.p;

    public static implicit operator PID3D11VideoProcessorEnumerator1(TerraFX.Interop.DirectX.ID3D11VideoProcessorEnumerator1* p) => *(PID3D11VideoProcessorEnumerator1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11VideoProcessorEnumerator1*(PID3D11VideoProcessorEnumerator1 p) => (TerraFX.Interop.DirectX.ID3D11VideoProcessorEnumerator1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11VideoProcessorEnumerator*(PID3D11VideoProcessorEnumerator1 p) => (TerraFX.Interop.DirectX.ID3D11VideoProcessorEnumerator*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11VideoProcessorEnumerator1 p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11VideoProcessorEnumerator1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11VideoProcessorEnumerator1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11VideoProcessorInputView
{
    private readonly TerraFX.Interop.DirectX.ID3D11VideoProcessorInputView* p;

    public TerraFX.Interop.DirectX.ID3D11VideoProcessorInputView* Get() => this.p;

    public static implicit operator PID3D11VideoProcessorInputView(TerraFX.Interop.DirectX.ID3D11VideoProcessorInputView* p) => *(PID3D11VideoProcessorInputView*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11VideoProcessorInputView*(PID3D11VideoProcessorInputView p) => (TerraFX.Interop.DirectX.ID3D11VideoProcessorInputView*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11View*(PID3D11VideoProcessorInputView p) => (TerraFX.Interop.DirectX.ID3D11View*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11VideoProcessorInputView p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11VideoProcessorInputView p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11VideoProcessorInputView p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11VideoProcessorOutputView
{
    private readonly TerraFX.Interop.DirectX.ID3D11VideoProcessorOutputView* p;

    public TerraFX.Interop.DirectX.ID3D11VideoProcessorOutputView* Get() => this.p;

    public static implicit operator PID3D11VideoProcessorOutputView(TerraFX.Interop.DirectX.ID3D11VideoProcessorOutputView* p) => *(PID3D11VideoProcessorOutputView*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11VideoProcessorOutputView*(PID3D11VideoProcessorOutputView p) => (TerraFX.Interop.DirectX.ID3D11VideoProcessorOutputView*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11View*(PID3D11VideoProcessorOutputView p) => (TerraFX.Interop.DirectX.ID3D11View*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11VideoProcessorOutputView p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11VideoProcessorOutputView p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11VideoProcessorOutputView p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D11View
{
    private readonly TerraFX.Interop.DirectX.ID3D11View* p;

    public TerraFX.Interop.DirectX.ID3D11View* Get() => this.p;

    public static implicit operator PID3D11View(TerraFX.Interop.DirectX.ID3D11View* p) => *(PID3D11View*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11View*(PID3D11View p) => (TerraFX.Interop.DirectX.ID3D11View*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3D11View p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D11View p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D11View p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12CommandAllocator
{
    private readonly TerraFX.Interop.DirectX.ID3D12CommandAllocator* p;

    public TerraFX.Interop.DirectX.ID3D12CommandAllocator* Get() => this.p;

    public static implicit operator PID3D12CommandAllocator(TerraFX.Interop.DirectX.ID3D12CommandAllocator* p) => *(PID3D12CommandAllocator*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12CommandAllocator*(PID3D12CommandAllocator p) => (TerraFX.Interop.DirectX.ID3D12CommandAllocator*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Pageable*(PID3D12CommandAllocator p) => (TerraFX.Interop.DirectX.ID3D12Pageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12CommandAllocator p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12CommandAllocator p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12CommandAllocator p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12CommandAllocator p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12CommandList
{
    private readonly TerraFX.Interop.DirectX.ID3D12CommandList* p;

    public TerraFX.Interop.DirectX.ID3D12CommandList* Get() => this.p;

    public static implicit operator PID3D12CommandList(TerraFX.Interop.DirectX.ID3D12CommandList* p) => *(PID3D12CommandList*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12CommandList*(PID3D12CommandList p) => (TerraFX.Interop.DirectX.ID3D12CommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12CommandList p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12CommandList p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12CommandList p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12CommandList p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12CommandQueue
{
    private readonly TerraFX.Interop.DirectX.ID3D12CommandQueue* p;

    public TerraFX.Interop.DirectX.ID3D12CommandQueue* Get() => this.p;

    public static implicit operator PID3D12CommandQueue(TerraFX.Interop.DirectX.ID3D12CommandQueue* p) => *(PID3D12CommandQueue*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12CommandQueue*(PID3D12CommandQueue p) => (TerraFX.Interop.DirectX.ID3D12CommandQueue*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Pageable*(PID3D12CommandQueue p) => (TerraFX.Interop.DirectX.ID3D12Pageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12CommandQueue p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12CommandQueue p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12CommandQueue p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12CommandQueue p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12CommandQueueDownlevel
{
    private readonly TerraFX.Interop.DirectX.ID3D12CommandQueueDownlevel* p;

    public TerraFX.Interop.DirectX.ID3D12CommandQueueDownlevel* Get() => this.p;

    public static implicit operator PID3D12CommandQueueDownlevel(TerraFX.Interop.DirectX.ID3D12CommandQueueDownlevel* p) => *(PID3D12CommandQueueDownlevel*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12CommandQueueDownlevel*(PID3D12CommandQueueDownlevel p) => (TerraFX.Interop.DirectX.ID3D12CommandQueueDownlevel*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12CommandQueueDownlevel p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12CommandQueueDownlevel p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12CommandSignature
{
    private readonly TerraFX.Interop.DirectX.ID3D12CommandSignature* p;

    public TerraFX.Interop.DirectX.ID3D12CommandSignature* Get() => this.p;

    public static implicit operator PID3D12CommandSignature(TerraFX.Interop.DirectX.ID3D12CommandSignature* p) => *(PID3D12CommandSignature*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12CommandSignature*(PID3D12CommandSignature p) => (TerraFX.Interop.DirectX.ID3D12CommandSignature*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Pageable*(PID3D12CommandSignature p) => (TerraFX.Interop.DirectX.ID3D12Pageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12CommandSignature p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12CommandSignature p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12CommandSignature p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12CommandSignature p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12CompatibilityDevice
{
    private readonly TerraFX.Interop.DirectX.ID3D12CompatibilityDevice* p;

    public TerraFX.Interop.DirectX.ID3D12CompatibilityDevice* Get() => this.p;

    public static implicit operator PID3D12CompatibilityDevice(TerraFX.Interop.DirectX.ID3D12CompatibilityDevice* p) => *(PID3D12CompatibilityDevice*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12CompatibilityDevice*(PID3D12CompatibilityDevice p) => (TerraFX.Interop.DirectX.ID3D12CompatibilityDevice*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12CompatibilityDevice p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12CompatibilityDevice p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Debug
{
    private readonly TerraFX.Interop.DirectX.ID3D12Debug* p;

    public TerraFX.Interop.DirectX.ID3D12Debug* Get() => this.p;

    public static implicit operator PID3D12Debug(TerraFX.Interop.DirectX.ID3D12Debug* p) => *(PID3D12Debug*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Debug*(PID3D12Debug p) => (TerraFX.Interop.DirectX.ID3D12Debug*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Debug p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Debug p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Debug1
{
    private readonly TerraFX.Interop.DirectX.ID3D12Debug1* p;

    public TerraFX.Interop.DirectX.ID3D12Debug1* Get() => this.p;

    public static implicit operator PID3D12Debug1(TerraFX.Interop.DirectX.ID3D12Debug1* p) => *(PID3D12Debug1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Debug1*(PID3D12Debug1 p) => (TerraFX.Interop.DirectX.ID3D12Debug1*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Debug1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Debug1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Debug2
{
    private readonly TerraFX.Interop.DirectX.ID3D12Debug2* p;

    public TerraFX.Interop.DirectX.ID3D12Debug2* Get() => this.p;

    public static implicit operator PID3D12Debug2(TerraFX.Interop.DirectX.ID3D12Debug2* p) => *(PID3D12Debug2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Debug2*(PID3D12Debug2 p) => (TerraFX.Interop.DirectX.ID3D12Debug2*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Debug2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Debug2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Debug3
{
    private readonly TerraFX.Interop.DirectX.ID3D12Debug3* p;

    public TerraFX.Interop.DirectX.ID3D12Debug3* Get() => this.p;

    public static implicit operator PID3D12Debug3(TerraFX.Interop.DirectX.ID3D12Debug3* p) => *(PID3D12Debug3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Debug3*(PID3D12Debug3 p) => (TerraFX.Interop.DirectX.ID3D12Debug3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Debug*(PID3D12Debug3 p) => (TerraFX.Interop.DirectX.ID3D12Debug*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Debug3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Debug3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Debug4
{
    private readonly TerraFX.Interop.DirectX.ID3D12Debug4* p;

    public TerraFX.Interop.DirectX.ID3D12Debug4* Get() => this.p;

    public static implicit operator PID3D12Debug4(TerraFX.Interop.DirectX.ID3D12Debug4* p) => *(PID3D12Debug4*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Debug4*(PID3D12Debug4 p) => (TerraFX.Interop.DirectX.ID3D12Debug4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Debug3*(PID3D12Debug4 p) => (TerraFX.Interop.DirectX.ID3D12Debug3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Debug*(PID3D12Debug4 p) => (TerraFX.Interop.DirectX.ID3D12Debug*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Debug4 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Debug4 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Debug5
{
    private readonly TerraFX.Interop.DirectX.ID3D12Debug5* p;

    public TerraFX.Interop.DirectX.ID3D12Debug5* Get() => this.p;

    public static implicit operator PID3D12Debug5(TerraFX.Interop.DirectX.ID3D12Debug5* p) => *(PID3D12Debug5*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Debug5*(PID3D12Debug5 p) => (TerraFX.Interop.DirectX.ID3D12Debug5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Debug4*(PID3D12Debug5 p) => (TerraFX.Interop.DirectX.ID3D12Debug4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Debug3*(PID3D12Debug5 p) => (TerraFX.Interop.DirectX.ID3D12Debug3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Debug*(PID3D12Debug5 p) => (TerraFX.Interop.DirectX.ID3D12Debug*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Debug5 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Debug5 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Debug6
{
    private readonly TerraFX.Interop.DirectX.ID3D12Debug6* p;

    public TerraFX.Interop.DirectX.ID3D12Debug6* Get() => this.p;

    public static implicit operator PID3D12Debug6(TerraFX.Interop.DirectX.ID3D12Debug6* p) => *(PID3D12Debug6*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Debug6*(PID3D12Debug6 p) => (TerraFX.Interop.DirectX.ID3D12Debug6*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Debug5*(PID3D12Debug6 p) => (TerraFX.Interop.DirectX.ID3D12Debug5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Debug4*(PID3D12Debug6 p) => (TerraFX.Interop.DirectX.ID3D12Debug4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Debug3*(PID3D12Debug6 p) => (TerraFX.Interop.DirectX.ID3D12Debug3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Debug*(PID3D12Debug6 p) => (TerraFX.Interop.DirectX.ID3D12Debug*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Debug6 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Debug6 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12DebugCommandList
{
    private readonly TerraFX.Interop.DirectX.ID3D12DebugCommandList* p;

    public TerraFX.Interop.DirectX.ID3D12DebugCommandList* Get() => this.p;

    public static implicit operator PID3D12DebugCommandList(TerraFX.Interop.DirectX.ID3D12DebugCommandList* p) => *(PID3D12DebugCommandList*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DebugCommandList*(PID3D12DebugCommandList p) => (TerraFX.Interop.DirectX.ID3D12DebugCommandList*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12DebugCommandList p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12DebugCommandList p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12DebugCommandList1
{
    private readonly TerraFX.Interop.DirectX.ID3D12DebugCommandList1* p;

    public TerraFX.Interop.DirectX.ID3D12DebugCommandList1* Get() => this.p;

    public static implicit operator PID3D12DebugCommandList1(TerraFX.Interop.DirectX.ID3D12DebugCommandList1* p) => *(PID3D12DebugCommandList1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DebugCommandList1*(PID3D12DebugCommandList1 p) => (TerraFX.Interop.DirectX.ID3D12DebugCommandList1*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12DebugCommandList1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12DebugCommandList1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12DebugCommandList2
{
    private readonly TerraFX.Interop.DirectX.ID3D12DebugCommandList2* p;

    public TerraFX.Interop.DirectX.ID3D12DebugCommandList2* Get() => this.p;

    public static implicit operator PID3D12DebugCommandList2(TerraFX.Interop.DirectX.ID3D12DebugCommandList2* p) => *(PID3D12DebugCommandList2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DebugCommandList2*(PID3D12DebugCommandList2 p) => (TerraFX.Interop.DirectX.ID3D12DebugCommandList2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DebugCommandList*(PID3D12DebugCommandList2 p) => (TerraFX.Interop.DirectX.ID3D12DebugCommandList*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12DebugCommandList2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12DebugCommandList2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12DebugCommandList3
{
    private readonly TerraFX.Interop.DirectX.ID3D12DebugCommandList3* p;

    public TerraFX.Interop.DirectX.ID3D12DebugCommandList3* Get() => this.p;

    public static implicit operator PID3D12DebugCommandList3(TerraFX.Interop.DirectX.ID3D12DebugCommandList3* p) => *(PID3D12DebugCommandList3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DebugCommandList3*(PID3D12DebugCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12DebugCommandList3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DebugCommandList2*(PID3D12DebugCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12DebugCommandList2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DebugCommandList*(PID3D12DebugCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12DebugCommandList*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12DebugCommandList3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12DebugCommandList3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12DebugCommandQueue
{
    private readonly TerraFX.Interop.DirectX.ID3D12DebugCommandQueue* p;

    public TerraFX.Interop.DirectX.ID3D12DebugCommandQueue* Get() => this.p;

    public static implicit operator PID3D12DebugCommandQueue(TerraFX.Interop.DirectX.ID3D12DebugCommandQueue* p) => *(PID3D12DebugCommandQueue*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DebugCommandQueue*(PID3D12DebugCommandQueue p) => (TerraFX.Interop.DirectX.ID3D12DebugCommandQueue*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12DebugCommandQueue p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12DebugCommandQueue p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12DebugCommandQueue1
{
    private readonly TerraFX.Interop.DirectX.ID3D12DebugCommandQueue1* p;

    public TerraFX.Interop.DirectX.ID3D12DebugCommandQueue1* Get() => this.p;

    public static implicit operator PID3D12DebugCommandQueue1(TerraFX.Interop.DirectX.ID3D12DebugCommandQueue1* p) => *(PID3D12DebugCommandQueue1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DebugCommandQueue1*(PID3D12DebugCommandQueue1 p) => (TerraFX.Interop.DirectX.ID3D12DebugCommandQueue1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DebugCommandQueue*(PID3D12DebugCommandQueue1 p) => (TerraFX.Interop.DirectX.ID3D12DebugCommandQueue*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12DebugCommandQueue1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12DebugCommandQueue1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12DebugDevice
{
    private readonly TerraFX.Interop.DirectX.ID3D12DebugDevice* p;

    public TerraFX.Interop.DirectX.ID3D12DebugDevice* Get() => this.p;

    public static implicit operator PID3D12DebugDevice(TerraFX.Interop.DirectX.ID3D12DebugDevice* p) => *(PID3D12DebugDevice*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DebugDevice*(PID3D12DebugDevice p) => (TerraFX.Interop.DirectX.ID3D12DebugDevice*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12DebugDevice p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12DebugDevice p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12DebugDevice1
{
    private readonly TerraFX.Interop.DirectX.ID3D12DebugDevice1* p;

    public TerraFX.Interop.DirectX.ID3D12DebugDevice1* Get() => this.p;

    public static implicit operator PID3D12DebugDevice1(TerraFX.Interop.DirectX.ID3D12DebugDevice1* p) => *(PID3D12DebugDevice1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DebugDevice1*(PID3D12DebugDevice1 p) => (TerraFX.Interop.DirectX.ID3D12DebugDevice1*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12DebugDevice1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12DebugDevice1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12DebugDevice2
{
    private readonly TerraFX.Interop.DirectX.ID3D12DebugDevice2* p;

    public TerraFX.Interop.DirectX.ID3D12DebugDevice2* Get() => this.p;

    public static implicit operator PID3D12DebugDevice2(TerraFX.Interop.DirectX.ID3D12DebugDevice2* p) => *(PID3D12DebugDevice2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DebugDevice2*(PID3D12DebugDevice2 p) => (TerraFX.Interop.DirectX.ID3D12DebugDevice2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DebugDevice*(PID3D12DebugDevice2 p) => (TerraFX.Interop.DirectX.ID3D12DebugDevice*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12DebugDevice2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12DebugDevice2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12DescriptorHeap
{
    private readonly TerraFX.Interop.DirectX.ID3D12DescriptorHeap* p;

    public TerraFX.Interop.DirectX.ID3D12DescriptorHeap* Get() => this.p;

    public static implicit operator PID3D12DescriptorHeap(TerraFX.Interop.DirectX.ID3D12DescriptorHeap* p) => *(PID3D12DescriptorHeap*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DescriptorHeap*(PID3D12DescriptorHeap p) => (TerraFX.Interop.DirectX.ID3D12DescriptorHeap*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Pageable*(PID3D12DescriptorHeap p) => (TerraFX.Interop.DirectX.ID3D12Pageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12DescriptorHeap p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12DescriptorHeap p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12DescriptorHeap p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12DescriptorHeap p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Device
{
    private readonly TerraFX.Interop.DirectX.ID3D12Device* p;

    public TerraFX.Interop.DirectX.ID3D12Device* Get() => this.p;

    public static implicit operator PID3D12Device(TerraFX.Interop.DirectX.ID3D12Device* p) => *(PID3D12Device*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device*(PID3D12Device p) => (TerraFX.Interop.DirectX.ID3D12Device*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12Device p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Device p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Device p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Device1
{
    private readonly TerraFX.Interop.DirectX.ID3D12Device1* p;

    public TerraFX.Interop.DirectX.ID3D12Device1* Get() => this.p;

    public static implicit operator PID3D12Device1(TerraFX.Interop.DirectX.ID3D12Device1* p) => *(PID3D12Device1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device1*(PID3D12Device1 p) => (TerraFX.Interop.DirectX.ID3D12Device1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device*(PID3D12Device1 p) => (TerraFX.Interop.DirectX.ID3D12Device*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12Device1 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Device1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Device1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Device10
{
    private readonly TerraFX.Interop.DirectX.ID3D12Device10* p;

    public TerraFX.Interop.DirectX.ID3D12Device10* Get() => this.p;

    public static implicit operator PID3D12Device10(TerraFX.Interop.DirectX.ID3D12Device10* p) => *(PID3D12Device10*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device10*(PID3D12Device10 p) => (TerraFX.Interop.DirectX.ID3D12Device10*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device9*(PID3D12Device10 p) => (TerraFX.Interop.DirectX.ID3D12Device9*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device8*(PID3D12Device10 p) => (TerraFX.Interop.DirectX.ID3D12Device8*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device7*(PID3D12Device10 p) => (TerraFX.Interop.DirectX.ID3D12Device7*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device6*(PID3D12Device10 p) => (TerraFX.Interop.DirectX.ID3D12Device6*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device5*(PID3D12Device10 p) => (TerraFX.Interop.DirectX.ID3D12Device5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device4*(PID3D12Device10 p) => (TerraFX.Interop.DirectX.ID3D12Device4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device3*(PID3D12Device10 p) => (TerraFX.Interop.DirectX.ID3D12Device3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device2*(PID3D12Device10 p) => (TerraFX.Interop.DirectX.ID3D12Device2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device1*(PID3D12Device10 p) => (TerraFX.Interop.DirectX.ID3D12Device1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device*(PID3D12Device10 p) => (TerraFX.Interop.DirectX.ID3D12Device*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12Device10 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Device10 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Device10 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Device11
{
    private readonly TerraFX.Interop.DirectX.ID3D12Device11* p;

    public TerraFX.Interop.DirectX.ID3D12Device11* Get() => this.p;

    public static implicit operator PID3D12Device11(TerraFX.Interop.DirectX.ID3D12Device11* p) => *(PID3D12Device11*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device11*(PID3D12Device11 p) => (TerraFX.Interop.DirectX.ID3D12Device11*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device10*(PID3D12Device11 p) => (TerraFX.Interop.DirectX.ID3D12Device10*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device9*(PID3D12Device11 p) => (TerraFX.Interop.DirectX.ID3D12Device9*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device8*(PID3D12Device11 p) => (TerraFX.Interop.DirectX.ID3D12Device8*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device7*(PID3D12Device11 p) => (TerraFX.Interop.DirectX.ID3D12Device7*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device6*(PID3D12Device11 p) => (TerraFX.Interop.DirectX.ID3D12Device6*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device5*(PID3D12Device11 p) => (TerraFX.Interop.DirectX.ID3D12Device5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device4*(PID3D12Device11 p) => (TerraFX.Interop.DirectX.ID3D12Device4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device3*(PID3D12Device11 p) => (TerraFX.Interop.DirectX.ID3D12Device3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device2*(PID3D12Device11 p) => (TerraFX.Interop.DirectX.ID3D12Device2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device1*(PID3D12Device11 p) => (TerraFX.Interop.DirectX.ID3D12Device1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device*(PID3D12Device11 p) => (TerraFX.Interop.DirectX.ID3D12Device*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12Device11 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Device11 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Device11 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Device12
{
    private readonly TerraFX.Interop.DirectX.ID3D12Device12* p;

    public TerraFX.Interop.DirectX.ID3D12Device12* Get() => this.p;

    public static implicit operator PID3D12Device12(TerraFX.Interop.DirectX.ID3D12Device12* p) => *(PID3D12Device12*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device12*(PID3D12Device12 p) => (TerraFX.Interop.DirectX.ID3D12Device12*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device11*(PID3D12Device12 p) => (TerraFX.Interop.DirectX.ID3D12Device11*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device10*(PID3D12Device12 p) => (TerraFX.Interop.DirectX.ID3D12Device10*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device9*(PID3D12Device12 p) => (TerraFX.Interop.DirectX.ID3D12Device9*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device8*(PID3D12Device12 p) => (TerraFX.Interop.DirectX.ID3D12Device8*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device7*(PID3D12Device12 p) => (TerraFX.Interop.DirectX.ID3D12Device7*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device6*(PID3D12Device12 p) => (TerraFX.Interop.DirectX.ID3D12Device6*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device5*(PID3D12Device12 p) => (TerraFX.Interop.DirectX.ID3D12Device5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device4*(PID3D12Device12 p) => (TerraFX.Interop.DirectX.ID3D12Device4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device3*(PID3D12Device12 p) => (TerraFX.Interop.DirectX.ID3D12Device3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device2*(PID3D12Device12 p) => (TerraFX.Interop.DirectX.ID3D12Device2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device1*(PID3D12Device12 p) => (TerraFX.Interop.DirectX.ID3D12Device1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device*(PID3D12Device12 p) => (TerraFX.Interop.DirectX.ID3D12Device*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12Device12 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Device12 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Device12 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Device13
{
    private readonly TerraFX.Interop.DirectX.ID3D12Device13* p;

    public TerraFX.Interop.DirectX.ID3D12Device13* Get() => this.p;

    public static implicit operator PID3D12Device13(TerraFX.Interop.DirectX.ID3D12Device13* p) => *(PID3D12Device13*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device13*(PID3D12Device13 p) => (TerraFX.Interop.DirectX.ID3D12Device13*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device12*(PID3D12Device13 p) => (TerraFX.Interop.DirectX.ID3D12Device12*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device11*(PID3D12Device13 p) => (TerraFX.Interop.DirectX.ID3D12Device11*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device10*(PID3D12Device13 p) => (TerraFX.Interop.DirectX.ID3D12Device10*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device9*(PID3D12Device13 p) => (TerraFX.Interop.DirectX.ID3D12Device9*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device8*(PID3D12Device13 p) => (TerraFX.Interop.DirectX.ID3D12Device8*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device7*(PID3D12Device13 p) => (TerraFX.Interop.DirectX.ID3D12Device7*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device6*(PID3D12Device13 p) => (TerraFX.Interop.DirectX.ID3D12Device6*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device5*(PID3D12Device13 p) => (TerraFX.Interop.DirectX.ID3D12Device5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device4*(PID3D12Device13 p) => (TerraFX.Interop.DirectX.ID3D12Device4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device3*(PID3D12Device13 p) => (TerraFX.Interop.DirectX.ID3D12Device3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device2*(PID3D12Device13 p) => (TerraFX.Interop.DirectX.ID3D12Device2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device1*(PID3D12Device13 p) => (TerraFX.Interop.DirectX.ID3D12Device1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device*(PID3D12Device13 p) => (TerraFX.Interop.DirectX.ID3D12Device*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12Device13 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Device13 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Device13 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Device2
{
    private readonly TerraFX.Interop.DirectX.ID3D12Device2* p;

    public TerraFX.Interop.DirectX.ID3D12Device2* Get() => this.p;

    public static implicit operator PID3D12Device2(TerraFX.Interop.DirectX.ID3D12Device2* p) => *(PID3D12Device2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device2*(PID3D12Device2 p) => (TerraFX.Interop.DirectX.ID3D12Device2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device1*(PID3D12Device2 p) => (TerraFX.Interop.DirectX.ID3D12Device1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device*(PID3D12Device2 p) => (TerraFX.Interop.DirectX.ID3D12Device*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12Device2 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Device2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Device2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Device3
{
    private readonly TerraFX.Interop.DirectX.ID3D12Device3* p;

    public TerraFX.Interop.DirectX.ID3D12Device3* Get() => this.p;

    public static implicit operator PID3D12Device3(TerraFX.Interop.DirectX.ID3D12Device3* p) => *(PID3D12Device3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device3*(PID3D12Device3 p) => (TerraFX.Interop.DirectX.ID3D12Device3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device2*(PID3D12Device3 p) => (TerraFX.Interop.DirectX.ID3D12Device2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device1*(PID3D12Device3 p) => (TerraFX.Interop.DirectX.ID3D12Device1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device*(PID3D12Device3 p) => (TerraFX.Interop.DirectX.ID3D12Device*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12Device3 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Device3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Device3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Device4
{
    private readonly TerraFX.Interop.DirectX.ID3D12Device4* p;

    public TerraFX.Interop.DirectX.ID3D12Device4* Get() => this.p;

    public static implicit operator PID3D12Device4(TerraFX.Interop.DirectX.ID3D12Device4* p) => *(PID3D12Device4*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device4*(PID3D12Device4 p) => (TerraFX.Interop.DirectX.ID3D12Device4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device3*(PID3D12Device4 p) => (TerraFX.Interop.DirectX.ID3D12Device3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device2*(PID3D12Device4 p) => (TerraFX.Interop.DirectX.ID3D12Device2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device1*(PID3D12Device4 p) => (TerraFX.Interop.DirectX.ID3D12Device1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device*(PID3D12Device4 p) => (TerraFX.Interop.DirectX.ID3D12Device*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12Device4 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Device4 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Device4 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Device5
{
    private readonly TerraFX.Interop.DirectX.ID3D12Device5* p;

    public TerraFX.Interop.DirectX.ID3D12Device5* Get() => this.p;

    public static implicit operator PID3D12Device5(TerraFX.Interop.DirectX.ID3D12Device5* p) => *(PID3D12Device5*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device5*(PID3D12Device5 p) => (TerraFX.Interop.DirectX.ID3D12Device5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device4*(PID3D12Device5 p) => (TerraFX.Interop.DirectX.ID3D12Device4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device3*(PID3D12Device5 p) => (TerraFX.Interop.DirectX.ID3D12Device3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device2*(PID3D12Device5 p) => (TerraFX.Interop.DirectX.ID3D12Device2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device1*(PID3D12Device5 p) => (TerraFX.Interop.DirectX.ID3D12Device1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device*(PID3D12Device5 p) => (TerraFX.Interop.DirectX.ID3D12Device*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12Device5 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Device5 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Device5 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Device6
{
    private readonly TerraFX.Interop.DirectX.ID3D12Device6* p;

    public TerraFX.Interop.DirectX.ID3D12Device6* Get() => this.p;

    public static implicit operator PID3D12Device6(TerraFX.Interop.DirectX.ID3D12Device6* p) => *(PID3D12Device6*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device6*(PID3D12Device6 p) => (TerraFX.Interop.DirectX.ID3D12Device6*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device5*(PID3D12Device6 p) => (TerraFX.Interop.DirectX.ID3D12Device5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device4*(PID3D12Device6 p) => (TerraFX.Interop.DirectX.ID3D12Device4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device3*(PID3D12Device6 p) => (TerraFX.Interop.DirectX.ID3D12Device3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device2*(PID3D12Device6 p) => (TerraFX.Interop.DirectX.ID3D12Device2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device1*(PID3D12Device6 p) => (TerraFX.Interop.DirectX.ID3D12Device1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device*(PID3D12Device6 p) => (TerraFX.Interop.DirectX.ID3D12Device*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12Device6 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Device6 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Device6 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Device7
{
    private readonly TerraFX.Interop.DirectX.ID3D12Device7* p;

    public TerraFX.Interop.DirectX.ID3D12Device7* Get() => this.p;

    public static implicit operator PID3D12Device7(TerraFX.Interop.DirectX.ID3D12Device7* p) => *(PID3D12Device7*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device7*(PID3D12Device7 p) => (TerraFX.Interop.DirectX.ID3D12Device7*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device6*(PID3D12Device7 p) => (TerraFX.Interop.DirectX.ID3D12Device6*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device5*(PID3D12Device7 p) => (TerraFX.Interop.DirectX.ID3D12Device5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device4*(PID3D12Device7 p) => (TerraFX.Interop.DirectX.ID3D12Device4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device3*(PID3D12Device7 p) => (TerraFX.Interop.DirectX.ID3D12Device3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device2*(PID3D12Device7 p) => (TerraFX.Interop.DirectX.ID3D12Device2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device1*(PID3D12Device7 p) => (TerraFX.Interop.DirectX.ID3D12Device1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device*(PID3D12Device7 p) => (TerraFX.Interop.DirectX.ID3D12Device*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12Device7 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Device7 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Device7 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Device8
{
    private readonly TerraFX.Interop.DirectX.ID3D12Device8* p;

    public TerraFX.Interop.DirectX.ID3D12Device8* Get() => this.p;

    public static implicit operator PID3D12Device8(TerraFX.Interop.DirectX.ID3D12Device8* p) => *(PID3D12Device8*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device8*(PID3D12Device8 p) => (TerraFX.Interop.DirectX.ID3D12Device8*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device7*(PID3D12Device8 p) => (TerraFX.Interop.DirectX.ID3D12Device7*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device6*(PID3D12Device8 p) => (TerraFX.Interop.DirectX.ID3D12Device6*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device5*(PID3D12Device8 p) => (TerraFX.Interop.DirectX.ID3D12Device5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device4*(PID3D12Device8 p) => (TerraFX.Interop.DirectX.ID3D12Device4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device3*(PID3D12Device8 p) => (TerraFX.Interop.DirectX.ID3D12Device3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device2*(PID3D12Device8 p) => (TerraFX.Interop.DirectX.ID3D12Device2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device1*(PID3D12Device8 p) => (TerraFX.Interop.DirectX.ID3D12Device1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device*(PID3D12Device8 p) => (TerraFX.Interop.DirectX.ID3D12Device*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12Device8 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Device8 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Device8 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Device9
{
    private readonly TerraFX.Interop.DirectX.ID3D12Device9* p;

    public TerraFX.Interop.DirectX.ID3D12Device9* Get() => this.p;

    public static implicit operator PID3D12Device9(TerraFX.Interop.DirectX.ID3D12Device9* p) => *(PID3D12Device9*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device9*(PID3D12Device9 p) => (TerraFX.Interop.DirectX.ID3D12Device9*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device8*(PID3D12Device9 p) => (TerraFX.Interop.DirectX.ID3D12Device8*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device7*(PID3D12Device9 p) => (TerraFX.Interop.DirectX.ID3D12Device7*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device6*(PID3D12Device9 p) => (TerraFX.Interop.DirectX.ID3D12Device6*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device5*(PID3D12Device9 p) => (TerraFX.Interop.DirectX.ID3D12Device5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device4*(PID3D12Device9 p) => (TerraFX.Interop.DirectX.ID3D12Device4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device3*(PID3D12Device9 p) => (TerraFX.Interop.DirectX.ID3D12Device3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device2*(PID3D12Device9 p) => (TerraFX.Interop.DirectX.ID3D12Device2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device1*(PID3D12Device9 p) => (TerraFX.Interop.DirectX.ID3D12Device1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Device*(PID3D12Device9 p) => (TerraFX.Interop.DirectX.ID3D12Device*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12Device9 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Device9 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Device9 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12DeviceChild
{
    private readonly TerraFX.Interop.DirectX.ID3D12DeviceChild* p;

    public TerraFX.Interop.DirectX.ID3D12DeviceChild* Get() => this.p;

    public static implicit operator PID3D12DeviceChild(TerraFX.Interop.DirectX.ID3D12DeviceChild* p) => *(PID3D12DeviceChild*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12DeviceChild p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12DeviceChild p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12DeviceChild p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12DeviceChild p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12DeviceConfiguration
{
    private readonly TerraFX.Interop.DirectX.ID3D12DeviceConfiguration* p;

    public TerraFX.Interop.DirectX.ID3D12DeviceConfiguration* Get() => this.p;

    public static implicit operator PID3D12DeviceConfiguration(TerraFX.Interop.DirectX.ID3D12DeviceConfiguration* p) => *(PID3D12DeviceConfiguration*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceConfiguration*(PID3D12DeviceConfiguration p) => (TerraFX.Interop.DirectX.ID3D12DeviceConfiguration*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12DeviceConfiguration p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12DeviceConfiguration p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12DeviceDownlevel
{
    private readonly TerraFX.Interop.DirectX.ID3D12DeviceDownlevel* p;

    public TerraFX.Interop.DirectX.ID3D12DeviceDownlevel* Get() => this.p;

    public static implicit operator PID3D12DeviceDownlevel(TerraFX.Interop.DirectX.ID3D12DeviceDownlevel* p) => *(PID3D12DeviceDownlevel*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceDownlevel*(PID3D12DeviceDownlevel p) => (TerraFX.Interop.DirectX.ID3D12DeviceDownlevel*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12DeviceDownlevel p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12DeviceDownlevel p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12DeviceFactory
{
    private readonly TerraFX.Interop.DirectX.ID3D12DeviceFactory* p;

    public TerraFX.Interop.DirectX.ID3D12DeviceFactory* Get() => this.p;

    public static implicit operator PID3D12DeviceFactory(TerraFX.Interop.DirectX.ID3D12DeviceFactory* p) => *(PID3D12DeviceFactory*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceFactory*(PID3D12DeviceFactory p) => (TerraFX.Interop.DirectX.ID3D12DeviceFactory*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12DeviceFactory p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12DeviceFactory p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12DeviceRemovedExtendedData
{
    private readonly TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedData* p;

    public TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedData* Get() => this.p;

    public static implicit operator PID3D12DeviceRemovedExtendedData(TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedData* p) => *(PID3D12DeviceRemovedExtendedData*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedData*(PID3D12DeviceRemovedExtendedData p) => (TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedData*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12DeviceRemovedExtendedData p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12DeviceRemovedExtendedData p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12DeviceRemovedExtendedData1
{
    private readonly TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedData1* p;

    public TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedData1* Get() => this.p;

    public static implicit operator PID3D12DeviceRemovedExtendedData1(TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedData1* p) => *(PID3D12DeviceRemovedExtendedData1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedData1*(PID3D12DeviceRemovedExtendedData1 p) => (TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedData1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedData*(PID3D12DeviceRemovedExtendedData1 p) => (TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedData*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12DeviceRemovedExtendedData1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12DeviceRemovedExtendedData1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12DeviceRemovedExtendedData2
{
    private readonly TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedData2* p;

    public TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedData2* Get() => this.p;

    public static implicit operator PID3D12DeviceRemovedExtendedData2(TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedData2* p) => *(PID3D12DeviceRemovedExtendedData2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedData2*(PID3D12DeviceRemovedExtendedData2 p) => (TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedData2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedData1*(PID3D12DeviceRemovedExtendedData2 p) => (TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedData1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedData*(PID3D12DeviceRemovedExtendedData2 p) => (TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedData*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12DeviceRemovedExtendedData2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12DeviceRemovedExtendedData2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12DeviceRemovedExtendedDataSettings
{
    private readonly TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedDataSettings* p;

    public TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedDataSettings* Get() => this.p;

    public static implicit operator PID3D12DeviceRemovedExtendedDataSettings(TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedDataSettings* p) => *(PID3D12DeviceRemovedExtendedDataSettings*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedDataSettings*(PID3D12DeviceRemovedExtendedDataSettings p) => (TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedDataSettings*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12DeviceRemovedExtendedDataSettings p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12DeviceRemovedExtendedDataSettings p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12DeviceRemovedExtendedDataSettings1
{
    private readonly TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedDataSettings1* p;

    public TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedDataSettings1* Get() => this.p;

    public static implicit operator PID3D12DeviceRemovedExtendedDataSettings1(TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedDataSettings1* p) => *(PID3D12DeviceRemovedExtendedDataSettings1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedDataSettings1*(PID3D12DeviceRemovedExtendedDataSettings1 p) => (TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedDataSettings1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedDataSettings*(PID3D12DeviceRemovedExtendedDataSettings1 p) => (TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedDataSettings*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12DeviceRemovedExtendedDataSettings1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12DeviceRemovedExtendedDataSettings1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12DeviceRemovedExtendedDataSettings2
{
    private readonly TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedDataSettings2* p;

    public TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedDataSettings2* Get() => this.p;

    public static implicit operator PID3D12DeviceRemovedExtendedDataSettings2(TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedDataSettings2* p) => *(PID3D12DeviceRemovedExtendedDataSettings2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedDataSettings2*(PID3D12DeviceRemovedExtendedDataSettings2 p) => (TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedDataSettings2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedDataSettings1*(PID3D12DeviceRemovedExtendedDataSettings2 p) => (TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedDataSettings1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedDataSettings*(PID3D12DeviceRemovedExtendedDataSettings2 p) => (TerraFX.Interop.DirectX.ID3D12DeviceRemovedExtendedDataSettings*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12DeviceRemovedExtendedDataSettings2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12DeviceRemovedExtendedDataSettings2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Fence
{
    private readonly TerraFX.Interop.DirectX.ID3D12Fence* p;

    public TerraFX.Interop.DirectX.ID3D12Fence* Get() => this.p;

    public static implicit operator PID3D12Fence(TerraFX.Interop.DirectX.ID3D12Fence* p) => *(PID3D12Fence*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Fence*(PID3D12Fence p) => (TerraFX.Interop.DirectX.ID3D12Fence*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Pageable*(PID3D12Fence p) => (TerraFX.Interop.DirectX.ID3D12Pageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12Fence p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12Fence p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Fence p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Fence p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Fence1
{
    private readonly TerraFX.Interop.DirectX.ID3D12Fence1* p;

    public TerraFX.Interop.DirectX.ID3D12Fence1* Get() => this.p;

    public static implicit operator PID3D12Fence1(TerraFX.Interop.DirectX.ID3D12Fence1* p) => *(PID3D12Fence1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Fence1*(PID3D12Fence1 p) => (TerraFX.Interop.DirectX.ID3D12Fence1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Fence*(PID3D12Fence1 p) => (TerraFX.Interop.DirectX.ID3D12Fence*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Pageable*(PID3D12Fence1 p) => (TerraFX.Interop.DirectX.ID3D12Pageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12Fence1 p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12Fence1 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Fence1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Fence1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12GraphicsCommandList
{
    private readonly TerraFX.Interop.DirectX.ID3D12GraphicsCommandList* p;

    public TerraFX.Interop.DirectX.ID3D12GraphicsCommandList* Get() => this.p;

    public static implicit operator PID3D12GraphicsCommandList(TerraFX.Interop.DirectX.ID3D12GraphicsCommandList* p) => *(PID3D12GraphicsCommandList*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList*(PID3D12GraphicsCommandList p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12CommandList*(PID3D12GraphicsCommandList p) => (TerraFX.Interop.DirectX.ID3D12CommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12GraphicsCommandList p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12GraphicsCommandList p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12GraphicsCommandList p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12GraphicsCommandList p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12GraphicsCommandList1
{
    private readonly TerraFX.Interop.DirectX.ID3D12GraphicsCommandList1* p;

    public TerraFX.Interop.DirectX.ID3D12GraphicsCommandList1* Get() => this.p;

    public static implicit operator PID3D12GraphicsCommandList1(TerraFX.Interop.DirectX.ID3D12GraphicsCommandList1* p) => *(PID3D12GraphicsCommandList1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList1*(PID3D12GraphicsCommandList1 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList*(PID3D12GraphicsCommandList1 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12CommandList*(PID3D12GraphicsCommandList1 p) => (TerraFX.Interop.DirectX.ID3D12CommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12GraphicsCommandList1 p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12GraphicsCommandList1 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12GraphicsCommandList1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12GraphicsCommandList1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12GraphicsCommandList2
{
    private readonly TerraFX.Interop.DirectX.ID3D12GraphicsCommandList2* p;

    public TerraFX.Interop.DirectX.ID3D12GraphicsCommandList2* Get() => this.p;

    public static implicit operator PID3D12GraphicsCommandList2(TerraFX.Interop.DirectX.ID3D12GraphicsCommandList2* p) => *(PID3D12GraphicsCommandList2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList2*(PID3D12GraphicsCommandList2 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList1*(PID3D12GraphicsCommandList2 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList*(PID3D12GraphicsCommandList2 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12CommandList*(PID3D12GraphicsCommandList2 p) => (TerraFX.Interop.DirectX.ID3D12CommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12GraphicsCommandList2 p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12GraphicsCommandList2 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12GraphicsCommandList2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12GraphicsCommandList2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12GraphicsCommandList3
{
    private readonly TerraFX.Interop.DirectX.ID3D12GraphicsCommandList3* p;

    public TerraFX.Interop.DirectX.ID3D12GraphicsCommandList3* Get() => this.p;

    public static implicit operator PID3D12GraphicsCommandList3(TerraFX.Interop.DirectX.ID3D12GraphicsCommandList3* p) => *(PID3D12GraphicsCommandList3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList3*(PID3D12GraphicsCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList2*(PID3D12GraphicsCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList1*(PID3D12GraphicsCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList*(PID3D12GraphicsCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12CommandList*(PID3D12GraphicsCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12CommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12GraphicsCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12GraphicsCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12GraphicsCommandList3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12GraphicsCommandList3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12GraphicsCommandList4
{
    private readonly TerraFX.Interop.DirectX.ID3D12GraphicsCommandList4* p;

    public TerraFX.Interop.DirectX.ID3D12GraphicsCommandList4* Get() => this.p;

    public static implicit operator PID3D12GraphicsCommandList4(TerraFX.Interop.DirectX.ID3D12GraphicsCommandList4* p) => *(PID3D12GraphicsCommandList4*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList4*(PID3D12GraphicsCommandList4 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList3*(PID3D12GraphicsCommandList4 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList2*(PID3D12GraphicsCommandList4 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList1*(PID3D12GraphicsCommandList4 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList*(PID3D12GraphicsCommandList4 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12CommandList*(PID3D12GraphicsCommandList4 p) => (TerraFX.Interop.DirectX.ID3D12CommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12GraphicsCommandList4 p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12GraphicsCommandList4 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12GraphicsCommandList4 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12GraphicsCommandList4 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12GraphicsCommandList5
{
    private readonly TerraFX.Interop.DirectX.ID3D12GraphicsCommandList5* p;

    public TerraFX.Interop.DirectX.ID3D12GraphicsCommandList5* Get() => this.p;

    public static implicit operator PID3D12GraphicsCommandList5(TerraFX.Interop.DirectX.ID3D12GraphicsCommandList5* p) => *(PID3D12GraphicsCommandList5*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList5*(PID3D12GraphicsCommandList5 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList4*(PID3D12GraphicsCommandList5 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList3*(PID3D12GraphicsCommandList5 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList2*(PID3D12GraphicsCommandList5 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList1*(PID3D12GraphicsCommandList5 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList*(PID3D12GraphicsCommandList5 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12CommandList*(PID3D12GraphicsCommandList5 p) => (TerraFX.Interop.DirectX.ID3D12CommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12GraphicsCommandList5 p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12GraphicsCommandList5 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12GraphicsCommandList5 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12GraphicsCommandList5 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12GraphicsCommandList6
{
    private readonly TerraFX.Interop.DirectX.ID3D12GraphicsCommandList6* p;

    public TerraFX.Interop.DirectX.ID3D12GraphicsCommandList6* Get() => this.p;

    public static implicit operator PID3D12GraphicsCommandList6(TerraFX.Interop.DirectX.ID3D12GraphicsCommandList6* p) => *(PID3D12GraphicsCommandList6*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList6*(PID3D12GraphicsCommandList6 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList6*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList5*(PID3D12GraphicsCommandList6 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList4*(PID3D12GraphicsCommandList6 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList3*(PID3D12GraphicsCommandList6 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList2*(PID3D12GraphicsCommandList6 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList1*(PID3D12GraphicsCommandList6 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList*(PID3D12GraphicsCommandList6 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12CommandList*(PID3D12GraphicsCommandList6 p) => (TerraFX.Interop.DirectX.ID3D12CommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12GraphicsCommandList6 p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12GraphicsCommandList6 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12GraphicsCommandList6 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12GraphicsCommandList6 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12GraphicsCommandList7
{
    private readonly TerraFX.Interop.DirectX.ID3D12GraphicsCommandList7* p;

    public TerraFX.Interop.DirectX.ID3D12GraphicsCommandList7* Get() => this.p;

    public static implicit operator PID3D12GraphicsCommandList7(TerraFX.Interop.DirectX.ID3D12GraphicsCommandList7* p) => *(PID3D12GraphicsCommandList7*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList7*(PID3D12GraphicsCommandList7 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList7*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList6*(PID3D12GraphicsCommandList7 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList6*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList5*(PID3D12GraphicsCommandList7 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList4*(PID3D12GraphicsCommandList7 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList3*(PID3D12GraphicsCommandList7 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList2*(PID3D12GraphicsCommandList7 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList1*(PID3D12GraphicsCommandList7 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList*(PID3D12GraphicsCommandList7 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12CommandList*(PID3D12GraphicsCommandList7 p) => (TerraFX.Interop.DirectX.ID3D12CommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12GraphicsCommandList7 p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12GraphicsCommandList7 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12GraphicsCommandList7 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12GraphicsCommandList7 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12GraphicsCommandList8
{
    private readonly TerraFX.Interop.DirectX.ID3D12GraphicsCommandList8* p;

    public TerraFX.Interop.DirectX.ID3D12GraphicsCommandList8* Get() => this.p;

    public static implicit operator PID3D12GraphicsCommandList8(TerraFX.Interop.DirectX.ID3D12GraphicsCommandList8* p) => *(PID3D12GraphicsCommandList8*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList8*(PID3D12GraphicsCommandList8 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList8*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList7*(PID3D12GraphicsCommandList8 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList7*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList6*(PID3D12GraphicsCommandList8 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList6*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList5*(PID3D12GraphicsCommandList8 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList4*(PID3D12GraphicsCommandList8 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList3*(PID3D12GraphicsCommandList8 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList2*(PID3D12GraphicsCommandList8 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList1*(PID3D12GraphicsCommandList8 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList*(PID3D12GraphicsCommandList8 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12CommandList*(PID3D12GraphicsCommandList8 p) => (TerraFX.Interop.DirectX.ID3D12CommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12GraphicsCommandList8 p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12GraphicsCommandList8 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12GraphicsCommandList8 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12GraphicsCommandList8 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12GraphicsCommandList9
{
    private readonly TerraFX.Interop.DirectX.ID3D12GraphicsCommandList9* p;

    public TerraFX.Interop.DirectX.ID3D12GraphicsCommandList9* Get() => this.p;

    public static implicit operator PID3D12GraphicsCommandList9(TerraFX.Interop.DirectX.ID3D12GraphicsCommandList9* p) => *(PID3D12GraphicsCommandList9*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList9*(PID3D12GraphicsCommandList9 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList9*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList8*(PID3D12GraphicsCommandList9 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList8*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList7*(PID3D12GraphicsCommandList9 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList7*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList6*(PID3D12GraphicsCommandList9 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList6*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList5*(PID3D12GraphicsCommandList9 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList4*(PID3D12GraphicsCommandList9 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList3*(PID3D12GraphicsCommandList9 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList2*(PID3D12GraphicsCommandList9 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList1*(PID3D12GraphicsCommandList9 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12GraphicsCommandList*(PID3D12GraphicsCommandList9 p) => (TerraFX.Interop.DirectX.ID3D12GraphicsCommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12CommandList*(PID3D12GraphicsCommandList9 p) => (TerraFX.Interop.DirectX.ID3D12CommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12GraphicsCommandList9 p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12GraphicsCommandList9 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12GraphicsCommandList9 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12GraphicsCommandList9 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Heap
{
    private readonly TerraFX.Interop.DirectX.ID3D12Heap* p;

    public TerraFX.Interop.DirectX.ID3D12Heap* Get() => this.p;

    public static implicit operator PID3D12Heap(TerraFX.Interop.DirectX.ID3D12Heap* p) => *(PID3D12Heap*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Heap*(PID3D12Heap p) => (TerraFX.Interop.DirectX.ID3D12Heap*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Pageable*(PID3D12Heap p) => (TerraFX.Interop.DirectX.ID3D12Pageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12Heap p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12Heap p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Heap p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Heap p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Heap1
{
    private readonly TerraFX.Interop.DirectX.ID3D12Heap1* p;

    public TerraFX.Interop.DirectX.ID3D12Heap1* Get() => this.p;

    public static implicit operator PID3D12Heap1(TerraFX.Interop.DirectX.ID3D12Heap1* p) => *(PID3D12Heap1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Heap1*(PID3D12Heap1 p) => (TerraFX.Interop.DirectX.ID3D12Heap1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Heap*(PID3D12Heap1 p) => (TerraFX.Interop.DirectX.ID3D12Heap*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Pageable*(PID3D12Heap1 p) => (TerraFX.Interop.DirectX.ID3D12Pageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12Heap1 p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12Heap1 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Heap1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Heap1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12InfoQueue
{
    private readonly TerraFX.Interop.DirectX.ID3D12InfoQueue* p;

    public TerraFX.Interop.DirectX.ID3D12InfoQueue* Get() => this.p;

    public static implicit operator PID3D12InfoQueue(TerraFX.Interop.DirectX.ID3D12InfoQueue* p) => *(PID3D12InfoQueue*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12InfoQueue*(PID3D12InfoQueue p) => (TerraFX.Interop.DirectX.ID3D12InfoQueue*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12InfoQueue p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12InfoQueue p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12InfoQueue1
{
    private readonly TerraFX.Interop.DirectX.ID3D12InfoQueue1* p;

    public TerraFX.Interop.DirectX.ID3D12InfoQueue1* Get() => this.p;

    public static implicit operator PID3D12InfoQueue1(TerraFX.Interop.DirectX.ID3D12InfoQueue1* p) => *(PID3D12InfoQueue1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12InfoQueue1*(PID3D12InfoQueue1 p) => (TerraFX.Interop.DirectX.ID3D12InfoQueue1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12InfoQueue*(PID3D12InfoQueue1 p) => (TerraFX.Interop.DirectX.ID3D12InfoQueue*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12InfoQueue1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12InfoQueue1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12LibraryReflection
{
    private readonly TerraFX.Interop.DirectX.ID3D12LibraryReflection* p;

    public TerraFX.Interop.DirectX.ID3D12LibraryReflection* Get() => this.p;

    public static implicit operator PID3D12LibraryReflection(TerraFX.Interop.DirectX.ID3D12LibraryReflection* p) => *(PID3D12LibraryReflection*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12LibraryReflection*(PID3D12LibraryReflection p) => (TerraFX.Interop.DirectX.ID3D12LibraryReflection*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12LibraryReflection p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12LibraryReflection p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12LifetimeOwner
{
    private readonly TerraFX.Interop.DirectX.ID3D12LifetimeOwner* p;

    public TerraFX.Interop.DirectX.ID3D12LifetimeOwner* Get() => this.p;

    public static implicit operator PID3D12LifetimeOwner(TerraFX.Interop.DirectX.ID3D12LifetimeOwner* p) => *(PID3D12LifetimeOwner*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12LifetimeOwner*(PID3D12LifetimeOwner p) => (TerraFX.Interop.DirectX.ID3D12LifetimeOwner*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12LifetimeOwner p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12LifetimeOwner p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12LifetimeTracker
{
    private readonly TerraFX.Interop.DirectX.ID3D12LifetimeTracker* p;

    public TerraFX.Interop.DirectX.ID3D12LifetimeTracker* Get() => this.p;

    public static implicit operator PID3D12LifetimeTracker(TerraFX.Interop.DirectX.ID3D12LifetimeTracker* p) => *(PID3D12LifetimeTracker*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12LifetimeTracker*(PID3D12LifetimeTracker p) => (TerraFX.Interop.DirectX.ID3D12LifetimeTracker*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12LifetimeTracker p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12LifetimeTracker p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12LifetimeTracker p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12LifetimeTracker p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12ManualWriteTrackingResource
{
    private readonly TerraFX.Interop.DirectX.ID3D12ManualWriteTrackingResource* p;

    public TerraFX.Interop.DirectX.ID3D12ManualWriteTrackingResource* Get() => this.p;

    public static implicit operator PID3D12ManualWriteTrackingResource(TerraFX.Interop.DirectX.ID3D12ManualWriteTrackingResource* p) => *(PID3D12ManualWriteTrackingResource*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12ManualWriteTrackingResource*(PID3D12ManualWriteTrackingResource p) => (TerraFX.Interop.DirectX.ID3D12ManualWriteTrackingResource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12ManualWriteTrackingResource p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12ManualWriteTrackingResource p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12MetaCommand
{
    private readonly TerraFX.Interop.DirectX.ID3D12MetaCommand* p;

    public TerraFX.Interop.DirectX.ID3D12MetaCommand* Get() => this.p;

    public static implicit operator PID3D12MetaCommand(TerraFX.Interop.DirectX.ID3D12MetaCommand* p) => *(PID3D12MetaCommand*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12MetaCommand*(PID3D12MetaCommand p) => (TerraFX.Interop.DirectX.ID3D12MetaCommand*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Pageable*(PID3D12MetaCommand p) => (TerraFX.Interop.DirectX.ID3D12Pageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12MetaCommand p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12MetaCommand p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12MetaCommand p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12MetaCommand p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Object
{
    private readonly TerraFX.Interop.DirectX.ID3D12Object* p;

    public TerraFX.Interop.DirectX.ID3D12Object* Get() => this.p;

    public static implicit operator PID3D12Object(TerraFX.Interop.DirectX.ID3D12Object* p) => *(PID3D12Object*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12Object p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Object p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Object p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Pageable
{
    private readonly TerraFX.Interop.DirectX.ID3D12Pageable* p;

    public TerraFX.Interop.DirectX.ID3D12Pageable* Get() => this.p;

    public static implicit operator PID3D12Pageable(TerraFX.Interop.DirectX.ID3D12Pageable* p) => *(PID3D12Pageable*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Pageable*(PID3D12Pageable p) => (TerraFX.Interop.DirectX.ID3D12Pageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12Pageable p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12Pageable p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Pageable p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Pageable p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12PipelineLibrary
{
    private readonly TerraFX.Interop.DirectX.ID3D12PipelineLibrary* p;

    public TerraFX.Interop.DirectX.ID3D12PipelineLibrary* Get() => this.p;

    public static implicit operator PID3D12PipelineLibrary(TerraFX.Interop.DirectX.ID3D12PipelineLibrary* p) => *(PID3D12PipelineLibrary*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12PipelineLibrary*(PID3D12PipelineLibrary p) => (TerraFX.Interop.DirectX.ID3D12PipelineLibrary*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12PipelineLibrary p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12PipelineLibrary p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12PipelineLibrary p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12PipelineLibrary p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12PipelineLibrary1
{
    private readonly TerraFX.Interop.DirectX.ID3D12PipelineLibrary1* p;

    public TerraFX.Interop.DirectX.ID3D12PipelineLibrary1* Get() => this.p;

    public static implicit operator PID3D12PipelineLibrary1(TerraFX.Interop.DirectX.ID3D12PipelineLibrary1* p) => *(PID3D12PipelineLibrary1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12PipelineLibrary1*(PID3D12PipelineLibrary1 p) => (TerraFX.Interop.DirectX.ID3D12PipelineLibrary1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12PipelineLibrary*(PID3D12PipelineLibrary1 p) => (TerraFX.Interop.DirectX.ID3D12PipelineLibrary*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12PipelineLibrary1 p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12PipelineLibrary1 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12PipelineLibrary1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12PipelineLibrary1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12PipelineState
{
    private readonly TerraFX.Interop.DirectX.ID3D12PipelineState* p;

    public TerraFX.Interop.DirectX.ID3D12PipelineState* Get() => this.p;

    public static implicit operator PID3D12PipelineState(TerraFX.Interop.DirectX.ID3D12PipelineState* p) => *(PID3D12PipelineState*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12PipelineState*(PID3D12PipelineState p) => (TerraFX.Interop.DirectX.ID3D12PipelineState*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Pageable*(PID3D12PipelineState p) => (TerraFX.Interop.DirectX.ID3D12Pageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12PipelineState p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12PipelineState p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12PipelineState p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12PipelineState p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12ProtectedResourceSession
{
    private readonly TerraFX.Interop.DirectX.ID3D12ProtectedResourceSession* p;

    public TerraFX.Interop.DirectX.ID3D12ProtectedResourceSession* Get() => this.p;

    public static implicit operator PID3D12ProtectedResourceSession(TerraFX.Interop.DirectX.ID3D12ProtectedResourceSession* p) => *(PID3D12ProtectedResourceSession*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12ProtectedResourceSession*(PID3D12ProtectedResourceSession p) => (TerraFX.Interop.DirectX.ID3D12ProtectedResourceSession*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12ProtectedSession*(PID3D12ProtectedResourceSession p) => (TerraFX.Interop.DirectX.ID3D12ProtectedSession*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12ProtectedResourceSession p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12ProtectedResourceSession p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12ProtectedResourceSession p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12ProtectedResourceSession p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12ProtectedResourceSession1
{
    private readonly TerraFX.Interop.DirectX.ID3D12ProtectedResourceSession1* p;

    public TerraFX.Interop.DirectX.ID3D12ProtectedResourceSession1* Get() => this.p;

    public static implicit operator PID3D12ProtectedResourceSession1(TerraFX.Interop.DirectX.ID3D12ProtectedResourceSession1* p) => *(PID3D12ProtectedResourceSession1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12ProtectedResourceSession1*(PID3D12ProtectedResourceSession1 p) => (TerraFX.Interop.DirectX.ID3D12ProtectedResourceSession1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12ProtectedResourceSession*(PID3D12ProtectedResourceSession1 p) => (TerraFX.Interop.DirectX.ID3D12ProtectedResourceSession*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12ProtectedSession*(PID3D12ProtectedResourceSession1 p) => (TerraFX.Interop.DirectX.ID3D12ProtectedSession*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12ProtectedResourceSession1 p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12ProtectedResourceSession1 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12ProtectedResourceSession1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12ProtectedResourceSession1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12ProtectedSession
{
    private readonly TerraFX.Interop.DirectX.ID3D12ProtectedSession* p;

    public TerraFX.Interop.DirectX.ID3D12ProtectedSession* Get() => this.p;

    public static implicit operator PID3D12ProtectedSession(TerraFX.Interop.DirectX.ID3D12ProtectedSession* p) => *(PID3D12ProtectedSession*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12ProtectedSession*(PID3D12ProtectedSession p) => (TerraFX.Interop.DirectX.ID3D12ProtectedSession*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12ProtectedSession p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12ProtectedSession p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12ProtectedSession p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12ProtectedSession p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12QueryHeap
{
    private readonly TerraFX.Interop.DirectX.ID3D12QueryHeap* p;

    public TerraFX.Interop.DirectX.ID3D12QueryHeap* Get() => this.p;

    public static implicit operator PID3D12QueryHeap(TerraFX.Interop.DirectX.ID3D12QueryHeap* p) => *(PID3D12QueryHeap*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12QueryHeap*(PID3D12QueryHeap p) => (TerraFX.Interop.DirectX.ID3D12QueryHeap*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Pageable*(PID3D12QueryHeap p) => (TerraFX.Interop.DirectX.ID3D12Pageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12QueryHeap p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12QueryHeap p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12QueryHeap p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12QueryHeap p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Resource
{
    private readonly TerraFX.Interop.DirectX.ID3D12Resource* p;

    public TerraFX.Interop.DirectX.ID3D12Resource* Get() => this.p;

    public static implicit operator PID3D12Resource(TerraFX.Interop.DirectX.ID3D12Resource* p) => *(PID3D12Resource*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Resource*(PID3D12Resource p) => (TerraFX.Interop.DirectX.ID3D12Resource*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Pageable*(PID3D12Resource p) => (TerraFX.Interop.DirectX.ID3D12Pageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12Resource p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12Resource p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Resource p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Resource p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Resource1
{
    private readonly TerraFX.Interop.DirectX.ID3D12Resource1* p;

    public TerraFX.Interop.DirectX.ID3D12Resource1* Get() => this.p;

    public static implicit operator PID3D12Resource1(TerraFX.Interop.DirectX.ID3D12Resource1* p) => *(PID3D12Resource1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Resource1*(PID3D12Resource1 p) => (TerraFX.Interop.DirectX.ID3D12Resource1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Resource*(PID3D12Resource1 p) => (TerraFX.Interop.DirectX.ID3D12Resource*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Pageable*(PID3D12Resource1 p) => (TerraFX.Interop.DirectX.ID3D12Pageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12Resource1 p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12Resource1 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Resource1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Resource1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Resource2
{
    private readonly TerraFX.Interop.DirectX.ID3D12Resource2* p;

    public TerraFX.Interop.DirectX.ID3D12Resource2* Get() => this.p;

    public static implicit operator PID3D12Resource2(TerraFX.Interop.DirectX.ID3D12Resource2* p) => *(PID3D12Resource2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Resource2*(PID3D12Resource2 p) => (TerraFX.Interop.DirectX.ID3D12Resource2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Resource1*(PID3D12Resource2 p) => (TerraFX.Interop.DirectX.ID3D12Resource1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Resource*(PID3D12Resource2 p) => (TerraFX.Interop.DirectX.ID3D12Resource*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Pageable*(PID3D12Resource2 p) => (TerraFX.Interop.DirectX.ID3D12Pageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12Resource2 p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12Resource2 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Resource2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Resource2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12RootSignature
{
    private readonly TerraFX.Interop.DirectX.ID3D12RootSignature* p;

    public TerraFX.Interop.DirectX.ID3D12RootSignature* Get() => this.p;

    public static implicit operator PID3D12RootSignature(TerraFX.Interop.DirectX.ID3D12RootSignature* p) => *(PID3D12RootSignature*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12RootSignature*(PID3D12RootSignature p) => (TerraFX.Interop.DirectX.ID3D12RootSignature*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12RootSignature p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12RootSignature p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12RootSignature p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12RootSignature p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12RootSignatureDeserializer
{
    private readonly TerraFX.Interop.DirectX.ID3D12RootSignatureDeserializer* p;

    public TerraFX.Interop.DirectX.ID3D12RootSignatureDeserializer* Get() => this.p;

    public static implicit operator PID3D12RootSignatureDeserializer(TerraFX.Interop.DirectX.ID3D12RootSignatureDeserializer* p) => *(PID3D12RootSignatureDeserializer*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12RootSignatureDeserializer*(PID3D12RootSignatureDeserializer p) => (TerraFX.Interop.DirectX.ID3D12RootSignatureDeserializer*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12RootSignatureDeserializer p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12RootSignatureDeserializer p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12SDKConfiguration
{
    private readonly TerraFX.Interop.DirectX.ID3D12SDKConfiguration* p;

    public TerraFX.Interop.DirectX.ID3D12SDKConfiguration* Get() => this.p;

    public static implicit operator PID3D12SDKConfiguration(TerraFX.Interop.DirectX.ID3D12SDKConfiguration* p) => *(PID3D12SDKConfiguration*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12SDKConfiguration*(PID3D12SDKConfiguration p) => (TerraFX.Interop.DirectX.ID3D12SDKConfiguration*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12SDKConfiguration p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12SDKConfiguration p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12SDKConfiguration1
{
    private readonly TerraFX.Interop.DirectX.ID3D12SDKConfiguration1* p;

    public TerraFX.Interop.DirectX.ID3D12SDKConfiguration1* Get() => this.p;

    public static implicit operator PID3D12SDKConfiguration1(TerraFX.Interop.DirectX.ID3D12SDKConfiguration1* p) => *(PID3D12SDKConfiguration1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12SDKConfiguration1*(PID3D12SDKConfiguration1 p) => (TerraFX.Interop.DirectX.ID3D12SDKConfiguration1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12SDKConfiguration*(PID3D12SDKConfiguration1 p) => (TerraFX.Interop.DirectX.ID3D12SDKConfiguration*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12SDKConfiguration1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12SDKConfiguration1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12ShaderCacheSession
{
    private readonly TerraFX.Interop.DirectX.ID3D12ShaderCacheSession* p;

    public TerraFX.Interop.DirectX.ID3D12ShaderCacheSession* Get() => this.p;

    public static implicit operator PID3D12ShaderCacheSession(TerraFX.Interop.DirectX.ID3D12ShaderCacheSession* p) => *(PID3D12ShaderCacheSession*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12ShaderCacheSession*(PID3D12ShaderCacheSession p) => (TerraFX.Interop.DirectX.ID3D12ShaderCacheSession*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12ShaderCacheSession p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12ShaderCacheSession p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12ShaderCacheSession p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12ShaderCacheSession p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12ShaderReflection
{
    private readonly TerraFX.Interop.DirectX.ID3D12ShaderReflection* p;

    public TerraFX.Interop.DirectX.ID3D12ShaderReflection* Get() => this.p;

    public static implicit operator PID3D12ShaderReflection(TerraFX.Interop.DirectX.ID3D12ShaderReflection* p) => *(PID3D12ShaderReflection*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12ShaderReflection*(PID3D12ShaderReflection p) => (TerraFX.Interop.DirectX.ID3D12ShaderReflection*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12ShaderReflection p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12ShaderReflection p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12SharingContract
{
    private readonly TerraFX.Interop.DirectX.ID3D12SharingContract* p;

    public TerraFX.Interop.DirectX.ID3D12SharingContract* Get() => this.p;

    public static implicit operator PID3D12SharingContract(TerraFX.Interop.DirectX.ID3D12SharingContract* p) => *(PID3D12SharingContract*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12SharingContract*(PID3D12SharingContract p) => (TerraFX.Interop.DirectX.ID3D12SharingContract*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12SharingContract p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12SharingContract p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12StateObject
{
    private readonly TerraFX.Interop.DirectX.ID3D12StateObject* p;

    public TerraFX.Interop.DirectX.ID3D12StateObject* Get() => this.p;

    public static implicit operator PID3D12StateObject(TerraFX.Interop.DirectX.ID3D12StateObject* p) => *(PID3D12StateObject*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12StateObject*(PID3D12StateObject p) => (TerraFX.Interop.DirectX.ID3D12StateObject*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Pageable*(PID3D12StateObject p) => (TerraFX.Interop.DirectX.ID3D12Pageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12StateObject p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12StateObject p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12StateObject p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12StateObject p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12StateObjectProperties
{
    private readonly TerraFX.Interop.DirectX.ID3D12StateObjectProperties* p;

    public TerraFX.Interop.DirectX.ID3D12StateObjectProperties* Get() => this.p;

    public static implicit operator PID3D12StateObjectProperties(TerraFX.Interop.DirectX.ID3D12StateObjectProperties* p) => *(PID3D12StateObjectProperties*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12StateObjectProperties*(PID3D12StateObjectProperties p) => (TerraFX.Interop.DirectX.ID3D12StateObjectProperties*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12StateObjectProperties p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12StateObjectProperties p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12SwapChainAssistant
{
    private readonly TerraFX.Interop.DirectX.ID3D12SwapChainAssistant* p;

    public TerraFX.Interop.DirectX.ID3D12SwapChainAssistant* Get() => this.p;

    public static implicit operator PID3D12SwapChainAssistant(TerraFX.Interop.DirectX.ID3D12SwapChainAssistant* p) => *(PID3D12SwapChainAssistant*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12SwapChainAssistant*(PID3D12SwapChainAssistant p) => (TerraFX.Interop.DirectX.ID3D12SwapChainAssistant*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12SwapChainAssistant p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12SwapChainAssistant p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12Tools
{
    private readonly TerraFX.Interop.DirectX.ID3D12Tools* p;

    public TerraFX.Interop.DirectX.ID3D12Tools* Get() => this.p;

    public static implicit operator PID3D12Tools(TerraFX.Interop.DirectX.ID3D12Tools* p) => *(PID3D12Tools*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Tools*(PID3D12Tools p) => (TerraFX.Interop.DirectX.ID3D12Tools*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12Tools p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12Tools p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12VersionedRootSignatureDeserializer
{
    private readonly TerraFX.Interop.DirectX.ID3D12VersionedRootSignatureDeserializer* p;

    public TerraFX.Interop.DirectX.ID3D12VersionedRootSignatureDeserializer* Get() => this.p;

    public static implicit operator PID3D12VersionedRootSignatureDeserializer(TerraFX.Interop.DirectX.ID3D12VersionedRootSignatureDeserializer* p) => *(PID3D12VersionedRootSignatureDeserializer*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VersionedRootSignatureDeserializer*(PID3D12VersionedRootSignatureDeserializer p) => (TerraFX.Interop.DirectX.ID3D12VersionedRootSignatureDeserializer*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12VersionedRootSignatureDeserializer p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12VersionedRootSignatureDeserializer p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12VideoDecodeCommandList
{
    private readonly TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList* p;

    public TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList* Get() => this.p;

    public static implicit operator PID3D12VideoDecodeCommandList(TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList* p) => *(PID3D12VideoDecodeCommandList*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList*(PID3D12VideoDecodeCommandList p) => (TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12CommandList*(PID3D12VideoDecodeCommandList p) => (TerraFX.Interop.DirectX.ID3D12CommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12VideoDecodeCommandList p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12VideoDecodeCommandList p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12VideoDecodeCommandList p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12VideoDecodeCommandList p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12VideoDecodeCommandList1
{
    private readonly TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList1* p;

    public TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList1* Get() => this.p;

    public static implicit operator PID3D12VideoDecodeCommandList1(TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList1* p) => *(PID3D12VideoDecodeCommandList1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList1*(PID3D12VideoDecodeCommandList1 p) => (TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList*(PID3D12VideoDecodeCommandList1 p) => (TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12CommandList*(PID3D12VideoDecodeCommandList1 p) => (TerraFX.Interop.DirectX.ID3D12CommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12VideoDecodeCommandList1 p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12VideoDecodeCommandList1 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12VideoDecodeCommandList1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12VideoDecodeCommandList1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12VideoDecodeCommandList2
{
    private readonly TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList2* p;

    public TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList2* Get() => this.p;

    public static implicit operator PID3D12VideoDecodeCommandList2(TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList2* p) => *(PID3D12VideoDecodeCommandList2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList2*(PID3D12VideoDecodeCommandList2 p) => (TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList1*(PID3D12VideoDecodeCommandList2 p) => (TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList*(PID3D12VideoDecodeCommandList2 p) => (TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12CommandList*(PID3D12VideoDecodeCommandList2 p) => (TerraFX.Interop.DirectX.ID3D12CommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12VideoDecodeCommandList2 p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12VideoDecodeCommandList2 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12VideoDecodeCommandList2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12VideoDecodeCommandList2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12VideoDecodeCommandList3
{
    private readonly TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList3* p;

    public TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList3* Get() => this.p;

    public static implicit operator PID3D12VideoDecodeCommandList3(TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList3* p) => *(PID3D12VideoDecodeCommandList3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList3*(PID3D12VideoDecodeCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList2*(PID3D12VideoDecodeCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList1*(PID3D12VideoDecodeCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList*(PID3D12VideoDecodeCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12VideoDecodeCommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12CommandList*(PID3D12VideoDecodeCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12CommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12VideoDecodeCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12VideoDecodeCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12VideoDecodeCommandList3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12VideoDecodeCommandList3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12VideoDecoder
{
    private readonly TerraFX.Interop.DirectX.ID3D12VideoDecoder* p;

    public TerraFX.Interop.DirectX.ID3D12VideoDecoder* Get() => this.p;

    public static implicit operator PID3D12VideoDecoder(TerraFX.Interop.DirectX.ID3D12VideoDecoder* p) => *(PID3D12VideoDecoder*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoDecoder*(PID3D12VideoDecoder p) => (TerraFX.Interop.DirectX.ID3D12VideoDecoder*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Pageable*(PID3D12VideoDecoder p) => (TerraFX.Interop.DirectX.ID3D12Pageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12VideoDecoder p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12VideoDecoder p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12VideoDecoder p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12VideoDecoder p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12VideoDecoder1
{
    private readonly TerraFX.Interop.DirectX.ID3D12VideoDecoder1* p;

    public TerraFX.Interop.DirectX.ID3D12VideoDecoder1* Get() => this.p;

    public static implicit operator PID3D12VideoDecoder1(TerraFX.Interop.DirectX.ID3D12VideoDecoder1* p) => *(PID3D12VideoDecoder1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoDecoder1*(PID3D12VideoDecoder1 p) => (TerraFX.Interop.DirectX.ID3D12VideoDecoder1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoDecoder*(PID3D12VideoDecoder1 p) => (TerraFX.Interop.DirectX.ID3D12VideoDecoder*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Pageable*(PID3D12VideoDecoder1 p) => (TerraFX.Interop.DirectX.ID3D12Pageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12VideoDecoder1 p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12VideoDecoder1 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12VideoDecoder1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12VideoDecoder1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12VideoDecoderHeap
{
    private readonly TerraFX.Interop.DirectX.ID3D12VideoDecoderHeap* p;

    public TerraFX.Interop.DirectX.ID3D12VideoDecoderHeap* Get() => this.p;

    public static implicit operator PID3D12VideoDecoderHeap(TerraFX.Interop.DirectX.ID3D12VideoDecoderHeap* p) => *(PID3D12VideoDecoderHeap*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoDecoderHeap*(PID3D12VideoDecoderHeap p) => (TerraFX.Interop.DirectX.ID3D12VideoDecoderHeap*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Pageable*(PID3D12VideoDecoderHeap p) => (TerraFX.Interop.DirectX.ID3D12Pageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12VideoDecoderHeap p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12VideoDecoderHeap p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12VideoDecoderHeap p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12VideoDecoderHeap p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12VideoDecoderHeap1
{
    private readonly TerraFX.Interop.DirectX.ID3D12VideoDecoderHeap1* p;

    public TerraFX.Interop.DirectX.ID3D12VideoDecoderHeap1* Get() => this.p;

    public static implicit operator PID3D12VideoDecoderHeap1(TerraFX.Interop.DirectX.ID3D12VideoDecoderHeap1* p) => *(PID3D12VideoDecoderHeap1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoDecoderHeap1*(PID3D12VideoDecoderHeap1 p) => (TerraFX.Interop.DirectX.ID3D12VideoDecoderHeap1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoDecoderHeap*(PID3D12VideoDecoderHeap1 p) => (TerraFX.Interop.DirectX.ID3D12VideoDecoderHeap*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Pageable*(PID3D12VideoDecoderHeap1 p) => (TerraFX.Interop.DirectX.ID3D12Pageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12VideoDecoderHeap1 p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12VideoDecoderHeap1 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12VideoDecoderHeap1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12VideoDecoderHeap1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12VideoDevice
{
    private readonly TerraFX.Interop.DirectX.ID3D12VideoDevice* p;

    public TerraFX.Interop.DirectX.ID3D12VideoDevice* Get() => this.p;

    public static implicit operator PID3D12VideoDevice(TerraFX.Interop.DirectX.ID3D12VideoDevice* p) => *(PID3D12VideoDevice*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoDevice*(PID3D12VideoDevice p) => (TerraFX.Interop.DirectX.ID3D12VideoDevice*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12VideoDevice p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12VideoDevice p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12VideoDevice1
{
    private readonly TerraFX.Interop.DirectX.ID3D12VideoDevice1* p;

    public TerraFX.Interop.DirectX.ID3D12VideoDevice1* Get() => this.p;

    public static implicit operator PID3D12VideoDevice1(TerraFX.Interop.DirectX.ID3D12VideoDevice1* p) => *(PID3D12VideoDevice1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoDevice1*(PID3D12VideoDevice1 p) => (TerraFX.Interop.DirectX.ID3D12VideoDevice1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoDevice*(PID3D12VideoDevice1 p) => (TerraFX.Interop.DirectX.ID3D12VideoDevice*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12VideoDevice1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12VideoDevice1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12VideoDevice2
{
    private readonly TerraFX.Interop.DirectX.ID3D12VideoDevice2* p;

    public TerraFX.Interop.DirectX.ID3D12VideoDevice2* Get() => this.p;

    public static implicit operator PID3D12VideoDevice2(TerraFX.Interop.DirectX.ID3D12VideoDevice2* p) => *(PID3D12VideoDevice2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoDevice2*(PID3D12VideoDevice2 p) => (TerraFX.Interop.DirectX.ID3D12VideoDevice2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoDevice1*(PID3D12VideoDevice2 p) => (TerraFX.Interop.DirectX.ID3D12VideoDevice1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoDevice*(PID3D12VideoDevice2 p) => (TerraFX.Interop.DirectX.ID3D12VideoDevice*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12VideoDevice2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12VideoDevice2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12VideoDevice3
{
    private readonly TerraFX.Interop.DirectX.ID3D12VideoDevice3* p;

    public TerraFX.Interop.DirectX.ID3D12VideoDevice3* Get() => this.p;

    public static implicit operator PID3D12VideoDevice3(TerraFX.Interop.DirectX.ID3D12VideoDevice3* p) => *(PID3D12VideoDevice3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoDevice3*(PID3D12VideoDevice3 p) => (TerraFX.Interop.DirectX.ID3D12VideoDevice3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoDevice2*(PID3D12VideoDevice3 p) => (TerraFX.Interop.DirectX.ID3D12VideoDevice2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoDevice1*(PID3D12VideoDevice3 p) => (TerraFX.Interop.DirectX.ID3D12VideoDevice1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoDevice*(PID3D12VideoDevice3 p) => (TerraFX.Interop.DirectX.ID3D12VideoDevice*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12VideoDevice3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12VideoDevice3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12VideoEncodeCommandList
{
    private readonly TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList* p;

    public TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList* Get() => this.p;

    public static implicit operator PID3D12VideoEncodeCommandList(TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList* p) => *(PID3D12VideoEncodeCommandList*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList*(PID3D12VideoEncodeCommandList p) => (TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12CommandList*(PID3D12VideoEncodeCommandList p) => (TerraFX.Interop.DirectX.ID3D12CommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12VideoEncodeCommandList p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12VideoEncodeCommandList p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12VideoEncodeCommandList p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12VideoEncodeCommandList p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12VideoEncodeCommandList1
{
    private readonly TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList1* p;

    public TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList1* Get() => this.p;

    public static implicit operator PID3D12VideoEncodeCommandList1(TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList1* p) => *(PID3D12VideoEncodeCommandList1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList1*(PID3D12VideoEncodeCommandList1 p) => (TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList*(PID3D12VideoEncodeCommandList1 p) => (TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12CommandList*(PID3D12VideoEncodeCommandList1 p) => (TerraFX.Interop.DirectX.ID3D12CommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12VideoEncodeCommandList1 p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12VideoEncodeCommandList1 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12VideoEncodeCommandList1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12VideoEncodeCommandList1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12VideoEncodeCommandList2
{
    private readonly TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList2* p;

    public TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList2* Get() => this.p;

    public static implicit operator PID3D12VideoEncodeCommandList2(TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList2* p) => *(PID3D12VideoEncodeCommandList2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList2*(PID3D12VideoEncodeCommandList2 p) => (TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList1*(PID3D12VideoEncodeCommandList2 p) => (TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList*(PID3D12VideoEncodeCommandList2 p) => (TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12CommandList*(PID3D12VideoEncodeCommandList2 p) => (TerraFX.Interop.DirectX.ID3D12CommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12VideoEncodeCommandList2 p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12VideoEncodeCommandList2 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12VideoEncodeCommandList2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12VideoEncodeCommandList2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12VideoEncodeCommandList3
{
    private readonly TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList3* p;

    public TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList3* Get() => this.p;

    public static implicit operator PID3D12VideoEncodeCommandList3(TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList3* p) => *(PID3D12VideoEncodeCommandList3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList3*(PID3D12VideoEncodeCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList2*(PID3D12VideoEncodeCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList1*(PID3D12VideoEncodeCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList*(PID3D12VideoEncodeCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12VideoEncodeCommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12CommandList*(PID3D12VideoEncodeCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12CommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12VideoEncodeCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12VideoEncodeCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12VideoEncodeCommandList3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12VideoEncodeCommandList3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12VideoEncoder
{
    private readonly TerraFX.Interop.DirectX.ID3D12VideoEncoder* p;

    public TerraFX.Interop.DirectX.ID3D12VideoEncoder* Get() => this.p;

    public static implicit operator PID3D12VideoEncoder(TerraFX.Interop.DirectX.ID3D12VideoEncoder* p) => *(PID3D12VideoEncoder*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoEncoder*(PID3D12VideoEncoder p) => (TerraFX.Interop.DirectX.ID3D12VideoEncoder*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Pageable*(PID3D12VideoEncoder p) => (TerraFX.Interop.DirectX.ID3D12Pageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12VideoEncoder p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12VideoEncoder p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12VideoEncoder p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12VideoEncoder p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12VideoEncoderHeap
{
    private readonly TerraFX.Interop.DirectX.ID3D12VideoEncoderHeap* p;

    public TerraFX.Interop.DirectX.ID3D12VideoEncoderHeap* Get() => this.p;

    public static implicit operator PID3D12VideoEncoderHeap(TerraFX.Interop.DirectX.ID3D12VideoEncoderHeap* p) => *(PID3D12VideoEncoderHeap*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoEncoderHeap*(PID3D12VideoEncoderHeap p) => (TerraFX.Interop.DirectX.ID3D12VideoEncoderHeap*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Pageable*(PID3D12VideoEncoderHeap p) => (TerraFX.Interop.DirectX.ID3D12Pageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12VideoEncoderHeap p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12VideoEncoderHeap p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12VideoEncoderHeap p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12VideoEncoderHeap p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12VideoExtensionCommand
{
    private readonly TerraFX.Interop.DirectX.ID3D12VideoExtensionCommand* p;

    public TerraFX.Interop.DirectX.ID3D12VideoExtensionCommand* Get() => this.p;

    public static implicit operator PID3D12VideoExtensionCommand(TerraFX.Interop.DirectX.ID3D12VideoExtensionCommand* p) => *(PID3D12VideoExtensionCommand*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoExtensionCommand*(PID3D12VideoExtensionCommand p) => (TerraFX.Interop.DirectX.ID3D12VideoExtensionCommand*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Pageable*(PID3D12VideoExtensionCommand p) => (TerraFX.Interop.DirectX.ID3D12Pageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12VideoExtensionCommand p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12VideoExtensionCommand p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12VideoExtensionCommand p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12VideoExtensionCommand p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12VideoMotionEstimator
{
    private readonly TerraFX.Interop.DirectX.ID3D12VideoMotionEstimator* p;

    public TerraFX.Interop.DirectX.ID3D12VideoMotionEstimator* Get() => this.p;

    public static implicit operator PID3D12VideoMotionEstimator(TerraFX.Interop.DirectX.ID3D12VideoMotionEstimator* p) => *(PID3D12VideoMotionEstimator*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoMotionEstimator*(PID3D12VideoMotionEstimator p) => (TerraFX.Interop.DirectX.ID3D12VideoMotionEstimator*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Pageable*(PID3D12VideoMotionEstimator p) => (TerraFX.Interop.DirectX.ID3D12Pageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12VideoMotionEstimator p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12VideoMotionEstimator p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12VideoMotionEstimator p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12VideoMotionEstimator p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12VideoMotionVectorHeap
{
    private readonly TerraFX.Interop.DirectX.ID3D12VideoMotionVectorHeap* p;

    public TerraFX.Interop.DirectX.ID3D12VideoMotionVectorHeap* Get() => this.p;

    public static implicit operator PID3D12VideoMotionVectorHeap(TerraFX.Interop.DirectX.ID3D12VideoMotionVectorHeap* p) => *(PID3D12VideoMotionVectorHeap*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoMotionVectorHeap*(PID3D12VideoMotionVectorHeap p) => (TerraFX.Interop.DirectX.ID3D12VideoMotionVectorHeap*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Pageable*(PID3D12VideoMotionVectorHeap p) => (TerraFX.Interop.DirectX.ID3D12Pageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12VideoMotionVectorHeap p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12VideoMotionVectorHeap p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12VideoMotionVectorHeap p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12VideoMotionVectorHeap p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12VideoProcessCommandList
{
    private readonly TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList* p;

    public TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList* Get() => this.p;

    public static implicit operator PID3D12VideoProcessCommandList(TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList* p) => *(PID3D12VideoProcessCommandList*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList*(PID3D12VideoProcessCommandList p) => (TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12CommandList*(PID3D12VideoProcessCommandList p) => (TerraFX.Interop.DirectX.ID3D12CommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12VideoProcessCommandList p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12VideoProcessCommandList p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12VideoProcessCommandList p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12VideoProcessCommandList p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12VideoProcessCommandList1
{
    private readonly TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList1* p;

    public TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList1* Get() => this.p;

    public static implicit operator PID3D12VideoProcessCommandList1(TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList1* p) => *(PID3D12VideoProcessCommandList1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList1*(PID3D12VideoProcessCommandList1 p) => (TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList*(PID3D12VideoProcessCommandList1 p) => (TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12CommandList*(PID3D12VideoProcessCommandList1 p) => (TerraFX.Interop.DirectX.ID3D12CommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12VideoProcessCommandList1 p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12VideoProcessCommandList1 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12VideoProcessCommandList1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12VideoProcessCommandList1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12VideoProcessCommandList2
{
    private readonly TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList2* p;

    public TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList2* Get() => this.p;

    public static implicit operator PID3D12VideoProcessCommandList2(TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList2* p) => *(PID3D12VideoProcessCommandList2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList2*(PID3D12VideoProcessCommandList2 p) => (TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList1*(PID3D12VideoProcessCommandList2 p) => (TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList*(PID3D12VideoProcessCommandList2 p) => (TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12CommandList*(PID3D12VideoProcessCommandList2 p) => (TerraFX.Interop.DirectX.ID3D12CommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12VideoProcessCommandList2 p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12VideoProcessCommandList2 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12VideoProcessCommandList2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12VideoProcessCommandList2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12VideoProcessCommandList3
{
    private readonly TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList3* p;

    public TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList3* Get() => this.p;

    public static implicit operator PID3D12VideoProcessCommandList3(TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList3* p) => *(PID3D12VideoProcessCommandList3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList3*(PID3D12VideoProcessCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList2*(PID3D12VideoProcessCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList1*(PID3D12VideoProcessCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList*(PID3D12VideoProcessCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12VideoProcessCommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12CommandList*(PID3D12VideoProcessCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12CommandList*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12VideoProcessCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12VideoProcessCommandList3 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12VideoProcessCommandList3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12VideoProcessCommandList3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12VideoProcessor
{
    private readonly TerraFX.Interop.DirectX.ID3D12VideoProcessor* p;

    public TerraFX.Interop.DirectX.ID3D12VideoProcessor* Get() => this.p;

    public static implicit operator PID3D12VideoProcessor(TerraFX.Interop.DirectX.ID3D12VideoProcessor* p) => *(PID3D12VideoProcessor*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoProcessor*(PID3D12VideoProcessor p) => (TerraFX.Interop.DirectX.ID3D12VideoProcessor*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Pageable*(PID3D12VideoProcessor p) => (TerraFX.Interop.DirectX.ID3D12Pageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12VideoProcessor p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12VideoProcessor p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12VideoProcessor p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12VideoProcessor p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12VideoProcessor1
{
    private readonly TerraFX.Interop.DirectX.ID3D12VideoProcessor1* p;

    public TerraFX.Interop.DirectX.ID3D12VideoProcessor1* Get() => this.p;

    public static implicit operator PID3D12VideoProcessor1(TerraFX.Interop.DirectX.ID3D12VideoProcessor1* p) => *(PID3D12VideoProcessor1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoProcessor1*(PID3D12VideoProcessor1 p) => (TerraFX.Interop.DirectX.ID3D12VideoProcessor1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VideoProcessor*(PID3D12VideoProcessor1 p) => (TerraFX.Interop.DirectX.ID3D12VideoProcessor*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Pageable*(PID3D12VideoProcessor1 p) => (TerraFX.Interop.DirectX.ID3D12Pageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12DeviceChild*(PID3D12VideoProcessor1 p) => (TerraFX.Interop.DirectX.ID3D12DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12Object*(PID3D12VideoProcessor1 p) => (TerraFX.Interop.DirectX.ID3D12Object*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12VideoProcessor1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12VideoProcessor1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3D12VirtualizationGuestDevice
{
    private readonly TerraFX.Interop.DirectX.ID3D12VirtualizationGuestDevice* p;

    public TerraFX.Interop.DirectX.ID3D12VirtualizationGuestDevice* Get() => this.p;

    public static implicit operator PID3D12VirtualizationGuestDevice(TerraFX.Interop.DirectX.ID3D12VirtualizationGuestDevice* p) => *(PID3D12VirtualizationGuestDevice*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D12VirtualizationGuestDevice*(PID3D12VirtualizationGuestDevice p) => (TerraFX.Interop.DirectX.ID3D12VirtualizationGuestDevice*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3D12VirtualizationGuestDevice p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3D12VirtualizationGuestDevice p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3DBlob
{
    private readonly TerraFX.Interop.DirectX.ID3DBlob* p;

    public TerraFX.Interop.DirectX.ID3DBlob* Get() => this.p;

    public static implicit operator PID3DBlob(TerraFX.Interop.DirectX.ID3DBlob* p) => *(PID3DBlob*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3DBlob*(PID3DBlob p) => (TerraFX.Interop.DirectX.ID3DBlob*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3DBlob p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3DBlob p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3DDestructionNotifier
{
    private readonly TerraFX.Interop.DirectX.ID3DDestructionNotifier* p;

    public TerraFX.Interop.DirectX.ID3DDestructionNotifier* Get() => this.p;

    public static implicit operator PID3DDestructionNotifier(TerraFX.Interop.DirectX.ID3DDestructionNotifier* p) => *(PID3DDestructionNotifier*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3DDestructionNotifier*(PID3DDestructionNotifier p) => (TerraFX.Interop.DirectX.ID3DDestructionNotifier*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3DDestructionNotifier p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3DDestructionNotifier p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3DDeviceContextState
{
    private readonly TerraFX.Interop.DirectX.ID3DDeviceContextState* p;

    public TerraFX.Interop.DirectX.ID3DDeviceContextState* Get() => this.p;

    public static implicit operator PID3DDeviceContextState(TerraFX.Interop.DirectX.ID3DDeviceContextState* p) => *(PID3DDeviceContextState*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3DDeviceContextState*(PID3DDeviceContextState p) => (TerraFX.Interop.DirectX.ID3DDeviceContextState*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.ID3D11DeviceChild*(PID3DDeviceContextState p) => (TerraFX.Interop.DirectX.ID3D11DeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3DDeviceContextState p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3DDeviceContextState p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PID3DUserDefinedAnnotation
{
    private readonly TerraFX.Interop.DirectX.ID3DUserDefinedAnnotation* p;

    public TerraFX.Interop.DirectX.ID3DUserDefinedAnnotation* Get() => this.p;

    public static implicit operator PID3DUserDefinedAnnotation(TerraFX.Interop.DirectX.ID3DUserDefinedAnnotation* p) => *(PID3DUserDefinedAnnotation*)&p;
    public static implicit operator TerraFX.Interop.DirectX.ID3DUserDefinedAnnotation*(PID3DUserDefinedAnnotation p) => (TerraFX.Interop.DirectX.ID3DUserDefinedAnnotation*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PID3DUserDefinedAnnotation p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PID3DUserDefinedAnnotation p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionAffineTransform2DEffect
{
    private readonly TerraFX.Interop.DirectX.IDCompositionAffineTransform2DEffect* p;

    public TerraFX.Interop.DirectX.IDCompositionAffineTransform2DEffect* Get() => this.p;

    public static implicit operator PIDCompositionAffineTransform2DEffect(TerraFX.Interop.DirectX.IDCompositionAffineTransform2DEffect* p) => *(PIDCompositionAffineTransform2DEffect*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionAffineTransform2DEffect*(PIDCompositionAffineTransform2DEffect p) => (TerraFX.Interop.DirectX.IDCompositionAffineTransform2DEffect*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionFilterEffect*(PIDCompositionAffineTransform2DEffect p) => (TerraFX.Interop.DirectX.IDCompositionFilterEffect*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionEffect*(PIDCompositionAffineTransform2DEffect p) => (TerraFX.Interop.DirectX.IDCompositionEffect*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionAffineTransform2DEffect p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionAffineTransform2DEffect p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionAnimation
{
    private readonly TerraFX.Interop.DirectX.IDCompositionAnimation* p;

    public TerraFX.Interop.DirectX.IDCompositionAnimation* Get() => this.p;

    public static implicit operator PIDCompositionAnimation(TerraFX.Interop.DirectX.IDCompositionAnimation* p) => *(PIDCompositionAnimation*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionAnimation*(PIDCompositionAnimation p) => (TerraFX.Interop.DirectX.IDCompositionAnimation*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionAnimation p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionAnimation p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionArithmeticCompositeEffect
{
    private readonly TerraFX.Interop.DirectX.IDCompositionArithmeticCompositeEffect* p;

    public TerraFX.Interop.DirectX.IDCompositionArithmeticCompositeEffect* Get() => this.p;

    public static implicit operator PIDCompositionArithmeticCompositeEffect(TerraFX.Interop.DirectX.IDCompositionArithmeticCompositeEffect* p) => *(PIDCompositionArithmeticCompositeEffect*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionArithmeticCompositeEffect*(PIDCompositionArithmeticCompositeEffect p) => (TerraFX.Interop.DirectX.IDCompositionArithmeticCompositeEffect*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionFilterEffect*(PIDCompositionArithmeticCompositeEffect p) => (TerraFX.Interop.DirectX.IDCompositionFilterEffect*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionEffect*(PIDCompositionArithmeticCompositeEffect p) => (TerraFX.Interop.DirectX.IDCompositionEffect*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionArithmeticCompositeEffect p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionArithmeticCompositeEffect p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionBlendEffect
{
    private readonly TerraFX.Interop.DirectX.IDCompositionBlendEffect* p;

    public TerraFX.Interop.DirectX.IDCompositionBlendEffect* Get() => this.p;

    public static implicit operator PIDCompositionBlendEffect(TerraFX.Interop.DirectX.IDCompositionBlendEffect* p) => *(PIDCompositionBlendEffect*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionBlendEffect*(PIDCompositionBlendEffect p) => (TerraFX.Interop.DirectX.IDCompositionBlendEffect*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionFilterEffect*(PIDCompositionBlendEffect p) => (TerraFX.Interop.DirectX.IDCompositionFilterEffect*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionEffect*(PIDCompositionBlendEffect p) => (TerraFX.Interop.DirectX.IDCompositionEffect*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionBlendEffect p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionBlendEffect p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionBrightnessEffect
{
    private readonly TerraFX.Interop.DirectX.IDCompositionBrightnessEffect* p;

    public TerraFX.Interop.DirectX.IDCompositionBrightnessEffect* Get() => this.p;

    public static implicit operator PIDCompositionBrightnessEffect(TerraFX.Interop.DirectX.IDCompositionBrightnessEffect* p) => *(PIDCompositionBrightnessEffect*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionBrightnessEffect*(PIDCompositionBrightnessEffect p) => (TerraFX.Interop.DirectX.IDCompositionBrightnessEffect*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionFilterEffect*(PIDCompositionBrightnessEffect p) => (TerraFX.Interop.DirectX.IDCompositionFilterEffect*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionEffect*(PIDCompositionBrightnessEffect p) => (TerraFX.Interop.DirectX.IDCompositionEffect*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionBrightnessEffect p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionBrightnessEffect p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionClip
{
    private readonly TerraFX.Interop.DirectX.IDCompositionClip* p;

    public TerraFX.Interop.DirectX.IDCompositionClip* Get() => this.p;

    public static implicit operator PIDCompositionClip(TerraFX.Interop.DirectX.IDCompositionClip* p) => *(PIDCompositionClip*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionClip*(PIDCompositionClip p) => (TerraFX.Interop.DirectX.IDCompositionClip*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionClip p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionClip p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionColorMatrixEffect
{
    private readonly TerraFX.Interop.DirectX.IDCompositionColorMatrixEffect* p;

    public TerraFX.Interop.DirectX.IDCompositionColorMatrixEffect* Get() => this.p;

    public static implicit operator PIDCompositionColorMatrixEffect(TerraFX.Interop.DirectX.IDCompositionColorMatrixEffect* p) => *(PIDCompositionColorMatrixEffect*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionColorMatrixEffect*(PIDCompositionColorMatrixEffect p) => (TerraFX.Interop.DirectX.IDCompositionColorMatrixEffect*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionFilterEffect*(PIDCompositionColorMatrixEffect p) => (TerraFX.Interop.DirectX.IDCompositionFilterEffect*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionEffect*(PIDCompositionColorMatrixEffect p) => (TerraFX.Interop.DirectX.IDCompositionEffect*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionColorMatrixEffect p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionColorMatrixEffect p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionCompositeEffect
{
    private readonly TerraFX.Interop.DirectX.IDCompositionCompositeEffect* p;

    public TerraFX.Interop.DirectX.IDCompositionCompositeEffect* Get() => this.p;

    public static implicit operator PIDCompositionCompositeEffect(TerraFX.Interop.DirectX.IDCompositionCompositeEffect* p) => *(PIDCompositionCompositeEffect*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionCompositeEffect*(PIDCompositionCompositeEffect p) => (TerraFX.Interop.DirectX.IDCompositionCompositeEffect*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionFilterEffect*(PIDCompositionCompositeEffect p) => (TerraFX.Interop.DirectX.IDCompositionFilterEffect*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionEffect*(PIDCompositionCompositeEffect p) => (TerraFX.Interop.DirectX.IDCompositionEffect*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionCompositeEffect p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionCompositeEffect p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionDelegatedInkTrail
{
    private readonly TerraFX.Interop.DirectX.IDCompositionDelegatedInkTrail* p;

    public TerraFX.Interop.DirectX.IDCompositionDelegatedInkTrail* Get() => this.p;

    public static implicit operator PIDCompositionDelegatedInkTrail(TerraFX.Interop.DirectX.IDCompositionDelegatedInkTrail* p) => *(PIDCompositionDelegatedInkTrail*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionDelegatedInkTrail*(PIDCompositionDelegatedInkTrail p) => (TerraFX.Interop.DirectX.IDCompositionDelegatedInkTrail*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionDelegatedInkTrail p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionDelegatedInkTrail p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionDesktopDevice
{
    private readonly TerraFX.Interop.DirectX.IDCompositionDesktopDevice* p;

    public TerraFX.Interop.DirectX.IDCompositionDesktopDevice* Get() => this.p;

    public static implicit operator PIDCompositionDesktopDevice(TerraFX.Interop.DirectX.IDCompositionDesktopDevice* p) => *(PIDCompositionDesktopDevice*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionDesktopDevice*(PIDCompositionDesktopDevice p) => (TerraFX.Interop.DirectX.IDCompositionDesktopDevice*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionDevice2*(PIDCompositionDesktopDevice p) => (TerraFX.Interop.DirectX.IDCompositionDevice2*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionDesktopDevice p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionDesktopDevice p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionDevice
{
    private readonly TerraFX.Interop.DirectX.IDCompositionDevice* p;

    public TerraFX.Interop.DirectX.IDCompositionDevice* Get() => this.p;

    public static implicit operator PIDCompositionDevice(TerraFX.Interop.DirectX.IDCompositionDevice* p) => *(PIDCompositionDevice*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionDevice*(PIDCompositionDevice p) => (TerraFX.Interop.DirectX.IDCompositionDevice*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionDevice p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionDevice p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionDevice2
{
    private readonly TerraFX.Interop.DirectX.IDCompositionDevice2* p;

    public TerraFX.Interop.DirectX.IDCompositionDevice2* Get() => this.p;

    public static implicit operator PIDCompositionDevice2(TerraFX.Interop.DirectX.IDCompositionDevice2* p) => *(PIDCompositionDevice2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionDevice2*(PIDCompositionDevice2 p) => (TerraFX.Interop.DirectX.IDCompositionDevice2*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionDevice2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionDevice2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionDevice3
{
    private readonly TerraFX.Interop.DirectX.IDCompositionDevice3* p;

    public TerraFX.Interop.DirectX.IDCompositionDevice3* Get() => this.p;

    public static implicit operator PIDCompositionDevice3(TerraFX.Interop.DirectX.IDCompositionDevice3* p) => *(PIDCompositionDevice3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionDevice3*(PIDCompositionDevice3 p) => (TerraFX.Interop.DirectX.IDCompositionDevice3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionDevice2*(PIDCompositionDevice3 p) => (TerraFX.Interop.DirectX.IDCompositionDevice2*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionDevice3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionDevice3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionDevice4
{
    private readonly TerraFX.Interop.DirectX.IDCompositionDevice4* p;

    public TerraFX.Interop.DirectX.IDCompositionDevice4* Get() => this.p;

    public static implicit operator PIDCompositionDevice4(TerraFX.Interop.DirectX.IDCompositionDevice4* p) => *(PIDCompositionDevice4*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionDevice4*(PIDCompositionDevice4 p) => (TerraFX.Interop.DirectX.IDCompositionDevice4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionDevice3*(PIDCompositionDevice4 p) => (TerraFX.Interop.DirectX.IDCompositionDevice3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionDevice2*(PIDCompositionDevice4 p) => (TerraFX.Interop.DirectX.IDCompositionDevice2*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionDevice4 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionDevice4 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionDeviceDebug
{
    private readonly TerraFX.Interop.DirectX.IDCompositionDeviceDebug* p;

    public TerraFX.Interop.DirectX.IDCompositionDeviceDebug* Get() => this.p;

    public static implicit operator PIDCompositionDeviceDebug(TerraFX.Interop.DirectX.IDCompositionDeviceDebug* p) => *(PIDCompositionDeviceDebug*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionDeviceDebug*(PIDCompositionDeviceDebug p) => (TerraFX.Interop.DirectX.IDCompositionDeviceDebug*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionDeviceDebug p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionDeviceDebug p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionEffect
{
    private readonly TerraFX.Interop.DirectX.IDCompositionEffect* p;

    public TerraFX.Interop.DirectX.IDCompositionEffect* Get() => this.p;

    public static implicit operator PIDCompositionEffect(TerraFX.Interop.DirectX.IDCompositionEffect* p) => *(PIDCompositionEffect*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionEffect*(PIDCompositionEffect p) => (TerraFX.Interop.DirectX.IDCompositionEffect*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionEffect p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionEffect p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionEffectGroup
{
    private readonly TerraFX.Interop.DirectX.IDCompositionEffectGroup* p;

    public TerraFX.Interop.DirectX.IDCompositionEffectGroup* Get() => this.p;

    public static implicit operator PIDCompositionEffectGroup(TerraFX.Interop.DirectX.IDCompositionEffectGroup* p) => *(PIDCompositionEffectGroup*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionEffectGroup*(PIDCompositionEffectGroup p) => (TerraFX.Interop.DirectX.IDCompositionEffectGroup*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionEffect*(PIDCompositionEffectGroup p) => (TerraFX.Interop.DirectX.IDCompositionEffect*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionEffectGroup p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionEffectGroup p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionFilterEffect
{
    private readonly TerraFX.Interop.DirectX.IDCompositionFilterEffect* p;

    public TerraFX.Interop.DirectX.IDCompositionFilterEffect* Get() => this.p;

    public static implicit operator PIDCompositionFilterEffect(TerraFX.Interop.DirectX.IDCompositionFilterEffect* p) => *(PIDCompositionFilterEffect*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionFilterEffect*(PIDCompositionFilterEffect p) => (TerraFX.Interop.DirectX.IDCompositionFilterEffect*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionEffect*(PIDCompositionFilterEffect p) => (TerraFX.Interop.DirectX.IDCompositionEffect*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionFilterEffect p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionFilterEffect p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionGaussianBlurEffect
{
    private readonly TerraFX.Interop.DirectX.IDCompositionGaussianBlurEffect* p;

    public TerraFX.Interop.DirectX.IDCompositionGaussianBlurEffect* Get() => this.p;

    public static implicit operator PIDCompositionGaussianBlurEffect(TerraFX.Interop.DirectX.IDCompositionGaussianBlurEffect* p) => *(PIDCompositionGaussianBlurEffect*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionGaussianBlurEffect*(PIDCompositionGaussianBlurEffect p) => (TerraFX.Interop.DirectX.IDCompositionGaussianBlurEffect*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionFilterEffect*(PIDCompositionGaussianBlurEffect p) => (TerraFX.Interop.DirectX.IDCompositionFilterEffect*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionEffect*(PIDCompositionGaussianBlurEffect p) => (TerraFX.Interop.DirectX.IDCompositionEffect*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionGaussianBlurEffect p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionGaussianBlurEffect p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionHueRotationEffect
{
    private readonly TerraFX.Interop.DirectX.IDCompositionHueRotationEffect* p;

    public TerraFX.Interop.DirectX.IDCompositionHueRotationEffect* Get() => this.p;

    public static implicit operator PIDCompositionHueRotationEffect(TerraFX.Interop.DirectX.IDCompositionHueRotationEffect* p) => *(PIDCompositionHueRotationEffect*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionHueRotationEffect*(PIDCompositionHueRotationEffect p) => (TerraFX.Interop.DirectX.IDCompositionHueRotationEffect*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionFilterEffect*(PIDCompositionHueRotationEffect p) => (TerraFX.Interop.DirectX.IDCompositionFilterEffect*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionEffect*(PIDCompositionHueRotationEffect p) => (TerraFX.Interop.DirectX.IDCompositionEffect*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionHueRotationEffect p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionHueRotationEffect p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionInkTrailDevice
{
    private readonly TerraFX.Interop.DirectX.IDCompositionInkTrailDevice* p;

    public TerraFX.Interop.DirectX.IDCompositionInkTrailDevice* Get() => this.p;

    public static implicit operator PIDCompositionInkTrailDevice(TerraFX.Interop.DirectX.IDCompositionInkTrailDevice* p) => *(PIDCompositionInkTrailDevice*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionInkTrailDevice*(PIDCompositionInkTrailDevice p) => (TerraFX.Interop.DirectX.IDCompositionInkTrailDevice*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionInkTrailDevice p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionInkTrailDevice p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionLinearTransferEffect
{
    private readonly TerraFX.Interop.DirectX.IDCompositionLinearTransferEffect* p;

    public TerraFX.Interop.DirectX.IDCompositionLinearTransferEffect* Get() => this.p;

    public static implicit operator PIDCompositionLinearTransferEffect(TerraFX.Interop.DirectX.IDCompositionLinearTransferEffect* p) => *(PIDCompositionLinearTransferEffect*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionLinearTransferEffect*(PIDCompositionLinearTransferEffect p) => (TerraFX.Interop.DirectX.IDCompositionLinearTransferEffect*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionFilterEffect*(PIDCompositionLinearTransferEffect p) => (TerraFX.Interop.DirectX.IDCompositionFilterEffect*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionEffect*(PIDCompositionLinearTransferEffect p) => (TerraFX.Interop.DirectX.IDCompositionEffect*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionLinearTransferEffect p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionLinearTransferEffect p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionMatrixTransform
{
    private readonly TerraFX.Interop.DirectX.IDCompositionMatrixTransform* p;

    public TerraFX.Interop.DirectX.IDCompositionMatrixTransform* Get() => this.p;

    public static implicit operator PIDCompositionMatrixTransform(TerraFX.Interop.DirectX.IDCompositionMatrixTransform* p) => *(PIDCompositionMatrixTransform*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionMatrixTransform*(PIDCompositionMatrixTransform p) => (TerraFX.Interop.DirectX.IDCompositionMatrixTransform*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionTransform*(PIDCompositionMatrixTransform p) => (TerraFX.Interop.DirectX.IDCompositionTransform*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionTransform3D*(PIDCompositionMatrixTransform p) => (TerraFX.Interop.DirectX.IDCompositionTransform3D*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionEffect*(PIDCompositionMatrixTransform p) => (TerraFX.Interop.DirectX.IDCompositionEffect*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionMatrixTransform p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionMatrixTransform p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionMatrixTransform3D
{
    private readonly TerraFX.Interop.DirectX.IDCompositionMatrixTransform3D* p;

    public TerraFX.Interop.DirectX.IDCompositionMatrixTransform3D* Get() => this.p;

    public static implicit operator PIDCompositionMatrixTransform3D(TerraFX.Interop.DirectX.IDCompositionMatrixTransform3D* p) => *(PIDCompositionMatrixTransform3D*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionMatrixTransform3D*(PIDCompositionMatrixTransform3D p) => (TerraFX.Interop.DirectX.IDCompositionMatrixTransform3D*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionTransform3D*(PIDCompositionMatrixTransform3D p) => (TerraFX.Interop.DirectX.IDCompositionTransform3D*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionEffect*(PIDCompositionMatrixTransform3D p) => (TerraFX.Interop.DirectX.IDCompositionEffect*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionMatrixTransform3D p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionMatrixTransform3D p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionRectangleClip
{
    private readonly TerraFX.Interop.DirectX.IDCompositionRectangleClip* p;

    public TerraFX.Interop.DirectX.IDCompositionRectangleClip* Get() => this.p;

    public static implicit operator PIDCompositionRectangleClip(TerraFX.Interop.DirectX.IDCompositionRectangleClip* p) => *(PIDCompositionRectangleClip*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionRectangleClip*(PIDCompositionRectangleClip p) => (TerraFX.Interop.DirectX.IDCompositionRectangleClip*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionClip*(PIDCompositionRectangleClip p) => (TerraFX.Interop.DirectX.IDCompositionClip*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionRectangleClip p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionRectangleClip p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionRotateTransform
{
    private readonly TerraFX.Interop.DirectX.IDCompositionRotateTransform* p;

    public TerraFX.Interop.DirectX.IDCompositionRotateTransform* Get() => this.p;

    public static implicit operator PIDCompositionRotateTransform(TerraFX.Interop.DirectX.IDCompositionRotateTransform* p) => *(PIDCompositionRotateTransform*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionRotateTransform*(PIDCompositionRotateTransform p) => (TerraFX.Interop.DirectX.IDCompositionRotateTransform*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionTransform*(PIDCompositionRotateTransform p) => (TerraFX.Interop.DirectX.IDCompositionTransform*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionTransform3D*(PIDCompositionRotateTransform p) => (TerraFX.Interop.DirectX.IDCompositionTransform3D*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionEffect*(PIDCompositionRotateTransform p) => (TerraFX.Interop.DirectX.IDCompositionEffect*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionRotateTransform p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionRotateTransform p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionRotateTransform3D
{
    private readonly TerraFX.Interop.DirectX.IDCompositionRotateTransform3D* p;

    public TerraFX.Interop.DirectX.IDCompositionRotateTransform3D* Get() => this.p;

    public static implicit operator PIDCompositionRotateTransform3D(TerraFX.Interop.DirectX.IDCompositionRotateTransform3D* p) => *(PIDCompositionRotateTransform3D*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionRotateTransform3D*(PIDCompositionRotateTransform3D p) => (TerraFX.Interop.DirectX.IDCompositionRotateTransform3D*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionTransform3D*(PIDCompositionRotateTransform3D p) => (TerraFX.Interop.DirectX.IDCompositionTransform3D*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionEffect*(PIDCompositionRotateTransform3D p) => (TerraFX.Interop.DirectX.IDCompositionEffect*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionRotateTransform3D p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionRotateTransform3D p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionSaturationEffect
{
    private readonly TerraFX.Interop.DirectX.IDCompositionSaturationEffect* p;

    public TerraFX.Interop.DirectX.IDCompositionSaturationEffect* Get() => this.p;

    public static implicit operator PIDCompositionSaturationEffect(TerraFX.Interop.DirectX.IDCompositionSaturationEffect* p) => *(PIDCompositionSaturationEffect*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionSaturationEffect*(PIDCompositionSaturationEffect p) => (TerraFX.Interop.DirectX.IDCompositionSaturationEffect*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionFilterEffect*(PIDCompositionSaturationEffect p) => (TerraFX.Interop.DirectX.IDCompositionFilterEffect*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionEffect*(PIDCompositionSaturationEffect p) => (TerraFX.Interop.DirectX.IDCompositionEffect*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionSaturationEffect p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionSaturationEffect p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionScaleTransform
{
    private readonly TerraFX.Interop.DirectX.IDCompositionScaleTransform* p;

    public TerraFX.Interop.DirectX.IDCompositionScaleTransform* Get() => this.p;

    public static implicit operator PIDCompositionScaleTransform(TerraFX.Interop.DirectX.IDCompositionScaleTransform* p) => *(PIDCompositionScaleTransform*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionScaleTransform*(PIDCompositionScaleTransform p) => (TerraFX.Interop.DirectX.IDCompositionScaleTransform*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionTransform*(PIDCompositionScaleTransform p) => (TerraFX.Interop.DirectX.IDCompositionTransform*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionTransform3D*(PIDCompositionScaleTransform p) => (TerraFX.Interop.DirectX.IDCompositionTransform3D*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionEffect*(PIDCompositionScaleTransform p) => (TerraFX.Interop.DirectX.IDCompositionEffect*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionScaleTransform p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionScaleTransform p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionScaleTransform3D
{
    private readonly TerraFX.Interop.DirectX.IDCompositionScaleTransform3D* p;

    public TerraFX.Interop.DirectX.IDCompositionScaleTransform3D* Get() => this.p;

    public static implicit operator PIDCompositionScaleTransform3D(TerraFX.Interop.DirectX.IDCompositionScaleTransform3D* p) => *(PIDCompositionScaleTransform3D*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionScaleTransform3D*(PIDCompositionScaleTransform3D p) => (TerraFX.Interop.DirectX.IDCompositionScaleTransform3D*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionTransform3D*(PIDCompositionScaleTransform3D p) => (TerraFX.Interop.DirectX.IDCompositionTransform3D*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionEffect*(PIDCompositionScaleTransform3D p) => (TerraFX.Interop.DirectX.IDCompositionEffect*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionScaleTransform3D p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionScaleTransform3D p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionShadowEffect
{
    private readonly TerraFX.Interop.DirectX.IDCompositionShadowEffect* p;

    public TerraFX.Interop.DirectX.IDCompositionShadowEffect* Get() => this.p;

    public static implicit operator PIDCompositionShadowEffect(TerraFX.Interop.DirectX.IDCompositionShadowEffect* p) => *(PIDCompositionShadowEffect*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionShadowEffect*(PIDCompositionShadowEffect p) => (TerraFX.Interop.DirectX.IDCompositionShadowEffect*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionFilterEffect*(PIDCompositionShadowEffect p) => (TerraFX.Interop.DirectX.IDCompositionFilterEffect*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionEffect*(PIDCompositionShadowEffect p) => (TerraFX.Interop.DirectX.IDCompositionEffect*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionShadowEffect p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionShadowEffect p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionSkewTransform
{
    private readonly TerraFX.Interop.DirectX.IDCompositionSkewTransform* p;

    public TerraFX.Interop.DirectX.IDCompositionSkewTransform* Get() => this.p;

    public static implicit operator PIDCompositionSkewTransform(TerraFX.Interop.DirectX.IDCompositionSkewTransform* p) => *(PIDCompositionSkewTransform*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionSkewTransform*(PIDCompositionSkewTransform p) => (TerraFX.Interop.DirectX.IDCompositionSkewTransform*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionTransform*(PIDCompositionSkewTransform p) => (TerraFX.Interop.DirectX.IDCompositionTransform*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionTransform3D*(PIDCompositionSkewTransform p) => (TerraFX.Interop.DirectX.IDCompositionTransform3D*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionEffect*(PIDCompositionSkewTransform p) => (TerraFX.Interop.DirectX.IDCompositionEffect*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionSkewTransform p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionSkewTransform p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionSurface
{
    private readonly TerraFX.Interop.DirectX.IDCompositionSurface* p;

    public TerraFX.Interop.DirectX.IDCompositionSurface* Get() => this.p;

    public static implicit operator PIDCompositionSurface(TerraFX.Interop.DirectX.IDCompositionSurface* p) => *(PIDCompositionSurface*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionSurface*(PIDCompositionSurface p) => (TerraFX.Interop.DirectX.IDCompositionSurface*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionSurface p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionSurface p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionSurfaceFactory
{
    private readonly TerraFX.Interop.DirectX.IDCompositionSurfaceFactory* p;

    public TerraFX.Interop.DirectX.IDCompositionSurfaceFactory* Get() => this.p;

    public static implicit operator PIDCompositionSurfaceFactory(TerraFX.Interop.DirectX.IDCompositionSurfaceFactory* p) => *(PIDCompositionSurfaceFactory*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionSurfaceFactory*(PIDCompositionSurfaceFactory p) => (TerraFX.Interop.DirectX.IDCompositionSurfaceFactory*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionSurfaceFactory p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionSurfaceFactory p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionTableTransferEffect
{
    private readonly TerraFX.Interop.DirectX.IDCompositionTableTransferEffect* p;

    public TerraFX.Interop.DirectX.IDCompositionTableTransferEffect* Get() => this.p;

    public static implicit operator PIDCompositionTableTransferEffect(TerraFX.Interop.DirectX.IDCompositionTableTransferEffect* p) => *(PIDCompositionTableTransferEffect*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionTableTransferEffect*(PIDCompositionTableTransferEffect p) => (TerraFX.Interop.DirectX.IDCompositionTableTransferEffect*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionFilterEffect*(PIDCompositionTableTransferEffect p) => (TerraFX.Interop.DirectX.IDCompositionFilterEffect*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionEffect*(PIDCompositionTableTransferEffect p) => (TerraFX.Interop.DirectX.IDCompositionEffect*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionTableTransferEffect p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionTableTransferEffect p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionTarget
{
    private readonly TerraFX.Interop.DirectX.IDCompositionTarget* p;

    public TerraFX.Interop.DirectX.IDCompositionTarget* Get() => this.p;

    public static implicit operator PIDCompositionTarget(TerraFX.Interop.DirectX.IDCompositionTarget* p) => *(PIDCompositionTarget*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionTarget*(PIDCompositionTarget p) => (TerraFX.Interop.DirectX.IDCompositionTarget*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionTarget p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionTarget p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionTexture
{
    private readonly TerraFX.Interop.DirectX.IDCompositionTexture* p;

    public TerraFX.Interop.DirectX.IDCompositionTexture* Get() => this.p;

    public static implicit operator PIDCompositionTexture(TerraFX.Interop.DirectX.IDCompositionTexture* p) => *(PIDCompositionTexture*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionTexture*(PIDCompositionTexture p) => (TerraFX.Interop.DirectX.IDCompositionTexture*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionTexture p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionTexture p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionTransform
{
    private readonly TerraFX.Interop.DirectX.IDCompositionTransform* p;

    public TerraFX.Interop.DirectX.IDCompositionTransform* Get() => this.p;

    public static implicit operator PIDCompositionTransform(TerraFX.Interop.DirectX.IDCompositionTransform* p) => *(PIDCompositionTransform*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionTransform*(PIDCompositionTransform p) => (TerraFX.Interop.DirectX.IDCompositionTransform*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionTransform3D*(PIDCompositionTransform p) => (TerraFX.Interop.DirectX.IDCompositionTransform3D*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionEffect*(PIDCompositionTransform p) => (TerraFX.Interop.DirectX.IDCompositionEffect*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionTransform p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionTransform p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionTransform3D
{
    private readonly TerraFX.Interop.DirectX.IDCompositionTransform3D* p;

    public TerraFX.Interop.DirectX.IDCompositionTransform3D* Get() => this.p;

    public static implicit operator PIDCompositionTransform3D(TerraFX.Interop.DirectX.IDCompositionTransform3D* p) => *(PIDCompositionTransform3D*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionTransform3D*(PIDCompositionTransform3D p) => (TerraFX.Interop.DirectX.IDCompositionTransform3D*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionEffect*(PIDCompositionTransform3D p) => (TerraFX.Interop.DirectX.IDCompositionEffect*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionTransform3D p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionTransform3D p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionTranslateTransform
{
    private readonly TerraFX.Interop.DirectX.IDCompositionTranslateTransform* p;

    public TerraFX.Interop.DirectX.IDCompositionTranslateTransform* Get() => this.p;

    public static implicit operator PIDCompositionTranslateTransform(TerraFX.Interop.DirectX.IDCompositionTranslateTransform* p) => *(PIDCompositionTranslateTransform*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionTranslateTransform*(PIDCompositionTranslateTransform p) => (TerraFX.Interop.DirectX.IDCompositionTranslateTransform*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionTransform*(PIDCompositionTranslateTransform p) => (TerraFX.Interop.DirectX.IDCompositionTransform*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionTransform3D*(PIDCompositionTranslateTransform p) => (TerraFX.Interop.DirectX.IDCompositionTransform3D*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionEffect*(PIDCompositionTranslateTransform p) => (TerraFX.Interop.DirectX.IDCompositionEffect*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionTranslateTransform p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionTranslateTransform p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionTranslateTransform3D
{
    private readonly TerraFX.Interop.DirectX.IDCompositionTranslateTransform3D* p;

    public TerraFX.Interop.DirectX.IDCompositionTranslateTransform3D* Get() => this.p;

    public static implicit operator PIDCompositionTranslateTransform3D(TerraFX.Interop.DirectX.IDCompositionTranslateTransform3D* p) => *(PIDCompositionTranslateTransform3D*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionTranslateTransform3D*(PIDCompositionTranslateTransform3D p) => (TerraFX.Interop.DirectX.IDCompositionTranslateTransform3D*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionTransform3D*(PIDCompositionTranslateTransform3D p) => (TerraFX.Interop.DirectX.IDCompositionTransform3D*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionEffect*(PIDCompositionTranslateTransform3D p) => (TerraFX.Interop.DirectX.IDCompositionEffect*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionTranslateTransform3D p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionTranslateTransform3D p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionTurbulenceEffect
{
    private readonly TerraFX.Interop.DirectX.IDCompositionTurbulenceEffect* p;

    public TerraFX.Interop.DirectX.IDCompositionTurbulenceEffect* Get() => this.p;

    public static implicit operator PIDCompositionTurbulenceEffect(TerraFX.Interop.DirectX.IDCompositionTurbulenceEffect* p) => *(PIDCompositionTurbulenceEffect*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionTurbulenceEffect*(PIDCompositionTurbulenceEffect p) => (TerraFX.Interop.DirectX.IDCompositionTurbulenceEffect*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionFilterEffect*(PIDCompositionTurbulenceEffect p) => (TerraFX.Interop.DirectX.IDCompositionFilterEffect*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionEffect*(PIDCompositionTurbulenceEffect p) => (TerraFX.Interop.DirectX.IDCompositionEffect*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionTurbulenceEffect p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionTurbulenceEffect p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionVirtualSurface
{
    private readonly TerraFX.Interop.DirectX.IDCompositionVirtualSurface* p;

    public TerraFX.Interop.DirectX.IDCompositionVirtualSurface* Get() => this.p;

    public static implicit operator PIDCompositionVirtualSurface(TerraFX.Interop.DirectX.IDCompositionVirtualSurface* p) => *(PIDCompositionVirtualSurface*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionVirtualSurface*(PIDCompositionVirtualSurface p) => (TerraFX.Interop.DirectX.IDCompositionVirtualSurface*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionSurface*(PIDCompositionVirtualSurface p) => (TerraFX.Interop.DirectX.IDCompositionSurface*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionVirtualSurface p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionVirtualSurface p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionVisual
{
    private readonly TerraFX.Interop.DirectX.IDCompositionVisual* p;

    public TerraFX.Interop.DirectX.IDCompositionVisual* Get() => this.p;

    public static implicit operator PIDCompositionVisual(TerraFX.Interop.DirectX.IDCompositionVisual* p) => *(PIDCompositionVisual*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionVisual*(PIDCompositionVisual p) => (TerraFX.Interop.DirectX.IDCompositionVisual*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionVisual p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionVisual p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionVisual2
{
    private readonly TerraFX.Interop.DirectX.IDCompositionVisual2* p;

    public TerraFX.Interop.DirectX.IDCompositionVisual2* Get() => this.p;

    public static implicit operator PIDCompositionVisual2(TerraFX.Interop.DirectX.IDCompositionVisual2* p) => *(PIDCompositionVisual2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionVisual2*(PIDCompositionVisual2 p) => (TerraFX.Interop.DirectX.IDCompositionVisual2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionVisual*(PIDCompositionVisual2 p) => (TerraFX.Interop.DirectX.IDCompositionVisual*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionVisual2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionVisual2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionVisual3
{
    private readonly TerraFX.Interop.DirectX.IDCompositionVisual3* p;

    public TerraFX.Interop.DirectX.IDCompositionVisual3* Get() => this.p;

    public static implicit operator PIDCompositionVisual3(TerraFX.Interop.DirectX.IDCompositionVisual3* p) => *(PIDCompositionVisual3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionVisual3*(PIDCompositionVisual3 p) => (TerraFX.Interop.DirectX.IDCompositionVisual3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionVisualDebug*(PIDCompositionVisual3 p) => (TerraFX.Interop.DirectX.IDCompositionVisualDebug*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionVisual2*(PIDCompositionVisual3 p) => (TerraFX.Interop.DirectX.IDCompositionVisual2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionVisual*(PIDCompositionVisual3 p) => (TerraFX.Interop.DirectX.IDCompositionVisual*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionVisual3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionVisual3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDCompositionVisualDebug
{
    private readonly TerraFX.Interop.DirectX.IDCompositionVisualDebug* p;

    public TerraFX.Interop.DirectX.IDCompositionVisualDebug* Get() => this.p;

    public static implicit operator PIDCompositionVisualDebug(TerraFX.Interop.DirectX.IDCompositionVisualDebug* p) => *(PIDCompositionVisualDebug*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionVisualDebug*(PIDCompositionVisualDebug p) => (TerraFX.Interop.DirectX.IDCompositionVisualDebug*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionVisual2*(PIDCompositionVisualDebug p) => (TerraFX.Interop.DirectX.IDCompositionVisual2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDCompositionVisual*(PIDCompositionVisualDebug p) => (TerraFX.Interop.DirectX.IDCompositionVisual*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDCompositionVisualDebug p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDCompositionVisualDebug p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirect3D9
{
    private readonly TerraFX.Interop.DirectX.IDirect3D9* p;

    public TerraFX.Interop.DirectX.IDirect3D9* Get() => this.p;

    public static implicit operator PIDirect3D9(TerraFX.Interop.DirectX.IDirect3D9* p) => *(PIDirect3D9*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3D9*(PIDirect3D9 p) => (TerraFX.Interop.DirectX.IDirect3D9*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirect3D9 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirect3D9 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirect3D9Ex
{
    private readonly TerraFX.Interop.DirectX.IDirect3D9Ex* p;

    public TerraFX.Interop.DirectX.IDirect3D9Ex* Get() => this.p;

    public static implicit operator PIDirect3D9Ex(TerraFX.Interop.DirectX.IDirect3D9Ex* p) => *(PIDirect3D9Ex*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3D9Ex*(PIDirect3D9Ex p) => (TerraFX.Interop.DirectX.IDirect3D9Ex*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3D9*(PIDirect3D9Ex p) => (TerraFX.Interop.DirectX.IDirect3D9*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirect3D9Ex p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirect3D9Ex p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirect3D9ExOverlayExtension
{
    private readonly TerraFX.Interop.DirectX.IDirect3D9ExOverlayExtension* p;

    public TerraFX.Interop.DirectX.IDirect3D9ExOverlayExtension* Get() => this.p;

    public static implicit operator PIDirect3D9ExOverlayExtension(TerraFX.Interop.DirectX.IDirect3D9ExOverlayExtension* p) => *(PIDirect3D9ExOverlayExtension*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3D9ExOverlayExtension*(PIDirect3D9ExOverlayExtension p) => (TerraFX.Interop.DirectX.IDirect3D9ExOverlayExtension*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirect3D9ExOverlayExtension p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirect3D9ExOverlayExtension p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirect3DAuthenticatedChannel9
{
    private readonly TerraFX.Interop.DirectX.IDirect3DAuthenticatedChannel9* p;

    public TerraFX.Interop.DirectX.IDirect3DAuthenticatedChannel9* Get() => this.p;

    public static implicit operator PIDirect3DAuthenticatedChannel9(TerraFX.Interop.DirectX.IDirect3DAuthenticatedChannel9* p) => *(PIDirect3DAuthenticatedChannel9*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DAuthenticatedChannel9*(PIDirect3DAuthenticatedChannel9 p) => (TerraFX.Interop.DirectX.IDirect3DAuthenticatedChannel9*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirect3DAuthenticatedChannel9 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirect3DAuthenticatedChannel9 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirect3DBaseTexture9
{
    private readonly TerraFX.Interop.DirectX.IDirect3DBaseTexture9* p;

    public TerraFX.Interop.DirectX.IDirect3DBaseTexture9* Get() => this.p;

    public static implicit operator PIDirect3DBaseTexture9(TerraFX.Interop.DirectX.IDirect3DBaseTexture9* p) => *(PIDirect3DBaseTexture9*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DBaseTexture9*(PIDirect3DBaseTexture9 p) => (TerraFX.Interop.DirectX.IDirect3DBaseTexture9*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DResource9*(PIDirect3DBaseTexture9 p) => (TerraFX.Interop.DirectX.IDirect3DResource9*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirect3DBaseTexture9 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirect3DBaseTexture9 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirect3DCryptoSession9
{
    private readonly TerraFX.Interop.DirectX.IDirect3DCryptoSession9* p;

    public TerraFX.Interop.DirectX.IDirect3DCryptoSession9* Get() => this.p;

    public static implicit operator PIDirect3DCryptoSession9(TerraFX.Interop.DirectX.IDirect3DCryptoSession9* p) => *(PIDirect3DCryptoSession9*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DCryptoSession9*(PIDirect3DCryptoSession9 p) => (TerraFX.Interop.DirectX.IDirect3DCryptoSession9*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirect3DCryptoSession9 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirect3DCryptoSession9 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirect3DCubeTexture9
{
    private readonly TerraFX.Interop.DirectX.IDirect3DCubeTexture9* p;

    public TerraFX.Interop.DirectX.IDirect3DCubeTexture9* Get() => this.p;

    public static implicit operator PIDirect3DCubeTexture9(TerraFX.Interop.DirectX.IDirect3DCubeTexture9* p) => *(PIDirect3DCubeTexture9*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DCubeTexture9*(PIDirect3DCubeTexture9 p) => (TerraFX.Interop.DirectX.IDirect3DCubeTexture9*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DBaseTexture9*(PIDirect3DCubeTexture9 p) => (TerraFX.Interop.DirectX.IDirect3DBaseTexture9*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DResource9*(PIDirect3DCubeTexture9 p) => (TerraFX.Interop.DirectX.IDirect3DResource9*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirect3DCubeTexture9 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirect3DCubeTexture9 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirect3DDevice9
{
    private readonly TerraFX.Interop.DirectX.IDirect3DDevice9* p;

    public TerraFX.Interop.DirectX.IDirect3DDevice9* Get() => this.p;

    public static implicit operator PIDirect3DDevice9(TerraFX.Interop.DirectX.IDirect3DDevice9* p) => *(PIDirect3DDevice9*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DDevice9*(PIDirect3DDevice9 p) => (TerraFX.Interop.DirectX.IDirect3DDevice9*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirect3DDevice9 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirect3DDevice9 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirect3DDevice9Ex
{
    private readonly TerraFX.Interop.DirectX.IDirect3DDevice9Ex* p;

    public TerraFX.Interop.DirectX.IDirect3DDevice9Ex* Get() => this.p;

    public static implicit operator PIDirect3DDevice9Ex(TerraFX.Interop.DirectX.IDirect3DDevice9Ex* p) => *(PIDirect3DDevice9Ex*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DDevice9Ex*(PIDirect3DDevice9Ex p) => (TerraFX.Interop.DirectX.IDirect3DDevice9Ex*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DDevice9*(PIDirect3DDevice9Ex p) => (TerraFX.Interop.DirectX.IDirect3DDevice9*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirect3DDevice9Ex p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirect3DDevice9Ex p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirect3DDevice9Video
{
    private readonly TerraFX.Interop.DirectX.IDirect3DDevice9Video* p;

    public TerraFX.Interop.DirectX.IDirect3DDevice9Video* Get() => this.p;

    public static implicit operator PIDirect3DDevice9Video(TerraFX.Interop.DirectX.IDirect3DDevice9Video* p) => *(PIDirect3DDevice9Video*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DDevice9Video*(PIDirect3DDevice9Video p) => (TerraFX.Interop.DirectX.IDirect3DDevice9Video*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirect3DDevice9Video p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirect3DDevice9Video p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirect3DIndexBuffer9
{
    private readonly TerraFX.Interop.DirectX.IDirect3DIndexBuffer9* p;

    public TerraFX.Interop.DirectX.IDirect3DIndexBuffer9* Get() => this.p;

    public static implicit operator PIDirect3DIndexBuffer9(TerraFX.Interop.DirectX.IDirect3DIndexBuffer9* p) => *(PIDirect3DIndexBuffer9*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DIndexBuffer9*(PIDirect3DIndexBuffer9 p) => (TerraFX.Interop.DirectX.IDirect3DIndexBuffer9*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DResource9*(PIDirect3DIndexBuffer9 p) => (TerraFX.Interop.DirectX.IDirect3DResource9*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirect3DIndexBuffer9 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirect3DIndexBuffer9 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirect3DPixelShader9
{
    private readonly TerraFX.Interop.DirectX.IDirect3DPixelShader9* p;

    public TerraFX.Interop.DirectX.IDirect3DPixelShader9* Get() => this.p;

    public static implicit operator PIDirect3DPixelShader9(TerraFX.Interop.DirectX.IDirect3DPixelShader9* p) => *(PIDirect3DPixelShader9*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DPixelShader9*(PIDirect3DPixelShader9 p) => (TerraFX.Interop.DirectX.IDirect3DPixelShader9*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirect3DPixelShader9 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirect3DPixelShader9 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirect3DQuery9
{
    private readonly TerraFX.Interop.DirectX.IDirect3DQuery9* p;

    public TerraFX.Interop.DirectX.IDirect3DQuery9* Get() => this.p;

    public static implicit operator PIDirect3DQuery9(TerraFX.Interop.DirectX.IDirect3DQuery9* p) => *(PIDirect3DQuery9*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DQuery9*(PIDirect3DQuery9 p) => (TerraFX.Interop.DirectX.IDirect3DQuery9*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirect3DQuery9 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirect3DQuery9 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirect3DResource9
{
    private readonly TerraFX.Interop.DirectX.IDirect3DResource9* p;

    public TerraFX.Interop.DirectX.IDirect3DResource9* Get() => this.p;

    public static implicit operator PIDirect3DResource9(TerraFX.Interop.DirectX.IDirect3DResource9* p) => *(PIDirect3DResource9*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DResource9*(PIDirect3DResource9 p) => (TerraFX.Interop.DirectX.IDirect3DResource9*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirect3DResource9 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirect3DResource9 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirect3DStateBlock9
{
    private readonly TerraFX.Interop.DirectX.IDirect3DStateBlock9* p;

    public TerraFX.Interop.DirectX.IDirect3DStateBlock9* Get() => this.p;

    public static implicit operator PIDirect3DStateBlock9(TerraFX.Interop.DirectX.IDirect3DStateBlock9* p) => *(PIDirect3DStateBlock9*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DStateBlock9*(PIDirect3DStateBlock9 p) => (TerraFX.Interop.DirectX.IDirect3DStateBlock9*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirect3DStateBlock9 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirect3DStateBlock9 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirect3DSurface9
{
    private readonly TerraFX.Interop.DirectX.IDirect3DSurface9* p;

    public TerraFX.Interop.DirectX.IDirect3DSurface9* Get() => this.p;

    public static implicit operator PIDirect3DSurface9(TerraFX.Interop.DirectX.IDirect3DSurface9* p) => *(PIDirect3DSurface9*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DSurface9*(PIDirect3DSurface9 p) => (TerraFX.Interop.DirectX.IDirect3DSurface9*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DResource9*(PIDirect3DSurface9 p) => (TerraFX.Interop.DirectX.IDirect3DResource9*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirect3DSurface9 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirect3DSurface9 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirect3DSwapChain9
{
    private readonly TerraFX.Interop.DirectX.IDirect3DSwapChain9* p;

    public TerraFX.Interop.DirectX.IDirect3DSwapChain9* Get() => this.p;

    public static implicit operator PIDirect3DSwapChain9(TerraFX.Interop.DirectX.IDirect3DSwapChain9* p) => *(PIDirect3DSwapChain9*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DSwapChain9*(PIDirect3DSwapChain9 p) => (TerraFX.Interop.DirectX.IDirect3DSwapChain9*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirect3DSwapChain9 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirect3DSwapChain9 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirect3DSwapChain9Ex
{
    private readonly TerraFX.Interop.DirectX.IDirect3DSwapChain9Ex* p;

    public TerraFX.Interop.DirectX.IDirect3DSwapChain9Ex* Get() => this.p;

    public static implicit operator PIDirect3DSwapChain9Ex(TerraFX.Interop.DirectX.IDirect3DSwapChain9Ex* p) => *(PIDirect3DSwapChain9Ex*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DSwapChain9Ex*(PIDirect3DSwapChain9Ex p) => (TerraFX.Interop.DirectX.IDirect3DSwapChain9Ex*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DSwapChain9*(PIDirect3DSwapChain9Ex p) => (TerraFX.Interop.DirectX.IDirect3DSwapChain9*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirect3DSwapChain9Ex p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirect3DSwapChain9Ex p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirect3DTexture9
{
    private readonly TerraFX.Interop.DirectX.IDirect3DTexture9* p;

    public TerraFX.Interop.DirectX.IDirect3DTexture9* Get() => this.p;

    public static implicit operator PIDirect3DTexture9(TerraFX.Interop.DirectX.IDirect3DTexture9* p) => *(PIDirect3DTexture9*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DTexture9*(PIDirect3DTexture9 p) => (TerraFX.Interop.DirectX.IDirect3DTexture9*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DBaseTexture9*(PIDirect3DTexture9 p) => (TerraFX.Interop.DirectX.IDirect3DBaseTexture9*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DResource9*(PIDirect3DTexture9 p) => (TerraFX.Interop.DirectX.IDirect3DResource9*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirect3DTexture9 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirect3DTexture9 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirect3DVertexBuffer9
{
    private readonly TerraFX.Interop.DirectX.IDirect3DVertexBuffer9* p;

    public TerraFX.Interop.DirectX.IDirect3DVertexBuffer9* Get() => this.p;

    public static implicit operator PIDirect3DVertexBuffer9(TerraFX.Interop.DirectX.IDirect3DVertexBuffer9* p) => *(PIDirect3DVertexBuffer9*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DVertexBuffer9*(PIDirect3DVertexBuffer9 p) => (TerraFX.Interop.DirectX.IDirect3DVertexBuffer9*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DResource9*(PIDirect3DVertexBuffer9 p) => (TerraFX.Interop.DirectX.IDirect3DResource9*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirect3DVertexBuffer9 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirect3DVertexBuffer9 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirect3DVertexDeclaration9
{
    private readonly TerraFX.Interop.DirectX.IDirect3DVertexDeclaration9* p;

    public TerraFX.Interop.DirectX.IDirect3DVertexDeclaration9* Get() => this.p;

    public static implicit operator PIDirect3DVertexDeclaration9(TerraFX.Interop.DirectX.IDirect3DVertexDeclaration9* p) => *(PIDirect3DVertexDeclaration9*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DVertexDeclaration9*(PIDirect3DVertexDeclaration9 p) => (TerraFX.Interop.DirectX.IDirect3DVertexDeclaration9*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirect3DVertexDeclaration9 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirect3DVertexDeclaration9 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirect3DVertexShader9
{
    private readonly TerraFX.Interop.DirectX.IDirect3DVertexShader9* p;

    public TerraFX.Interop.DirectX.IDirect3DVertexShader9* Get() => this.p;

    public static implicit operator PIDirect3DVertexShader9(TerraFX.Interop.DirectX.IDirect3DVertexShader9* p) => *(PIDirect3DVertexShader9*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DVertexShader9*(PIDirect3DVertexShader9 p) => (TerraFX.Interop.DirectX.IDirect3DVertexShader9*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirect3DVertexShader9 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirect3DVertexShader9 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirect3DVolume9
{
    private readonly TerraFX.Interop.DirectX.IDirect3DVolume9* p;

    public TerraFX.Interop.DirectX.IDirect3DVolume9* Get() => this.p;

    public static implicit operator PIDirect3DVolume9(TerraFX.Interop.DirectX.IDirect3DVolume9* p) => *(PIDirect3DVolume9*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DVolume9*(PIDirect3DVolume9 p) => (TerraFX.Interop.DirectX.IDirect3DVolume9*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirect3DVolume9 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirect3DVolume9 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirect3DVolumeTexture9
{
    private readonly TerraFX.Interop.DirectX.IDirect3DVolumeTexture9* p;

    public TerraFX.Interop.DirectX.IDirect3DVolumeTexture9* Get() => this.p;

    public static implicit operator PIDirect3DVolumeTexture9(TerraFX.Interop.DirectX.IDirect3DVolumeTexture9* p) => *(PIDirect3DVolumeTexture9*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DVolumeTexture9*(PIDirect3DVolumeTexture9 p) => (TerraFX.Interop.DirectX.IDirect3DVolumeTexture9*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DBaseTexture9*(PIDirect3DVolumeTexture9 p) => (TerraFX.Interop.DirectX.IDirect3DBaseTexture9*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirect3DResource9*(PIDirect3DVolumeTexture9 p) => (TerraFX.Interop.DirectX.IDirect3DResource9*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirect3DVolumeTexture9 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirect3DVolumeTexture9 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectDraw
{
    private readonly TerraFX.Interop.DirectX.IDirectDraw* p;

    public TerraFX.Interop.DirectX.IDirectDraw* Get() => this.p;

    public static implicit operator PIDirectDraw(TerraFX.Interop.DirectX.IDirectDraw* p) => *(PIDirectDraw*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectDraw*(PIDirectDraw p) => (TerraFX.Interop.DirectX.IDirectDraw*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectDraw p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectDraw p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectDraw2
{
    private readonly TerraFX.Interop.DirectX.IDirectDraw2* p;

    public TerraFX.Interop.DirectX.IDirectDraw2* Get() => this.p;

    public static implicit operator PIDirectDraw2(TerraFX.Interop.DirectX.IDirectDraw2* p) => *(PIDirectDraw2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectDraw2*(PIDirectDraw2 p) => (TerraFX.Interop.DirectX.IDirectDraw2*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectDraw2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectDraw2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectDraw4
{
    private readonly TerraFX.Interop.DirectX.IDirectDraw4* p;

    public TerraFX.Interop.DirectX.IDirectDraw4* Get() => this.p;

    public static implicit operator PIDirectDraw4(TerraFX.Interop.DirectX.IDirectDraw4* p) => *(PIDirectDraw4*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectDraw4*(PIDirectDraw4 p) => (TerraFX.Interop.DirectX.IDirectDraw4*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectDraw4 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectDraw4 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectDraw7
{
    private readonly TerraFX.Interop.DirectX.IDirectDraw7* p;

    public TerraFX.Interop.DirectX.IDirectDraw7* Get() => this.p;

    public static implicit operator PIDirectDraw7(TerraFX.Interop.DirectX.IDirectDraw7* p) => *(PIDirectDraw7*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectDraw7*(PIDirectDraw7 p) => (TerraFX.Interop.DirectX.IDirectDraw7*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectDraw7 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectDraw7 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectDrawClipper
{
    private readonly TerraFX.Interop.DirectX.IDirectDrawClipper* p;

    public TerraFX.Interop.DirectX.IDirectDrawClipper* Get() => this.p;

    public static implicit operator PIDirectDrawClipper(TerraFX.Interop.DirectX.IDirectDrawClipper* p) => *(PIDirectDrawClipper*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectDrawClipper*(PIDirectDrawClipper p) => (TerraFX.Interop.DirectX.IDirectDrawClipper*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectDrawClipper p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectDrawClipper p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectDrawColorControl
{
    private readonly TerraFX.Interop.DirectX.IDirectDrawColorControl* p;

    public TerraFX.Interop.DirectX.IDirectDrawColorControl* Get() => this.p;

    public static implicit operator PIDirectDrawColorControl(TerraFX.Interop.DirectX.IDirectDrawColorControl* p) => *(PIDirectDrawColorControl*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectDrawColorControl*(PIDirectDrawColorControl p) => (TerraFX.Interop.DirectX.IDirectDrawColorControl*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectDrawColorControl p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectDrawColorControl p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectDrawGammaControl
{
    private readonly TerraFX.Interop.DirectX.IDirectDrawGammaControl* p;

    public TerraFX.Interop.DirectX.IDirectDrawGammaControl* Get() => this.p;

    public static implicit operator PIDirectDrawGammaControl(TerraFX.Interop.DirectX.IDirectDrawGammaControl* p) => *(PIDirectDrawGammaControl*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectDrawGammaControl*(PIDirectDrawGammaControl p) => (TerraFX.Interop.DirectX.IDirectDrawGammaControl*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectDrawGammaControl p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectDrawGammaControl p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectDrawPalette
{
    private readonly TerraFX.Interop.DirectX.IDirectDrawPalette* p;

    public TerraFX.Interop.DirectX.IDirectDrawPalette* Get() => this.p;

    public static implicit operator PIDirectDrawPalette(TerraFX.Interop.DirectX.IDirectDrawPalette* p) => *(PIDirectDrawPalette*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectDrawPalette*(PIDirectDrawPalette p) => (TerraFX.Interop.DirectX.IDirectDrawPalette*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectDrawPalette p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectDrawPalette p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectDrawSurface
{
    private readonly TerraFX.Interop.DirectX.IDirectDrawSurface* p;

    public TerraFX.Interop.DirectX.IDirectDrawSurface* Get() => this.p;

    public static implicit operator PIDirectDrawSurface(TerraFX.Interop.DirectX.IDirectDrawSurface* p) => *(PIDirectDrawSurface*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectDrawSurface*(PIDirectDrawSurface p) => (TerraFX.Interop.DirectX.IDirectDrawSurface*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectDrawSurface p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectDrawSurface p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectDrawSurface2
{
    private readonly TerraFX.Interop.DirectX.IDirectDrawSurface2* p;

    public TerraFX.Interop.DirectX.IDirectDrawSurface2* Get() => this.p;

    public static implicit operator PIDirectDrawSurface2(TerraFX.Interop.DirectX.IDirectDrawSurface2* p) => *(PIDirectDrawSurface2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectDrawSurface2*(PIDirectDrawSurface2 p) => (TerraFX.Interop.DirectX.IDirectDrawSurface2*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectDrawSurface2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectDrawSurface2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectDrawSurface3
{
    private readonly TerraFX.Interop.DirectX.IDirectDrawSurface3* p;

    public TerraFX.Interop.DirectX.IDirectDrawSurface3* Get() => this.p;

    public static implicit operator PIDirectDrawSurface3(TerraFX.Interop.DirectX.IDirectDrawSurface3* p) => *(PIDirectDrawSurface3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectDrawSurface3*(PIDirectDrawSurface3 p) => (TerraFX.Interop.DirectX.IDirectDrawSurface3*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectDrawSurface3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectDrawSurface3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectDrawSurface4
{
    private readonly TerraFX.Interop.DirectX.IDirectDrawSurface4* p;

    public TerraFX.Interop.DirectX.IDirectDrawSurface4* Get() => this.p;

    public static implicit operator PIDirectDrawSurface4(TerraFX.Interop.DirectX.IDirectDrawSurface4* p) => *(PIDirectDrawSurface4*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectDrawSurface4*(PIDirectDrawSurface4 p) => (TerraFX.Interop.DirectX.IDirectDrawSurface4*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectDrawSurface4 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectDrawSurface4 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectDrawSurface7
{
    private readonly TerraFX.Interop.DirectX.IDirectDrawSurface7* p;

    public TerraFX.Interop.DirectX.IDirectDrawSurface7* Get() => this.p;

    public static implicit operator PIDirectDrawSurface7(TerraFX.Interop.DirectX.IDirectDrawSurface7* p) => *(PIDirectDrawSurface7*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectDrawSurface7*(PIDirectDrawSurface7 p) => (TerraFX.Interop.DirectX.IDirectDrawSurface7*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectDrawSurface7 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectDrawSurface7 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectInput2A
{
    private readonly TerraFX.Interop.DirectX.IDirectInput2A* p;

    public TerraFX.Interop.DirectX.IDirectInput2A* Get() => this.p;

    public static implicit operator PIDirectInput2A(TerraFX.Interop.DirectX.IDirectInput2A* p) => *(PIDirectInput2A*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectInput2A*(PIDirectInput2A p) => (TerraFX.Interop.DirectX.IDirectInput2A*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectInputA*(PIDirectInput2A p) => (TerraFX.Interop.DirectX.IDirectInputA*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectInput2A p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectInput2A p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectInput2W
{
    private readonly TerraFX.Interop.DirectX.IDirectInput2W* p;

    public TerraFX.Interop.DirectX.IDirectInput2W* Get() => this.p;

    public static implicit operator PIDirectInput2W(TerraFX.Interop.DirectX.IDirectInput2W* p) => *(PIDirectInput2W*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectInput2W*(PIDirectInput2W p) => (TerraFX.Interop.DirectX.IDirectInput2W*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectInputW*(PIDirectInput2W p) => (TerraFX.Interop.DirectX.IDirectInputW*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectInput2W p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectInput2W p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectInput7A
{
    private readonly TerraFX.Interop.DirectX.IDirectInput7A* p;

    public TerraFX.Interop.DirectX.IDirectInput7A* Get() => this.p;

    public static implicit operator PIDirectInput7A(TerraFX.Interop.DirectX.IDirectInput7A* p) => *(PIDirectInput7A*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectInput7A*(PIDirectInput7A p) => (TerraFX.Interop.DirectX.IDirectInput7A*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectInput2A*(PIDirectInput7A p) => (TerraFX.Interop.DirectX.IDirectInput2A*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectInputA*(PIDirectInput7A p) => (TerraFX.Interop.DirectX.IDirectInputA*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectInput7A p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectInput7A p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectInput7W
{
    private readonly TerraFX.Interop.DirectX.IDirectInput7W* p;

    public TerraFX.Interop.DirectX.IDirectInput7W* Get() => this.p;

    public static implicit operator PIDirectInput7W(TerraFX.Interop.DirectX.IDirectInput7W* p) => *(PIDirectInput7W*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectInput7W*(PIDirectInput7W p) => (TerraFX.Interop.DirectX.IDirectInput7W*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectInput2W*(PIDirectInput7W p) => (TerraFX.Interop.DirectX.IDirectInput2W*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectInputW*(PIDirectInput7W p) => (TerraFX.Interop.DirectX.IDirectInputW*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectInput7W p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectInput7W p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectInput8A
{
    private readonly TerraFX.Interop.DirectX.IDirectInput8A* p;

    public TerraFX.Interop.DirectX.IDirectInput8A* Get() => this.p;

    public static implicit operator PIDirectInput8A(TerraFX.Interop.DirectX.IDirectInput8A* p) => *(PIDirectInput8A*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectInput8A*(PIDirectInput8A p) => (TerraFX.Interop.DirectX.IDirectInput8A*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectInput8A p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectInput8A p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectInput8W
{
    private readonly TerraFX.Interop.DirectX.IDirectInput8W* p;

    public TerraFX.Interop.DirectX.IDirectInput8W* Get() => this.p;

    public static implicit operator PIDirectInput8W(TerraFX.Interop.DirectX.IDirectInput8W* p) => *(PIDirectInput8W*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectInput8W*(PIDirectInput8W p) => (TerraFX.Interop.DirectX.IDirectInput8W*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectInput8W p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectInput8W p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectInputA
{
    private readonly TerraFX.Interop.DirectX.IDirectInputA* p;

    public TerraFX.Interop.DirectX.IDirectInputA* Get() => this.p;

    public static implicit operator PIDirectInputA(TerraFX.Interop.DirectX.IDirectInputA* p) => *(PIDirectInputA*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectInputA*(PIDirectInputA p) => (TerraFX.Interop.DirectX.IDirectInputA*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectInputA p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectInputA p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectInputDevice2A
{
    private readonly TerraFX.Interop.DirectX.IDirectInputDevice2A* p;

    public TerraFX.Interop.DirectX.IDirectInputDevice2A* Get() => this.p;

    public static implicit operator PIDirectInputDevice2A(TerraFX.Interop.DirectX.IDirectInputDevice2A* p) => *(PIDirectInputDevice2A*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectInputDevice2A*(PIDirectInputDevice2A p) => (TerraFX.Interop.DirectX.IDirectInputDevice2A*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectInputDeviceA*(PIDirectInputDevice2A p) => (TerraFX.Interop.DirectX.IDirectInputDeviceA*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectInputDevice2A p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectInputDevice2A p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectInputDevice2W
{
    private readonly TerraFX.Interop.DirectX.IDirectInputDevice2W* p;

    public TerraFX.Interop.DirectX.IDirectInputDevice2W* Get() => this.p;

    public static implicit operator PIDirectInputDevice2W(TerraFX.Interop.DirectX.IDirectInputDevice2W* p) => *(PIDirectInputDevice2W*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectInputDevice2W*(PIDirectInputDevice2W p) => (TerraFX.Interop.DirectX.IDirectInputDevice2W*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectInputDeviceW*(PIDirectInputDevice2W p) => (TerraFX.Interop.DirectX.IDirectInputDeviceW*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectInputDevice2W p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectInputDevice2W p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectInputDevice7A
{
    private readonly TerraFX.Interop.DirectX.IDirectInputDevice7A* p;

    public TerraFX.Interop.DirectX.IDirectInputDevice7A* Get() => this.p;

    public static implicit operator PIDirectInputDevice7A(TerraFX.Interop.DirectX.IDirectInputDevice7A* p) => *(PIDirectInputDevice7A*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectInputDevice7A*(PIDirectInputDevice7A p) => (TerraFX.Interop.DirectX.IDirectInputDevice7A*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectInputDevice2A*(PIDirectInputDevice7A p) => (TerraFX.Interop.DirectX.IDirectInputDevice2A*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectInputDeviceA*(PIDirectInputDevice7A p) => (TerraFX.Interop.DirectX.IDirectInputDeviceA*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectInputDevice7A p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectInputDevice7A p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectInputDevice7W
{
    private readonly TerraFX.Interop.DirectX.IDirectInputDevice7W* p;

    public TerraFX.Interop.DirectX.IDirectInputDevice7W* Get() => this.p;

    public static implicit operator PIDirectInputDevice7W(TerraFX.Interop.DirectX.IDirectInputDevice7W* p) => *(PIDirectInputDevice7W*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectInputDevice7W*(PIDirectInputDevice7W p) => (TerraFX.Interop.DirectX.IDirectInputDevice7W*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectInputDevice2W*(PIDirectInputDevice7W p) => (TerraFX.Interop.DirectX.IDirectInputDevice2W*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectInputDeviceW*(PIDirectInputDevice7W p) => (TerraFX.Interop.DirectX.IDirectInputDeviceW*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectInputDevice7W p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectInputDevice7W p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectInputDevice8A
{
    private readonly TerraFX.Interop.DirectX.IDirectInputDevice8A* p;

    public TerraFX.Interop.DirectX.IDirectInputDevice8A* Get() => this.p;

    public static implicit operator PIDirectInputDevice8A(TerraFX.Interop.DirectX.IDirectInputDevice8A* p) => *(PIDirectInputDevice8A*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectInputDevice8A*(PIDirectInputDevice8A p) => (TerraFX.Interop.DirectX.IDirectInputDevice8A*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectInputDevice8A p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectInputDevice8A p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectInputDevice8W
{
    private readonly TerraFX.Interop.DirectX.IDirectInputDevice8W* p;

    public TerraFX.Interop.DirectX.IDirectInputDevice8W* Get() => this.p;

    public static implicit operator PIDirectInputDevice8W(TerraFX.Interop.DirectX.IDirectInputDevice8W* p) => *(PIDirectInputDevice8W*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectInputDevice8W*(PIDirectInputDevice8W p) => (TerraFX.Interop.DirectX.IDirectInputDevice8W*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectInputDevice8W p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectInputDevice8W p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectInputDeviceA
{
    private readonly TerraFX.Interop.DirectX.IDirectInputDeviceA* p;

    public TerraFX.Interop.DirectX.IDirectInputDeviceA* Get() => this.p;

    public static implicit operator PIDirectInputDeviceA(TerraFX.Interop.DirectX.IDirectInputDeviceA* p) => *(PIDirectInputDeviceA*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectInputDeviceA*(PIDirectInputDeviceA p) => (TerraFX.Interop.DirectX.IDirectInputDeviceA*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectInputDeviceA p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectInputDeviceA p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectInputDeviceW
{
    private readonly TerraFX.Interop.DirectX.IDirectInputDeviceW* p;

    public TerraFX.Interop.DirectX.IDirectInputDeviceW* Get() => this.p;

    public static implicit operator PIDirectInputDeviceW(TerraFX.Interop.DirectX.IDirectInputDeviceW* p) => *(PIDirectInputDeviceW*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectInputDeviceW*(PIDirectInputDeviceW p) => (TerraFX.Interop.DirectX.IDirectInputDeviceW*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectInputDeviceW p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectInputDeviceW p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectInputEffect
{
    private readonly TerraFX.Interop.DirectX.IDirectInputEffect* p;

    public TerraFX.Interop.DirectX.IDirectInputEffect* Get() => this.p;

    public static implicit operator PIDirectInputEffect(TerraFX.Interop.DirectX.IDirectInputEffect* p) => *(PIDirectInputEffect*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectInputEffect*(PIDirectInputEffect p) => (TerraFX.Interop.DirectX.IDirectInputEffect*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectInputEffect p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectInputEffect p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectInputW
{
    private readonly TerraFX.Interop.DirectX.IDirectInputW* p;

    public TerraFX.Interop.DirectX.IDirectInputW* Get() => this.p;

    public static implicit operator PIDirectInputW(TerraFX.Interop.DirectX.IDirectInputW* p) => *(PIDirectInputW*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectInputW*(PIDirectInputW p) => (TerraFX.Interop.DirectX.IDirectInputW*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectInputW p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectInputW p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectManipulationAutoScrollBehavior
{
    private readonly TerraFX.Interop.DirectX.IDirectManipulationAutoScrollBehavior* p;

    public TerraFX.Interop.DirectX.IDirectManipulationAutoScrollBehavior* Get() => this.p;

    public static implicit operator PIDirectManipulationAutoScrollBehavior(TerraFX.Interop.DirectX.IDirectManipulationAutoScrollBehavior* p) => *(PIDirectManipulationAutoScrollBehavior*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectManipulationAutoScrollBehavior*(PIDirectManipulationAutoScrollBehavior p) => (TerraFX.Interop.DirectX.IDirectManipulationAutoScrollBehavior*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectManipulationAutoScrollBehavior p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectManipulationAutoScrollBehavior p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectManipulationCompositor
{
    private readonly TerraFX.Interop.DirectX.IDirectManipulationCompositor* p;

    public TerraFX.Interop.DirectX.IDirectManipulationCompositor* Get() => this.p;

    public static implicit operator PIDirectManipulationCompositor(TerraFX.Interop.DirectX.IDirectManipulationCompositor* p) => *(PIDirectManipulationCompositor*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectManipulationCompositor*(PIDirectManipulationCompositor p) => (TerraFX.Interop.DirectX.IDirectManipulationCompositor*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectManipulationCompositor p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectManipulationCompositor p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectManipulationCompositor2
{
    private readonly TerraFX.Interop.DirectX.IDirectManipulationCompositor2* p;

    public TerraFX.Interop.DirectX.IDirectManipulationCompositor2* Get() => this.p;

    public static implicit operator PIDirectManipulationCompositor2(TerraFX.Interop.DirectX.IDirectManipulationCompositor2* p) => *(PIDirectManipulationCompositor2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectManipulationCompositor2*(PIDirectManipulationCompositor2 p) => (TerraFX.Interop.DirectX.IDirectManipulationCompositor2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectManipulationCompositor*(PIDirectManipulationCompositor2 p) => (TerraFX.Interop.DirectX.IDirectManipulationCompositor*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectManipulationCompositor2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectManipulationCompositor2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectManipulationContent
{
    private readonly TerraFX.Interop.DirectX.IDirectManipulationContent* p;

    public TerraFX.Interop.DirectX.IDirectManipulationContent* Get() => this.p;

    public static implicit operator PIDirectManipulationContent(TerraFX.Interop.DirectX.IDirectManipulationContent* p) => *(PIDirectManipulationContent*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectManipulationContent*(PIDirectManipulationContent p) => (TerraFX.Interop.DirectX.IDirectManipulationContent*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectManipulationContent p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectManipulationContent p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectManipulationDeferContactService
{
    private readonly TerraFX.Interop.DirectX.IDirectManipulationDeferContactService* p;

    public TerraFX.Interop.DirectX.IDirectManipulationDeferContactService* Get() => this.p;

    public static implicit operator PIDirectManipulationDeferContactService(TerraFX.Interop.DirectX.IDirectManipulationDeferContactService* p) => *(PIDirectManipulationDeferContactService*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectManipulationDeferContactService*(PIDirectManipulationDeferContactService p) => (TerraFX.Interop.DirectX.IDirectManipulationDeferContactService*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectManipulationDeferContactService p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectManipulationDeferContactService p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectManipulationDragDropBehavior
{
    private readonly TerraFX.Interop.DirectX.IDirectManipulationDragDropBehavior* p;

    public TerraFX.Interop.DirectX.IDirectManipulationDragDropBehavior* Get() => this.p;

    public static implicit operator PIDirectManipulationDragDropBehavior(TerraFX.Interop.DirectX.IDirectManipulationDragDropBehavior* p) => *(PIDirectManipulationDragDropBehavior*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectManipulationDragDropBehavior*(PIDirectManipulationDragDropBehavior p) => (TerraFX.Interop.DirectX.IDirectManipulationDragDropBehavior*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectManipulationDragDropBehavior p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectManipulationDragDropBehavior p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectManipulationDragDropEventHandler
{
    private readonly TerraFX.Interop.DirectX.IDirectManipulationDragDropEventHandler* p;

    public TerraFX.Interop.DirectX.IDirectManipulationDragDropEventHandler* Get() => this.p;

    public static implicit operator PIDirectManipulationDragDropEventHandler(TerraFX.Interop.DirectX.IDirectManipulationDragDropEventHandler* p) => *(PIDirectManipulationDragDropEventHandler*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectManipulationDragDropEventHandler*(PIDirectManipulationDragDropEventHandler p) => (TerraFX.Interop.DirectX.IDirectManipulationDragDropEventHandler*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectManipulationDragDropEventHandler p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectManipulationDragDropEventHandler p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectManipulationFrameInfoProvider
{
    private readonly TerraFX.Interop.DirectX.IDirectManipulationFrameInfoProvider* p;

    public TerraFX.Interop.DirectX.IDirectManipulationFrameInfoProvider* Get() => this.p;

    public static implicit operator PIDirectManipulationFrameInfoProvider(TerraFX.Interop.DirectX.IDirectManipulationFrameInfoProvider* p) => *(PIDirectManipulationFrameInfoProvider*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectManipulationFrameInfoProvider*(PIDirectManipulationFrameInfoProvider p) => (TerraFX.Interop.DirectX.IDirectManipulationFrameInfoProvider*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectManipulationFrameInfoProvider p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectManipulationFrameInfoProvider p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectManipulationInteractionEventHandler
{
    private readonly TerraFX.Interop.DirectX.IDirectManipulationInteractionEventHandler* p;

    public TerraFX.Interop.DirectX.IDirectManipulationInteractionEventHandler* Get() => this.p;

    public static implicit operator PIDirectManipulationInteractionEventHandler(TerraFX.Interop.DirectX.IDirectManipulationInteractionEventHandler* p) => *(PIDirectManipulationInteractionEventHandler*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectManipulationInteractionEventHandler*(PIDirectManipulationInteractionEventHandler p) => (TerraFX.Interop.DirectX.IDirectManipulationInteractionEventHandler*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectManipulationInteractionEventHandler p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectManipulationInteractionEventHandler p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectManipulationManager
{
    private readonly TerraFX.Interop.DirectX.IDirectManipulationManager* p;

    public TerraFX.Interop.DirectX.IDirectManipulationManager* Get() => this.p;

    public static implicit operator PIDirectManipulationManager(TerraFX.Interop.DirectX.IDirectManipulationManager* p) => *(PIDirectManipulationManager*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectManipulationManager*(PIDirectManipulationManager p) => (TerraFX.Interop.DirectX.IDirectManipulationManager*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectManipulationManager p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectManipulationManager p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectManipulationManager2
{
    private readonly TerraFX.Interop.DirectX.IDirectManipulationManager2* p;

    public TerraFX.Interop.DirectX.IDirectManipulationManager2* Get() => this.p;

    public static implicit operator PIDirectManipulationManager2(TerraFX.Interop.DirectX.IDirectManipulationManager2* p) => *(PIDirectManipulationManager2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectManipulationManager2*(PIDirectManipulationManager2 p) => (TerraFX.Interop.DirectX.IDirectManipulationManager2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectManipulationManager*(PIDirectManipulationManager2 p) => (TerraFX.Interop.DirectX.IDirectManipulationManager*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectManipulationManager2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectManipulationManager2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectManipulationManager3
{
    private readonly TerraFX.Interop.DirectX.IDirectManipulationManager3* p;

    public TerraFX.Interop.DirectX.IDirectManipulationManager3* Get() => this.p;

    public static implicit operator PIDirectManipulationManager3(TerraFX.Interop.DirectX.IDirectManipulationManager3* p) => *(PIDirectManipulationManager3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectManipulationManager3*(PIDirectManipulationManager3 p) => (TerraFX.Interop.DirectX.IDirectManipulationManager3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectManipulationManager2*(PIDirectManipulationManager3 p) => (TerraFX.Interop.DirectX.IDirectManipulationManager2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectManipulationManager*(PIDirectManipulationManager3 p) => (TerraFX.Interop.DirectX.IDirectManipulationManager*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectManipulationManager3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectManipulationManager3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectManipulationPrimaryContent
{
    private readonly TerraFX.Interop.DirectX.IDirectManipulationPrimaryContent* p;

    public TerraFX.Interop.DirectX.IDirectManipulationPrimaryContent* Get() => this.p;

    public static implicit operator PIDirectManipulationPrimaryContent(TerraFX.Interop.DirectX.IDirectManipulationPrimaryContent* p) => *(PIDirectManipulationPrimaryContent*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectManipulationPrimaryContent*(PIDirectManipulationPrimaryContent p) => (TerraFX.Interop.DirectX.IDirectManipulationPrimaryContent*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectManipulationPrimaryContent p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectManipulationPrimaryContent p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectManipulationUpdateHandler
{
    private readonly TerraFX.Interop.DirectX.IDirectManipulationUpdateHandler* p;

    public TerraFX.Interop.DirectX.IDirectManipulationUpdateHandler* Get() => this.p;

    public static implicit operator PIDirectManipulationUpdateHandler(TerraFX.Interop.DirectX.IDirectManipulationUpdateHandler* p) => *(PIDirectManipulationUpdateHandler*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectManipulationUpdateHandler*(PIDirectManipulationUpdateHandler p) => (TerraFX.Interop.DirectX.IDirectManipulationUpdateHandler*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectManipulationUpdateHandler p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectManipulationUpdateHandler p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectManipulationUpdateManager
{
    private readonly TerraFX.Interop.DirectX.IDirectManipulationUpdateManager* p;

    public TerraFX.Interop.DirectX.IDirectManipulationUpdateManager* Get() => this.p;

    public static implicit operator PIDirectManipulationUpdateManager(TerraFX.Interop.DirectX.IDirectManipulationUpdateManager* p) => *(PIDirectManipulationUpdateManager*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectManipulationUpdateManager*(PIDirectManipulationUpdateManager p) => (TerraFX.Interop.DirectX.IDirectManipulationUpdateManager*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectManipulationUpdateManager p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectManipulationUpdateManager p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectManipulationViewport
{
    private readonly TerraFX.Interop.DirectX.IDirectManipulationViewport* p;

    public TerraFX.Interop.DirectX.IDirectManipulationViewport* Get() => this.p;

    public static implicit operator PIDirectManipulationViewport(TerraFX.Interop.DirectX.IDirectManipulationViewport* p) => *(PIDirectManipulationViewport*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectManipulationViewport*(PIDirectManipulationViewport p) => (TerraFX.Interop.DirectX.IDirectManipulationViewport*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectManipulationViewport p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectManipulationViewport p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectManipulationViewport2
{
    private readonly TerraFX.Interop.DirectX.IDirectManipulationViewport2* p;

    public TerraFX.Interop.DirectX.IDirectManipulationViewport2* Get() => this.p;

    public static implicit operator PIDirectManipulationViewport2(TerraFX.Interop.DirectX.IDirectManipulationViewport2* p) => *(PIDirectManipulationViewport2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectManipulationViewport2*(PIDirectManipulationViewport2 p) => (TerraFX.Interop.DirectX.IDirectManipulationViewport2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectManipulationViewport*(PIDirectManipulationViewport2 p) => (TerraFX.Interop.DirectX.IDirectManipulationViewport*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectManipulationViewport2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectManipulationViewport2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDirectManipulationViewportEventHandler
{
    private readonly TerraFX.Interop.DirectX.IDirectManipulationViewportEventHandler* p;

    public TerraFX.Interop.DirectX.IDirectManipulationViewportEventHandler* Get() => this.p;

    public static implicit operator PIDirectManipulationViewportEventHandler(TerraFX.Interop.DirectX.IDirectManipulationViewportEventHandler* p) => *(PIDirectManipulationViewportEventHandler*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDirectManipulationViewportEventHandler*(PIDirectManipulationViewportEventHandler p) => (TerraFX.Interop.DirectX.IDirectManipulationViewportEventHandler*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDirectManipulationViewportEventHandler p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDirectManipulationViewportEventHandler p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDMLBindingTable
{
    private readonly TerraFX.Interop.DirectX.IDMLBindingTable* p;

    public TerraFX.Interop.DirectX.IDMLBindingTable* Get() => this.p;

    public static implicit operator PIDMLBindingTable(TerraFX.Interop.DirectX.IDMLBindingTable* p) => *(PIDMLBindingTable*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLBindingTable*(PIDMLBindingTable p) => (TerraFX.Interop.DirectX.IDMLBindingTable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLDeviceChild*(PIDMLBindingTable p) => (TerraFX.Interop.DirectX.IDMLDeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLObject*(PIDMLBindingTable p) => (TerraFX.Interop.DirectX.IDMLObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDMLBindingTable p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDMLBindingTable p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDMLCommandRecorder
{
    private readonly TerraFX.Interop.DirectX.IDMLCommandRecorder* p;

    public TerraFX.Interop.DirectX.IDMLCommandRecorder* Get() => this.p;

    public static implicit operator PIDMLCommandRecorder(TerraFX.Interop.DirectX.IDMLCommandRecorder* p) => *(PIDMLCommandRecorder*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLCommandRecorder*(PIDMLCommandRecorder p) => (TerraFX.Interop.DirectX.IDMLCommandRecorder*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLDeviceChild*(PIDMLCommandRecorder p) => (TerraFX.Interop.DirectX.IDMLDeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLObject*(PIDMLCommandRecorder p) => (TerraFX.Interop.DirectX.IDMLObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDMLCommandRecorder p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDMLCommandRecorder p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDMLCompiledOperator
{
    private readonly TerraFX.Interop.DirectX.IDMLCompiledOperator* p;

    public TerraFX.Interop.DirectX.IDMLCompiledOperator* Get() => this.p;

    public static implicit operator PIDMLCompiledOperator(TerraFX.Interop.DirectX.IDMLCompiledOperator* p) => *(PIDMLCompiledOperator*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLCompiledOperator*(PIDMLCompiledOperator p) => (TerraFX.Interop.DirectX.IDMLCompiledOperator*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLDispatchable*(PIDMLCompiledOperator p) => (TerraFX.Interop.DirectX.IDMLDispatchable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLPageable*(PIDMLCompiledOperator p) => (TerraFX.Interop.DirectX.IDMLPageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLDeviceChild*(PIDMLCompiledOperator p) => (TerraFX.Interop.DirectX.IDMLDeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLObject*(PIDMLCompiledOperator p) => (TerraFX.Interop.DirectX.IDMLObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDMLCompiledOperator p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDMLCompiledOperator p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDMLDebugDevice
{
    private readonly TerraFX.Interop.DirectX.IDMLDebugDevice* p;

    public TerraFX.Interop.DirectX.IDMLDebugDevice* Get() => this.p;

    public static implicit operator PIDMLDebugDevice(TerraFX.Interop.DirectX.IDMLDebugDevice* p) => *(PIDMLDebugDevice*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLDebugDevice*(PIDMLDebugDevice p) => (TerraFX.Interop.DirectX.IDMLDebugDevice*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDMLDebugDevice p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDMLDebugDevice p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDMLDevice
{
    private readonly TerraFX.Interop.DirectX.IDMLDevice* p;

    public TerraFX.Interop.DirectX.IDMLDevice* Get() => this.p;

    public static implicit operator PIDMLDevice(TerraFX.Interop.DirectX.IDMLDevice* p) => *(PIDMLDevice*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLDevice*(PIDMLDevice p) => (TerraFX.Interop.DirectX.IDMLDevice*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLObject*(PIDMLDevice p) => (TerraFX.Interop.DirectX.IDMLObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDMLDevice p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDMLDevice p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDMLDevice1
{
    private readonly TerraFX.Interop.DirectX.IDMLDevice1* p;

    public TerraFX.Interop.DirectX.IDMLDevice1* Get() => this.p;

    public static implicit operator PIDMLDevice1(TerraFX.Interop.DirectX.IDMLDevice1* p) => *(PIDMLDevice1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLDevice1*(PIDMLDevice1 p) => (TerraFX.Interop.DirectX.IDMLDevice1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLDevice*(PIDMLDevice1 p) => (TerraFX.Interop.DirectX.IDMLDevice*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLObject*(PIDMLDevice1 p) => (TerraFX.Interop.DirectX.IDMLObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDMLDevice1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDMLDevice1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDMLDeviceChild
{
    private readonly TerraFX.Interop.DirectX.IDMLDeviceChild* p;

    public TerraFX.Interop.DirectX.IDMLDeviceChild* Get() => this.p;

    public static implicit operator PIDMLDeviceChild(TerraFX.Interop.DirectX.IDMLDeviceChild* p) => *(PIDMLDeviceChild*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLDeviceChild*(PIDMLDeviceChild p) => (TerraFX.Interop.DirectX.IDMLDeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLObject*(PIDMLDeviceChild p) => (TerraFX.Interop.DirectX.IDMLObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDMLDeviceChild p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDMLDeviceChild p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDMLDispatchable
{
    private readonly TerraFX.Interop.DirectX.IDMLDispatchable* p;

    public TerraFX.Interop.DirectX.IDMLDispatchable* Get() => this.p;

    public static implicit operator PIDMLDispatchable(TerraFX.Interop.DirectX.IDMLDispatchable* p) => *(PIDMLDispatchable*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLDispatchable*(PIDMLDispatchable p) => (TerraFX.Interop.DirectX.IDMLDispatchable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLPageable*(PIDMLDispatchable p) => (TerraFX.Interop.DirectX.IDMLPageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLDeviceChild*(PIDMLDispatchable p) => (TerraFX.Interop.DirectX.IDMLDeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLObject*(PIDMLDispatchable p) => (TerraFX.Interop.DirectX.IDMLObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDMLDispatchable p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDMLDispatchable p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDMLObject
{
    private readonly TerraFX.Interop.DirectX.IDMLObject* p;

    public TerraFX.Interop.DirectX.IDMLObject* Get() => this.p;

    public static implicit operator PIDMLObject(TerraFX.Interop.DirectX.IDMLObject* p) => *(PIDMLObject*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLObject*(PIDMLObject p) => (TerraFX.Interop.DirectX.IDMLObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDMLObject p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDMLObject p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDMLOperator
{
    private readonly TerraFX.Interop.DirectX.IDMLOperator* p;

    public TerraFX.Interop.DirectX.IDMLOperator* Get() => this.p;

    public static implicit operator PIDMLOperator(TerraFX.Interop.DirectX.IDMLOperator* p) => *(PIDMLOperator*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLOperator*(PIDMLOperator p) => (TerraFX.Interop.DirectX.IDMLOperator*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLDeviceChild*(PIDMLOperator p) => (TerraFX.Interop.DirectX.IDMLDeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLObject*(PIDMLOperator p) => (TerraFX.Interop.DirectX.IDMLObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDMLOperator p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDMLOperator p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDMLOperatorInitializer
{
    private readonly TerraFX.Interop.DirectX.IDMLOperatorInitializer* p;

    public TerraFX.Interop.DirectX.IDMLOperatorInitializer* Get() => this.p;

    public static implicit operator PIDMLOperatorInitializer(TerraFX.Interop.DirectX.IDMLOperatorInitializer* p) => *(PIDMLOperatorInitializer*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLOperatorInitializer*(PIDMLOperatorInitializer p) => (TerraFX.Interop.DirectX.IDMLOperatorInitializer*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLDispatchable*(PIDMLOperatorInitializer p) => (TerraFX.Interop.DirectX.IDMLDispatchable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLPageable*(PIDMLOperatorInitializer p) => (TerraFX.Interop.DirectX.IDMLPageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLDeviceChild*(PIDMLOperatorInitializer p) => (TerraFX.Interop.DirectX.IDMLDeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLObject*(PIDMLOperatorInitializer p) => (TerraFX.Interop.DirectX.IDMLObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDMLOperatorInitializer p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDMLOperatorInitializer p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDMLPageable
{
    private readonly TerraFX.Interop.DirectX.IDMLPageable* p;

    public TerraFX.Interop.DirectX.IDMLPageable* Get() => this.p;

    public static implicit operator PIDMLPageable(TerraFX.Interop.DirectX.IDMLPageable* p) => *(PIDMLPageable*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLPageable*(PIDMLPageable p) => (TerraFX.Interop.DirectX.IDMLPageable*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLDeviceChild*(PIDMLPageable p) => (TerraFX.Interop.DirectX.IDMLDeviceChild*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDMLObject*(PIDMLPageable p) => (TerraFX.Interop.DirectX.IDMLObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDMLPageable p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDMLPageable p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteAsyncResult
{
    private readonly TerraFX.Interop.DirectX.IDWriteAsyncResult* p;

    public TerraFX.Interop.DirectX.IDWriteAsyncResult* Get() => this.p;

    public static implicit operator PIDWriteAsyncResult(TerraFX.Interop.DirectX.IDWriteAsyncResult* p) => *(PIDWriteAsyncResult*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteAsyncResult*(PIDWriteAsyncResult p) => (TerraFX.Interop.DirectX.IDWriteAsyncResult*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteAsyncResult p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteAsyncResult p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteBitmapRenderTarget
{
    private readonly TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget* p;

    public TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget* Get() => this.p;

    public static implicit operator PIDWriteBitmapRenderTarget(TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget* p) => *(PIDWriteBitmapRenderTarget*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget*(PIDWriteBitmapRenderTarget p) => (TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteBitmapRenderTarget p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteBitmapRenderTarget p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteBitmapRenderTarget1
{
    private readonly TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget1* p;

    public TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget1* Get() => this.p;

    public static implicit operator PIDWriteBitmapRenderTarget1(TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget1* p) => *(PIDWriteBitmapRenderTarget1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget1*(PIDWriteBitmapRenderTarget1 p) => (TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget*(PIDWriteBitmapRenderTarget1 p) => (TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteBitmapRenderTarget1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteBitmapRenderTarget1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteBitmapRenderTarget2
{
    private readonly TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget2* p;

    public TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget2* Get() => this.p;

    public static implicit operator PIDWriteBitmapRenderTarget2(TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget2* p) => *(PIDWriteBitmapRenderTarget2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget2*(PIDWriteBitmapRenderTarget2 p) => (TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget1*(PIDWriteBitmapRenderTarget2 p) => (TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget*(PIDWriteBitmapRenderTarget2 p) => (TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteBitmapRenderTarget2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteBitmapRenderTarget2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteBitmapRenderTarget3
{
    private readonly TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget3* p;

    public TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget3* Get() => this.p;

    public static implicit operator PIDWriteBitmapRenderTarget3(TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget3* p) => *(PIDWriteBitmapRenderTarget3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget3*(PIDWriteBitmapRenderTarget3 p) => (TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget2*(PIDWriteBitmapRenderTarget3 p) => (TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget1*(PIDWriteBitmapRenderTarget3 p) => (TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget*(PIDWriteBitmapRenderTarget3 p) => (TerraFX.Interop.DirectX.IDWriteBitmapRenderTarget*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteBitmapRenderTarget3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteBitmapRenderTarget3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteColorGlyphRunEnumerator
{
    private readonly TerraFX.Interop.DirectX.IDWriteColorGlyphRunEnumerator* p;

    public TerraFX.Interop.DirectX.IDWriteColorGlyphRunEnumerator* Get() => this.p;

    public static implicit operator PIDWriteColorGlyphRunEnumerator(TerraFX.Interop.DirectX.IDWriteColorGlyphRunEnumerator* p) => *(PIDWriteColorGlyphRunEnumerator*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteColorGlyphRunEnumerator*(PIDWriteColorGlyphRunEnumerator p) => (TerraFX.Interop.DirectX.IDWriteColorGlyphRunEnumerator*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteColorGlyphRunEnumerator p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteColorGlyphRunEnumerator p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteColorGlyphRunEnumerator1
{
    private readonly TerraFX.Interop.DirectX.IDWriteColorGlyphRunEnumerator1* p;

    public TerraFX.Interop.DirectX.IDWriteColorGlyphRunEnumerator1* Get() => this.p;

    public static implicit operator PIDWriteColorGlyphRunEnumerator1(TerraFX.Interop.DirectX.IDWriteColorGlyphRunEnumerator1* p) => *(PIDWriteColorGlyphRunEnumerator1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteColorGlyphRunEnumerator1*(PIDWriteColorGlyphRunEnumerator1 p) => (TerraFX.Interop.DirectX.IDWriteColorGlyphRunEnumerator1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteColorGlyphRunEnumerator*(PIDWriteColorGlyphRunEnumerator1 p) => (TerraFX.Interop.DirectX.IDWriteColorGlyphRunEnumerator*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteColorGlyphRunEnumerator1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteColorGlyphRunEnumerator1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFactory
{
    private readonly TerraFX.Interop.DirectX.IDWriteFactory* p;

    public TerraFX.Interop.DirectX.IDWriteFactory* Get() => this.p;

    public static implicit operator PIDWriteFactory(TerraFX.Interop.DirectX.IDWriteFactory* p) => *(PIDWriteFactory*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory*(PIDWriteFactory p) => (TerraFX.Interop.DirectX.IDWriteFactory*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFactory p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFactory p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFactory1
{
    private readonly TerraFX.Interop.DirectX.IDWriteFactory1* p;

    public TerraFX.Interop.DirectX.IDWriteFactory1* Get() => this.p;

    public static implicit operator PIDWriteFactory1(TerraFX.Interop.DirectX.IDWriteFactory1* p) => *(PIDWriteFactory1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory1*(PIDWriteFactory1 p) => (TerraFX.Interop.DirectX.IDWriteFactory1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory*(PIDWriteFactory1 p) => (TerraFX.Interop.DirectX.IDWriteFactory*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFactory1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFactory1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFactory2
{
    private readonly TerraFX.Interop.DirectX.IDWriteFactory2* p;

    public TerraFX.Interop.DirectX.IDWriteFactory2* Get() => this.p;

    public static implicit operator PIDWriteFactory2(TerraFX.Interop.DirectX.IDWriteFactory2* p) => *(PIDWriteFactory2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory2*(PIDWriteFactory2 p) => (TerraFX.Interop.DirectX.IDWriteFactory2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory1*(PIDWriteFactory2 p) => (TerraFX.Interop.DirectX.IDWriteFactory1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory*(PIDWriteFactory2 p) => (TerraFX.Interop.DirectX.IDWriteFactory*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFactory2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFactory2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFactory3
{
    private readonly TerraFX.Interop.DirectX.IDWriteFactory3* p;

    public TerraFX.Interop.DirectX.IDWriteFactory3* Get() => this.p;

    public static implicit operator PIDWriteFactory3(TerraFX.Interop.DirectX.IDWriteFactory3* p) => *(PIDWriteFactory3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory3*(PIDWriteFactory3 p) => (TerraFX.Interop.DirectX.IDWriteFactory3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory2*(PIDWriteFactory3 p) => (TerraFX.Interop.DirectX.IDWriteFactory2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory1*(PIDWriteFactory3 p) => (TerraFX.Interop.DirectX.IDWriteFactory1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory*(PIDWriteFactory3 p) => (TerraFX.Interop.DirectX.IDWriteFactory*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFactory3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFactory3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFactory4
{
    private readonly TerraFX.Interop.DirectX.IDWriteFactory4* p;

    public TerraFX.Interop.DirectX.IDWriteFactory4* Get() => this.p;

    public static implicit operator PIDWriteFactory4(TerraFX.Interop.DirectX.IDWriteFactory4* p) => *(PIDWriteFactory4*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory4*(PIDWriteFactory4 p) => (TerraFX.Interop.DirectX.IDWriteFactory4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory3*(PIDWriteFactory4 p) => (TerraFX.Interop.DirectX.IDWriteFactory3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory2*(PIDWriteFactory4 p) => (TerraFX.Interop.DirectX.IDWriteFactory2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory1*(PIDWriteFactory4 p) => (TerraFX.Interop.DirectX.IDWriteFactory1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory*(PIDWriteFactory4 p) => (TerraFX.Interop.DirectX.IDWriteFactory*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFactory4 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFactory4 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFactory5
{
    private readonly TerraFX.Interop.DirectX.IDWriteFactory5* p;

    public TerraFX.Interop.DirectX.IDWriteFactory5* Get() => this.p;

    public static implicit operator PIDWriteFactory5(TerraFX.Interop.DirectX.IDWriteFactory5* p) => *(PIDWriteFactory5*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory5*(PIDWriteFactory5 p) => (TerraFX.Interop.DirectX.IDWriteFactory5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory4*(PIDWriteFactory5 p) => (TerraFX.Interop.DirectX.IDWriteFactory4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory3*(PIDWriteFactory5 p) => (TerraFX.Interop.DirectX.IDWriteFactory3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory2*(PIDWriteFactory5 p) => (TerraFX.Interop.DirectX.IDWriteFactory2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory1*(PIDWriteFactory5 p) => (TerraFX.Interop.DirectX.IDWriteFactory1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory*(PIDWriteFactory5 p) => (TerraFX.Interop.DirectX.IDWriteFactory*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFactory5 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFactory5 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFactory6
{
    private readonly TerraFX.Interop.DirectX.IDWriteFactory6* p;

    public TerraFX.Interop.DirectX.IDWriteFactory6* Get() => this.p;

    public static implicit operator PIDWriteFactory6(TerraFX.Interop.DirectX.IDWriteFactory6* p) => *(PIDWriteFactory6*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory6*(PIDWriteFactory6 p) => (TerraFX.Interop.DirectX.IDWriteFactory6*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory5*(PIDWriteFactory6 p) => (TerraFX.Interop.DirectX.IDWriteFactory5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory4*(PIDWriteFactory6 p) => (TerraFX.Interop.DirectX.IDWriteFactory4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory3*(PIDWriteFactory6 p) => (TerraFX.Interop.DirectX.IDWriteFactory3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory2*(PIDWriteFactory6 p) => (TerraFX.Interop.DirectX.IDWriteFactory2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory1*(PIDWriteFactory6 p) => (TerraFX.Interop.DirectX.IDWriteFactory1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory*(PIDWriteFactory6 p) => (TerraFX.Interop.DirectX.IDWriteFactory*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFactory6 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFactory6 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFactory7
{
    private readonly TerraFX.Interop.DirectX.IDWriteFactory7* p;

    public TerraFX.Interop.DirectX.IDWriteFactory7* Get() => this.p;

    public static implicit operator PIDWriteFactory7(TerraFX.Interop.DirectX.IDWriteFactory7* p) => *(PIDWriteFactory7*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory7*(PIDWriteFactory7 p) => (TerraFX.Interop.DirectX.IDWriteFactory7*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory6*(PIDWriteFactory7 p) => (TerraFX.Interop.DirectX.IDWriteFactory6*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory5*(PIDWriteFactory7 p) => (TerraFX.Interop.DirectX.IDWriteFactory5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory4*(PIDWriteFactory7 p) => (TerraFX.Interop.DirectX.IDWriteFactory4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory3*(PIDWriteFactory7 p) => (TerraFX.Interop.DirectX.IDWriteFactory3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory2*(PIDWriteFactory7 p) => (TerraFX.Interop.DirectX.IDWriteFactory2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory1*(PIDWriteFactory7 p) => (TerraFX.Interop.DirectX.IDWriteFactory1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory*(PIDWriteFactory7 p) => (TerraFX.Interop.DirectX.IDWriteFactory*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFactory7 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFactory7 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFactory8
{
    private readonly TerraFX.Interop.DirectX.IDWriteFactory8* p;

    public TerraFX.Interop.DirectX.IDWriteFactory8* Get() => this.p;

    public static implicit operator PIDWriteFactory8(TerraFX.Interop.DirectX.IDWriteFactory8* p) => *(PIDWriteFactory8*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory8*(PIDWriteFactory8 p) => (TerraFX.Interop.DirectX.IDWriteFactory8*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory7*(PIDWriteFactory8 p) => (TerraFX.Interop.DirectX.IDWriteFactory7*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory6*(PIDWriteFactory8 p) => (TerraFX.Interop.DirectX.IDWriteFactory6*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory5*(PIDWriteFactory8 p) => (TerraFX.Interop.DirectX.IDWriteFactory5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory4*(PIDWriteFactory8 p) => (TerraFX.Interop.DirectX.IDWriteFactory4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory3*(PIDWriteFactory8 p) => (TerraFX.Interop.DirectX.IDWriteFactory3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory2*(PIDWriteFactory8 p) => (TerraFX.Interop.DirectX.IDWriteFactory2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory1*(PIDWriteFactory8 p) => (TerraFX.Interop.DirectX.IDWriteFactory1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFactory*(PIDWriteFactory8 p) => (TerraFX.Interop.DirectX.IDWriteFactory*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFactory8 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFactory8 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFont
{
    private readonly TerraFX.Interop.DirectX.IDWriteFont* p;

    public TerraFX.Interop.DirectX.IDWriteFont* Get() => this.p;

    public static implicit operator PIDWriteFont(TerraFX.Interop.DirectX.IDWriteFont* p) => *(PIDWriteFont*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFont*(PIDWriteFont p) => (TerraFX.Interop.DirectX.IDWriteFont*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFont p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFont p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFont1
{
    private readonly TerraFX.Interop.DirectX.IDWriteFont1* p;

    public TerraFX.Interop.DirectX.IDWriteFont1* Get() => this.p;

    public static implicit operator PIDWriteFont1(TerraFX.Interop.DirectX.IDWriteFont1* p) => *(PIDWriteFont1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFont1*(PIDWriteFont1 p) => (TerraFX.Interop.DirectX.IDWriteFont1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFont*(PIDWriteFont1 p) => (TerraFX.Interop.DirectX.IDWriteFont*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFont1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFont1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFont2
{
    private readonly TerraFX.Interop.DirectX.IDWriteFont2* p;

    public TerraFX.Interop.DirectX.IDWriteFont2* Get() => this.p;

    public static implicit operator PIDWriteFont2(TerraFX.Interop.DirectX.IDWriteFont2* p) => *(PIDWriteFont2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFont2*(PIDWriteFont2 p) => (TerraFX.Interop.DirectX.IDWriteFont2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFont1*(PIDWriteFont2 p) => (TerraFX.Interop.DirectX.IDWriteFont1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFont*(PIDWriteFont2 p) => (TerraFX.Interop.DirectX.IDWriteFont*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFont2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFont2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFont3
{
    private readonly TerraFX.Interop.DirectX.IDWriteFont3* p;

    public TerraFX.Interop.DirectX.IDWriteFont3* Get() => this.p;

    public static implicit operator PIDWriteFont3(TerraFX.Interop.DirectX.IDWriteFont3* p) => *(PIDWriteFont3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFont3*(PIDWriteFont3 p) => (TerraFX.Interop.DirectX.IDWriteFont3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFont2*(PIDWriteFont3 p) => (TerraFX.Interop.DirectX.IDWriteFont2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFont1*(PIDWriteFont3 p) => (TerraFX.Interop.DirectX.IDWriteFont1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFont*(PIDWriteFont3 p) => (TerraFX.Interop.DirectX.IDWriteFont*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFont3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFont3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontCollection
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontCollection* p;

    public TerraFX.Interop.DirectX.IDWriteFontCollection* Get() => this.p;

    public static implicit operator PIDWriteFontCollection(TerraFX.Interop.DirectX.IDWriteFontCollection* p) => *(PIDWriteFontCollection*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontCollection*(PIDWriteFontCollection p) => (TerraFX.Interop.DirectX.IDWriteFontCollection*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontCollection p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontCollection p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontCollection1
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontCollection1* p;

    public TerraFX.Interop.DirectX.IDWriteFontCollection1* Get() => this.p;

    public static implicit operator PIDWriteFontCollection1(TerraFX.Interop.DirectX.IDWriteFontCollection1* p) => *(PIDWriteFontCollection1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontCollection1*(PIDWriteFontCollection1 p) => (TerraFX.Interop.DirectX.IDWriteFontCollection1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontCollection*(PIDWriteFontCollection1 p) => (TerraFX.Interop.DirectX.IDWriteFontCollection*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontCollection1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontCollection1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontCollection2
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontCollection2* p;

    public TerraFX.Interop.DirectX.IDWriteFontCollection2* Get() => this.p;

    public static implicit operator PIDWriteFontCollection2(TerraFX.Interop.DirectX.IDWriteFontCollection2* p) => *(PIDWriteFontCollection2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontCollection2*(PIDWriteFontCollection2 p) => (TerraFX.Interop.DirectX.IDWriteFontCollection2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontCollection1*(PIDWriteFontCollection2 p) => (TerraFX.Interop.DirectX.IDWriteFontCollection1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontCollection*(PIDWriteFontCollection2 p) => (TerraFX.Interop.DirectX.IDWriteFontCollection*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontCollection2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontCollection2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontCollection3
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontCollection3* p;

    public TerraFX.Interop.DirectX.IDWriteFontCollection3* Get() => this.p;

    public static implicit operator PIDWriteFontCollection3(TerraFX.Interop.DirectX.IDWriteFontCollection3* p) => *(PIDWriteFontCollection3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontCollection3*(PIDWriteFontCollection3 p) => (TerraFX.Interop.DirectX.IDWriteFontCollection3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontCollection2*(PIDWriteFontCollection3 p) => (TerraFX.Interop.DirectX.IDWriteFontCollection2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontCollection1*(PIDWriteFontCollection3 p) => (TerraFX.Interop.DirectX.IDWriteFontCollection1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontCollection*(PIDWriteFontCollection3 p) => (TerraFX.Interop.DirectX.IDWriteFontCollection*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontCollection3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontCollection3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontCollectionLoader
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontCollectionLoader* p;

    public TerraFX.Interop.DirectX.IDWriteFontCollectionLoader* Get() => this.p;

    public static implicit operator PIDWriteFontCollectionLoader(TerraFX.Interop.DirectX.IDWriteFontCollectionLoader* p) => *(PIDWriteFontCollectionLoader*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontCollectionLoader*(PIDWriteFontCollectionLoader p) => (TerraFX.Interop.DirectX.IDWriteFontCollectionLoader*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontCollectionLoader p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontCollectionLoader p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontDownloadListener
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontDownloadListener* p;

    public TerraFX.Interop.DirectX.IDWriteFontDownloadListener* Get() => this.p;

    public static implicit operator PIDWriteFontDownloadListener(TerraFX.Interop.DirectX.IDWriteFontDownloadListener* p) => *(PIDWriteFontDownloadListener*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontDownloadListener*(PIDWriteFontDownloadListener p) => (TerraFX.Interop.DirectX.IDWriteFontDownloadListener*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontDownloadListener p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontDownloadListener p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontDownloadQueue
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontDownloadQueue* p;

    public TerraFX.Interop.DirectX.IDWriteFontDownloadQueue* Get() => this.p;

    public static implicit operator PIDWriteFontDownloadQueue(TerraFX.Interop.DirectX.IDWriteFontDownloadQueue* p) => *(PIDWriteFontDownloadQueue*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontDownloadQueue*(PIDWriteFontDownloadQueue p) => (TerraFX.Interop.DirectX.IDWriteFontDownloadQueue*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontDownloadQueue p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontDownloadQueue p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontFace
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontFace* p;

    public TerraFX.Interop.DirectX.IDWriteFontFace* Get() => this.p;

    public static implicit operator PIDWriteFontFace(TerraFX.Interop.DirectX.IDWriteFontFace* p) => *(PIDWriteFontFace*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace*(PIDWriteFontFace p) => (TerraFX.Interop.DirectX.IDWriteFontFace*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontFace p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontFace p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontFace1
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontFace1* p;

    public TerraFX.Interop.DirectX.IDWriteFontFace1* Get() => this.p;

    public static implicit operator PIDWriteFontFace1(TerraFX.Interop.DirectX.IDWriteFontFace1* p) => *(PIDWriteFontFace1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace1*(PIDWriteFontFace1 p) => (TerraFX.Interop.DirectX.IDWriteFontFace1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace*(PIDWriteFontFace1 p) => (TerraFX.Interop.DirectX.IDWriteFontFace*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontFace1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontFace1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontFace2
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontFace2* p;

    public TerraFX.Interop.DirectX.IDWriteFontFace2* Get() => this.p;

    public static implicit operator PIDWriteFontFace2(TerraFX.Interop.DirectX.IDWriteFontFace2* p) => *(PIDWriteFontFace2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace2*(PIDWriteFontFace2 p) => (TerraFX.Interop.DirectX.IDWriteFontFace2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace1*(PIDWriteFontFace2 p) => (TerraFX.Interop.DirectX.IDWriteFontFace1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace*(PIDWriteFontFace2 p) => (TerraFX.Interop.DirectX.IDWriteFontFace*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontFace2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontFace2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontFace3
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontFace3* p;

    public TerraFX.Interop.DirectX.IDWriteFontFace3* Get() => this.p;

    public static implicit operator PIDWriteFontFace3(TerraFX.Interop.DirectX.IDWriteFontFace3* p) => *(PIDWriteFontFace3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace3*(PIDWriteFontFace3 p) => (TerraFX.Interop.DirectX.IDWriteFontFace3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace2*(PIDWriteFontFace3 p) => (TerraFX.Interop.DirectX.IDWriteFontFace2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace1*(PIDWriteFontFace3 p) => (TerraFX.Interop.DirectX.IDWriteFontFace1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace*(PIDWriteFontFace3 p) => (TerraFX.Interop.DirectX.IDWriteFontFace*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontFace3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontFace3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontFace4
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontFace4* p;

    public TerraFX.Interop.DirectX.IDWriteFontFace4* Get() => this.p;

    public static implicit operator PIDWriteFontFace4(TerraFX.Interop.DirectX.IDWriteFontFace4* p) => *(PIDWriteFontFace4*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace4*(PIDWriteFontFace4 p) => (TerraFX.Interop.DirectX.IDWriteFontFace4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace3*(PIDWriteFontFace4 p) => (TerraFX.Interop.DirectX.IDWriteFontFace3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace2*(PIDWriteFontFace4 p) => (TerraFX.Interop.DirectX.IDWriteFontFace2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace1*(PIDWriteFontFace4 p) => (TerraFX.Interop.DirectX.IDWriteFontFace1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace*(PIDWriteFontFace4 p) => (TerraFX.Interop.DirectX.IDWriteFontFace*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontFace4 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontFace4 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontFace5
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontFace5* p;

    public TerraFX.Interop.DirectX.IDWriteFontFace5* Get() => this.p;

    public static implicit operator PIDWriteFontFace5(TerraFX.Interop.DirectX.IDWriteFontFace5* p) => *(PIDWriteFontFace5*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace5*(PIDWriteFontFace5 p) => (TerraFX.Interop.DirectX.IDWriteFontFace5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace4*(PIDWriteFontFace5 p) => (TerraFX.Interop.DirectX.IDWriteFontFace4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace3*(PIDWriteFontFace5 p) => (TerraFX.Interop.DirectX.IDWriteFontFace3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace2*(PIDWriteFontFace5 p) => (TerraFX.Interop.DirectX.IDWriteFontFace2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace1*(PIDWriteFontFace5 p) => (TerraFX.Interop.DirectX.IDWriteFontFace1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace*(PIDWriteFontFace5 p) => (TerraFX.Interop.DirectX.IDWriteFontFace*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontFace5 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontFace5 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontFace6
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontFace6* p;

    public TerraFX.Interop.DirectX.IDWriteFontFace6* Get() => this.p;

    public static implicit operator PIDWriteFontFace6(TerraFX.Interop.DirectX.IDWriteFontFace6* p) => *(PIDWriteFontFace6*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace6*(PIDWriteFontFace6 p) => (TerraFX.Interop.DirectX.IDWriteFontFace6*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace5*(PIDWriteFontFace6 p) => (TerraFX.Interop.DirectX.IDWriteFontFace5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace4*(PIDWriteFontFace6 p) => (TerraFX.Interop.DirectX.IDWriteFontFace4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace3*(PIDWriteFontFace6 p) => (TerraFX.Interop.DirectX.IDWriteFontFace3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace2*(PIDWriteFontFace6 p) => (TerraFX.Interop.DirectX.IDWriteFontFace2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace1*(PIDWriteFontFace6 p) => (TerraFX.Interop.DirectX.IDWriteFontFace1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace*(PIDWriteFontFace6 p) => (TerraFX.Interop.DirectX.IDWriteFontFace*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontFace6 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontFace6 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontFace7
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontFace7* p;

    public TerraFX.Interop.DirectX.IDWriteFontFace7* Get() => this.p;

    public static implicit operator PIDWriteFontFace7(TerraFX.Interop.DirectX.IDWriteFontFace7* p) => *(PIDWriteFontFace7*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace7*(PIDWriteFontFace7 p) => (TerraFX.Interop.DirectX.IDWriteFontFace7*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace6*(PIDWriteFontFace7 p) => (TerraFX.Interop.DirectX.IDWriteFontFace6*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace5*(PIDWriteFontFace7 p) => (TerraFX.Interop.DirectX.IDWriteFontFace5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace4*(PIDWriteFontFace7 p) => (TerraFX.Interop.DirectX.IDWriteFontFace4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace3*(PIDWriteFontFace7 p) => (TerraFX.Interop.DirectX.IDWriteFontFace3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace2*(PIDWriteFontFace7 p) => (TerraFX.Interop.DirectX.IDWriteFontFace2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace1*(PIDWriteFontFace7 p) => (TerraFX.Interop.DirectX.IDWriteFontFace1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFace*(PIDWriteFontFace7 p) => (TerraFX.Interop.DirectX.IDWriteFontFace*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontFace7 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontFace7 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontFaceReference
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontFaceReference* p;

    public TerraFX.Interop.DirectX.IDWriteFontFaceReference* Get() => this.p;

    public static implicit operator PIDWriteFontFaceReference(TerraFX.Interop.DirectX.IDWriteFontFaceReference* p) => *(PIDWriteFontFaceReference*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFaceReference*(PIDWriteFontFaceReference p) => (TerraFX.Interop.DirectX.IDWriteFontFaceReference*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontFaceReference p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontFaceReference p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontFaceReference1
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontFaceReference1* p;

    public TerraFX.Interop.DirectX.IDWriteFontFaceReference1* Get() => this.p;

    public static implicit operator PIDWriteFontFaceReference1(TerraFX.Interop.DirectX.IDWriteFontFaceReference1* p) => *(PIDWriteFontFaceReference1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFaceReference1*(PIDWriteFontFaceReference1 p) => (TerraFX.Interop.DirectX.IDWriteFontFaceReference1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFaceReference*(PIDWriteFontFaceReference1 p) => (TerraFX.Interop.DirectX.IDWriteFontFaceReference*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontFaceReference1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontFaceReference1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontFallback
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontFallback* p;

    public TerraFX.Interop.DirectX.IDWriteFontFallback* Get() => this.p;

    public static implicit operator PIDWriteFontFallback(TerraFX.Interop.DirectX.IDWriteFontFallback* p) => *(PIDWriteFontFallback*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFallback*(PIDWriteFontFallback p) => (TerraFX.Interop.DirectX.IDWriteFontFallback*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontFallback p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontFallback p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontFallback1
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontFallback1* p;

    public TerraFX.Interop.DirectX.IDWriteFontFallback1* Get() => this.p;

    public static implicit operator PIDWriteFontFallback1(TerraFX.Interop.DirectX.IDWriteFontFallback1* p) => *(PIDWriteFontFallback1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFallback1*(PIDWriteFontFallback1 p) => (TerraFX.Interop.DirectX.IDWriteFontFallback1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFallback*(PIDWriteFontFallback1 p) => (TerraFX.Interop.DirectX.IDWriteFontFallback*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontFallback1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontFallback1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontFallbackBuilder
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontFallbackBuilder* p;

    public TerraFX.Interop.DirectX.IDWriteFontFallbackBuilder* Get() => this.p;

    public static implicit operator PIDWriteFontFallbackBuilder(TerraFX.Interop.DirectX.IDWriteFontFallbackBuilder* p) => *(PIDWriteFontFallbackBuilder*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFallbackBuilder*(PIDWriteFontFallbackBuilder p) => (TerraFX.Interop.DirectX.IDWriteFontFallbackBuilder*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontFallbackBuilder p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontFallbackBuilder p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontFamily
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontFamily* p;

    public TerraFX.Interop.DirectX.IDWriteFontFamily* Get() => this.p;

    public static implicit operator PIDWriteFontFamily(TerraFX.Interop.DirectX.IDWriteFontFamily* p) => *(PIDWriteFontFamily*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFamily*(PIDWriteFontFamily p) => (TerraFX.Interop.DirectX.IDWriteFontFamily*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontList*(PIDWriteFontFamily p) => (TerraFX.Interop.DirectX.IDWriteFontList*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontFamily p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontFamily p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontFamily1
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontFamily1* p;

    public TerraFX.Interop.DirectX.IDWriteFontFamily1* Get() => this.p;

    public static implicit operator PIDWriteFontFamily1(TerraFX.Interop.DirectX.IDWriteFontFamily1* p) => *(PIDWriteFontFamily1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFamily1*(PIDWriteFontFamily1 p) => (TerraFX.Interop.DirectX.IDWriteFontFamily1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFamily*(PIDWriteFontFamily1 p) => (TerraFX.Interop.DirectX.IDWriteFontFamily*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontList*(PIDWriteFontFamily1 p) => (TerraFX.Interop.DirectX.IDWriteFontList*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontFamily1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontFamily1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontFamily2
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontFamily2* p;

    public TerraFX.Interop.DirectX.IDWriteFontFamily2* Get() => this.p;

    public static implicit operator PIDWriteFontFamily2(TerraFX.Interop.DirectX.IDWriteFontFamily2* p) => *(PIDWriteFontFamily2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFamily2*(PIDWriteFontFamily2 p) => (TerraFX.Interop.DirectX.IDWriteFontFamily2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFamily1*(PIDWriteFontFamily2 p) => (TerraFX.Interop.DirectX.IDWriteFontFamily1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFamily*(PIDWriteFontFamily2 p) => (TerraFX.Interop.DirectX.IDWriteFontFamily*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontList*(PIDWriteFontFamily2 p) => (TerraFX.Interop.DirectX.IDWriteFontList*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontFamily2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontFamily2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontFile
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontFile* p;

    public TerraFX.Interop.DirectX.IDWriteFontFile* Get() => this.p;

    public static implicit operator PIDWriteFontFile(TerraFX.Interop.DirectX.IDWriteFontFile* p) => *(PIDWriteFontFile*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFile*(PIDWriteFontFile p) => (TerraFX.Interop.DirectX.IDWriteFontFile*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontFile p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontFile p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontFileEnumerator
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontFileEnumerator* p;

    public TerraFX.Interop.DirectX.IDWriteFontFileEnumerator* Get() => this.p;

    public static implicit operator PIDWriteFontFileEnumerator(TerraFX.Interop.DirectX.IDWriteFontFileEnumerator* p) => *(PIDWriteFontFileEnumerator*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFileEnumerator*(PIDWriteFontFileEnumerator p) => (TerraFX.Interop.DirectX.IDWriteFontFileEnumerator*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontFileEnumerator p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontFileEnumerator p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontFileLoader
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontFileLoader* p;

    public TerraFX.Interop.DirectX.IDWriteFontFileLoader* Get() => this.p;

    public static implicit operator PIDWriteFontFileLoader(TerraFX.Interop.DirectX.IDWriteFontFileLoader* p) => *(PIDWriteFontFileLoader*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFileLoader*(PIDWriteFontFileLoader p) => (TerraFX.Interop.DirectX.IDWriteFontFileLoader*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontFileLoader p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontFileLoader p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontFileStream
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontFileStream* p;

    public TerraFX.Interop.DirectX.IDWriteFontFileStream* Get() => this.p;

    public static implicit operator PIDWriteFontFileStream(TerraFX.Interop.DirectX.IDWriteFontFileStream* p) => *(PIDWriteFontFileStream*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFileStream*(PIDWriteFontFileStream p) => (TerraFX.Interop.DirectX.IDWriteFontFileStream*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontFileStream p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontFileStream p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontList
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontList* p;

    public TerraFX.Interop.DirectX.IDWriteFontList* Get() => this.p;

    public static implicit operator PIDWriteFontList(TerraFX.Interop.DirectX.IDWriteFontList* p) => *(PIDWriteFontList*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontList*(PIDWriteFontList p) => (TerraFX.Interop.DirectX.IDWriteFontList*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontList p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontList p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontList1
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontList1* p;

    public TerraFX.Interop.DirectX.IDWriteFontList1* Get() => this.p;

    public static implicit operator PIDWriteFontList1(TerraFX.Interop.DirectX.IDWriteFontList1* p) => *(PIDWriteFontList1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontList1*(PIDWriteFontList1 p) => (TerraFX.Interop.DirectX.IDWriteFontList1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontList*(PIDWriteFontList1 p) => (TerraFX.Interop.DirectX.IDWriteFontList*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontList1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontList1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontList2
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontList2* p;

    public TerraFX.Interop.DirectX.IDWriteFontList2* Get() => this.p;

    public static implicit operator PIDWriteFontList2(TerraFX.Interop.DirectX.IDWriteFontList2* p) => *(PIDWriteFontList2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontList2*(PIDWriteFontList2 p) => (TerraFX.Interop.DirectX.IDWriteFontList2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontList1*(PIDWriteFontList2 p) => (TerraFX.Interop.DirectX.IDWriteFontList1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontList*(PIDWriteFontList2 p) => (TerraFX.Interop.DirectX.IDWriteFontList*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontList2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontList2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontResource
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontResource* p;

    public TerraFX.Interop.DirectX.IDWriteFontResource* Get() => this.p;

    public static implicit operator PIDWriteFontResource(TerraFX.Interop.DirectX.IDWriteFontResource* p) => *(PIDWriteFontResource*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontResource*(PIDWriteFontResource p) => (TerraFX.Interop.DirectX.IDWriteFontResource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontResource p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontResource p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontSet
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontSet* p;

    public TerraFX.Interop.DirectX.IDWriteFontSet* Get() => this.p;

    public static implicit operator PIDWriteFontSet(TerraFX.Interop.DirectX.IDWriteFontSet* p) => *(PIDWriteFontSet*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontSet*(PIDWriteFontSet p) => (TerraFX.Interop.DirectX.IDWriteFontSet*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontSet p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontSet p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontSet1
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontSet1* p;

    public TerraFX.Interop.DirectX.IDWriteFontSet1* Get() => this.p;

    public static implicit operator PIDWriteFontSet1(TerraFX.Interop.DirectX.IDWriteFontSet1* p) => *(PIDWriteFontSet1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontSet1*(PIDWriteFontSet1 p) => (TerraFX.Interop.DirectX.IDWriteFontSet1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontSet*(PIDWriteFontSet1 p) => (TerraFX.Interop.DirectX.IDWriteFontSet*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontSet1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontSet1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontSet2
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontSet2* p;

    public TerraFX.Interop.DirectX.IDWriteFontSet2* Get() => this.p;

    public static implicit operator PIDWriteFontSet2(TerraFX.Interop.DirectX.IDWriteFontSet2* p) => *(PIDWriteFontSet2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontSet2*(PIDWriteFontSet2 p) => (TerraFX.Interop.DirectX.IDWriteFontSet2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontSet1*(PIDWriteFontSet2 p) => (TerraFX.Interop.DirectX.IDWriteFontSet1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontSet*(PIDWriteFontSet2 p) => (TerraFX.Interop.DirectX.IDWriteFontSet*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontSet2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontSet2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontSet3
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontSet3* p;

    public TerraFX.Interop.DirectX.IDWriteFontSet3* Get() => this.p;

    public static implicit operator PIDWriteFontSet3(TerraFX.Interop.DirectX.IDWriteFontSet3* p) => *(PIDWriteFontSet3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontSet3*(PIDWriteFontSet3 p) => (TerraFX.Interop.DirectX.IDWriteFontSet3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontSet2*(PIDWriteFontSet3 p) => (TerraFX.Interop.DirectX.IDWriteFontSet2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontSet1*(PIDWriteFontSet3 p) => (TerraFX.Interop.DirectX.IDWriteFontSet1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontSet*(PIDWriteFontSet3 p) => (TerraFX.Interop.DirectX.IDWriteFontSet*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontSet3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontSet3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontSet4
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontSet4* p;

    public TerraFX.Interop.DirectX.IDWriteFontSet4* Get() => this.p;

    public static implicit operator PIDWriteFontSet4(TerraFX.Interop.DirectX.IDWriteFontSet4* p) => *(PIDWriteFontSet4*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontSet4*(PIDWriteFontSet4 p) => (TerraFX.Interop.DirectX.IDWriteFontSet4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontSet3*(PIDWriteFontSet4 p) => (TerraFX.Interop.DirectX.IDWriteFontSet3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontSet2*(PIDWriteFontSet4 p) => (TerraFX.Interop.DirectX.IDWriteFontSet2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontSet1*(PIDWriteFontSet4 p) => (TerraFX.Interop.DirectX.IDWriteFontSet1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontSet*(PIDWriteFontSet4 p) => (TerraFX.Interop.DirectX.IDWriteFontSet*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontSet4 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontSet4 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontSetBuilder
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontSetBuilder* p;

    public TerraFX.Interop.DirectX.IDWriteFontSetBuilder* Get() => this.p;

    public static implicit operator PIDWriteFontSetBuilder(TerraFX.Interop.DirectX.IDWriteFontSetBuilder* p) => *(PIDWriteFontSetBuilder*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontSetBuilder*(PIDWriteFontSetBuilder p) => (TerraFX.Interop.DirectX.IDWriteFontSetBuilder*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontSetBuilder p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontSetBuilder p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontSetBuilder1
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontSetBuilder1* p;

    public TerraFX.Interop.DirectX.IDWriteFontSetBuilder1* Get() => this.p;

    public static implicit operator PIDWriteFontSetBuilder1(TerraFX.Interop.DirectX.IDWriteFontSetBuilder1* p) => *(PIDWriteFontSetBuilder1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontSetBuilder1*(PIDWriteFontSetBuilder1 p) => (TerraFX.Interop.DirectX.IDWriteFontSetBuilder1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontSetBuilder*(PIDWriteFontSetBuilder1 p) => (TerraFX.Interop.DirectX.IDWriteFontSetBuilder*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontSetBuilder1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontSetBuilder1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteFontSetBuilder2
{
    private readonly TerraFX.Interop.DirectX.IDWriteFontSetBuilder2* p;

    public TerraFX.Interop.DirectX.IDWriteFontSetBuilder2* Get() => this.p;

    public static implicit operator PIDWriteFontSetBuilder2(TerraFX.Interop.DirectX.IDWriteFontSetBuilder2* p) => *(PIDWriteFontSetBuilder2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontSetBuilder2*(PIDWriteFontSetBuilder2 p) => (TerraFX.Interop.DirectX.IDWriteFontSetBuilder2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontSetBuilder1*(PIDWriteFontSetBuilder2 p) => (TerraFX.Interop.DirectX.IDWriteFontSetBuilder1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontSetBuilder*(PIDWriteFontSetBuilder2 p) => (TerraFX.Interop.DirectX.IDWriteFontSetBuilder*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteFontSetBuilder2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteFontSetBuilder2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteGdiInterop
{
    private readonly TerraFX.Interop.DirectX.IDWriteGdiInterop* p;

    public TerraFX.Interop.DirectX.IDWriteGdiInterop* Get() => this.p;

    public static implicit operator PIDWriteGdiInterop(TerraFX.Interop.DirectX.IDWriteGdiInterop* p) => *(PIDWriteGdiInterop*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteGdiInterop*(PIDWriteGdiInterop p) => (TerraFX.Interop.DirectX.IDWriteGdiInterop*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteGdiInterop p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteGdiInterop p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteGdiInterop1
{
    private readonly TerraFX.Interop.DirectX.IDWriteGdiInterop1* p;

    public TerraFX.Interop.DirectX.IDWriteGdiInterop1* Get() => this.p;

    public static implicit operator PIDWriteGdiInterop1(TerraFX.Interop.DirectX.IDWriteGdiInterop1* p) => *(PIDWriteGdiInterop1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteGdiInterop1*(PIDWriteGdiInterop1 p) => (TerraFX.Interop.DirectX.IDWriteGdiInterop1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteGdiInterop*(PIDWriteGdiInterop1 p) => (TerraFX.Interop.DirectX.IDWriteGdiInterop*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteGdiInterop1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteGdiInterop1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteGlyphRunAnalysis
{
    private readonly TerraFX.Interop.DirectX.IDWriteGlyphRunAnalysis* p;

    public TerraFX.Interop.DirectX.IDWriteGlyphRunAnalysis* Get() => this.p;

    public static implicit operator PIDWriteGlyphRunAnalysis(TerraFX.Interop.DirectX.IDWriteGlyphRunAnalysis* p) => *(PIDWriteGlyphRunAnalysis*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteGlyphRunAnalysis*(PIDWriteGlyphRunAnalysis p) => (TerraFX.Interop.DirectX.IDWriteGlyphRunAnalysis*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteGlyphRunAnalysis p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteGlyphRunAnalysis p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteInlineObject
{
    private readonly TerraFX.Interop.DirectX.IDWriteInlineObject* p;

    public TerraFX.Interop.DirectX.IDWriteInlineObject* Get() => this.p;

    public static implicit operator PIDWriteInlineObject(TerraFX.Interop.DirectX.IDWriteInlineObject* p) => *(PIDWriteInlineObject*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteInlineObject*(PIDWriteInlineObject p) => (TerraFX.Interop.DirectX.IDWriteInlineObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteInlineObject p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteInlineObject p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteInMemoryFontFileLoader
{
    private readonly TerraFX.Interop.DirectX.IDWriteInMemoryFontFileLoader* p;

    public TerraFX.Interop.DirectX.IDWriteInMemoryFontFileLoader* Get() => this.p;

    public static implicit operator PIDWriteInMemoryFontFileLoader(TerraFX.Interop.DirectX.IDWriteInMemoryFontFileLoader* p) => *(PIDWriteInMemoryFontFileLoader*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteInMemoryFontFileLoader*(PIDWriteInMemoryFontFileLoader p) => (TerraFX.Interop.DirectX.IDWriteInMemoryFontFileLoader*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFileLoader*(PIDWriteInMemoryFontFileLoader p) => (TerraFX.Interop.DirectX.IDWriteFontFileLoader*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteInMemoryFontFileLoader p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteInMemoryFontFileLoader p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteLocalFontFileLoader
{
    private readonly TerraFX.Interop.DirectX.IDWriteLocalFontFileLoader* p;

    public TerraFX.Interop.DirectX.IDWriteLocalFontFileLoader* Get() => this.p;

    public static implicit operator PIDWriteLocalFontFileLoader(TerraFX.Interop.DirectX.IDWriteLocalFontFileLoader* p) => *(PIDWriteLocalFontFileLoader*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteLocalFontFileLoader*(PIDWriteLocalFontFileLoader p) => (TerraFX.Interop.DirectX.IDWriteLocalFontFileLoader*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFileLoader*(PIDWriteLocalFontFileLoader p) => (TerraFX.Interop.DirectX.IDWriteFontFileLoader*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteLocalFontFileLoader p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteLocalFontFileLoader p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteLocalizedStrings
{
    private readonly TerraFX.Interop.DirectX.IDWriteLocalizedStrings* p;

    public TerraFX.Interop.DirectX.IDWriteLocalizedStrings* Get() => this.p;

    public static implicit operator PIDWriteLocalizedStrings(TerraFX.Interop.DirectX.IDWriteLocalizedStrings* p) => *(PIDWriteLocalizedStrings*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteLocalizedStrings*(PIDWriteLocalizedStrings p) => (TerraFX.Interop.DirectX.IDWriteLocalizedStrings*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteLocalizedStrings p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteLocalizedStrings p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteNumberSubstitution
{
    private readonly TerraFX.Interop.DirectX.IDWriteNumberSubstitution* p;

    public TerraFX.Interop.DirectX.IDWriteNumberSubstitution* Get() => this.p;

    public static implicit operator PIDWriteNumberSubstitution(TerraFX.Interop.DirectX.IDWriteNumberSubstitution* p) => *(PIDWriteNumberSubstitution*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteNumberSubstitution*(PIDWriteNumberSubstitution p) => (TerraFX.Interop.DirectX.IDWriteNumberSubstitution*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteNumberSubstitution p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteNumberSubstitution p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWritePaintReader
{
    private readonly TerraFX.Interop.DirectX.IDWritePaintReader* p;

    public TerraFX.Interop.DirectX.IDWritePaintReader* Get() => this.p;

    public static implicit operator PIDWritePaintReader(TerraFX.Interop.DirectX.IDWritePaintReader* p) => *(PIDWritePaintReader*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWritePaintReader*(PIDWritePaintReader p) => (TerraFX.Interop.DirectX.IDWritePaintReader*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWritePaintReader p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWritePaintReader p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWritePixelSnapping
{
    private readonly TerraFX.Interop.DirectX.IDWritePixelSnapping* p;

    public TerraFX.Interop.DirectX.IDWritePixelSnapping* Get() => this.p;

    public static implicit operator PIDWritePixelSnapping(TerraFX.Interop.DirectX.IDWritePixelSnapping* p) => *(PIDWritePixelSnapping*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWritePixelSnapping*(PIDWritePixelSnapping p) => (TerraFX.Interop.DirectX.IDWritePixelSnapping*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWritePixelSnapping p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWritePixelSnapping p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteRemoteFontFileLoader
{
    private readonly TerraFX.Interop.DirectX.IDWriteRemoteFontFileLoader* p;

    public TerraFX.Interop.DirectX.IDWriteRemoteFontFileLoader* Get() => this.p;

    public static implicit operator PIDWriteRemoteFontFileLoader(TerraFX.Interop.DirectX.IDWriteRemoteFontFileLoader* p) => *(PIDWriteRemoteFontFileLoader*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteRemoteFontFileLoader*(PIDWriteRemoteFontFileLoader p) => (TerraFX.Interop.DirectX.IDWriteRemoteFontFileLoader*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFileLoader*(PIDWriteRemoteFontFileLoader p) => (TerraFX.Interop.DirectX.IDWriteFontFileLoader*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteRemoteFontFileLoader p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteRemoteFontFileLoader p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteRemoteFontFileStream
{
    private readonly TerraFX.Interop.DirectX.IDWriteRemoteFontFileStream* p;

    public TerraFX.Interop.DirectX.IDWriteRemoteFontFileStream* Get() => this.p;

    public static implicit operator PIDWriteRemoteFontFileStream(TerraFX.Interop.DirectX.IDWriteRemoteFontFileStream* p) => *(PIDWriteRemoteFontFileStream*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteRemoteFontFileStream*(PIDWriteRemoteFontFileStream p) => (TerraFX.Interop.DirectX.IDWriteRemoteFontFileStream*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteFontFileStream*(PIDWriteRemoteFontFileStream p) => (TerraFX.Interop.DirectX.IDWriteFontFileStream*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteRemoteFontFileStream p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteRemoteFontFileStream p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteRenderingParams
{
    private readonly TerraFX.Interop.DirectX.IDWriteRenderingParams* p;

    public TerraFX.Interop.DirectX.IDWriteRenderingParams* Get() => this.p;

    public static implicit operator PIDWriteRenderingParams(TerraFX.Interop.DirectX.IDWriteRenderingParams* p) => *(PIDWriteRenderingParams*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteRenderingParams*(PIDWriteRenderingParams p) => (TerraFX.Interop.DirectX.IDWriteRenderingParams*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteRenderingParams p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteRenderingParams p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteRenderingParams1
{
    private readonly TerraFX.Interop.DirectX.IDWriteRenderingParams1* p;

    public TerraFX.Interop.DirectX.IDWriteRenderingParams1* Get() => this.p;

    public static implicit operator PIDWriteRenderingParams1(TerraFX.Interop.DirectX.IDWriteRenderingParams1* p) => *(PIDWriteRenderingParams1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteRenderingParams1*(PIDWriteRenderingParams1 p) => (TerraFX.Interop.DirectX.IDWriteRenderingParams1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteRenderingParams*(PIDWriteRenderingParams1 p) => (TerraFX.Interop.DirectX.IDWriteRenderingParams*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteRenderingParams1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteRenderingParams1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteRenderingParams2
{
    private readonly TerraFX.Interop.DirectX.IDWriteRenderingParams2* p;

    public TerraFX.Interop.DirectX.IDWriteRenderingParams2* Get() => this.p;

    public static implicit operator PIDWriteRenderingParams2(TerraFX.Interop.DirectX.IDWriteRenderingParams2* p) => *(PIDWriteRenderingParams2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteRenderingParams2*(PIDWriteRenderingParams2 p) => (TerraFX.Interop.DirectX.IDWriteRenderingParams2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteRenderingParams1*(PIDWriteRenderingParams2 p) => (TerraFX.Interop.DirectX.IDWriteRenderingParams1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteRenderingParams*(PIDWriteRenderingParams2 p) => (TerraFX.Interop.DirectX.IDWriteRenderingParams*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteRenderingParams2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteRenderingParams2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteRenderingParams3
{
    private readonly TerraFX.Interop.DirectX.IDWriteRenderingParams3* p;

    public TerraFX.Interop.DirectX.IDWriteRenderingParams3* Get() => this.p;

    public static implicit operator PIDWriteRenderingParams3(TerraFX.Interop.DirectX.IDWriteRenderingParams3* p) => *(PIDWriteRenderingParams3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteRenderingParams3*(PIDWriteRenderingParams3 p) => (TerraFX.Interop.DirectX.IDWriteRenderingParams3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteRenderingParams2*(PIDWriteRenderingParams3 p) => (TerraFX.Interop.DirectX.IDWriteRenderingParams2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteRenderingParams1*(PIDWriteRenderingParams3 p) => (TerraFX.Interop.DirectX.IDWriteRenderingParams1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteRenderingParams*(PIDWriteRenderingParams3 p) => (TerraFX.Interop.DirectX.IDWriteRenderingParams*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteRenderingParams3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteRenderingParams3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteStringList
{
    private readonly TerraFX.Interop.DirectX.IDWriteStringList* p;

    public TerraFX.Interop.DirectX.IDWriteStringList* Get() => this.p;

    public static implicit operator PIDWriteStringList(TerraFX.Interop.DirectX.IDWriteStringList* p) => *(PIDWriteStringList*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteStringList*(PIDWriteStringList p) => (TerraFX.Interop.DirectX.IDWriteStringList*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteStringList p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteStringList p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteTextAnalysisSink
{
    private readonly TerraFX.Interop.DirectX.IDWriteTextAnalysisSink* p;

    public TerraFX.Interop.DirectX.IDWriteTextAnalysisSink* Get() => this.p;

    public static implicit operator PIDWriteTextAnalysisSink(TerraFX.Interop.DirectX.IDWriteTextAnalysisSink* p) => *(PIDWriteTextAnalysisSink*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextAnalysisSink*(PIDWriteTextAnalysisSink p) => (TerraFX.Interop.DirectX.IDWriteTextAnalysisSink*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteTextAnalysisSink p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteTextAnalysisSink p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteTextAnalysisSink1
{
    private readonly TerraFX.Interop.DirectX.IDWriteTextAnalysisSink1* p;

    public TerraFX.Interop.DirectX.IDWriteTextAnalysisSink1* Get() => this.p;

    public static implicit operator PIDWriteTextAnalysisSink1(TerraFX.Interop.DirectX.IDWriteTextAnalysisSink1* p) => *(PIDWriteTextAnalysisSink1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextAnalysisSink1*(PIDWriteTextAnalysisSink1 p) => (TerraFX.Interop.DirectX.IDWriteTextAnalysisSink1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextAnalysisSink*(PIDWriteTextAnalysisSink1 p) => (TerraFX.Interop.DirectX.IDWriteTextAnalysisSink*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteTextAnalysisSink1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteTextAnalysisSink1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteTextAnalysisSource
{
    private readonly TerraFX.Interop.DirectX.IDWriteTextAnalysisSource* p;

    public TerraFX.Interop.DirectX.IDWriteTextAnalysisSource* Get() => this.p;

    public static implicit operator PIDWriteTextAnalysisSource(TerraFX.Interop.DirectX.IDWriteTextAnalysisSource* p) => *(PIDWriteTextAnalysisSource*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextAnalysisSource*(PIDWriteTextAnalysisSource p) => (TerraFX.Interop.DirectX.IDWriteTextAnalysisSource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteTextAnalysisSource p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteTextAnalysisSource p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteTextAnalysisSource1
{
    private readonly TerraFX.Interop.DirectX.IDWriteTextAnalysisSource1* p;

    public TerraFX.Interop.DirectX.IDWriteTextAnalysisSource1* Get() => this.p;

    public static implicit operator PIDWriteTextAnalysisSource1(TerraFX.Interop.DirectX.IDWriteTextAnalysisSource1* p) => *(PIDWriteTextAnalysisSource1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextAnalysisSource1*(PIDWriteTextAnalysisSource1 p) => (TerraFX.Interop.DirectX.IDWriteTextAnalysisSource1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextAnalysisSource*(PIDWriteTextAnalysisSource1 p) => (TerraFX.Interop.DirectX.IDWriteTextAnalysisSource*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteTextAnalysisSource1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteTextAnalysisSource1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteTextAnalyzer
{
    private readonly TerraFX.Interop.DirectX.IDWriteTextAnalyzer* p;

    public TerraFX.Interop.DirectX.IDWriteTextAnalyzer* Get() => this.p;

    public static implicit operator PIDWriteTextAnalyzer(TerraFX.Interop.DirectX.IDWriteTextAnalyzer* p) => *(PIDWriteTextAnalyzer*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextAnalyzer*(PIDWriteTextAnalyzer p) => (TerraFX.Interop.DirectX.IDWriteTextAnalyzer*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteTextAnalyzer p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteTextAnalyzer p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteTextAnalyzer1
{
    private readonly TerraFX.Interop.DirectX.IDWriteTextAnalyzer1* p;

    public TerraFX.Interop.DirectX.IDWriteTextAnalyzer1* Get() => this.p;

    public static implicit operator PIDWriteTextAnalyzer1(TerraFX.Interop.DirectX.IDWriteTextAnalyzer1* p) => *(PIDWriteTextAnalyzer1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextAnalyzer1*(PIDWriteTextAnalyzer1 p) => (TerraFX.Interop.DirectX.IDWriteTextAnalyzer1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextAnalyzer*(PIDWriteTextAnalyzer1 p) => (TerraFX.Interop.DirectX.IDWriteTextAnalyzer*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteTextAnalyzer1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteTextAnalyzer1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteTextAnalyzer2
{
    private readonly TerraFX.Interop.DirectX.IDWriteTextAnalyzer2* p;

    public TerraFX.Interop.DirectX.IDWriteTextAnalyzer2* Get() => this.p;

    public static implicit operator PIDWriteTextAnalyzer2(TerraFX.Interop.DirectX.IDWriteTextAnalyzer2* p) => *(PIDWriteTextAnalyzer2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextAnalyzer2*(PIDWriteTextAnalyzer2 p) => (TerraFX.Interop.DirectX.IDWriteTextAnalyzer2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextAnalyzer1*(PIDWriteTextAnalyzer2 p) => (TerraFX.Interop.DirectX.IDWriteTextAnalyzer1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextAnalyzer*(PIDWriteTextAnalyzer2 p) => (TerraFX.Interop.DirectX.IDWriteTextAnalyzer*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteTextAnalyzer2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteTextAnalyzer2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteTextFormat
{
    private readonly TerraFX.Interop.DirectX.IDWriteTextFormat* p;

    public TerraFX.Interop.DirectX.IDWriteTextFormat* Get() => this.p;

    public static implicit operator PIDWriteTextFormat(TerraFX.Interop.DirectX.IDWriteTextFormat* p) => *(PIDWriteTextFormat*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextFormat*(PIDWriteTextFormat p) => (TerraFX.Interop.DirectX.IDWriteTextFormat*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteTextFormat p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteTextFormat p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteTextFormat1
{
    private readonly TerraFX.Interop.DirectX.IDWriteTextFormat1* p;

    public TerraFX.Interop.DirectX.IDWriteTextFormat1* Get() => this.p;

    public static implicit operator PIDWriteTextFormat1(TerraFX.Interop.DirectX.IDWriteTextFormat1* p) => *(PIDWriteTextFormat1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextFormat1*(PIDWriteTextFormat1 p) => (TerraFX.Interop.DirectX.IDWriteTextFormat1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextFormat*(PIDWriteTextFormat1 p) => (TerraFX.Interop.DirectX.IDWriteTextFormat*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteTextFormat1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteTextFormat1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteTextFormat2
{
    private readonly TerraFX.Interop.DirectX.IDWriteTextFormat2* p;

    public TerraFX.Interop.DirectX.IDWriteTextFormat2* Get() => this.p;

    public static implicit operator PIDWriteTextFormat2(TerraFX.Interop.DirectX.IDWriteTextFormat2* p) => *(PIDWriteTextFormat2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextFormat2*(PIDWriteTextFormat2 p) => (TerraFX.Interop.DirectX.IDWriteTextFormat2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextFormat1*(PIDWriteTextFormat2 p) => (TerraFX.Interop.DirectX.IDWriteTextFormat1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextFormat*(PIDWriteTextFormat2 p) => (TerraFX.Interop.DirectX.IDWriteTextFormat*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteTextFormat2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteTextFormat2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteTextFormat3
{
    private readonly TerraFX.Interop.DirectX.IDWriteTextFormat3* p;

    public TerraFX.Interop.DirectX.IDWriteTextFormat3* Get() => this.p;

    public static implicit operator PIDWriteTextFormat3(TerraFX.Interop.DirectX.IDWriteTextFormat3* p) => *(PIDWriteTextFormat3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextFormat3*(PIDWriteTextFormat3 p) => (TerraFX.Interop.DirectX.IDWriteTextFormat3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextFormat2*(PIDWriteTextFormat3 p) => (TerraFX.Interop.DirectX.IDWriteTextFormat2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextFormat1*(PIDWriteTextFormat3 p) => (TerraFX.Interop.DirectX.IDWriteTextFormat1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextFormat*(PIDWriteTextFormat3 p) => (TerraFX.Interop.DirectX.IDWriteTextFormat*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteTextFormat3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteTextFormat3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteTextLayout
{
    private readonly TerraFX.Interop.DirectX.IDWriteTextLayout* p;

    public TerraFX.Interop.DirectX.IDWriteTextLayout* Get() => this.p;

    public static implicit operator PIDWriteTextLayout(TerraFX.Interop.DirectX.IDWriteTextLayout* p) => *(PIDWriteTextLayout*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextLayout*(PIDWriteTextLayout p) => (TerraFX.Interop.DirectX.IDWriteTextLayout*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextFormat*(PIDWriteTextLayout p) => (TerraFX.Interop.DirectX.IDWriteTextFormat*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteTextLayout p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteTextLayout p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteTextLayout1
{
    private readonly TerraFX.Interop.DirectX.IDWriteTextLayout1* p;

    public TerraFX.Interop.DirectX.IDWriteTextLayout1* Get() => this.p;

    public static implicit operator PIDWriteTextLayout1(TerraFX.Interop.DirectX.IDWriteTextLayout1* p) => *(PIDWriteTextLayout1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextLayout1*(PIDWriteTextLayout1 p) => (TerraFX.Interop.DirectX.IDWriteTextLayout1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextLayout*(PIDWriteTextLayout1 p) => (TerraFX.Interop.DirectX.IDWriteTextLayout*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextFormat*(PIDWriteTextLayout1 p) => (TerraFX.Interop.DirectX.IDWriteTextFormat*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteTextLayout1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteTextLayout1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteTextLayout2
{
    private readonly TerraFX.Interop.DirectX.IDWriteTextLayout2* p;

    public TerraFX.Interop.DirectX.IDWriteTextLayout2* Get() => this.p;

    public static implicit operator PIDWriteTextLayout2(TerraFX.Interop.DirectX.IDWriteTextLayout2* p) => *(PIDWriteTextLayout2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextLayout2*(PIDWriteTextLayout2 p) => (TerraFX.Interop.DirectX.IDWriteTextLayout2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextLayout1*(PIDWriteTextLayout2 p) => (TerraFX.Interop.DirectX.IDWriteTextLayout1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextLayout*(PIDWriteTextLayout2 p) => (TerraFX.Interop.DirectX.IDWriteTextLayout*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextFormat*(PIDWriteTextLayout2 p) => (TerraFX.Interop.DirectX.IDWriteTextFormat*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteTextLayout2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteTextLayout2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteTextLayout3
{
    private readonly TerraFX.Interop.DirectX.IDWriteTextLayout3* p;

    public TerraFX.Interop.DirectX.IDWriteTextLayout3* Get() => this.p;

    public static implicit operator PIDWriteTextLayout3(TerraFX.Interop.DirectX.IDWriteTextLayout3* p) => *(PIDWriteTextLayout3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextLayout3*(PIDWriteTextLayout3 p) => (TerraFX.Interop.DirectX.IDWriteTextLayout3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextLayout2*(PIDWriteTextLayout3 p) => (TerraFX.Interop.DirectX.IDWriteTextLayout2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextLayout1*(PIDWriteTextLayout3 p) => (TerraFX.Interop.DirectX.IDWriteTextLayout1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextLayout*(PIDWriteTextLayout3 p) => (TerraFX.Interop.DirectX.IDWriteTextLayout*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextFormat*(PIDWriteTextLayout3 p) => (TerraFX.Interop.DirectX.IDWriteTextFormat*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteTextLayout3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteTextLayout3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteTextLayout4
{
    private readonly TerraFX.Interop.DirectX.IDWriteTextLayout4* p;

    public TerraFX.Interop.DirectX.IDWriteTextLayout4* Get() => this.p;

    public static implicit operator PIDWriteTextLayout4(TerraFX.Interop.DirectX.IDWriteTextLayout4* p) => *(PIDWriteTextLayout4*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextLayout4*(PIDWriteTextLayout4 p) => (TerraFX.Interop.DirectX.IDWriteTextLayout4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextLayout3*(PIDWriteTextLayout4 p) => (TerraFX.Interop.DirectX.IDWriteTextLayout3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextLayout2*(PIDWriteTextLayout4 p) => (TerraFX.Interop.DirectX.IDWriteTextLayout2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextLayout1*(PIDWriteTextLayout4 p) => (TerraFX.Interop.DirectX.IDWriteTextLayout1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextLayout*(PIDWriteTextLayout4 p) => (TerraFX.Interop.DirectX.IDWriteTextLayout*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextFormat*(PIDWriteTextLayout4 p) => (TerraFX.Interop.DirectX.IDWriteTextFormat*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteTextLayout4 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteTextLayout4 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteTextRenderer
{
    private readonly TerraFX.Interop.DirectX.IDWriteTextRenderer* p;

    public TerraFX.Interop.DirectX.IDWriteTextRenderer* Get() => this.p;

    public static implicit operator PIDWriteTextRenderer(TerraFX.Interop.DirectX.IDWriteTextRenderer* p) => *(PIDWriteTextRenderer*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextRenderer*(PIDWriteTextRenderer p) => (TerraFX.Interop.DirectX.IDWriteTextRenderer*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWritePixelSnapping*(PIDWriteTextRenderer p) => (TerraFX.Interop.DirectX.IDWritePixelSnapping*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteTextRenderer p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteTextRenderer p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteTextRenderer1
{
    private readonly TerraFX.Interop.DirectX.IDWriteTextRenderer1* p;

    public TerraFX.Interop.DirectX.IDWriteTextRenderer1* Get() => this.p;

    public static implicit operator PIDWriteTextRenderer1(TerraFX.Interop.DirectX.IDWriteTextRenderer1* p) => *(PIDWriteTextRenderer1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextRenderer1*(PIDWriteTextRenderer1 p) => (TerraFX.Interop.DirectX.IDWriteTextRenderer1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTextRenderer*(PIDWriteTextRenderer1 p) => (TerraFX.Interop.DirectX.IDWriteTextRenderer*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDWritePixelSnapping*(PIDWriteTextRenderer1 p) => (TerraFX.Interop.DirectX.IDWritePixelSnapping*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteTextRenderer1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteTextRenderer1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDWriteTypography
{
    private readonly TerraFX.Interop.DirectX.IDWriteTypography* p;

    public TerraFX.Interop.DirectX.IDWriteTypography* Get() => this.p;

    public static implicit operator PIDWriteTypography(TerraFX.Interop.DirectX.IDWriteTypography* p) => *(PIDWriteTypography*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDWriteTypography*(PIDWriteTypography p) => (TerraFX.Interop.DirectX.IDWriteTypography*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDWriteTypography p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDWriteTypography p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDxcAssembler
{
    private readonly TerraFX.Interop.DirectX.IDxcAssembler* p;

    public TerraFX.Interop.DirectX.IDxcAssembler* Get() => this.p;

    public static implicit operator PIDxcAssembler(TerraFX.Interop.DirectX.IDxcAssembler* p) => *(PIDxcAssembler*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcAssembler*(PIDxcAssembler p) => (TerraFX.Interop.DirectX.IDxcAssembler*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDxcAssembler p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDxcAssembler p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDxcBlob
{
    private readonly TerraFX.Interop.DirectX.IDxcBlob* p;

    public TerraFX.Interop.DirectX.IDxcBlob* Get() => this.p;

    public static implicit operator PIDxcBlob(TerraFX.Interop.DirectX.IDxcBlob* p) => *(PIDxcBlob*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcBlob*(PIDxcBlob p) => (TerraFX.Interop.DirectX.IDxcBlob*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDxcBlob p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDxcBlob p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDxcBlobEncoding
{
    private readonly TerraFX.Interop.DirectX.IDxcBlobEncoding* p;

    public TerraFX.Interop.DirectX.IDxcBlobEncoding* Get() => this.p;

    public static implicit operator PIDxcBlobEncoding(TerraFX.Interop.DirectX.IDxcBlobEncoding* p) => *(PIDxcBlobEncoding*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcBlobEncoding*(PIDxcBlobEncoding p) => (TerraFX.Interop.DirectX.IDxcBlobEncoding*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcBlob*(PIDxcBlobEncoding p) => (TerraFX.Interop.DirectX.IDxcBlob*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDxcBlobEncoding p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDxcBlobEncoding p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDxcBlobUtf16
{
    private readonly TerraFX.Interop.DirectX.IDxcBlobUtf16* p;

    public TerraFX.Interop.DirectX.IDxcBlobUtf16* Get() => this.p;

    public static implicit operator PIDxcBlobUtf16(TerraFX.Interop.DirectX.IDxcBlobUtf16* p) => *(PIDxcBlobUtf16*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcBlobUtf16*(PIDxcBlobUtf16 p) => (TerraFX.Interop.DirectX.IDxcBlobUtf16*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcBlobEncoding*(PIDxcBlobUtf16 p) => (TerraFX.Interop.DirectX.IDxcBlobEncoding*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcBlob*(PIDxcBlobUtf16 p) => (TerraFX.Interop.DirectX.IDxcBlob*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDxcBlobUtf16 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDxcBlobUtf16 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDxcBlobUtf8
{
    private readonly TerraFX.Interop.DirectX.IDxcBlobUtf8* p;

    public TerraFX.Interop.DirectX.IDxcBlobUtf8* Get() => this.p;

    public static implicit operator PIDxcBlobUtf8(TerraFX.Interop.DirectX.IDxcBlobUtf8* p) => *(PIDxcBlobUtf8*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcBlobUtf8*(PIDxcBlobUtf8 p) => (TerraFX.Interop.DirectX.IDxcBlobUtf8*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcBlobEncoding*(PIDxcBlobUtf8 p) => (TerraFX.Interop.DirectX.IDxcBlobEncoding*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcBlob*(PIDxcBlobUtf8 p) => (TerraFX.Interop.DirectX.IDxcBlob*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDxcBlobUtf8 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDxcBlobUtf8 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDxcCompiler
{
    private readonly TerraFX.Interop.DirectX.IDxcCompiler* p;

    public TerraFX.Interop.DirectX.IDxcCompiler* Get() => this.p;

    public static implicit operator PIDxcCompiler(TerraFX.Interop.DirectX.IDxcCompiler* p) => *(PIDxcCompiler*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcCompiler*(PIDxcCompiler p) => (TerraFX.Interop.DirectX.IDxcCompiler*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDxcCompiler p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDxcCompiler p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDxcCompiler2
{
    private readonly TerraFX.Interop.DirectX.IDxcCompiler2* p;

    public TerraFX.Interop.DirectX.IDxcCompiler2* Get() => this.p;

    public static implicit operator PIDxcCompiler2(TerraFX.Interop.DirectX.IDxcCompiler2* p) => *(PIDxcCompiler2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcCompiler2*(PIDxcCompiler2 p) => (TerraFX.Interop.DirectX.IDxcCompiler2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcCompiler*(PIDxcCompiler2 p) => (TerraFX.Interop.DirectX.IDxcCompiler*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDxcCompiler2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDxcCompiler2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDxcCompiler3
{
    private readonly TerraFX.Interop.DirectX.IDxcCompiler3* p;

    public TerraFX.Interop.DirectX.IDxcCompiler3* Get() => this.p;

    public static implicit operator PIDxcCompiler3(TerraFX.Interop.DirectX.IDxcCompiler3* p) => *(PIDxcCompiler3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcCompiler3*(PIDxcCompiler3 p) => (TerraFX.Interop.DirectX.IDxcCompiler3*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDxcCompiler3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDxcCompiler3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDxcCompilerArgs
{
    private readonly TerraFX.Interop.DirectX.IDxcCompilerArgs* p;

    public TerraFX.Interop.DirectX.IDxcCompilerArgs* Get() => this.p;

    public static implicit operator PIDxcCompilerArgs(TerraFX.Interop.DirectX.IDxcCompilerArgs* p) => *(PIDxcCompilerArgs*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcCompilerArgs*(PIDxcCompilerArgs p) => (TerraFX.Interop.DirectX.IDxcCompilerArgs*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDxcCompilerArgs p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDxcCompilerArgs p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDxcContainerBuilder
{
    private readonly TerraFX.Interop.DirectX.IDxcContainerBuilder* p;

    public TerraFX.Interop.DirectX.IDxcContainerBuilder* Get() => this.p;

    public static implicit operator PIDxcContainerBuilder(TerraFX.Interop.DirectX.IDxcContainerBuilder* p) => *(PIDxcContainerBuilder*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcContainerBuilder*(PIDxcContainerBuilder p) => (TerraFX.Interop.DirectX.IDxcContainerBuilder*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDxcContainerBuilder p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDxcContainerBuilder p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDxcContainerReflection
{
    private readonly TerraFX.Interop.DirectX.IDxcContainerReflection* p;

    public TerraFX.Interop.DirectX.IDxcContainerReflection* Get() => this.p;

    public static implicit operator PIDxcContainerReflection(TerraFX.Interop.DirectX.IDxcContainerReflection* p) => *(PIDxcContainerReflection*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcContainerReflection*(PIDxcContainerReflection p) => (TerraFX.Interop.DirectX.IDxcContainerReflection*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDxcContainerReflection p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDxcContainerReflection p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDxcExtraOutputs
{
    private readonly TerraFX.Interop.DirectX.IDxcExtraOutputs* p;

    public TerraFX.Interop.DirectX.IDxcExtraOutputs* Get() => this.p;

    public static implicit operator PIDxcExtraOutputs(TerraFX.Interop.DirectX.IDxcExtraOutputs* p) => *(PIDxcExtraOutputs*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcExtraOutputs*(PIDxcExtraOutputs p) => (TerraFX.Interop.DirectX.IDxcExtraOutputs*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDxcExtraOutputs p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDxcExtraOutputs p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDxcIncludeHandler
{
    private readonly TerraFX.Interop.DirectX.IDxcIncludeHandler* p;

    public TerraFX.Interop.DirectX.IDxcIncludeHandler* Get() => this.p;

    public static implicit operator PIDxcIncludeHandler(TerraFX.Interop.DirectX.IDxcIncludeHandler* p) => *(PIDxcIncludeHandler*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcIncludeHandler*(PIDxcIncludeHandler p) => (TerraFX.Interop.DirectX.IDxcIncludeHandler*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDxcIncludeHandler p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDxcIncludeHandler p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDxcLibrary
{
    private readonly TerraFX.Interop.DirectX.IDxcLibrary* p;

    public TerraFX.Interop.DirectX.IDxcLibrary* Get() => this.p;

    public static implicit operator PIDxcLibrary(TerraFX.Interop.DirectX.IDxcLibrary* p) => *(PIDxcLibrary*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcLibrary*(PIDxcLibrary p) => (TerraFX.Interop.DirectX.IDxcLibrary*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDxcLibrary p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDxcLibrary p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDxcLinker
{
    private readonly TerraFX.Interop.DirectX.IDxcLinker* p;

    public TerraFX.Interop.DirectX.IDxcLinker* Get() => this.p;

    public static implicit operator PIDxcLinker(TerraFX.Interop.DirectX.IDxcLinker* p) => *(PIDxcLinker*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcLinker*(PIDxcLinker p) => (TerraFX.Interop.DirectX.IDxcLinker*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDxcLinker p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDxcLinker p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDxcOperationResult
{
    private readonly TerraFX.Interop.DirectX.IDxcOperationResult* p;

    public TerraFX.Interop.DirectX.IDxcOperationResult* Get() => this.p;

    public static implicit operator PIDxcOperationResult(TerraFX.Interop.DirectX.IDxcOperationResult* p) => *(PIDxcOperationResult*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcOperationResult*(PIDxcOperationResult p) => (TerraFX.Interop.DirectX.IDxcOperationResult*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDxcOperationResult p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDxcOperationResult p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDxcOptimizer
{
    private readonly TerraFX.Interop.DirectX.IDxcOptimizer* p;

    public TerraFX.Interop.DirectX.IDxcOptimizer* Get() => this.p;

    public static implicit operator PIDxcOptimizer(TerraFX.Interop.DirectX.IDxcOptimizer* p) => *(PIDxcOptimizer*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcOptimizer*(PIDxcOptimizer p) => (TerraFX.Interop.DirectX.IDxcOptimizer*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDxcOptimizer p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDxcOptimizer p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDxcOptimizerPass
{
    private readonly TerraFX.Interop.DirectX.IDxcOptimizerPass* p;

    public TerraFX.Interop.DirectX.IDxcOptimizerPass* Get() => this.p;

    public static implicit operator PIDxcOptimizerPass(TerraFX.Interop.DirectX.IDxcOptimizerPass* p) => *(PIDxcOptimizerPass*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcOptimizerPass*(PIDxcOptimizerPass p) => (TerraFX.Interop.DirectX.IDxcOptimizerPass*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDxcOptimizerPass p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDxcOptimizerPass p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXCoreAdapter
{
    private readonly TerraFX.Interop.DirectX.IDXCoreAdapter* p;

    public TerraFX.Interop.DirectX.IDXCoreAdapter* Get() => this.p;

    public static implicit operator PIDXCoreAdapter(TerraFX.Interop.DirectX.IDXCoreAdapter* p) => *(PIDXCoreAdapter*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXCoreAdapter*(PIDXCoreAdapter p) => (TerraFX.Interop.DirectX.IDXCoreAdapter*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXCoreAdapter p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXCoreAdapter p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXCoreAdapterFactory
{
    private readonly TerraFX.Interop.DirectX.IDXCoreAdapterFactory* p;

    public TerraFX.Interop.DirectX.IDXCoreAdapterFactory* Get() => this.p;

    public static implicit operator PIDXCoreAdapterFactory(TerraFX.Interop.DirectX.IDXCoreAdapterFactory* p) => *(PIDXCoreAdapterFactory*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXCoreAdapterFactory*(PIDXCoreAdapterFactory p) => (TerraFX.Interop.DirectX.IDXCoreAdapterFactory*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXCoreAdapterFactory p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXCoreAdapterFactory p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXCoreAdapterList
{
    private readonly TerraFX.Interop.DirectX.IDXCoreAdapterList* p;

    public TerraFX.Interop.DirectX.IDXCoreAdapterList* Get() => this.p;

    public static implicit operator PIDXCoreAdapterList(TerraFX.Interop.DirectX.IDXCoreAdapterList* p) => *(PIDXCoreAdapterList*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXCoreAdapterList*(PIDXCoreAdapterList p) => (TerraFX.Interop.DirectX.IDXCoreAdapterList*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXCoreAdapterList p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXCoreAdapterList p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDxcPdbUtils
{
    private readonly TerraFX.Interop.DirectX.IDxcPdbUtils* p;

    public TerraFX.Interop.DirectX.IDxcPdbUtils* Get() => this.p;

    public static implicit operator PIDxcPdbUtils(TerraFX.Interop.DirectX.IDxcPdbUtils* p) => *(PIDxcPdbUtils*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcPdbUtils*(PIDxcPdbUtils p) => (TerraFX.Interop.DirectX.IDxcPdbUtils*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDxcPdbUtils p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDxcPdbUtils p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDxcResult
{
    private readonly TerraFX.Interop.DirectX.IDxcResult* p;

    public TerraFX.Interop.DirectX.IDxcResult* Get() => this.p;

    public static implicit operator PIDxcResult(TerraFX.Interop.DirectX.IDxcResult* p) => *(PIDxcResult*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcResult*(PIDxcResult p) => (TerraFX.Interop.DirectX.IDxcResult*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcOperationResult*(PIDxcResult p) => (TerraFX.Interop.DirectX.IDxcOperationResult*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDxcResult p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDxcResult p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDxcUtils
{
    private readonly TerraFX.Interop.DirectX.IDxcUtils* p;

    public TerraFX.Interop.DirectX.IDxcUtils* Get() => this.p;

    public static implicit operator PIDxcUtils(TerraFX.Interop.DirectX.IDxcUtils* p) => *(PIDxcUtils*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcUtils*(PIDxcUtils p) => (TerraFX.Interop.DirectX.IDxcUtils*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDxcUtils p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDxcUtils p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDxcValidator
{
    private readonly TerraFX.Interop.DirectX.IDxcValidator* p;

    public TerraFX.Interop.DirectX.IDxcValidator* Get() => this.p;

    public static implicit operator PIDxcValidator(TerraFX.Interop.DirectX.IDxcValidator* p) => *(PIDxcValidator*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcValidator*(PIDxcValidator p) => (TerraFX.Interop.DirectX.IDxcValidator*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDxcValidator p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDxcValidator p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDxcValidator2
{
    private readonly TerraFX.Interop.DirectX.IDxcValidator2* p;

    public TerraFX.Interop.DirectX.IDxcValidator2* Get() => this.p;

    public static implicit operator PIDxcValidator2(TerraFX.Interop.DirectX.IDxcValidator2* p) => *(PIDxcValidator2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcValidator2*(PIDxcValidator2 p) => (TerraFX.Interop.DirectX.IDxcValidator2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcValidator*(PIDxcValidator2 p) => (TerraFX.Interop.DirectX.IDxcValidator*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDxcValidator2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDxcValidator2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDxcVersionInfo
{
    private readonly TerraFX.Interop.DirectX.IDxcVersionInfo* p;

    public TerraFX.Interop.DirectX.IDxcVersionInfo* Get() => this.p;

    public static implicit operator PIDxcVersionInfo(TerraFX.Interop.DirectX.IDxcVersionInfo* p) => *(PIDxcVersionInfo*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcVersionInfo*(PIDxcVersionInfo p) => (TerraFX.Interop.DirectX.IDxcVersionInfo*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDxcVersionInfo p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDxcVersionInfo p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDxcVersionInfo2
{
    private readonly TerraFX.Interop.DirectX.IDxcVersionInfo2* p;

    public TerraFX.Interop.DirectX.IDxcVersionInfo2* Get() => this.p;

    public static implicit operator PIDxcVersionInfo2(TerraFX.Interop.DirectX.IDxcVersionInfo2* p) => *(PIDxcVersionInfo2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcVersionInfo2*(PIDxcVersionInfo2 p) => (TerraFX.Interop.DirectX.IDxcVersionInfo2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcVersionInfo*(PIDxcVersionInfo2 p) => (TerraFX.Interop.DirectX.IDxcVersionInfo*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDxcVersionInfo2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDxcVersionInfo2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDxcVersionInfo3
{
    private readonly TerraFX.Interop.DirectX.IDxcVersionInfo3* p;

    public TerraFX.Interop.DirectX.IDxcVersionInfo3* Get() => this.p;

    public static implicit operator PIDxcVersionInfo3(TerraFX.Interop.DirectX.IDxcVersionInfo3* p) => *(PIDxcVersionInfo3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDxcVersionInfo3*(PIDxcVersionInfo3 p) => (TerraFX.Interop.DirectX.IDxcVersionInfo3*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDxcVersionInfo3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDxcVersionInfo3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDxDiagContainer
{
    private readonly TerraFX.Interop.DirectX.IDxDiagContainer* p;

    public TerraFX.Interop.DirectX.IDxDiagContainer* Get() => this.p;

    public static implicit operator PIDxDiagContainer(TerraFX.Interop.DirectX.IDxDiagContainer* p) => *(PIDxDiagContainer*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDxDiagContainer*(PIDxDiagContainer p) => (TerraFX.Interop.DirectX.IDxDiagContainer*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDxDiagContainer p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDxDiagContainer p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDxDiagProvider
{
    private readonly TerraFX.Interop.DirectX.IDxDiagProvider* p;

    public TerraFX.Interop.DirectX.IDxDiagProvider* Get() => this.p;

    public static implicit operator PIDxDiagProvider(TerraFX.Interop.DirectX.IDxDiagProvider* p) => *(PIDxDiagProvider*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDxDiagProvider*(PIDxDiagProvider p) => (TerraFX.Interop.DirectX.IDxDiagProvider*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDxDiagProvider p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDxDiagProvider p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIAdapter
{
    private readonly TerraFX.Interop.DirectX.IDXGIAdapter* p;

    public TerraFX.Interop.DirectX.IDXGIAdapter* Get() => this.p;

    public static implicit operator PIDXGIAdapter(TerraFX.Interop.DirectX.IDXGIAdapter* p) => *(PIDXGIAdapter*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIAdapter*(PIDXGIAdapter p) => (TerraFX.Interop.DirectX.IDXGIAdapter*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIAdapter p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIAdapter p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIAdapter p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIAdapter1
{
    private readonly TerraFX.Interop.DirectX.IDXGIAdapter1* p;

    public TerraFX.Interop.DirectX.IDXGIAdapter1* Get() => this.p;

    public static implicit operator PIDXGIAdapter1(TerraFX.Interop.DirectX.IDXGIAdapter1* p) => *(PIDXGIAdapter1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIAdapter1*(PIDXGIAdapter1 p) => (TerraFX.Interop.DirectX.IDXGIAdapter1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIAdapter*(PIDXGIAdapter1 p) => (TerraFX.Interop.DirectX.IDXGIAdapter*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIAdapter1 p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIAdapter1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIAdapter1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIAdapter2
{
    private readonly TerraFX.Interop.DirectX.IDXGIAdapter2* p;

    public TerraFX.Interop.DirectX.IDXGIAdapter2* Get() => this.p;

    public static implicit operator PIDXGIAdapter2(TerraFX.Interop.DirectX.IDXGIAdapter2* p) => *(PIDXGIAdapter2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIAdapter2*(PIDXGIAdapter2 p) => (TerraFX.Interop.DirectX.IDXGIAdapter2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIAdapter1*(PIDXGIAdapter2 p) => (TerraFX.Interop.DirectX.IDXGIAdapter1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIAdapter*(PIDXGIAdapter2 p) => (TerraFX.Interop.DirectX.IDXGIAdapter*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIAdapter2 p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIAdapter2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIAdapter2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIAdapter3
{
    private readonly TerraFX.Interop.DirectX.IDXGIAdapter3* p;

    public TerraFX.Interop.DirectX.IDXGIAdapter3* Get() => this.p;

    public static implicit operator PIDXGIAdapter3(TerraFX.Interop.DirectX.IDXGIAdapter3* p) => *(PIDXGIAdapter3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIAdapter3*(PIDXGIAdapter3 p) => (TerraFX.Interop.DirectX.IDXGIAdapter3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIAdapter2*(PIDXGIAdapter3 p) => (TerraFX.Interop.DirectX.IDXGIAdapter2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIAdapter1*(PIDXGIAdapter3 p) => (TerraFX.Interop.DirectX.IDXGIAdapter1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIAdapter*(PIDXGIAdapter3 p) => (TerraFX.Interop.DirectX.IDXGIAdapter*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIAdapter3 p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIAdapter3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIAdapter3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIAdapter4
{
    private readonly TerraFX.Interop.DirectX.IDXGIAdapter4* p;

    public TerraFX.Interop.DirectX.IDXGIAdapter4* Get() => this.p;

    public static implicit operator PIDXGIAdapter4(TerraFX.Interop.DirectX.IDXGIAdapter4* p) => *(PIDXGIAdapter4*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIAdapter4*(PIDXGIAdapter4 p) => (TerraFX.Interop.DirectX.IDXGIAdapter4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIAdapter3*(PIDXGIAdapter4 p) => (TerraFX.Interop.DirectX.IDXGIAdapter3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIAdapter2*(PIDXGIAdapter4 p) => (TerraFX.Interop.DirectX.IDXGIAdapter2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIAdapter1*(PIDXGIAdapter4 p) => (TerraFX.Interop.DirectX.IDXGIAdapter1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIAdapter*(PIDXGIAdapter4 p) => (TerraFX.Interop.DirectX.IDXGIAdapter*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIAdapter4 p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIAdapter4 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIAdapter4 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIDebug
{
    private readonly TerraFX.Interop.DirectX.IDXGIDebug* p;

    public TerraFX.Interop.DirectX.IDXGIDebug* Get() => this.p;

    public static implicit operator PIDXGIDebug(TerraFX.Interop.DirectX.IDXGIDebug* p) => *(PIDXGIDebug*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDebug*(PIDXGIDebug p) => (TerraFX.Interop.DirectX.IDXGIDebug*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIDebug p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIDebug p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIDebug1
{
    private readonly TerraFX.Interop.DirectX.IDXGIDebug1* p;

    public TerraFX.Interop.DirectX.IDXGIDebug1* Get() => this.p;

    public static implicit operator PIDXGIDebug1(TerraFX.Interop.DirectX.IDXGIDebug1* p) => *(PIDXGIDebug1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDebug1*(PIDXGIDebug1 p) => (TerraFX.Interop.DirectX.IDXGIDebug1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDebug*(PIDXGIDebug1 p) => (TerraFX.Interop.DirectX.IDXGIDebug*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIDebug1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIDebug1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIDecodeSwapChain
{
    private readonly TerraFX.Interop.DirectX.IDXGIDecodeSwapChain* p;

    public TerraFX.Interop.DirectX.IDXGIDecodeSwapChain* Get() => this.p;

    public static implicit operator PIDXGIDecodeSwapChain(TerraFX.Interop.DirectX.IDXGIDecodeSwapChain* p) => *(PIDXGIDecodeSwapChain*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDecodeSwapChain*(PIDXGIDecodeSwapChain p) => (TerraFX.Interop.DirectX.IDXGIDecodeSwapChain*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIDecodeSwapChain p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIDecodeSwapChain p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIDevice
{
    private readonly TerraFX.Interop.DirectX.IDXGIDevice* p;

    public TerraFX.Interop.DirectX.IDXGIDevice* Get() => this.p;

    public static implicit operator PIDXGIDevice(TerraFX.Interop.DirectX.IDXGIDevice* p) => *(PIDXGIDevice*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDevice*(PIDXGIDevice p) => (TerraFX.Interop.DirectX.IDXGIDevice*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIDevice p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIDevice p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIDevice p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIDevice1
{
    private readonly TerraFX.Interop.DirectX.IDXGIDevice1* p;

    public TerraFX.Interop.DirectX.IDXGIDevice1* Get() => this.p;

    public static implicit operator PIDXGIDevice1(TerraFX.Interop.DirectX.IDXGIDevice1* p) => *(PIDXGIDevice1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDevice1*(PIDXGIDevice1 p) => (TerraFX.Interop.DirectX.IDXGIDevice1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDevice*(PIDXGIDevice1 p) => (TerraFX.Interop.DirectX.IDXGIDevice*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIDevice1 p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIDevice1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIDevice1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIDevice2
{
    private readonly TerraFX.Interop.DirectX.IDXGIDevice2* p;

    public TerraFX.Interop.DirectX.IDXGIDevice2* Get() => this.p;

    public static implicit operator PIDXGIDevice2(TerraFX.Interop.DirectX.IDXGIDevice2* p) => *(PIDXGIDevice2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDevice2*(PIDXGIDevice2 p) => (TerraFX.Interop.DirectX.IDXGIDevice2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDevice1*(PIDXGIDevice2 p) => (TerraFX.Interop.DirectX.IDXGIDevice1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDevice*(PIDXGIDevice2 p) => (TerraFX.Interop.DirectX.IDXGIDevice*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIDevice2 p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIDevice2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIDevice2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIDevice3
{
    private readonly TerraFX.Interop.DirectX.IDXGIDevice3* p;

    public TerraFX.Interop.DirectX.IDXGIDevice3* Get() => this.p;

    public static implicit operator PIDXGIDevice3(TerraFX.Interop.DirectX.IDXGIDevice3* p) => *(PIDXGIDevice3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDevice3*(PIDXGIDevice3 p) => (TerraFX.Interop.DirectX.IDXGIDevice3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDevice2*(PIDXGIDevice3 p) => (TerraFX.Interop.DirectX.IDXGIDevice2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDevice1*(PIDXGIDevice3 p) => (TerraFX.Interop.DirectX.IDXGIDevice1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDevice*(PIDXGIDevice3 p) => (TerraFX.Interop.DirectX.IDXGIDevice*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIDevice3 p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIDevice3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIDevice3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIDevice4
{
    private readonly TerraFX.Interop.DirectX.IDXGIDevice4* p;

    public TerraFX.Interop.DirectX.IDXGIDevice4* Get() => this.p;

    public static implicit operator PIDXGIDevice4(TerraFX.Interop.DirectX.IDXGIDevice4* p) => *(PIDXGIDevice4*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDevice4*(PIDXGIDevice4 p) => (TerraFX.Interop.DirectX.IDXGIDevice4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDevice3*(PIDXGIDevice4 p) => (TerraFX.Interop.DirectX.IDXGIDevice3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDevice2*(PIDXGIDevice4 p) => (TerraFX.Interop.DirectX.IDXGIDevice2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDevice1*(PIDXGIDevice4 p) => (TerraFX.Interop.DirectX.IDXGIDevice1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDevice*(PIDXGIDevice4 p) => (TerraFX.Interop.DirectX.IDXGIDevice*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIDevice4 p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIDevice4 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIDevice4 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIDeviceSubObject
{
    private readonly TerraFX.Interop.DirectX.IDXGIDeviceSubObject* p;

    public TerraFX.Interop.DirectX.IDXGIDeviceSubObject* Get() => this.p;

    public static implicit operator PIDXGIDeviceSubObject(TerraFX.Interop.DirectX.IDXGIDeviceSubObject* p) => *(PIDXGIDeviceSubObject*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDeviceSubObject*(PIDXGIDeviceSubObject p) => (TerraFX.Interop.DirectX.IDXGIDeviceSubObject*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIDeviceSubObject p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIDeviceSubObject p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIDeviceSubObject p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIDisplayControl
{
    private readonly TerraFX.Interop.DirectX.IDXGIDisplayControl* p;

    public TerraFX.Interop.DirectX.IDXGIDisplayControl* Get() => this.p;

    public static implicit operator PIDXGIDisplayControl(TerraFX.Interop.DirectX.IDXGIDisplayControl* p) => *(PIDXGIDisplayControl*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDisplayControl*(PIDXGIDisplayControl p) => (TerraFX.Interop.DirectX.IDXGIDisplayControl*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIDisplayControl p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIDisplayControl p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIFactory
{
    private readonly TerraFX.Interop.DirectX.IDXGIFactory* p;

    public TerraFX.Interop.DirectX.IDXGIFactory* Get() => this.p;

    public static implicit operator PIDXGIFactory(TerraFX.Interop.DirectX.IDXGIFactory* p) => *(PIDXGIFactory*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory*(PIDXGIFactory p) => (TerraFX.Interop.DirectX.IDXGIFactory*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIFactory p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIFactory p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIFactory p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIFactory1
{
    private readonly TerraFX.Interop.DirectX.IDXGIFactory1* p;

    public TerraFX.Interop.DirectX.IDXGIFactory1* Get() => this.p;

    public static implicit operator PIDXGIFactory1(TerraFX.Interop.DirectX.IDXGIFactory1* p) => *(PIDXGIFactory1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory1*(PIDXGIFactory1 p) => (TerraFX.Interop.DirectX.IDXGIFactory1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory*(PIDXGIFactory1 p) => (TerraFX.Interop.DirectX.IDXGIFactory*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIFactory1 p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIFactory1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIFactory1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIFactory2
{
    private readonly TerraFX.Interop.DirectX.IDXGIFactory2* p;

    public TerraFX.Interop.DirectX.IDXGIFactory2* Get() => this.p;

    public static implicit operator PIDXGIFactory2(TerraFX.Interop.DirectX.IDXGIFactory2* p) => *(PIDXGIFactory2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory2*(PIDXGIFactory2 p) => (TerraFX.Interop.DirectX.IDXGIFactory2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory1*(PIDXGIFactory2 p) => (TerraFX.Interop.DirectX.IDXGIFactory1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory*(PIDXGIFactory2 p) => (TerraFX.Interop.DirectX.IDXGIFactory*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIFactory2 p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIFactory2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIFactory2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIFactory3
{
    private readonly TerraFX.Interop.DirectX.IDXGIFactory3* p;

    public TerraFX.Interop.DirectX.IDXGIFactory3* Get() => this.p;

    public static implicit operator PIDXGIFactory3(TerraFX.Interop.DirectX.IDXGIFactory3* p) => *(PIDXGIFactory3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory3*(PIDXGIFactory3 p) => (TerraFX.Interop.DirectX.IDXGIFactory3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory2*(PIDXGIFactory3 p) => (TerraFX.Interop.DirectX.IDXGIFactory2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory1*(PIDXGIFactory3 p) => (TerraFX.Interop.DirectX.IDXGIFactory1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory*(PIDXGIFactory3 p) => (TerraFX.Interop.DirectX.IDXGIFactory*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIFactory3 p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIFactory3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIFactory3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIFactory4
{
    private readonly TerraFX.Interop.DirectX.IDXGIFactory4* p;

    public TerraFX.Interop.DirectX.IDXGIFactory4* Get() => this.p;

    public static implicit operator PIDXGIFactory4(TerraFX.Interop.DirectX.IDXGIFactory4* p) => *(PIDXGIFactory4*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory4*(PIDXGIFactory4 p) => (TerraFX.Interop.DirectX.IDXGIFactory4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory3*(PIDXGIFactory4 p) => (TerraFX.Interop.DirectX.IDXGIFactory3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory2*(PIDXGIFactory4 p) => (TerraFX.Interop.DirectX.IDXGIFactory2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory1*(PIDXGIFactory4 p) => (TerraFX.Interop.DirectX.IDXGIFactory1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory*(PIDXGIFactory4 p) => (TerraFX.Interop.DirectX.IDXGIFactory*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIFactory4 p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIFactory4 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIFactory4 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIFactory5
{
    private readonly TerraFX.Interop.DirectX.IDXGIFactory5* p;

    public TerraFX.Interop.DirectX.IDXGIFactory5* Get() => this.p;

    public static implicit operator PIDXGIFactory5(TerraFX.Interop.DirectX.IDXGIFactory5* p) => *(PIDXGIFactory5*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory5*(PIDXGIFactory5 p) => (TerraFX.Interop.DirectX.IDXGIFactory5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory4*(PIDXGIFactory5 p) => (TerraFX.Interop.DirectX.IDXGIFactory4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory3*(PIDXGIFactory5 p) => (TerraFX.Interop.DirectX.IDXGIFactory3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory2*(PIDXGIFactory5 p) => (TerraFX.Interop.DirectX.IDXGIFactory2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory1*(PIDXGIFactory5 p) => (TerraFX.Interop.DirectX.IDXGIFactory1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory*(PIDXGIFactory5 p) => (TerraFX.Interop.DirectX.IDXGIFactory*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIFactory5 p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIFactory5 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIFactory5 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIFactory6
{
    private readonly TerraFX.Interop.DirectX.IDXGIFactory6* p;

    public TerraFX.Interop.DirectX.IDXGIFactory6* Get() => this.p;

    public static implicit operator PIDXGIFactory6(TerraFX.Interop.DirectX.IDXGIFactory6* p) => *(PIDXGIFactory6*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory6*(PIDXGIFactory6 p) => (TerraFX.Interop.DirectX.IDXGIFactory6*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory5*(PIDXGIFactory6 p) => (TerraFX.Interop.DirectX.IDXGIFactory5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory4*(PIDXGIFactory6 p) => (TerraFX.Interop.DirectX.IDXGIFactory4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory3*(PIDXGIFactory6 p) => (TerraFX.Interop.DirectX.IDXGIFactory3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory2*(PIDXGIFactory6 p) => (TerraFX.Interop.DirectX.IDXGIFactory2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory1*(PIDXGIFactory6 p) => (TerraFX.Interop.DirectX.IDXGIFactory1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory*(PIDXGIFactory6 p) => (TerraFX.Interop.DirectX.IDXGIFactory*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIFactory6 p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIFactory6 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIFactory6 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIFactory7
{
    private readonly TerraFX.Interop.DirectX.IDXGIFactory7* p;

    public TerraFX.Interop.DirectX.IDXGIFactory7* Get() => this.p;

    public static implicit operator PIDXGIFactory7(TerraFX.Interop.DirectX.IDXGIFactory7* p) => *(PIDXGIFactory7*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory7*(PIDXGIFactory7 p) => (TerraFX.Interop.DirectX.IDXGIFactory7*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory6*(PIDXGIFactory7 p) => (TerraFX.Interop.DirectX.IDXGIFactory6*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory5*(PIDXGIFactory7 p) => (TerraFX.Interop.DirectX.IDXGIFactory5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory4*(PIDXGIFactory7 p) => (TerraFX.Interop.DirectX.IDXGIFactory4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory3*(PIDXGIFactory7 p) => (TerraFX.Interop.DirectX.IDXGIFactory3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory2*(PIDXGIFactory7 p) => (TerraFX.Interop.DirectX.IDXGIFactory2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory1*(PIDXGIFactory7 p) => (TerraFX.Interop.DirectX.IDXGIFactory1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactory*(PIDXGIFactory7 p) => (TerraFX.Interop.DirectX.IDXGIFactory*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIFactory7 p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIFactory7 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIFactory7 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIFactoryMedia
{
    private readonly TerraFX.Interop.DirectX.IDXGIFactoryMedia* p;

    public TerraFX.Interop.DirectX.IDXGIFactoryMedia* Get() => this.p;

    public static implicit operator PIDXGIFactoryMedia(TerraFX.Interop.DirectX.IDXGIFactoryMedia* p) => *(PIDXGIFactoryMedia*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIFactoryMedia*(PIDXGIFactoryMedia p) => (TerraFX.Interop.DirectX.IDXGIFactoryMedia*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIFactoryMedia p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIFactoryMedia p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIInfoQueue
{
    private readonly TerraFX.Interop.DirectX.IDXGIInfoQueue* p;

    public TerraFX.Interop.DirectX.IDXGIInfoQueue* Get() => this.p;

    public static implicit operator PIDXGIInfoQueue(TerraFX.Interop.DirectX.IDXGIInfoQueue* p) => *(PIDXGIInfoQueue*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIInfoQueue*(PIDXGIInfoQueue p) => (TerraFX.Interop.DirectX.IDXGIInfoQueue*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIInfoQueue p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIInfoQueue p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIKeyedMutex
{
    private readonly TerraFX.Interop.DirectX.IDXGIKeyedMutex* p;

    public TerraFX.Interop.DirectX.IDXGIKeyedMutex* Get() => this.p;

    public static implicit operator PIDXGIKeyedMutex(TerraFX.Interop.DirectX.IDXGIKeyedMutex* p) => *(PIDXGIKeyedMutex*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIKeyedMutex*(PIDXGIKeyedMutex p) => (TerraFX.Interop.DirectX.IDXGIKeyedMutex*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDeviceSubObject*(PIDXGIKeyedMutex p) => (TerraFX.Interop.DirectX.IDXGIDeviceSubObject*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIKeyedMutex p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIKeyedMutex p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIKeyedMutex p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIObject
{
    private readonly TerraFX.Interop.DirectX.IDXGIObject* p;

    public TerraFX.Interop.DirectX.IDXGIObject* Get() => this.p;

    public static implicit operator PIDXGIObject(TerraFX.Interop.DirectX.IDXGIObject* p) => *(PIDXGIObject*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIObject p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIObject p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIObject p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIOutput
{
    private readonly TerraFX.Interop.DirectX.IDXGIOutput* p;

    public TerraFX.Interop.DirectX.IDXGIOutput* Get() => this.p;

    public static implicit operator PIDXGIOutput(TerraFX.Interop.DirectX.IDXGIOutput* p) => *(PIDXGIOutput*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIOutput*(PIDXGIOutput p) => (TerraFX.Interop.DirectX.IDXGIOutput*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIOutput p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIOutput p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIOutput p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIOutput1
{
    private readonly TerraFX.Interop.DirectX.IDXGIOutput1* p;

    public TerraFX.Interop.DirectX.IDXGIOutput1* Get() => this.p;

    public static implicit operator PIDXGIOutput1(TerraFX.Interop.DirectX.IDXGIOutput1* p) => *(PIDXGIOutput1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIOutput1*(PIDXGIOutput1 p) => (TerraFX.Interop.DirectX.IDXGIOutput1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIOutput*(PIDXGIOutput1 p) => (TerraFX.Interop.DirectX.IDXGIOutput*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIOutput1 p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIOutput1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIOutput1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIOutput2
{
    private readonly TerraFX.Interop.DirectX.IDXGIOutput2* p;

    public TerraFX.Interop.DirectX.IDXGIOutput2* Get() => this.p;

    public static implicit operator PIDXGIOutput2(TerraFX.Interop.DirectX.IDXGIOutput2* p) => *(PIDXGIOutput2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIOutput2*(PIDXGIOutput2 p) => (TerraFX.Interop.DirectX.IDXGIOutput2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIOutput1*(PIDXGIOutput2 p) => (TerraFX.Interop.DirectX.IDXGIOutput1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIOutput*(PIDXGIOutput2 p) => (TerraFX.Interop.DirectX.IDXGIOutput*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIOutput2 p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIOutput2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIOutput2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIOutput3
{
    private readonly TerraFX.Interop.DirectX.IDXGIOutput3* p;

    public TerraFX.Interop.DirectX.IDXGIOutput3* Get() => this.p;

    public static implicit operator PIDXGIOutput3(TerraFX.Interop.DirectX.IDXGIOutput3* p) => *(PIDXGIOutput3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIOutput3*(PIDXGIOutput3 p) => (TerraFX.Interop.DirectX.IDXGIOutput3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIOutput2*(PIDXGIOutput3 p) => (TerraFX.Interop.DirectX.IDXGIOutput2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIOutput1*(PIDXGIOutput3 p) => (TerraFX.Interop.DirectX.IDXGIOutput1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIOutput*(PIDXGIOutput3 p) => (TerraFX.Interop.DirectX.IDXGIOutput*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIOutput3 p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIOutput3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIOutput3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIOutput4
{
    private readonly TerraFX.Interop.DirectX.IDXGIOutput4* p;

    public TerraFX.Interop.DirectX.IDXGIOutput4* Get() => this.p;

    public static implicit operator PIDXGIOutput4(TerraFX.Interop.DirectX.IDXGIOutput4* p) => *(PIDXGIOutput4*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIOutput4*(PIDXGIOutput4 p) => (TerraFX.Interop.DirectX.IDXGIOutput4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIOutput3*(PIDXGIOutput4 p) => (TerraFX.Interop.DirectX.IDXGIOutput3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIOutput2*(PIDXGIOutput4 p) => (TerraFX.Interop.DirectX.IDXGIOutput2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIOutput1*(PIDXGIOutput4 p) => (TerraFX.Interop.DirectX.IDXGIOutput1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIOutput*(PIDXGIOutput4 p) => (TerraFX.Interop.DirectX.IDXGIOutput*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIOutput4 p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIOutput4 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIOutput4 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIOutput5
{
    private readonly TerraFX.Interop.DirectX.IDXGIOutput5* p;

    public TerraFX.Interop.DirectX.IDXGIOutput5* Get() => this.p;

    public static implicit operator PIDXGIOutput5(TerraFX.Interop.DirectX.IDXGIOutput5* p) => *(PIDXGIOutput5*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIOutput5*(PIDXGIOutput5 p) => (TerraFX.Interop.DirectX.IDXGIOutput5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIOutput4*(PIDXGIOutput5 p) => (TerraFX.Interop.DirectX.IDXGIOutput4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIOutput3*(PIDXGIOutput5 p) => (TerraFX.Interop.DirectX.IDXGIOutput3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIOutput2*(PIDXGIOutput5 p) => (TerraFX.Interop.DirectX.IDXGIOutput2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIOutput1*(PIDXGIOutput5 p) => (TerraFX.Interop.DirectX.IDXGIOutput1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIOutput*(PIDXGIOutput5 p) => (TerraFX.Interop.DirectX.IDXGIOutput*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIOutput5 p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIOutput5 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIOutput5 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIOutput6
{
    private readonly TerraFX.Interop.DirectX.IDXGIOutput6* p;

    public TerraFX.Interop.DirectX.IDXGIOutput6* Get() => this.p;

    public static implicit operator PIDXGIOutput6(TerraFX.Interop.DirectX.IDXGIOutput6* p) => *(PIDXGIOutput6*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIOutput6*(PIDXGIOutput6 p) => (TerraFX.Interop.DirectX.IDXGIOutput6*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIOutput5*(PIDXGIOutput6 p) => (TerraFX.Interop.DirectX.IDXGIOutput5*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIOutput4*(PIDXGIOutput6 p) => (TerraFX.Interop.DirectX.IDXGIOutput4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIOutput3*(PIDXGIOutput6 p) => (TerraFX.Interop.DirectX.IDXGIOutput3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIOutput2*(PIDXGIOutput6 p) => (TerraFX.Interop.DirectX.IDXGIOutput2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIOutput1*(PIDXGIOutput6 p) => (TerraFX.Interop.DirectX.IDXGIOutput1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIOutput*(PIDXGIOutput6 p) => (TerraFX.Interop.DirectX.IDXGIOutput*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIOutput6 p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIOutput6 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIOutput6 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIOutputDuplication
{
    private readonly TerraFX.Interop.DirectX.IDXGIOutputDuplication* p;

    public TerraFX.Interop.DirectX.IDXGIOutputDuplication* Get() => this.p;

    public static implicit operator PIDXGIOutputDuplication(TerraFX.Interop.DirectX.IDXGIOutputDuplication* p) => *(PIDXGIOutputDuplication*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIOutputDuplication*(PIDXGIOutputDuplication p) => (TerraFX.Interop.DirectX.IDXGIOutputDuplication*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIOutputDuplication p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIOutputDuplication p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIOutputDuplication p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIResource
{
    private readonly TerraFX.Interop.DirectX.IDXGIResource* p;

    public TerraFX.Interop.DirectX.IDXGIResource* Get() => this.p;

    public static implicit operator PIDXGIResource(TerraFX.Interop.DirectX.IDXGIResource* p) => *(PIDXGIResource*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIResource*(PIDXGIResource p) => (TerraFX.Interop.DirectX.IDXGIResource*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDeviceSubObject*(PIDXGIResource p) => (TerraFX.Interop.DirectX.IDXGIDeviceSubObject*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIResource p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIResource p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIResource p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGIResource1
{
    private readonly TerraFX.Interop.DirectX.IDXGIResource1* p;

    public TerraFX.Interop.DirectX.IDXGIResource1* Get() => this.p;

    public static implicit operator PIDXGIResource1(TerraFX.Interop.DirectX.IDXGIResource1* p) => *(PIDXGIResource1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIResource1*(PIDXGIResource1 p) => (TerraFX.Interop.DirectX.IDXGIResource1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIResource*(PIDXGIResource1 p) => (TerraFX.Interop.DirectX.IDXGIResource*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDeviceSubObject*(PIDXGIResource1 p) => (TerraFX.Interop.DirectX.IDXGIDeviceSubObject*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGIResource1 p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGIResource1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGIResource1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGISurface
{
    private readonly TerraFX.Interop.DirectX.IDXGISurface* p;

    public TerraFX.Interop.DirectX.IDXGISurface* Get() => this.p;

    public static implicit operator PIDXGISurface(TerraFX.Interop.DirectX.IDXGISurface* p) => *(PIDXGISurface*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGISurface*(PIDXGISurface p) => (TerraFX.Interop.DirectX.IDXGISurface*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDeviceSubObject*(PIDXGISurface p) => (TerraFX.Interop.DirectX.IDXGIDeviceSubObject*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGISurface p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGISurface p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGISurface p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGISurface1
{
    private readonly TerraFX.Interop.DirectX.IDXGISurface1* p;

    public TerraFX.Interop.DirectX.IDXGISurface1* Get() => this.p;

    public static implicit operator PIDXGISurface1(TerraFX.Interop.DirectX.IDXGISurface1* p) => *(PIDXGISurface1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGISurface1*(PIDXGISurface1 p) => (TerraFX.Interop.DirectX.IDXGISurface1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGISurface*(PIDXGISurface1 p) => (TerraFX.Interop.DirectX.IDXGISurface*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDeviceSubObject*(PIDXGISurface1 p) => (TerraFX.Interop.DirectX.IDXGIDeviceSubObject*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGISurface1 p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGISurface1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGISurface1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGISurface2
{
    private readonly TerraFX.Interop.DirectX.IDXGISurface2* p;

    public TerraFX.Interop.DirectX.IDXGISurface2* Get() => this.p;

    public static implicit operator PIDXGISurface2(TerraFX.Interop.DirectX.IDXGISurface2* p) => *(PIDXGISurface2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGISurface2*(PIDXGISurface2 p) => (TerraFX.Interop.DirectX.IDXGISurface2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGISurface1*(PIDXGISurface2 p) => (TerraFX.Interop.DirectX.IDXGISurface1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGISurface*(PIDXGISurface2 p) => (TerraFX.Interop.DirectX.IDXGISurface*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDeviceSubObject*(PIDXGISurface2 p) => (TerraFX.Interop.DirectX.IDXGIDeviceSubObject*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGISurface2 p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGISurface2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGISurface2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGISwapChain
{
    private readonly TerraFX.Interop.DirectX.IDXGISwapChain* p;

    public TerraFX.Interop.DirectX.IDXGISwapChain* Get() => this.p;

    public static implicit operator PIDXGISwapChain(TerraFX.Interop.DirectX.IDXGISwapChain* p) => *(PIDXGISwapChain*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGISwapChain*(PIDXGISwapChain p) => (TerraFX.Interop.DirectX.IDXGISwapChain*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDeviceSubObject*(PIDXGISwapChain p) => (TerraFX.Interop.DirectX.IDXGIDeviceSubObject*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGISwapChain p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGISwapChain p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGISwapChain p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGISwapChain1
{
    private readonly TerraFX.Interop.DirectX.IDXGISwapChain1* p;

    public TerraFX.Interop.DirectX.IDXGISwapChain1* Get() => this.p;

    public static implicit operator PIDXGISwapChain1(TerraFX.Interop.DirectX.IDXGISwapChain1* p) => *(PIDXGISwapChain1*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGISwapChain1*(PIDXGISwapChain1 p) => (TerraFX.Interop.DirectX.IDXGISwapChain1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGISwapChain*(PIDXGISwapChain1 p) => (TerraFX.Interop.DirectX.IDXGISwapChain*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDeviceSubObject*(PIDXGISwapChain1 p) => (TerraFX.Interop.DirectX.IDXGIDeviceSubObject*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGISwapChain1 p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGISwapChain1 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGISwapChain1 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGISwapChain2
{
    private readonly TerraFX.Interop.DirectX.IDXGISwapChain2* p;

    public TerraFX.Interop.DirectX.IDXGISwapChain2* Get() => this.p;

    public static implicit operator PIDXGISwapChain2(TerraFX.Interop.DirectX.IDXGISwapChain2* p) => *(PIDXGISwapChain2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGISwapChain2*(PIDXGISwapChain2 p) => (TerraFX.Interop.DirectX.IDXGISwapChain2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGISwapChain1*(PIDXGISwapChain2 p) => (TerraFX.Interop.DirectX.IDXGISwapChain1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGISwapChain*(PIDXGISwapChain2 p) => (TerraFX.Interop.DirectX.IDXGISwapChain*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDeviceSubObject*(PIDXGISwapChain2 p) => (TerraFX.Interop.DirectX.IDXGIDeviceSubObject*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGISwapChain2 p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGISwapChain2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGISwapChain2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGISwapChain3
{
    private readonly TerraFX.Interop.DirectX.IDXGISwapChain3* p;

    public TerraFX.Interop.DirectX.IDXGISwapChain3* Get() => this.p;

    public static implicit operator PIDXGISwapChain3(TerraFX.Interop.DirectX.IDXGISwapChain3* p) => *(PIDXGISwapChain3*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGISwapChain3*(PIDXGISwapChain3 p) => (TerraFX.Interop.DirectX.IDXGISwapChain3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGISwapChain2*(PIDXGISwapChain3 p) => (TerraFX.Interop.DirectX.IDXGISwapChain2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGISwapChain1*(PIDXGISwapChain3 p) => (TerraFX.Interop.DirectX.IDXGISwapChain1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGISwapChain*(PIDXGISwapChain3 p) => (TerraFX.Interop.DirectX.IDXGISwapChain*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDeviceSubObject*(PIDXGISwapChain3 p) => (TerraFX.Interop.DirectX.IDXGIDeviceSubObject*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGISwapChain3 p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGISwapChain3 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGISwapChain3 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGISwapChain4
{
    private readonly TerraFX.Interop.DirectX.IDXGISwapChain4* p;

    public TerraFX.Interop.DirectX.IDXGISwapChain4* Get() => this.p;

    public static implicit operator PIDXGISwapChain4(TerraFX.Interop.DirectX.IDXGISwapChain4* p) => *(PIDXGISwapChain4*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGISwapChain4*(PIDXGISwapChain4 p) => (TerraFX.Interop.DirectX.IDXGISwapChain4*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGISwapChain3*(PIDXGISwapChain4 p) => (TerraFX.Interop.DirectX.IDXGISwapChain3*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGISwapChain2*(PIDXGISwapChain4 p) => (TerraFX.Interop.DirectX.IDXGISwapChain2*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGISwapChain1*(PIDXGISwapChain4 p) => (TerraFX.Interop.DirectX.IDXGISwapChain1*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGISwapChain*(PIDXGISwapChain4 p) => (TerraFX.Interop.DirectX.IDXGISwapChain*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIDeviceSubObject*(PIDXGISwapChain4 p) => (TerraFX.Interop.DirectX.IDXGIDeviceSubObject*)p.p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGIObject*(PIDXGISwapChain4 p) => (TerraFX.Interop.DirectX.IDXGIObject*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGISwapChain4 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGISwapChain4 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGISwapChainMedia
{
    private readonly TerraFX.Interop.DirectX.IDXGISwapChainMedia* p;

    public TerraFX.Interop.DirectX.IDXGISwapChainMedia* Get() => this.p;

    public static implicit operator PIDXGISwapChainMedia(TerraFX.Interop.DirectX.IDXGISwapChainMedia* p) => *(PIDXGISwapChainMedia*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGISwapChainMedia*(PIDXGISwapChainMedia p) => (TerraFX.Interop.DirectX.IDXGISwapChainMedia*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGISwapChainMedia p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGISwapChainMedia p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIDXGraphicsAnalysis
{
    private readonly TerraFX.Interop.DirectX.IDXGraphicsAnalysis* p;

    public TerraFX.Interop.DirectX.IDXGraphicsAnalysis* Get() => this.p;

    public static implicit operator PIDXGraphicsAnalysis(TerraFX.Interop.DirectX.IDXGraphicsAnalysis* p) => *(PIDXGraphicsAnalysis*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IDXGraphicsAnalysis*(PIDXGraphicsAnalysis p) => (TerraFX.Interop.DirectX.IDXGraphicsAnalysis*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIDXGraphicsAnalysis p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIDXGraphicsAnalysis p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIXAPO
{
    private readonly TerraFX.Interop.DirectX.IXAPO* p;

    public TerraFX.Interop.DirectX.IXAPO* Get() => this.p;

    public static implicit operator PIXAPO(TerraFX.Interop.DirectX.IXAPO* p) => *(PIXAPO*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IXAPO*(PIXAPO p) => (TerraFX.Interop.DirectX.IXAPO*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIXAPO p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIXAPO p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIXAPOParameters
{
    private readonly TerraFX.Interop.DirectX.IXAPOParameters* p;

    public TerraFX.Interop.DirectX.IXAPOParameters* Get() => this.p;

    public static implicit operator PIXAPOParameters(TerraFX.Interop.DirectX.IXAPOParameters* p) => *(PIXAPOParameters*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IXAPOParameters*(PIXAPOParameters p) => (TerraFX.Interop.DirectX.IXAPOParameters*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIXAPOParameters p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIXAPOParameters p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIXAudio2
{
    private readonly TerraFX.Interop.DirectX.IXAudio2* p;

    public TerraFX.Interop.DirectX.IXAudio2* Get() => this.p;

    public static implicit operator PIXAudio2(TerraFX.Interop.DirectX.IXAudio2* p) => *(PIXAudio2*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IXAudio2*(PIXAudio2 p) => (TerraFX.Interop.DirectX.IXAudio2*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIXAudio2 p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIXAudio2 p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct PIXAudio2Extension
{
    private readonly TerraFX.Interop.DirectX.IXAudio2Extension* p;

    public TerraFX.Interop.DirectX.IXAudio2Extension* Get() => this.p;

    public static implicit operator PIXAudio2Extension(TerraFX.Interop.DirectX.IXAudio2Extension* p) => *(PIXAudio2Extension*)&p;
    public static implicit operator TerraFX.Interop.DirectX.IXAudio2Extension*(PIXAudio2Extension p) => (TerraFX.Interop.DirectX.IXAudio2Extension*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(PIXAudio2Extension p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(PIXAudio2Extension p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct POpenCLOn12CreatorID
{
    private readonly TerraFX.Interop.DirectX.OpenCLOn12CreatorID* p;

    public TerraFX.Interop.DirectX.OpenCLOn12CreatorID* Get() => this.p;

    public static implicit operator POpenCLOn12CreatorID(TerraFX.Interop.DirectX.OpenCLOn12CreatorID* p) => *(POpenCLOn12CreatorID*)&p;
    public static implicit operator TerraFX.Interop.DirectX.OpenCLOn12CreatorID*(POpenCLOn12CreatorID p) => (TerraFX.Interop.DirectX.OpenCLOn12CreatorID*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(POpenCLOn12CreatorID p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(POpenCLOn12CreatorID p) => p.p;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe readonly ref struct POpenGLOn12CreatorID
{
    private readonly TerraFX.Interop.DirectX.OpenGLOn12CreatorID* p;

    public TerraFX.Interop.DirectX.OpenGLOn12CreatorID* Get() => this.p;

    public static implicit operator POpenGLOn12CreatorID(TerraFX.Interop.DirectX.OpenGLOn12CreatorID* p) => *(POpenGLOn12CreatorID*)&p;
    public static implicit operator TerraFX.Interop.DirectX.OpenGLOn12CreatorID*(POpenGLOn12CreatorID p) => (TerraFX.Interop.DirectX.OpenGLOn12CreatorID*)p.p;
    public static implicit operator TerraFX.Interop.Windows.IUnknown*(POpenGLOn12CreatorID p) => (TerraFX.Interop.Windows.IUnknown*)p.p;
    public static implicit operator void*(POpenGLOn12CreatorID p) => p.p;
}
