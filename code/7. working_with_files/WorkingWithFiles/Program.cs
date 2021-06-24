using System;
using System.IO;
namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var path1 = @"F:\a.png";
           /* var path = @"E:\a.png";
            File.Copy(@"E:\b.png" , @"F:\b.png", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                
            }
            var content = File.ReadAllText(path);*/


            var fileInfo = new FileInfo(path1);
            fileInfo.CopyTo("...") ;
            fileInfo.Delete();
            if(fileInfo.Exists)
            
                
            
        }
    }
}
