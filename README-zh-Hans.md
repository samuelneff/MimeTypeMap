# MimeTypeMap

## 概述
提供广大双向的映射文件以mime和mime来扩展文件，列子：

```c#
...
{".jpe", "image/jpeg"},
{".jpeg", "image/jpeg"},
{".jpg", "image/jpeg"},
{".js", "application/javascript"},
{".json", "application/json"},
...
```

多数的mime有多种可能的扩展是预先定义的，为了得到最常见的扩展当被mime寻找扩展。自从多路扩展可以映射到一样的mime, 这是可能不一定`GetExtension(GetMimeType(ext))`回到他原来的扩展 - 他会回到最常见的扩展。


## 安装

一个 [NuGet package](https://www.nuget.org/packages/MediaTypeMap) 可以被简单地整合到 VisualStudio和自动更新。或者说，你可以克隆和参考，或是复制class到您的项目里， 

最初在 StackOverflow 的帖子在这里: http://stackoverflow.com/questions/1029740/get-mime-type-from-filename-extension

## 合作

您可以交任何PR当你认为有任何增建部分的可能性。谢谢！

Sam


## 用法

在安装MimeTypeMap之后， 会包括以下指令在您的class之中：

```cs
using MimeTypes;
```

### 得到并让mime到扩展里

```cs
Console.WriteLine("txt -> " + MimeTypeMap.GetMimeType("txt"));  // "text/plain"
```

传入string扩展和再得到mime回来。可以选择或不选择包括中期。如果不是的话它将会额外的附加在寻找mime之前。

如果没有mime被找到的话一般的字眼 "application/octet-stream" 会被归还。

### 得到并让扩张到mine

```cs
Console.WriteLine("audio/wav -> " + MimeTypeMap.GetExtension("audio/wav")); // ".wav"
```

传入mime和再得到扩展回来，如果mime是没被注册的话，错误报告会被显示

## 日志

2.3.2.0 - December, 28 2017 - Add Support for .NET Standard 2.0 and .NET Core 2.0

2.1.0 - August 14, 2015 - Refactor and add GetExtension method.

1.2.0 - April 22, 2015 - Breaking changes due to refactorings. You'll need to change namespace after this update. Also added OpenOffice related mime types, in a few cases overwriting rarely used MS mime types for the same extensions.

1.1.0 - April 22, 2015 - Merge pull requests

1.0.0 - Original load from StackOverflow as is
