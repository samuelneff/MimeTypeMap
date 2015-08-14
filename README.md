MimeTypeMap
===========

Provides a huge two-way mapping of file extensions to mime types and mime types to file extensions.

Most mime types that have multiple possible extensions are pre-defined to get the most common extension when looking
up extension by mime type. Since multiple extensions can map to the same mime type, it is not necessary that `GetExtension(GetMimeType(ext))` returns the original extension--it will return the most common extension.

A [NuGet package](https://www.nuget.org/packages/MediaTypeMap) is available for easy integration into VisualStudio and automatic updates.  Alternatively, you can clone and reference or copy the class to your project.

Originally posted on StackOverflow here: http://stackoverflow.com/questions/1029740/get-mime-type-from-filename-extension

Please submit pull requests for any additions.

Thanks!

Sam

GetMimeType(string extension)
=============================

Pass in a string extension and get a mime type back. Optionally include the period. If not it will be added before looking up the mime type.

If no mime type is found then the generic "application/octet-stream" is returned.

GetExtension(string mimeType)
=============================

Pass in a mime type and get an extension back. If the mime type is not registered, an error is thrown.

Change List
===========

2.1.0 - August 14, 2015 - Refactor and add GetExtension method.

1.2.0 - April 22, 2015 - Breaking changes due to refactorings. You'll need to change namespace after this update. Also added OpenOffice related mime types, in a few cases overwriting rarely used MS mime types for the same extensions.

1.1.0 - April 22, 2015 - Merge pull requests

1.0.0 - Original load from StackOverflow as is
