using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                string message = "";
                
                if (i % 3 == 0)
                {
                    message += "Fizz";
                }
                
                if (i % 5 == 0)
                {
                    message += "Buzz";
                }

                if (i % 7 == 0)
                {
                    message += "Bang";
                }

                if (i % 11 == 0)
                {
                    message = "Bong";
                }

                    if (string.IsNullOrEmpty(message))
                {
                    message = i.ToString();
                }

                Console.WriteLine(message);    
                
            }
        }
    }
}