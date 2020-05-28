using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ushtrime_nga_libri
{
    class Program
    {
        static string ReverseArray (string number)
        {
            char[] array = number.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        static double Average(double[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            double average = sum / numbers.Length;
            return average;
        }

        static double LinearEquation(double a, double b)
        {
            double x;
            x = -b / a;

            return x;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option below: ");
            Console.WriteLine("Type 0 if you want to put integer number into a reversed order? ");
            Console.WriteLine("Type 1 if you want to calculate the average of given sequence of numbers.");
            Console.WriteLine("Type 2 if you want to solve the linear equation a * x + b = 0.");
            Start:
            Console.Write("Your answer is 0, 1 or 2? - ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine();
            switch (a)
            {
                case 0:
                    {
                        Console.Write("Enter a number: ");
                        string number = Console.ReadLine();

                        Console.WriteLine("The number in reversed order is {0}",ReverseArray(number));
                        break;
                    }
                case 1:
                    {
                        Console.Write("Enter the length of the array: ");
                        int length = int.Parse(Console.ReadLine());
                        double[] numbers = new double[length];

                        Console.WriteLine();
                        for(int i = 0; i < length; i++)
                        {
                            Console.Write("Enter [{0}] = ", i);
                            numbers[i] = double.Parse(Console.ReadLine());
                        }
                        Console.Write("The average of the given array is equal to -> {0} ", Average(numbers));
                        Console.WriteLine();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("To find a*x + b = 0, we need to know a and b.");
                        Console.Write("Enter a = ");
                        int a1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter b = ");
                        int b1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("The equation is equal for x = {0}", LinearEquation(a1,b1));
                        Console.WriteLine();
                        break;
                    }
            }

            goto Start;

            Console.ReadKey();
        }
    }
}
