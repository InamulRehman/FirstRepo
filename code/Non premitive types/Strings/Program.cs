using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string myFirstName = "Ankel";
            string myLastName = "person";
            string abc = "hello jhon";
// concatenation
             Console.WriteLine(myFirstName +" "+ myLastName);    
// Formate
            string name = string.Format("{0} {1} , {2}" , myFirstName , myLastName , abc);
            Console.WriteLine(name);
// Join
            var NewName = new string[4] {"Ali", "Inam" ,"Bilal" ,"zeeshan"};
         // Console.WriteLine(NewName[0]+ NewName[1] +NewName[2] +NewName[3] );
            string list = string.Join(" ? " , NewName);
             Console.WriteLine(list);
// strings as array of characters
             string phone = "samsung";
             char firstCharacter = phone[0];
             char thirdCharacter = phone[2];
             Console.WriteLine(firstCharacter);
             Console.WriteLine(thirdCharacter);
// strings are immutable
             string itemName = "Laptop";
             char first_character = itemName[0];
             Console.WriteLine(first_character);
            // itemName[0] = 'l';
            // Console.WriteLine(first_character);
// without verbatim string
            string path = "c:\\projects\\project1\\folder1";
            Console.WriteLine(path);
//using  escape sequences
            string text1 = "Hello this is jhon \nfrom cave of \t programming .com \nI will guide you throughout the the csharp course.\n Get ready .\n See you towmorrow!";
            Console.WriteLine(text1);
// using verbatim string
            string path1 = @"c:\projects\project1\folder1";
            Console.WriteLine(path1);

            string text = @"Hello this is jhon
                from cave of programming .com
                I will guide you throughout the the csharp course.
                Get ready .
                See you towmorrow!";
            Console.WriteLine(text);

             











        }
    }
}
