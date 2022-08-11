using System;
using System.Text;
using System.Linq;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction[] array = new Fraction[]
            {
                new Fraction(1, 1),
                new Fraction(2, 1),
                new Fraction(3, 1)
            };

            Console.WriteLine(Sum(array));
            Console.WriteLine(Average(array));
        }

        static Fraction Sum(Fraction[] source)
        {
            Fraction result = new Fraction(0, 1);

            foreach (Fraction fraction in source)
            {
                result += fraction;
            }

            return result;
        }

        static Fraction Average(Fraction[] source)
        {
            Fraction sum = Sum(source);

            return sum / source.Length;
        }
    }
}
