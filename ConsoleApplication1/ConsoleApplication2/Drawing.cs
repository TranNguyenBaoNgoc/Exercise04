using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Drawing
    {
        //2
        public static void HLine(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(c);
            }
        }

        public static void VLine(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(c);
            }
        }

        public static void Square(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {
                HLine(n, c);
                Console.WriteLine();
            }
        }

        public static void SquareHollow(int n, char c)
        {
            HLine(n, c);
            Console.WriteLine();
            for (int i = 0; i < n - 2; i++)
            {
                HLine(1, c);
                HLine(n - 2, ' ');
                HLine(1, c);
                Console.WriteLine();
            }
            HLine(n, c);
            Console.WriteLine();
        }

        public static void DrawU(int n, char c)
        {
            for (int i = 0; i < n - 1; i++)
            {
                HLine(1, c);
                HLine(n - 2, ' ');
                HLine(1, c);
                Console.WriteLine();
            }
            HLine(n, c);
            Console.WriteLine();
        }

        public static void DrawV(int n, char c)
        {
            int b = 2 * n - 3;
            for (int i = 0; i < n - 1; i++)
            {
                HLine(i, ' ');
                HLine(1, c);
                HLine(b, ' ');
                HLine(1, c);
                Console.WriteLine();
                b -= 2;
            }
            HLine(n - 1, ' ');
            HLine(1, c);
            Console.WriteLine();
        }

        public static void RevTriangle(int n, char c)
        {
            HLine(2 * n - 1, c);
            Console.WriteLine();
            int a = 1, b = 2 * n - 5;
            for (int i = 0; i < n - 2; i++)
            {
                HLine(a, ' ');
                HLine(1, c);
                HLine(b, ' ');
                HLine(1, c);
                Console.WriteLine();
                a += 1;
                b -= 2;
            }
            HLine(n - 1, ' ');
            HLine(1, c);
            Console.WriteLine();
        }

        public static void Triangle(int n, char c)
        {
            HLine(n - 1, ' ');
            HLine(1, c);
            Console.WriteLine();
            int b = 1;
            for (int i = 2; i < n; i++)
            {
                HLine(n - i, ' ');
                HLine(1, c);
                HLine(b, ' ');
                HLine(1, c);
                Console.WriteLine();
                b += 2;
            }
            HLine(2 * n - 1, c);
            Console.WriteLine();
        }

        public static void DrawW(int n, char c)
        {
            HLine(1, c);
            HLine(2 * n - 3, ' ');
            HLine(1, c);
            HLine(2 * n - 3, ' ');
            HLine(1, c);
            Console.WriteLine();
            int b = 2 * n - 5;
            int x = 1;
            for (int i = 1; i < n - 1; i++)
            {
                HLine(i, ' ');
                HLine(1, c);
                HLine(b, ' ');
                HLine(1, c);
                HLine(x, ' ');
                HLine(1, c);
                HLine(b, ' ');
                HLine(1, c);
                Console.WriteLine();
                b -= 2;
                x += 2;
            }
            HLine(n - 1, ' ');
            HLine(1, c);
            HLine(2 * n - 3, ' ');
            HLine(1, c);
            Console.WriteLine();
        }

        public static void DrawA(int n, char c)
        {
            HLine(n + 1, ' ');
            HLine(1, c);
            Console.WriteLine();
            int a = 1, b = n;
            for (int i = 1; i < n / 2; i++)
            {
                HLine(b, ' ');
                HLine(1, c);
                HLine(a, ' ');
                HLine(1, c);
                Console.WriteLine();
                b--;
                a += 2;
            }
            HLine(b, ' ');
            HLine(n + 1, c);
            b--;
            a += 2;
            Console.WriteLine();
            for (int i = 1; i < n / 2 + 1; i++)
            {
                HLine(b, ' ');
                HLine(1, c);
                HLine(a, ' ');
                HLine(1, c);
                Console.WriteLine();
                b--;
                a += 2;
            }
        }

        public static void DrawX(int n, char c)
        {

            int a = 0, b = n-2;
            for (int i = 0; i < n / 2; i++)
            {
                HLine(a, ' ');
                HLine(1, c);
                HLine(b, ' ');
                HLine(1, c);
                Console.WriteLine();
                a++;
                b -= 2;
            }
            if (n%2 == 1)
            {
                HLine(n/2, ' ');
                HLine(1, c);
                Console.WriteLine();
            }
            b += 2;
            a--;
            for (int i = 0; i < n / 2; i++)
            {
                HLine(a, ' ');
                HLine(1, c);
                HLine(b, ' ');
                HLine(1, c);
                Console.WriteLine();
                b += 2;
                a--;
            }
        }

        public static void DrawPlus(int n, char c)
        {
            for (int i = 0; i < n / 2; i++)
            {
                HLine(n / 2, ' ');
                HLine(1, c);
                Console.WriteLine();
            }
            HLine(n + 1, c);
            Console.WriteLine();
            for (int i = 0; i < n / 2; i++)
            {
                HLine(n / 2, ' ');
                HLine(1, c);
                Console.WriteLine();
            }
        }
    }
}
