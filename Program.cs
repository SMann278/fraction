using System;

namespace ConsoleApp2
{
    public class Fraction
    {
        readonly int num;
        readonly int denom;

        public Fraction()
        {
            this.num = 0;
            this.denom = 1;
        }

        public Fraction(int num, int denom)
        {
            this.num = num;
            if (denom != 0)
            {
                this.denom = denom;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Denominator can't be zero");
            }

            Reduce(this);
        }

        public Fraction(int num)
        {
            this.num = num;
            this.denom = 1;
        }

        public Fraction(Fraction f1)
        {
            this.num = f1.num;
            if (f1.denom != 0)
            {
                this.denom = f1.denom;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Denominator can't be zero");
            }

            Reduce(this);
        }

        public int Numerator
        {
            get { return num; }
        }

        public int Denominator
        {
            get { return denom; }
        }

        public static implicit operator Fraction(int num) => new Fraction(num)
        public static Fraction Reduce(Fraction f1)
        {
            int factor = f1.Gcf(f1);
            return new Fraction(f1.num / factor, f1.denom / factor);
        }

        public int Gcf(Fraction f1)
        {
            int i;
            if (f1.num <= f1.denom)
            {
                i = Math.Abs(f1.num);
            }
            else
            {
                i = Math.Abs(f1.denom);
            }

            while (i > 0)
            {
                if (f1.num % i == 0 && f1.denom % i == 0)
                {
                    return i;
                }
                else
                {
                    i--;
                }
            }

            return i;
        }

        public static int Lcm(Fraction f1, Fraction f2)
        {
            int lcm;
            if (f1.Denominator >= f2.Denominator)
            {
                lcm = f1.Denominator;
            }
            else
            {
                lcm = f2.Denominator;
            }
            while (lcm%f1.Denominator!=0 || lcm%f2.Denominator!=0 )
            {
                lcm++;
            }
            return lcm;
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            //put with common denom
            int lcd = Fraction.Lcm(f1, f2);
            //recalculate the numerators over the lcd
            int f1Num = f1.num * (lcd/f1.denom);
            int f2Num = f2.num * (lcd/f2.denom);
            //create new fraction using sum and common denom
            //in the constructor it will be automatically reduced
            Fraction answer = new Fraction(f1Num + f2Num, lcd);
            return answer;
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            //put with common denom
            int lcd = Fraction.Lcm(f1, f2);
            //recalculate the numerators over the lcd
            int f1Num = f1.num * (lcd / f1.denom);
            int f2Num = f2.num * (lcd / f2.denom);
            //create new fraction using difference and common denom
            //in the constructor it will be automatically reduced
            Fraction answer = new Fraction(f1Num - f2Num, lcd);
            return answer;
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            //create new fraction using mult of num and denom
            //in the constructor it will be automatically reduced
            Fraction answer = new Fraction(f1.num * f2.num, f1.denom * f2.denom);
            return answer;
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            //create new fraction using reciprocal and multiplication
            //in the constructor it will be automatically reduced
            Fraction answer = new Fraction(f1.num * f2.denom, f1.denom * f2.num);
            return answer;
        }

        public static Double operator +(Fraction f1, double num)
        {
            return (double)f1 + num;
        }

        public static Double operator -(Fraction f1, double num)
        {
            return (double)f1 - num;
        }

        public static Double operator *(Fraction f1, double num)
        {
            return (double)f1 * num;
        }

        public static Double operator /(Fraction f1, double num)
        {
            return (double)f1 / num;
        }
        public static Double operator +(double num, Fraction f1)
        {
            return num + (double)f1;
        }
        public static Double operator -(double num, Fraction f1)
        {
            return num - (double)f1;
        }
        public static Double operator *(double num, Fraction f1)
        {
            return num * (double)f1;
        }
        public static Double operator /(double num, Fraction f1)
        {
            return num / (double)f1;
        }
        public static Fraction operator -(Fraction f1)
        {
            Fraction negation = new Fraction(-f1.num, f1.denom);
            //check if both are negative, if yes change to positive 
            if (negation.num < 0 && negation.denom < 0)
            {
                negation = new Fraction(-negation.num, -negation.denom);
            }
            return negation;
        }

        public static bool operator <(Fraction f1, Fraction f2)
        {
            //put with common denom
            int lcd = Fraction.Lcm(f1, f2);
            //recalculate the numerators over the lcd
            int f1Num = f1.num * (lcd / f1.denom);
            int f2Num = f2.num * (lcd / f2.denom);
            return f1Num < f2Num;
        }

        public static bool operator >(Fraction f1, Fraction f2)
        {
            //put with common denom
            int lcd = Fraction.Lcm(f1, f2);
            //recalculate the numerators over the lcd
            int f1Num = f1.num * (lcd / f1.denom);
            int f2Num = f2.num * (lcd / f2.denom);
            return f1Num > f2Num;
        }
        public static bool operator >=(Fraction f1, Fraction f2)
        {
            //put with common denom
            int lcd = Fraction.Lcm(f1, f2);
            //recalculate the numerators over the lcd
            int f1Num = f1.num * (lcd / f1.denom);
            int f2Num = f2.num * (lcd / f2.denom);
            return f1Num >= f2Num;
        }
        public static bool operator <=(Fraction f1, Fraction f2)
        {
            //put with common denom
            int lcd = Fraction.Lcm(f1, f2);
            //recalculate the numerators over the lcd
            int f1Num = f1.num * (lcd / f1.denom);
            int f2Num = f2.num * (lcd / f2.denom);
            return f1Num <= f2Num;
        }

        public static bool operator ==(Fraction f1, Fraction f2)
        {
            //put with common denom
            int lcd = Fraction.Lcm(f1, f2);
            //recalculate the numerators over the lcd
            int f1Num = f1.num * (lcd / f1.denom);
            int f2Num = f2.num * (lcd / f2.denom);
            return f1Num == f2Num;
        }

        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return !(f1 == f2);
        }

        public static explicit operator double(Fraction f)
        {
            return (double)f.Numerator / f.Denominator;
        }

        public static explicit operator int(Fraction f)
        {
            return f.Numerator / f.Denominator;
        }

        public static explicit operator Fraction(int i)
        {
            return new Fraction(i, 1);
        }
    }
}

