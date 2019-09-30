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
            Console.WriteLine(Pow(2,-2));
        }

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

        public static double Pow(int x, int y)
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
                    result *= (double) 1/x;
                }
            }
            return result;
        }
    }
}
