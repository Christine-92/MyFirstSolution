using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your Max Value is "+ MaxValue());
            
        }
        static int MaxValue()
        {
            Console.WriteLine("Please enter a count of inputs");
            int x = Convert.ToInt32(Console.ReadLine());
          var arr =  Array1(x);
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if(arr[i]>max)
                {
                    max = arr[i];
                }
            }

            return max;  
        }
        static int[] Array1(int x)
        {
            Console.WriteLine("Ener inputs "+x+" values");
            int [] values = new int[x];
            for (int i = 0; i < x; i++)
            {
                values[i] =Convert.ToInt32(Console.ReadLine());
            }
            return values;
        }
    } 
}
