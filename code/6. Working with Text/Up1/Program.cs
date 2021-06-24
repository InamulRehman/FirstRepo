using System;

namespace Up1
{
    class Program
    {
        static void Main(string[] args)
        {
            //first practice of using logic into another method , separately from console(procedural programing)
            Console.WriteLine("What is your name ");
            var name = Console.ReadLine();

            var reversed = ReverseName(name);    
            Console.WriteLine("Reversed name is: " + reversed);
        
             static string ReverseName(string name)
            {

                var arry = new char[name.Length];
                for (var i = name.Length; i>0; i-- )
                    arry[name.Length - 1] = name[i -1]; // not understanding the logic

            // var reversed = new string (arry);

                return new string(arry);
                
            }
        }


    }
}
