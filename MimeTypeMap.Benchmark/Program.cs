using BenchmarkDotNet.Running;
using MimeTypeMap.Benchmark;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

if (args.Length > 0)
{
    if (args[0] == "createswitch")
    {
        var findReg = new Regex(@"#region FastEdition(.|[\s])*#endregion", RegexOptions.Multiline);

        var dict = MimeTypes.MimeTypeMap.BuildMappings();
        var sb = new StringBuilder();
        var sbReverse = new StringBuilder();

        foreach (var key in dict.OrderBy(e => e.Key))
        {
            if (key.Key.StartsWith("."))
                sb.AppendLine($"case \"{key.Key.ToLower()}\": return \"{key.Value.ToLower()}\";");
            else
                sbReverse.AppendLine($"case \"{key.Key.ToLower()}\": return \"{key.Value.ToLower()}\";");
        }
        
        var func = @"           
        public static string GetMimeType(string extension, bool findExtensionString = true)
        {
            if (extension[0] != '.' && findExtensionString)
            {
                extension = extRegex().Match(extension).Value;
            }
            switch (extension.ToLower())
            {
                " + sb.ToString() + @"
                default: return ""application/octet-stream"";
            }
        }
        ";
        var funcReverse = @" 
        public static string GetExtension(string mime)
        {
            switch (mime.ToLower())
            {
" + sbReverse.ToString() + @"
                default: return string.Empty;
            }
        }";
        var container = @$"
using System.Text.RegularExpressions;

namespace MimeTypes
{{
    public static partial class MimeFastMap
    {{
#if NET8_0_OR_GREATER
        [GeneratedRegex(@""\..+$"", RegexOptions.IgnoreCase)]
        private static partial Regex extRegex();
#else
        private static Regex _extRegex = new Regex(@""(^|\.)[-Za-z0-9]+$"", RegexOptions.Compiled);
        private static Regex extRegex() => _extRegex;
#endif
        private const string Dot = ""."";        
        
{func}
{funcReverse}
    }}
}}
";
        var projPath = AppDomain.CurrentDomain.BaseDirectory;

        while (!File.Exists(Path.Combine(projPath, "MimeTypeMap.Benchmark.csproj")))
        {
            projPath = Path.GetFullPath(Path.Combine(projPath, ".."));
        }
        var overwriteFileName = Path.Combine(projPath, "..", "MimeTypeMap", "MimeFastMap.cs");
        File.WriteAllText(overwriteFileName, container);
        return;
    }
}

BenchmarkRunner.Run<Benchmark>();