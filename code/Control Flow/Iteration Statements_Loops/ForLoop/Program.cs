using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // we should use for loop where we are known about number of iterations
            for (var i=1; i<=10; i++){

                if(i%2==0){

                    Console.WriteLine(i);           // shows even numbers

                }

            }
            for (int i=10; i>=1; i--){

                if (i%2==0){

                    Console.WriteLine(i);        // also shows even no but in reverse order 
                }
            }
            
            var name = "Inam ul Rehman";
            for (var i=0; i< name.Length; i++){

                Console.WriteLine(name[i]);      //we used a Length method to show length of characters in string using for loop
            }
        }
    }
}
