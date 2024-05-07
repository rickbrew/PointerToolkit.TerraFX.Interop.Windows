## PointerToolkit.TerraFX.Interop.Windows

﻿Provides structs and methods ("operators") that enable compile-time type-safety when casting COM interface pointers from the [TerraFX.Interop.Windows](https://github.com/terrafx/terrafx.interop.windows) package.

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

In a large code base, this is error-prone and difficult to spot at code review time. If you cast to the wrong type you will get errors at runtime -- *hopefully*. In the worst case you'll have heap corruption, smashed stacks, crashes, and security vulnerabilities. We developers are imperfect beings, and we need the compiler's help at every step along the way.

There are two ways that this package affords you the ability to have type-safe pointer casting: per-type `P` wrapper structs (new style), and per-type `__cast()` method operators (old style). Which one you use depends on your preferences and the performance impact on your build. See the **Performance** section below for more info.

### `P` wrapper structs (new style)

This package defines, for every single COM interface struct in TerraFX.Interop.Windows, a corresponding wrapper struct whose name is `P` followed by the COM interface struct's name. For instance, `PID2D1SolidColorBrush` corresponds to `ID2D1SolidColorBrush*`. These structs then have implicit casting operators back to the original pointer type, and to all pointer types on the "inheritance" chain.

For example:

```csharp
ID2D1SolidColorBrush* pBrush;
HRESULT hr = pFactory->CreateSolidColorBrush(..., &pBrush); // creates a brush
...
pRenderTarget->FillRectangle(..., (PID2D1SolidColorBrush)pBrush); // will implicitly cast to ID2D1Brush*, not error prone!
```

While this syntax is not as convenient as the old `__cast()` method operators, its build-time performance is enormously better. You *must* cast to the COM interface's specific `P` wrapper struct, there are no implicit or explicit casts to the other wrapper structs (you cannot do e.g. `(PID2D1Brush)` or `(PIUnknown)` in the code snippet above). This ensures that there is not an overwhelming number of cast operators (which are still methods) for the compiler to search through. Otherwise `PIUnknown` would have ~6500 cast operators!

### __cast() method operators (old style)

This package also defines, for every single COM interface struct, a `__cast()` method which takes the pointer and returns the corresponding `P` wrapper struct (it used to return a `CastPtr<...>`).

For example:

```csharp
ID2D1SolidColorBrush* pBrush;
HRESULT hr = pFactory->CreateSolidColorBrush(..., &pBrush); // creates a brush
...
pRenderTarget->FillRectangle(..., __cast(pBrush)); // works great, not error prone!
```

When using this method for achieving type safe casting, consider adding `global using static`s for the various `Pointers` classes that you are using from this package:

```csharp
global using static TerraFX.Interop.DirectX.Pointers;
global using static TerraFX.Interop.Gdiplus.Pointers;
global using static TerraFX.Interop.Windows.Pointers;
global using static TerraFX.Interop.WinRT.Pointers;
```

***NOTE:** Only add these for the ones you actually use! See the **Performance** section below.*

You can then use `__cast(p)` as if it were one of those ugly-but-useful vendor-specific extensions that C++ compilers have loads of.

### Performance

The runtime performance of this package should be negligible-to-none. The modern .NET JIT should be capable of inlining all of it.

Build-time performance is another matter. The `__cast()` operators are fine if you're only `global static using` the DirectX or the Windows namespaces by themselves. If you have both then it will slow down the build "a lot" but you may not even notice it if your project is small enough. If you use all 3 of them (DirectX, Windows, and WinRT), your build time will SUFFER IMMENSELY.

To give you an idea of what I mean: `PaintDotNet.Windows.dll` was taking **40 seconds** to build on a Ryzen 9 7950X CPU. I then switched to the `P` wrapper structs, removed my use of `__cast()` entirely, and the build time was reduced to **2 seconds**. And this was with only about 200 uses of `__cast()`! The problem is that the compiler gets bogged down when it needs to find the right method overload in a list of ~6500 methods with the same name. It is a complicated problem space, and I do not expect them to optimize for this particular niche.

**Recommendation:** `__cast()` is fine if you're only importing the DirectX *or* Windows namespaces. Beyond that, switch to the `P` wrapper structs.

### Trimming

I recommend using trimming. I use `illink` in a custom post-build event rather than relying on the built-in facilities that MSBuild and Visual Studio provide. This way I can trim only the DLLs I need trimmed, such as TerraFX.Interop.Windows.dll and PointerToolkit.TerraFX.Interop.Windows.dll.