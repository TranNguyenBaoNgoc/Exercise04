using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Equation(2,3));
        }
        //4a
        public static Boolean IsOdd(int n)
        {
            if (n % 2 == 0)
            {
                return false;
            }
            return true;
        }

        public static Boolean IsEven(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static Boolean IsPrime(int n)
        {
            int c = 0;
            if (n >= 2)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        c++;
                    }
                }
            }
            if (c==2)
            {
                return true;
            }
            return false;
        }

        public static int Square(int n)
        {
            return n*n;
        }

        public static int Cube(int n)
        {
            return n*n*n;
        }

        public static double Pow(double x, double y)
        {
            double result = 1;
            if (x == 0)
            {
                result = 0;
            }
            else if (x != 0 && y > 0)
            {
                for (int i = 1; i <= y; i++)
                {
                    result *= x; 
                }
            }
            else if (x != 0 && y < 0)
            {
                for (int i = 1; i <= -y; i++)
                {
                    result *= 1/x;
                }
            }
            return result;
        }

        public static int Abs(int n)
        {
            if (n < 0)
            {
                n *= -1;
            }
            return n;
        }
        public static int Ceil(float n)
        {
            return (int)n + 1;
        }

        public static int Floor(float n)
        {
            return (int)n;
        }

        public static int Ran1()
        {
            Random r = new Random();
            return r.Next(0, (int)Pow(2,31));
        }

        public static int Ran2()
        {
            Random r = new Random();
            return r.Next(0,2);
        }

        public static int Factorial(int n)
        {
            int s = 1;
            for (int i = 1; i <= n; i++)
            {
                s *= i;
            }
            return s;
        }

        public static double Equation(double x, int n)
        {
            double s = 0;
            for (int i = 0; i <= n; i++)
            {
                s += Pow(-1,i)*(Pow(x, 2*i+1)/Factorial(2*i+1));
            }
            return s;
        }
    }
}
