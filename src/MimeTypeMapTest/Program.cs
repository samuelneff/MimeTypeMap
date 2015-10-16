using System;
using MimeTypes;

namespace MimeTypeMapTest
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("txt -> " + MimeTypeMap.GetMimeType("txt"));
            Console.WriteLine("audio/wav -> " + MimeTypeMap.GetExtension("audio/wav"));
            Console.WriteLine("Extensions with text/plain mime type: " + string.Join(", ", MimeTypeMap.GetKnownExtensions("text/plain")));

            Console.ReadKey();
        }
    }
}