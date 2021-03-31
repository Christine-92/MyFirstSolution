using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Value_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] MaxArray = { 5, 10, 17, -7, 0, 96, 0, -9, 55 };
            int max = MaxArray[0];
            for (int i = 1; i < MaxArray.Length; i++)
            {

                if (MaxArray[i] > max)
                {
                    max = MaxArray[i];

                }

            }
            Console.WriteLine(max);
            Console.ReadKey();

        }
    }
}
