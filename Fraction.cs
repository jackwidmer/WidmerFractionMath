using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WidmerFractionMath
{
    internal class Fraction
    {
        // These are called member variables
        private int numerator, denominator;
        public string strResult;

        // This is called the default constructor
        // Must have the same name as the class,
        // will never return a value
        public Fraction()
        {
            numerator = 0;
            denominator = 1;
        }

        // This is an overload constructor
        public Fraction(int num, int denom)
        {
            numerator = num;
            denominator = denom;
            Reduce();
        }

        public int GetNumerator()
        {
            return numerator;
        }

        public int GetDenominator()
        {
            return denominator;
        }

        // This is a private 'helper method'
        private void Reduce()
        {
            int sign = 1;
            if (numerator < 0)
            {
                sign *= -1; // sign = sign * -1
                numerator *= -1;
            }
            if (denominator < 0)
            {
                sign *= -1;
                denominator *= -1;
            }


            for (int i = numerator; i > 1; i--)
            {
                if(numerator % i == 0 && denominator % i == 0)
                { // if this is true, found the biggest number on top
                  // and bottom that is evenly divisible
                    numerator /= i; // numerator = numerator / i
                    denominator /= i;
                    break;
                }
            }

            numerator *= sign;
        } // End Reduce()

        /*
         * n1   n2   result n
         * -- + -- = --------
         * d1   d2   result d
         * 
         * result n = (n1 * d2) + (d1 * n2)
         * result d = d1 * d2
         * 
         * 
         */

        // Example of Java way if operator overload is not available
        public Fraction Add(Fraction fraction1, Fraction fraction2)
        {
            this.numerator = (fraction1.numerator * fraction2.denominator)
                + (fraction1.denominator * fraction2.numerator);

            this.denominator = fraction1.denominator * fraction2.denominator;

            this.Reduce();
            return this;
        }
        
        // Example of the C# way using operator overload method
        public static Fraction operator+ (Fraction fraction1, Fraction fraction2)
        {
            Fraction result = new Fraction();

            result.numerator = (fraction1.numerator * fraction2.denominator)
                + (fraction1.denominator * fraction2.numerator);

            result.denominator = fraction1.denominator * fraction2.denominator;

            result.Reduce();
            result.strResult = Convert.ToString(result.GetNumerator()) + " / " + Convert.ToString(result.GetDenominator());
            return result;
        }

        // Subtract method...
        public static Fraction operator- (Fraction fraction1, Fraction fraction2)
        {
            Fraction result = new Fraction();

            result.numerator = (fraction1.numerator * fraction2.denominator)
                - (fraction1.denominator * fraction2.numerator);

            result.denominator = fraction1.denominator * fraction2.denominator;

            result.Reduce();
            result.strResult = Convert.ToString(result.GetNumerator()) + " / " + Convert.ToString(result.GetDenominator());
            return result;
        }

        // Muliply method...
        public static Fraction operator* (Fraction fraction1, Fraction fraction2)
        {
            Fraction result = new Fraction();

            result.numerator = (fraction1.numerator * fraction2.numerator);

            result.denominator = fraction1.denominator * fraction2.denominator;

            result.Reduce();
            result.strResult = Convert.ToString(result.GetNumerator()) + " / " + Convert.ToString(result.GetDenominator());
            return result;
        }
        // Divide method...
        public static Fraction operator/ (Fraction fraction1, Fraction fraction2)
        {
            Fraction result = new Fraction();

            result.numerator = (fraction1.numerator * fraction2.denominator);

            result.denominator = fraction1.denominator * fraction2.numerator;

            result.Reduce();
            result.strResult = Convert.ToString(result.GetNumerator()) + " / " + Convert.ToString(result.GetDenominator());
            return result;
        }
        // Make a method that returns a string of the fraction
        // in this format: 3 / 4

        public string GetString()
        {
            return strResult;
        }
    }
}
