using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            VLine(4, 'i');
            Square(4, 'i');
            SquareHollow(5,'*');
            DrawU(5, '*');
            DrawV(5, '*');
            RevTriangle(5, '*');
            Triangle(5, '*');
            DrawA(4, '*');
            DrawPlus(4, '*');
            //1
            int[] Arr = new int[10];
            EnterAray(Arr);
            PrintArray(Arr);
            Console.WriteLine();
            if (CheckContain(Arr,5) == true)
            {
                Console.WriteLine("The series contains number 5");
            }
            else
                Console.WriteLine("The series not contains number 5");
            if (CheckContainOr(Arr, 5, 6) == true)
            {
                Console.WriteLine("The series contains number 5 or 6");
            }
            else
                Console.WriteLine("The series not contains number 5 or 6");
            if (CheckContainAnd(Arr, 5, 6) == true)
            {
                Console.WriteLine("The series contains number 5 and 6");
            }
            else
                Console.WriteLine("The series not contains number 5 and 6");
            Console.WriteLine("Have {0} number 5 in the series", Count(Arr, 5));
            Console.WriteLine("Have {0} number 5 or 6 in the series", CountOr(Arr, 5, 6));
            Console.Write("Sum: ");
            Console.WriteLine(SumValues(Arr));

            //2
        }

        //1
        static void EnterAray(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine("Nhap Phan Tu Arr[{0}]", i);
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void PrintArray(int[] Arr)
        {
            foreach (int item in Arr)
            {
                Console.Write(item + " ");
            }
        }

        static Boolean CheckContain(int[] Arr, int n)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == n)
                {
                    return true;
                }
            }
            return false;
        }

        static Boolean CheckContainOr(int[] Arr, int n1, int n2)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == n1 || Arr[i] ==n2)
                {
                    return true;
                }
            }
            return false;
        }

        static Boolean CheckContainAnd(int[] Arr, int n1, int n2)
        {
            if (CheckContain(Arr,n1)==true && CheckContain(Arr,n2) == true)
            {
                return true;
            }
            return false;
        }

        static int Count(int[] Arr, int n)
        {
            int s = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == n)
                {
                    s++;
                }
            }
            return s;
        }

        static int CountOr(int[] Arr, int n1, int n2)
        {
            int s = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == n1 || Arr[i] == n2)
                {
                    s++;
                }
            }
            return s;
        }
        static int SumValues(int[] Arr)
        {
            int s = 0;
            foreach (int item in Arr)
            {
                s += item;
            }
            return s;
        }

        //2
        static void HLine(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(c);
            }
        }

        static void VLine(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(c);
            }
        }

        static void Square(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {
                HLine(n, c);
                Console.WriteLine();
            }
        }

        static void SquareHollow(int n, char c)
        {
            HLine(n, c);
            Console.WriteLine();
            for (int i = 0; i < n-2; i++)
            {
                HLine(1, c);
                HLine(n-2, ' ');
                HLine(1, c);
                Console.WriteLine();
            }
            HLine(n, c);
            Console.WriteLine();
        }

        static void DrawU(int n, char c)
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

        static void DrawV(int n, char c)
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

        static void RevTriangle(int n, char c)
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

        static void Triangle(int n, char c)
        {
            HLine(n - 1, ' ');
            HLine(1, c);
            Console.WriteLine();
            int b = 1;
            for (int i = 2; i < n ; i++)
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

        static void DrawA(int n, char c)
        {
            HLine(n + 1, ' ');
            HLine(1, c);
            Console.WriteLine();
            int a = 1, b = n;
            for (int i = 1; i < n/2 +1; i++)
            {
                HLine(b, ' ');
                HLine(1, c);
                HLine(a, ' ');
                HLine(1, c);
                Console.WriteLine();
                b --;
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
        static void DrawPlus(int n, char c)
        {
            for (int i = 0; i < n/2; i++)
            {
                HLine(n / 2, ' ');
                HLine(1, c);
                Console.WriteLine();
            }
            HLine(n+1, c);
            Console.WriteLine();
            for (int i = 0; i < n/2; i++)
            {
                HLine(n / 2, ' ');
                HLine(1, c);
                Console.WriteLine();
            }
        }
    }
}
