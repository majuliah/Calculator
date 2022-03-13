﻿using System.Globalization;
using static System.Console;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to my first Calculator! \n ");
            WriteLine($"Wich operation do you want to do? ");
            WriteLine($"**** [ 1 ] Sum                ****");
            WriteLine($"**** [ 2 ] Subtraction        ****");
            WriteLine($"**** [ 3 ] Division           ****");
            WriteLine($"**** [ 4 ] Multiplication     ****");
            WriteLine($"**** [ 0 ] Close Solution     ****");

            int answer = int.Parse(ReadLine());

            while (answer != 0)
            {
                switch (answer)
                {
                    case 1:
                        Sum();
                        break;
                    case 2:
                        Subtraction();
                        break;
                    case 3:
                        Division();
                        break;
                    case 4:
                        Multiplication();
                        break;
                    default: 
                        WriteLine($"Closing solution...");
                        break;
                }
            }
        }

        static void Sum()
        {
            WriteLine($"Please, enter with one value: ");
            
            float firstValue = float.Parse(ReadLine(), CultureInfo.InvariantCulture);
            
            WriteLine($"Now enter with the second value: ");
            float secondValue = float.Parse(ReadLine(), CultureInfo.InvariantCulture);

            float result = firstValue + secondValue;
            
            WriteLine($"The result of the sum is: {result.ToString(CultureInfo.InvariantCulture)}");
            ReadKey();
        }

        static void Subtraction()
        {
            WriteLine($"Please, enter with one value: ");
            
            float firstValue = float.Parse(ReadLine(), CultureInfo.InvariantCulture);
            
            WriteLine($"Now enter with the second value: ");
            float secondValue = float.Parse(ReadLine(), CultureInfo.InvariantCulture);

            float result = firstValue - secondValue;
            
            WriteLine($"The result of the subtraction is: {result.ToString(CultureInfo.InvariantCulture)}");
            ReadKey();
        }

        static void Division()
        {
            WriteLine($"Please, enter with one value: ");
            
            float firstValue = float.Parse(ReadLine(), CultureInfo.InvariantCulture);
            
            WriteLine($"Now enter with the second value: ");
            float secondValue = float.Parse(ReadLine(), CultureInfo.InvariantCulture);

            float result = firstValue / secondValue;
            
            WriteLine($"The result of the division is: {result.ToString(CultureInfo.InvariantCulture)}");
            ReadKey();
        }

        static void Multiplication()
        {
            WriteLine($"Please, enter with one value: ");
            
            float firstValue = float.Parse(ReadLine(), CultureInfo.InvariantCulture);
            
            WriteLine($"Now enter with the second value: ");
            float secondValue = float.Parse(ReadLine(), CultureInfo.InvariantCulture);

            float result = firstValue * secondValue;
            
            WriteLine($"The result of the multiplication is: {result.ToString(CultureInfo.InvariantCulture)}");
            ReadKey();
        }
    }
}