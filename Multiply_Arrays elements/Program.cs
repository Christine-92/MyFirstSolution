using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Arrays_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = new int[4] { 1, 3, -5, 4 };
            int[] Array2 = { 1, 4, -5, -2 };

            List<int> list1 = new List<int>();
            for( int i=0; i<4;i++)
            
            {
               int x = Array1[i]*Array2[i];

                list1.Add(x);
       
            }
            foreach (int i in list1)
            {
                Console.WriteLine(i);
            }

            

        }
    }
}
