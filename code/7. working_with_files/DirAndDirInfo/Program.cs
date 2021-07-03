using System;
using System.IO;

namespace DirAndDirInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Directory.CreateDirectory(@"F:\dir\dir2\dir3\newone");
            // var files = Directory.GetFiles(@"F:\", "* .pdf" ,SearchOption.AllDirectories);
            // foreach(var file in files ) 
            // {          //not working why?

            //     Console.WriteLine(file);
            // }
            
            // var dirs = Directory.GetDirectories(@"C:\Users\Inam UL rehman\Desktop\vp-csharp\code\" ,"*.*" SearchOption.AllDirectories);
            // foreach (var dir in dirs)
            // {
            //         Console.WriteLine(dir); 
        
            // }

            var diroctoryinfo = new DirectoryInfo(@"\Users\Inam UL rehman\Desktop\csharp-01\code")  ;
            var diroctoriesinfo = diroctoryinfo.GetDirectories("*.*", SearchOption.AllDirectories)  ;
            foreach(var diroctory in diroctoriesinfo)
                {
                    Console.WriteLine(diroctory);
                }    
        }
        
    }
}
