using System;

namespace ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int [3] {2,  4 , 5};
            var arr1 = arr;
            arr1[0] = 0;
            Console.WriteLine(string.Format("arr[0]: {0}, arr1[0]: {1}" , arr, arr1));

          /*  here non premitive type array is created in heap and its address is pointing from stack to it (using pointer)
             when we assined arr to arr1 , arr1 takes the copy of the adress from stak and will also poit to same array 
             in the heap so same arry is used , any change in one will affect the other
             we allocate memory using new operator and deallocation done by compiler automatically */ 
        }        
    } 
}        
        
 

