using System;

namespace ConsoleApp14
{
    internal class Program
    {
        static int ac;
        static int bc;

        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            int z = 3;
            int i = 0;
            int k = 0;

            Console.WriteLine($"x = {x}; y = {y}; z = {z};");

            Third(x, y, z, out i, out k);

            Console.WriteLine($"ac = {i};");
            Console.WriteLine($"bc = {k};");

            Console.WriteLine($"x = {x}; y = {y}; z = {z};");
        }

        static void First(ref int a, ref int b, int c)
        {
            a += c;

            Console.WriteLine($"a + c = {a};");

            b += c;

            Console.WriteLine($"b + c = {b};");
            Console.WriteLine($"a = {a}; b = {b}; c = {c};");
        }

        static void Second(int a, int b, int c)
        {
            ac = a + c;

            Console.WriteLine($"a + c = {ac};");

            bc = b + c;

            Console.WriteLine($"b + c = {bc};");
            Console.WriteLine($"a = {a}; b = {b}; c = {c};");
        }

        static void Third(int a, int b, int c, out int otput1, out int output2)
        {
            otput1 = a + c;

            Console.WriteLine($"a + c = {otput1};");

            output2 = b + c;

            Console.WriteLine($"b + c = {output2};");
            Console.WriteLine($"a = {a}; b = {b}; c = {c};");
        }

        static int Four(int a, int b, int c)
        {
            int r1 = a + c;

            Console.WriteLine($"a + c = {r1};");

            int r2 = b + c;

            Console.WriteLine($"b + c = {r2};");
            Console.WriteLine($"a = {a}; b = {b}; c = {c};");

            return r1;
        }

        static int Five(int a, int b, int c)
        {
            int r1 = a + c;

            Console.WriteLine($"a + c = {r1};");

            int r2 = b + c;

            Console.WriteLine($"b + c = {r2};");
            Console.WriteLine($"a = {a}; b = {b}; c = {c};");

            return r1;
        }
    }
}
