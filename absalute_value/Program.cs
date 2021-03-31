using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absalute_value
{
    class Program
    {
        static void Main(string[] args)

        {
            /*Console.WriteLine("Enter two numbers");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            if (x >= y)
            { int s = 2*(x - y);
                Console.WriteLine(s);
            }
            else
            { int a = y - x;
                Console.WriteLine(a);


            }
            Console.ReadKey();*/
            Console.WriteLine("Enter two numbers");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int sum = x+y;
            if ((x == 20 || y == 20) || (sum == 20))
            { Console.WriteLine("True"); }
            else
            { Console.WriteLine("False"); }

        }

    }
}
