# Image64

Dotnet tool for converting images from file to base64 web data string.

## Install

Install dotnet 6, then:

```
dotnet tool install image64 -g
```

## Usage

```
dotnet image64 {file-path-to-image}
```

Supported extensions:
- png
- gif
- jpg/jpeg
- bmp

Example:

```
d:\>image64 image.png
---------------
data:image/png;base64, iVBORw0KGgoAAAANSUhEUgAAADQAAAArAQMAAAANNjnmAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAGUExURVlNW/3+/camVroAAAAJcEhZcwAADsMAAA7DAcdvqGQAAABqSURBVCjPY/gPBh/Ipn///zkfG/3LxnKOPZD+OXPmzPkg8ds3Z98H0TckIfTtnxD65k+I/B1JsHpK3QMkfv7FQn/e3c55EGSPtbHlTBAtXF25F+S+cAj9B0YfN64Eyf953155lFx3/P8AADB3D1nX2bYDAAAAAElFTkSuQmCC
---------------
Base64 image text copied to clipboard.

d:\>
```

## License

```
This is free and unencumbered software released into the public domain.

Anyone is free to copy, modify, publish, use, compile, sell, or
distribute this software, either in source code form or as a compiled
binary, for any purpose, commercial or non-commercial, and by any
means.

In jurisdictions that recognize copyright laws, the author or authors
of this software dedicate any and all copyright interest in the
software to the public domain. We make this dedication for the benefit
of the public at large and to the detriment of our heirs and
successors. We intend this dedication to be an overt act of
relinquishment in perpetuity of all present and future rights to this
software under copyright law.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR
OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
OTHER DEALINGS IN THE SOFTWARE.

For more information, please refer to <http://unlicense.org/>
```