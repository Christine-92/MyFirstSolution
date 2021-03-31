using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enlarge_Each_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] AddArray = { 1, 7, 0, -5, 4, 7, 8, 50 };

            for (int i = 0; i < AddArray.Length; i++)
            {
                AddArray[i] += 5;
         

            Console.WriteLine(AddArray[i]);
            }
            Console.ReadKey();

        }
    }
}
