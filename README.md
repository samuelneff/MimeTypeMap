# MimeTypeMap

English | [简体中文](README-zh-Hans.md)

## Summary
Provides a huge two-way mapping of file extensions to mime types and mime types to file extensions, e.g.:

```c#
...
{".jpe", "image/jpeg"},
{".jpeg", "image/jpeg"},
{".jpg", "image/jpeg"},
{".js", "application/javascript"},
{".json", "application/json"},
...
```

Most mime types that have multiple possible extensions are pre-defined to get the most common extension when looking
up extension by mime type. Since multiple extensions can map to the same mime type, it is not necessary that `GetExtension(GetMimeType(ext))` returns the original extension - it will return the most common extension.

Originally posted on StackOverflow here: http://stackoverflow.com/questions/1029740/get-mime-type-from-filename-extension

## NuGet

There are several packages on NuGet built from this repo. The official one is at this URL.

https://www.nuget.org/packages/MimeTypeMapOfficial

## Collaboration

Please submit pull requests for any additions. Thanks!

Sam


## Usage

After installation MimeTypeMap, include the following using statement in your class:

```cs
using MimeTypes;
```

### Getting the mime type to an extension

```cs
Console.WriteLine("txt -> " + MimeTypeMap.GetMimeType("txt"));  // "text/plain"
```

Pass in a string extension and get a mime type back. Optionally include the period. If not it will be added before looking up the mime type.

If no mime type is found then the generic "application/octet-stream" is returned.

### Getting the extension to a mime type

```cs
Console.WriteLine("audio/wav -> " + MimeTypeMap.GetExtension("audio/wav")); // ".wav"
```

Pass in a mime type and get an extension back. If the mime type is not registered, an error is thrown.
