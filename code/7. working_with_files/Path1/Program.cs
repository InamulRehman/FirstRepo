using System;
using System.IO;

namespace Path1
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Inam UL rehman\Desktop\csharp-01\code\HeloWorld.snl";
            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);
            Console.WriteLine("Extensions: {0}", extension);
            Console.WriteLine("Extensions: " + Path.GetExtension(path));
            Console.WriteLine("File name: " + Path.GetFileName(path));
            Console.WriteLine("File name without extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Diroctory name: " + Path.GetDirectoryName(path));
    
        }
    }
}
