using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] MyArray = new int[4] { 1, 9, 3, 4 };
            int[] MyArray2 = new int[4] { 1, 19, 34, 14 };
            /* foreach (var i in MyArray)

             {
                 Console.WriteLine(MyArray[i]);

             }*/
            Array.Sort(MyArray);
            Array.Reverse(MyArray2);
            for (int j = 0; j < MyArray.Length; j++)
            {
                Console.WriteLine(MyArray2[j]);
            }

            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine(MyArray[i]);
            }

        }
    }
}
    

