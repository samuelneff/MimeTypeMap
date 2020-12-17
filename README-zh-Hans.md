# MimeTypeMap

[English](README.md) | 简体中文

## 概述
提供了一个庞大的文件扩展名到mime类型和mime类型到文件扩展名的双向映射，例如：

```c#
...
{".jpe", "image/jpeg"},
{".jpeg", "image/jpeg"},
{".jpg", "image/jpeg"},
{".js", "application/javascript"},
{".json", "application/json"},
...
```

大多数具有多个可能扩展的mime类型都是预先定义的，以便在按mime类型查找扩展时获得最常见的扩展。因为多个扩展可以映射到相同的mime类型，所以 `GetExtension(GetMimeType(ext))` 没有必要返回原始的扩展名——它将返回最常见的扩展名。

最初发表在 StackOverflow 的帖子: http://stackoverflow.com/questions/1029740/get-mime-type-from-filename-extension

## NuGet

可以通过 Nuget 上的几个包访问这个仓库。官方的网址是这个。

https://www.nuget.org/packages/MimeTypeMapOfficial

## 合作

请提交任何 Pull Requests 请求。谢谢！

Sam


## 用法

安装完MimeTypeMap后，在你的类中添加以下using语句：

```cs
using MimeTypes;
```

### 文件扩展名转mime类型

```cs
Console.WriteLine("txt -> " + MimeTypeMap.GetMimeType("txt"));  // "text/plain"
```

传递一个字符串扩展名并返回mime类型，可选是否带小数点。如果没有，它将在查找mime类型之前添加。

如果没找到对应的mime类型，将返回 "application/octet-stream"。

### mime类型转文件扩展名

```cs
Console.WriteLine("audio/wav -> " + MimeTypeMap.GetExtension("audio/wav")); // ".wav"
```

传入一个mime类型并取回一个扩展名。如果未找到mime类型，则抛出一个异常。
