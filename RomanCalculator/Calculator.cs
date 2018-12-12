using System;

namespace RomanCalculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======= QCL Roman Calculator =======");

            while (true) {
                //Ask user first number
                Console.WriteLine("Type you first number: ");
                string firstNumber = Console.ReadLine();

                //Ask user second number
                Console.WriteLine("Type you second number: ");
                string secondNumber = Console.ReadLine();

                var result = Addition.Sum(firstNumber, secondNumber);

                Console.WriteLine($"\nResult of {firstNumber} + {secondNumber} = {result}" + Environment.NewLine);

                string answer = "";
                while (!answer.Equals("y", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("Another go? y/n");
                    answer = Console.ReadLine();

                    if (answer.Equals("n", StringComparison.InvariantCultureIgnoreCase))
                    {
                        Environment.Exit(0);
                    }

                    if (answer.Equals("y", StringComparison.InvariantCultureIgnoreCase)) {
                        break;
                    }
                    Console.WriteLine("Invalid code: all your base are belong to us!");
                }
            }
        }
    }
}
