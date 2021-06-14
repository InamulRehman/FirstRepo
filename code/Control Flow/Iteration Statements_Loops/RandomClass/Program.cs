using System;

namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var random = new Random();                                   // for detail see description
            for(var i=0; i<10; i++)
                Console.WriteLine(random.Next(19985, 19987));

            Console.WriteLine((int)'A');                  // returns the ascii/unicode equivalent of specified character, for more see description
            

         
            var ran = new Random();
           for (var j=0; j<10; j++)
                Console.Write((char)ran.Next(97 , 110)) ;      // 97-122 range for small letters
            
              //Console.WriteLine( "inam" + 'a');
            
            const int passworsLength = 10;
            var rand = new Random();
            var buffer = new char[passworsLength];  //10
            for (var y=0; y<passworsLength; y++)
               // Console.Write((char) ('a'+ random.Next(0, 26)));
                buffer[y]=((char) ('a'+ rand.Next(0, 26)));
                //Console.WriteLine();
            var password = new string(buffer);
            Console.WriteLine(password);

        
                

           
        }
    }
}
