using BenchmarkDotNet.Attributes;
using MimeTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MimeTypeMap.Benchmark;

[MemoryDiagnoser]
public class Benchmark
{
#if !DEBUG
    [Benchmark]
    public void FindMimeWithDictionary()
    {
        MimeTypes.MimeTypeMap.GetMimeType(".json");
        MimeTypes.MimeTypeMap.GetMimeType(".md");
        MimeTypes.MimeTypeMap.GetMimeType(".3g2");
        MimeTypes.MimeTypeMap.GetMimeType(".ruleset");
        MimeTypes.MimeTypeMap.GetMimeType(".zip");
        MimeTypes.MimeTypeMap.GetMimeType("json");
        MimeTypes.MimeTypeMap.GetMimeType("md");
        MimeTypes.MimeTypeMap.GetMimeType("3g2");
        MimeTypes.MimeTypeMap.GetMimeType("ruleset");
        MimeTypes.MimeTypeMap.GetMimeType("zip");
        MimeTypes.MimeTypeMap.GetMimeType("meinfile.json");
        MimeTypes.MimeTypeMap.GetMimeType("meinfile.md");
        MimeTypes.MimeTypeMap.GetMimeType("meinfile.3g2");
        MimeTypes.MimeTypeMap.GetMimeType("meinfile.ruleset");
        MimeTypes.MimeTypeMap.GetMimeType("meinfile.zip");
    }

    [Benchmark]
    public void FindMimeWithSwitch()
    {
        MimeTypes.MimeFastMap.GetMimeType(".json");
        MimeTypes.MimeFastMap.GetMimeType(".md");
        MimeTypes.MimeFastMap.GetMimeType(".3g2");
        MimeTypes.MimeFastMap.GetMimeType(".ruleset");
        MimeTypes.MimeFastMap.GetMimeType(".zip");
        MimeTypes.MimeFastMap.GetMimeType("json");
        MimeTypes.MimeFastMap.GetMimeType("md");
        MimeTypes.MimeFastMap.GetMimeType("3g2");
        MimeTypes.MimeFastMap.GetMimeType("ruleset");
        MimeTypes.MimeFastMap.GetMimeType("zip");
        MimeTypes.MimeFastMap.GetMimeType("meinfile.json");
        MimeTypes.MimeFastMap.GetMimeType("meinfile.md");
        MimeTypes.MimeFastMap.GetMimeType("meinfile.3g2");
        MimeTypes.MimeFastMap.GetMimeType("meinfile.ruleset");
        MimeTypes.MimeFastMap.GetMimeType("meinfile.zip");
    }

    //[Benchmark]
    //public void FindExtWithDictionary()
    //{
    //    MimeTypes.MimeTypeMap.GetMimeType("application/vnd.apple.numbers");
    //    MimeTypes.MimeTypeMap.GetMimeType("video/3gpp2");
    //    MimeTypes.MimeTypeMap.GetMimeType("application/javascript");
    //    MimeTypes.MimeTypeMap.GetMimeType("video/x-ms-wmv");
    //    MimeTypes.MimeTypeMap.GetMimeType("x-world/x-vrml");
    //}

    //[Benchmark]
    //public void FindExtWithSwitch()
    //{
    //    MimeTypes.MimeFastMap.GetMimeType("application/vnd.apple.numbers");
    //    MimeTypes.MimeFastMap.GetMimeType("video/3gpp2");
    //    MimeTypes.MimeFastMap.GetMimeType("application/javascript");
    //    MimeTypes.MimeFastMap.GetMimeType("video/x-ms-wmv");
    //    MimeTypes.MimeFastMap.GetMimeType("x-world/x-vrml");
    //}
#endif
}
