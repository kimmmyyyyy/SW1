using System;

namespace SW1
{
    class Program
    {

        static void PrimeChecker(int input, int index)
        {
            if (input <= 1)
            {
                Console.WriteLine($"{index}. {input}\t Composite");
                return;
            }
            bool isPrime = true;

            for (int i = 2; i < input; i++)
            {
                if (input % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{index}. {input}\tPrime");
            }
            else
            {
                Console.WriteLine($"{index}. {input}\tComposite");
            }
        }
        static void Converter(double userDollar)
        {
            double peso = 57.17;
            double yen = 146.67;

            double ConvertPeso = userDollar * peso;
            double ConvertYen = userDollar * yen;

            Console.Write($"{userDollar}\t\t{ConvertPeso}\t\t{ConvertYen}\n");
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Number: ");
            string values = Console.ReadLine();
            string[] numbers = values.Split(" ");

            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (int.TryParse(numbers[i], out int num))
                {
                    PrimeChecker(num, i + 1);
                }
                else
                {
                    Console.WriteLine($"{i + 1}. {numbers[i]} Invalid Input.");
                }
            }


            Console.WriteLine();
            Console.Write("Enter Currency in ($): ");

            string userInput = Console.ReadLine();

            string[] splitInput = userInput.Split(',');
            Console.WriteLine("Dollar($)\tPhil Peso(P)\tJpn Yen(Y) ");

            foreach (string split in splitInput)
            {
                if (double.TryParse(split.Trim(), out double dollar))
                {
                    Converter(dollar);
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                }
            }
        }
    }
}