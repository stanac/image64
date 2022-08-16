# Image64

Dotnet tool for converting images from file to base64 web data string.

## Install

Install dotnet 6 if not installed, then:

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
d:\>dotnet image64 image.png
---------------
data:image/png;base64, iVBORw0KGgoAAAANSUhEUgAAADQAAAArAQMAAAANNjnmAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAGUExURVlNW/3+/camVroAAAAJcEhZcwAADsMAAA7DAcdvqGQAAABqSURBVCjPY/gPBh/Ipn///zkfG/3LxnKOPZD+OXPmzPkg8ds3Z98H0TckIfTtnxD65k+I/B1JsHpK3QMkfv7FQn/e3c55EGSPtbHlTBAtXF25F+S+cAj9B0YfN64Eyf953155lFx3/P8AADB3D1nX2bYDAAAAAElFTkSuQmCC
---------------
Base64 image text copied to clipboard.

d:\>
```