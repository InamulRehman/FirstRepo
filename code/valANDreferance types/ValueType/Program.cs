using System;

namespace ValueType
{
    class Program
    {
        static void Main(string[] args)
        {
           int a = 10;            
           int b = a;
           b++;
           Console.WriteLine(string.Format("a: {0},  b: {1}", a,b));

         /*  here we have an premitive type integer so in this case only value of a
           will be assined to b . And both variables are at different menory location in the memeory
           so any change in one variable  will not affect the other */
               
        }
    }
}
