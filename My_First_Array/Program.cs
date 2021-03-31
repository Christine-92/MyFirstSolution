using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 5, 10, 100, 20, 30, 40 };
            int[] myArray2 = new int[5] { 5, 4, 1, 2, 0 };
            string[] namesList = new string[] { "Varsik", "Christ", "Varsik", "Christ", "Varsik", "Christ" };

            //int first = myArray[1];
            //Console.WriteLine(first);
            //Console.WriteLine(myArray); 
            //Console.WriteLine(namesList);

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    int item =  myArray[i];
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < namesList.Length; i++)
            //{
            //    string item = namesList[i];
            //    Console.WriteLine(item);
            //}
           
           for(int i = 0; i< myArray.Length; i++)
            {
                int j = myArray[i];
                if (j % 2 == 0)
                Console.WriteLine(j);
              
            }
           for(int k=0; k<namesList.Length; k++)
            {
                string n = namesList[k];
                if (n == "Varsik")
                    Console.WriteLine(n + " index is  " + k);
            }

            Console.ReadKey();
        }
		
    }
}
