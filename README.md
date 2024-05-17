# MimeTypeMap

English | [German](README-de-DE.md) | [简体中文](README-zh-Hans.md)

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

Note that the NuGet package sometimes lags behind the code in GitHub when there are contributions from others and I forget to update. If you find this to be the case and need some of the updates, create an issue here and I'll update NuGet.

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

## Collaboration & Contribution Principles

All code is licensed under MIT license.

Please submit pull requests for any additions while sticking to these principles for contributions:

* `MimeTypeMap.cs` - the primary list of mime types
  * Maintain the existing groups of extension to mime type (primary is extension to mime-type)
  * Only add new mime-type to extension mappings if it is necessary to disambiguate the mapping based onreversing the extension to mime-type mappings.
  * Within each group of mappings, maintain alphabetical order by key.
  * Comments on a particular mapping should be on the same line after the mapping
    * Comments are optional.
    * Always keep comments in a single line regardless of length.
    * Comments to the source for less common mime-types are appreciated.
    * Non-obvious additions are validated before accepting a PR; a comment helps with this tremendously.
    * Comments must be in English. Do not worry about spelling or grammar if it is not your native language; I can correct comments and will still appreciate the comment. Translation with Google Translate is fine.
  * Do not change any code outside the mapping without asking about it first; you might waste your time otherwise.
  * All changes must maintain backwards compatibility. This includes changing what the mime-type to extension maps to unless the primary mapping is clearly wrong (far less common).
* Project configuration changes
  *  Changes to update the project to support the latest version of .NET are appreciated.
  *  We must maintain backwards compatibility with all versions still commonly used in the wild.
* `CONTRIBUTORS` acknowledgement and file
  * All contributions are greatly appreciated; both the individual contributions and of course the contributor.
  * Contributors are clearly visible on the GitHub project page.
  * Therefore there is no separate `CONTRIBUTORS` file to maintain.
  
Thank you,

Sam
