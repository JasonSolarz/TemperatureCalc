using System;

//Convert a temperate from C to F or F to C. 

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Converter!");
            Console.Title = "Temperature Converter V1.0";

            string userInput;

            Console.Write("Input a temperature(exp: 32f/32c): ");
            userInput = Console.ReadLine();

            if(userInput.Contains('c') || userInput.Contains('C'))
            {
                userInput = userInput.Trim('c');
                userInput = userInput.Trim('C');

                Console.WriteLine(userInput + "c is equal to " + (Convert.ToDouble(userInput) * 1.8 + 32) + "f");
            }
            else if(userInput.Contains('f') || userInput.Contains('F'))
            {
                userInput = userInput.Trim('f');
                userInput = userInput.Trim('F');

                Console.WriteLine(userInput + "f is equal to " + ((Convert.ToDouble(userInput) - 30) / 2) + "c");
            }
            else
            {
                Console.WriteLine("I'm sorry, the temperature you input is not recognized.");
            }
        }
    }
}
