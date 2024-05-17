# MimeTypeMap

[English](README.md) | Deutsch |  [简体中文](README-zh-Hans.md)

## Zusammenfassung
Liefert ein bidirectionales Mapping von Dateiendungen zu MIME-Typen und umgekehrt. 
Die Dateiendungen und MIME-Typen sind in einer statischen Klasse definiert, die einfach in andere Projekte eingebunden werden kann.

```c#
...
{".jpe", "image/jpeg"},
{".jpeg", "image/jpeg"},
{".jpg", "image/jpeg"},
{".js", "application/javascript"},
{".json", "application/json"},
...
```

Die meisten MIME Types haben verschiedene Erweiterungen. Wenn Sie den MIME-Typ einer Erweiterung abrufen, wird die häufigste Erweiterung zurückgegeben.
So kannes vorkommen, dass `GetExtension(GetMimeType(ext))` nicht die ursprüngliche Erweiterung zurückgibt, sondern die häufigste Erweiterung.

Originaler Post von Stackoverflow: http://stackoverflow.com/questions/1029740/get-mime-type-from-filename-extension

## NuGet

Es gibt mehrere NuGet-Pakete, die auf diesem Projekt basieren. Das offizielle NuGet-Paket ist hier zu finden: https://www.nuget.org/packages/MimeTypeMapOfficial

Es kann sein, dass die Nuget-Pakete nicht immer auf dem neuesten Stand sind. 
Gebt mir in dem Fall bescheid und ich update die Pakete.

## Nutzung

Nach der Installation fügt folgendes using zu eurer Klasse:

```cs
using MimeTypes;
```

### Einen MIME Type abrufen

```cs
Console.WriteLine("txt -> " + MimeTypeMap.GetMimeType("txt"));  // "text/plain"
```

Übergebt die Extension nach der ihr suchen wollt. Es macht keinen Unterschied ob, der führende Punkt enthalten ist. Er wird im Zweifel angefügt.

Wenn kein MIME Type gefunden wurde gibt die Funktion: "application/octet-stream" zurück.

### Eine Extension abrufen

```cs
Console.WriteLine("audio/wav -> " + MimeTypeMap.GetExtension("audio/wav")); // ".wav"
```

Analog dazu könnt ihr den MIME Type übergeben und bekommt die Extension zurück.
Wir die Extension nicht gefunden wirft die Funktion einen Fehler.

## Collaboration & Contribution Principles
(Den Text habe ich nicht übersetzt um Ungenauigkeiten bei der Übersetzung zu vermeiden.)
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
