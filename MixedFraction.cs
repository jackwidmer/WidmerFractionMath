using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidmerFractionMath
{
    internal class MixedFraction : Fraction
    {
        // These are member variables
        public int mWhole, mNumerator, mDenominator;
        public string strMixed;

        // Constructor if no input values are given
        // Always the same name as the class, it's
        //how you know it's a contructor
        // base() is the default constructor
        public MixedFraction() : base()
        {
            mWhole = 0;
        }

        // Contructor if all three parameters are passed in
        // Call a static method to create values to pass to
        // the base constructor.
        // Turn into an improper fraction

        public MixedFraction(int whl, int num, int denom) : 
            base(CreateImproperNumerator(whl, num, denom), Math.Abs(denom))
        {
            mWhole = 0;
        }

        public int GetmWhole()
        {
            return mWhole;
        }

        public int GetmNumerator()
        {
            return mNumerator;
        }

        public int GetmDenominator()
        {
            return mDenominator;
        }

        private static int CreateImproperNumerator(int whl, int num, int denom)
        {
            int sign = 1;
            if(whl < 0) 
            { // makes it positive
                sign *= -1;
                whl *= -1;
            }
            if (num < 0)
            {
                sign *= -1;
                num *= -1;
            }
            if (denom < 0)
            {
                sign *= -1;
                denom *= -1;
            }
            // put the sign back on
            num = sign * ((whl * denom) + num);
            return num;
        }

        public void ToMixedFraction(Fraction impFraction)
        {
            mWhole = impFraction.GetNumerator() / impFraction.GetDenominator();

            mNumerator = impFraction.GetNumerator() % impFraction.GetDenominator();

            if(mWhole < 0)
            { // Strip the negative off the numerator if the whole is negative
                mNumerator = Math.Abs(mNumerator);
            }

            mDenominator = impFraction.GetDenominator();
            if(mNumerator == 0) // makes it back into a mixed function
            {
                mDenominator = 1;
            }
        }

        public void ToMixed()
        {
            mWhole = this.GetNumerator() / this.GetDenominator();

            mNumerator = this.GetNumerator() % this.GetDenominator();

            if(mWhole < 0)
            {// Strip the negative off the numerator if the whole is negative
                mNumerator = Math.Abs(mNumerator);
            }

            mDenominator = this.GetDenominator();
            if(mNumerator == 0)
            {
                mDenominator = 1;
            }
            
        }

        public override string ToString()
        {
            return base.ToString();
        }

        //Make a method that returns a string of the fraction
        //Example string: 2 3/4
         public new string GetString()
         {
            int numer = GetmNumerator();
            int denom = GetmDenominator();
            int whole = GetmWhole();

            strMixed = Convert.ToString(whole) + " " + 
                       Convert.ToString(numer) + "/" + 
                       Convert.ToString(denom);

            return strMixed;
        }

    }
}
