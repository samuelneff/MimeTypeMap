using System;
using MimeTypes;

namespace MimeTypeMapTest
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("txt -> " + MimeTypeMap.GetMimeType("txt"));
            Console.WriteLine("audio/wav -> " + MimeTypeMap.GetExtension("audio/wav"));
            MimeTypeMap.Replace("txt", "application/txt");
            Console.WriteLine("txt -> " + MimeTypeMap.GetMimeType("txt"));
            MimeTypeMap.Add("bigtext", "application/bigtext");
            Console.WriteLine("bigtext MimeType -> " + MimeTypeMap.GetMimeType("bigtext"));
            Console.WriteLine("bigtext Extension -> " + MimeTypeMap.GetExtension("application/bigtext"));
            MimeTypeMap.Replace("bigtext", "application/mybigtext");
            Console.WriteLine("bigtext replace -> " + MimeTypeMap.GetMimeType("bigtext"));
            Console.ReadKey();
        }
    }
}
