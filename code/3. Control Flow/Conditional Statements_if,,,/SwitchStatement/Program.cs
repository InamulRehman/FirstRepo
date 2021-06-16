using System;

namespace SwitchStatement
{
   public enum Season        
        {

            Spring,
            Summer,
            Autumn,
            Winter

        }
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;
            //var season = Season.Spring;
           // var season = Season.Winter;
            switch(season)                       
                {                                           //local variable
                    case Season.Autumn:                 //accessing value via dot operator and stored in local variable
                        //Console.WriteLine("we got it");//It's autumn and beautiful season
       //why output     //break;
                    /*case Season.Summer:
                        Console.WriteLine("we got it");//It's ok perfect to go to beach and enjoy
                        break;*/
                    case Season.Spring:
                        Console.WriteLine("Good season");
                        break;
                //    case Season.Winter:
                //        Console.WriteLine("Very cold season");
                //        break;
                    default:
                        Console.WriteLine("I don't understand that season");
                        break;
                }
        }
    }
}
