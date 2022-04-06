## PointerToolkit.TerraFX.Interop.Windows

﻿Provides methods ("operators") that enable compile-time type-safety when casting COM interface pointers from the [TerraFX.Interop.Windows](https://github.com/terrafx/terrafx.interop.windows) package.

C# and .NET do not have struct inheritance. The COM interface structs defined in [TerraFX.Interop.Windows](https://github.com/terrafx/terrafx.interop.windows) project the native COM interfaces defined in the Windows SDK. These COM interfaces have inheritance, but this cannot be expressed in .NET, and the C# compiler knows nothing about it. This gives us the problem where you may have a pointer to a COM object that should be implicitly castable to its base interface, but C# won't let you do it without an explicit cast.

For example, let's say you're doing some drawing with Direct2D and you want to fill a rectangle with a solid color brush:

```csharp
ID2D1SolidColorBrush* pBrush;
HRESULT hr = pFactory->CreateSolidColorBrush(..., &pBrush); // creates a brush
...
pRenderTarget->FillRectangle(..., pBrush); // error: ID2D1SolidColorBrush* isn't an ID2D1Brush*
```

To fix this you can of course insert a cast to `ID2D1Brush*`:

```csharp
ID2D1SolidColorBrush* pBrush;
HRESULT hr = pFactory->CreateSolidColorBrush(..., &pBrush); // creates a brush
...
pRenderTarget->FillRectangle(..., (ID2D1Brush*)pBrush); // works fine, but error prone
```

In a large code base, this is error-prone. If you cast to the wrong type you will get errors at runtime -- hopefully. In the worst case you'll have heap corruption, smashed stacks, crashes, and security vulnerabilities. We developers are imperfect beings, and we need the compiler's help at every step along the way.

[PointerToolkit](https://github.com/rickbrew/PointerToolkit), among other things, introduces a suite of `ref struct`s called `CastPtr<T, TBase1, ..., TBaseN>`. They wrap a pointer and provide implicit casting operators to the provided "base" types. 

This package then defines a suite of generated `__cast()` methods ("operators") that take pointers to these COM objects and return `CastPtr<...>` to permit you to use a derived pointer type when a base pointer type is needed.

For example:

```csharp
ID2D1SolidColorBrush* pBrush;
HRESULT hr = pFactory->CreateSolidColorBrush(..., &pBrush); // creates a brush
...
pRenderTarget->FillRectangle(..., __cast(pBrush)); // works great, not error prone!
```

When using this package, I highly recommend adding `global using static`s for the various `Pointers` classes from this package:

```csharp
global using static TerraFX.Interop.DirectX.Pointers;
global using static TerraFX.Interop.Gdiplus.Pointers;
global using static TerraFX.Interop.Windows.Pointers;
global using static TerraFX.Interop.WinRT.Pointers;
```

You can then use `__cast(p)` as if it were one of those ugly-but-useful vendor-specific extensions that C++ compilers have loads of.

Oh, I also recommend using trimming. I use `illink` in a custom post-build event rather than relying on the built-in facilities that MSBuild and Visual Studio provide. This way I can trim only the DLLs I need trimmed, such as TerraFX.Interop.Windows.dll and PointerToolkit.TerraFX.Interop.Windows.dll.