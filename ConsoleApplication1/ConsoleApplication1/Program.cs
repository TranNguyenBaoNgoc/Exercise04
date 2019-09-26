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
            Console.WriteLine(IsOdd(4));
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
    }
}
