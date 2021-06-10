using System;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Saqib Ali";
            //using for loop
            for (var i=0; i< name.Length; i++ ){

                Console.WriteLine(name[i]);

            }
            // using for each loop 1
            foreach(var character in name){

                Console.WriteLine(character);
            }
            // using for each loop 2
            var numbers = new int [] {2,5,7,4};
            foreach(var number in numbers){
                
                Console.WriteLine(number);
            }



        }
    }
}
