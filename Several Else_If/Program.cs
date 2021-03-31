using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Several_Else_If
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ener a number");
            string input = Console.ReadLine();
            int x = Convert.ToInt32(input);
            if (x % 3 == 0)
            {
                x = x * 3;
                Console.WriteLine(x);
            }
            else if (x % 10 == 0)
            {
                x = x + 100;
                Console.WriteLine(x);
            }
            else
            {
                x = x * 5;
                Console.WriteLine(x);
            }
            
            Console.ReadKey();
        }
    }
}
