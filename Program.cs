using System.Globalization;
using static System.Console;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to my first Calculator!");
            
            Sum();
            Subtraction();
            

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
    }
}