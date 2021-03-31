using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neagtive_pozitive
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Please enter two numbers");
             int x = Convert.ToInt32(Console.ReadLine());
             int y = Convert.ToInt32(Console.ReadLine());
             if ((x > 0 && y < 0) || (x < 0 && y > 0))
             { Console.WriteLine("True"); }*/

            Console.WriteLine("Please enter two numbers");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            if(x==y)
            { Console.WriteLine(y * 3); }
            else
            { int s = x + y;
                Console.WriteLine(s);
            }
            Console.ReadKey();


        }
    }
}
