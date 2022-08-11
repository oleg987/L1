using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Fraction
    {
        private readonly int _nominator;
        private readonly int _denominator;

        public int Nominator { get => _nominator; init => _nominator = value; }
        public int Denominator { get => _denominator; init => _denominator = value != 0 ? value : throw new Exception(); }

        public Fraction(int nominator, int denominator)
        {
            Nominator = nominator;
            Denominator = denominator;
        }

        public static Fraction operator/(Fraction left, int right)
        {
            return left * new Fraction(1, right);
        }

        public static Fraction operator++(Fraction fraction)
        {
            return new Fraction(fraction.Nominator + fraction.Denominator, fraction.Denominator);
        }

        public static Fraction operator +(Fraction left, Fraction right)
        {
            int denominator = left.Denominator * right.Denominator;
            int nominator = left.Nominator * right.Denominator + right.Nominator * left.Denominator;

            return new Fraction(nominator, denominator);
        }

        public static Fraction operator +(Fraction left, int right)
        {
            int denominator = left.Denominator;
            int nominator = left.Nominator + right * left.Denominator;

            return new Fraction(nominator, denominator);
        }

        public static Fraction operator +(int left, Fraction right)
        {
            return right + left;
        }

        public static Fraction operator*(Fraction left, Fraction right)
        {
            int nominator = left.Nominator * right.Nominator;
            int denominator = left.Denominator * right.Denominator;

            return new Fraction(nominator, denominator);
        }

        public static Fraction operator *(Fraction left, int right)
        {
            int nominator = left.Nominator * right;
            int denominator = left.Denominator;

            return new Fraction(nominator, denominator);
        }

        public static Fraction operator *(int left, Fraction right)
        {
            return right * left;
        }

        public override string? ToString()
        {
            return $"{Nominator}/{Denominator}";
        }
    }
}
