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
    }
}
