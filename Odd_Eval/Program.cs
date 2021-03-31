using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Eval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            int x = Convert.ToInt32(input);

            if (x % 2 == 0)
            {
                Console.WriteLine("The number is eval");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }

            Console.ReadKey();
        }
    }
}
