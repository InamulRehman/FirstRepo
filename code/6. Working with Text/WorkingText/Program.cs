using System;
using System.Collections.Generic;

namespace WorkingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Inam ul Rehman ";
            Console.WriteLine("Trim:  '{0}' " , fullName.Trim());
            Console.WriteLine("ToUpper:  '{0}' " , fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            Console.WriteLine("IndexOf ' ': {0} " , index); 

            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: {0} " , firstName);
            Console.WriteLine("LastName: {0} " , lastName);

            var name = fullName.Split(' ');
            Console.WriteLine("First Name: {0} " , name[0]);
            Console.WriteLine("LastName: {0} " , name[1]);

            var newName = fullName.Replace("Inam" , "INAM");
            Console.WriteLine("New name is: {0}" , newName);

            if(String.IsNullOrEmpty(""))
                Console.WriteLine("Invalid");
            if(String.IsNullOrEmpty(null))
                Console.WriteLine("Invalid1");
            if(String.IsNullOrEmpty(" "))
                Console.WriteLine("Invalid2");
            if(string.IsNullOrEmpty(" ".Trim()))
                Console.WriteLine("Invalid3");

            if(string.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid4");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            var price = 29.95f;
            Console.WriteLine(price.ToString("C"));
/*
            var sentence = "This is practice mood of csharp programming";
            
                if (sentence.Length < 20)
                    Console.WriteLine(sentence);
                else
                {
                    var words = sentence.Split(" ");
                    var totalCharacters = 0;
                    var summaryWords = new List<string>();
                
                foreach(var word in words)
                    {
                        summaryWords.Add(word);                //more to understand
                        totalCharacters += word.Length + 1;   
                        if (totalCharacters > 20)
                            break;
                    }  

                var summary = string.Join(" " , summaryWords) + "...";
                Console.WriteLine(summary);

*/
           
            var sentence = "This is practice mood of csharp programming";
            var summary = StringUtility.SummerizedText(sentence);
            //var summary = SummerizedText(sentence);
            Console.WriteLine(summary);
        }

    /*     static string SummerizedText(string text, int maxLength = 20)
            {
                if (text.Length < maxLength)
                    return(text);
                
                
                    var words = text.Split(" ");
                    var totalCharacters = 0;
                    var summaryWords = new List<string>();
                
                foreach(var word in words)
                    {
                        summaryWords.Add(word);                //more to understand
                        totalCharacters += word.Length + 1;   
                        if (totalCharacters > maxLength)
                            break;
                    }
                return (string.Join(" " , summaryWords) + "...");
                
            }

            
        */            
                   
    }

    public class StringUtility
        {
            public static string SummerizedText(string text, int maxLength = 20)
            {
                if (text.Length < maxLength)
                    return(text);
                
                
                    var words = text.Split(" ");
                    var totalCharacters = 0;
                    var summaryWords = new List<string>();
                
                foreach(var word in words)
                    {
                        summaryWords.Add(word);                //more to understand
                        totalCharacters += word.Length + 1;   
                        if (totalCharacters > maxLength)
                            break;
                    }
                return (string.Join(" " , summaryWords) + "...");
                
            }
        }


}
