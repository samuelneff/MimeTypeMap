using System;
using MimeTypes;

namespace MimeTypeMapTest
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("txt -> " + MimeTypeMap.GetMimeType("txt"));
            Console.WriteLine("audio/wav -> " + MimeTypeMap.GetExtension("audio/wav"));
            Console.ReadKey(true);
        }
    }
}