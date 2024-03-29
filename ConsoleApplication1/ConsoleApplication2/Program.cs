﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //2
            Drawing.VLine(4, 'i');
            Drawing.Square(4, 'o');
            Drawing.SquareHollow(4, 'o');
            Drawing.DrawU(4, 'u');
            Drawing.DrawV(4, 'V');
            Drawing.RevTriangle(4, 'V');
            Drawing.Triangle(4, 'A');
            Drawing.DrawW(4, 'W');
            Drawing.DrawA(4, 'A');
            Drawing.DrawX(5, 'X');
            Drawing.DrawPlus(4, '+');

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
        }

        //1
        static void EnterAray(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine("Nhap Phan Tu Arr[{0}]", i);
                Arr[i] = int.Parse(Console.ReadLine());
            }
        }

        static void PrintArray(int[] Arr)
        {
            foreach (int item in Arr)
            {
                Console.Write(item + " ");
            }
        }

        public static Boolean CheckContain(int[] Arr, int n)
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

        public static Boolean CheckContainOr(int[] Arr, int n1, int n2)
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

        public static Boolean CheckContainAnd(int[] Arr, int n1, int n2)
        {
            if (CheckContain(Arr,n1)==true && CheckContain(Arr,n2) == true)
            {
                return true;
            }
            return false;
        }

        public static int Count(int[] Arr, int n)
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

        public static int CountOr(int[] Arr, int n1, int n2)
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
        public static int SumValues(int[] Arr)
        {
            int s = 0;
            foreach (int item in Arr)
            {
                s += item;
            }
            return s;
        }

        
    }
}
