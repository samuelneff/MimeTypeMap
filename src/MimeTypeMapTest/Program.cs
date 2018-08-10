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
            
            Console.WriteLine("dll.config -> " + MimeTypeMap.GetMimeTypeFromFileName("hello.world.dll.config"));
            Console.WriteLine("config -> " + MimeTypeMap.GetMimeTypeFromFileName("hello.world.config"));
        }
    }
}
