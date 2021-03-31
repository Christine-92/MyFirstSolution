using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter min limit");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max limit");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int x = Convert.ToInt32(Console.ReadLine());
            bool p = InRange(a, b, x);
            Console.WriteLine("P = {p}");

        }
        static bool InRange(int a, int b, int x)
        {
            int[] MyArray = new int[a+b];
            MyArray[0] = a;
            MyArray[a+b-1] = b;
            if (x >= a & x <= b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

