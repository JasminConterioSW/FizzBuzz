using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many numbers do you want to FizzBuzz?");
            string iMaxString = Console.ReadLine();
            int iMax = Int32.Parse(iMaxString);
            
            for (int i = 1; i <= iMax; i++)
            {
                List<string> messageComponents = new List<string>();

                if (i % 3 == 0)
                {
                    messageComponents.Add("Fizz");
                }
                
                if (i % 5 == 0)
                {
                    messageComponents.Add("Buzz");
                }

                if (i % 7 == 0)
                {
                    messageComponents.Add("Bang");
                }

                if (i % 11 == 0)
                {
                    messageComponents.Clear();
                    messageComponents.Add("Bong");
                }



                if (i % 13 == 0)
                {
                    
                    
                    int bIndex = messageComponents.FindIndex(c => c.StartsWith("B"));
                    
                    
                    if (bIndex != -1)
                    {
                        messageComponents.Insert(bIndex, "Fezz");
                    }
                    else
                    {
                        messageComponents.Add("Fezz");
                    }
                    
                }


                if (i % 17 == 0)
                {
                    messageComponents.Reverse();
                }
    
                if (messageComponents.Count == 0)
                {
                    messageComponents.Add(i.ToString());
                }

 
                // convert MessageComponents to final message (not needed - now using built in function)
                /*
                string message = "";
                foreach (string mc in messageComponents)
                {
                    message += mc;
                }
                */

                string message = String.Join("", messageComponents);
                
                // Write message
                Console.WriteLine(message);    
 
            }
        }
    }
}