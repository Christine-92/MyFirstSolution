using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Eval_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int[] MyArray = new int[9] { 1, -10, 50, 4, 17, 6, 4, 8, 7 };
             int[] OddArray = new int [9];//0000000
             int[] EvalArray =  new int [9];
             int indexOdd = 0; 
             int indexEval = 0;
             for(int i=0; i<MyArray.Length; i++)
             {
                 int item = MyArray[i];
                 if (item % 2 == 0)
                 {

                     EvalArray[indexEval] = item;
                     indexEval++;

                 }
                 else
                 {
                     OddArray[indexOdd] = item;
                     indexOdd++;
                 }

             }

             Console.WriteLine("Odd");
             foreach (int itemOdd in OddArray)
             {
                 Console.WriteLine(itemOdd);
             }


             Console.WriteLine("Eval");
             foreach (int itemEval in EvalArray)
             {
                 Console.WriteLine(itemEval);*/
            int[] MyArray = new int[99];
            int[] OddArray = new int[99];
            List<int> myList = new List<int>();
            Random rnd = new Random();// class a vor random tver a vercnum  qo tvac rang-ic 

            for (int i = 0; i < 99; i++)
            {
                MyArray[i] = rnd.Next(0,1000);// or MyArray[]=i
            }

            int j = 0;

            for (int i = 0; i < 99; i++)
            {
                int item = MyArray[i];
                if (item % 2 != 0)
                {
                    OddArray[j] = item;
                    j++;

                    myList.Add(item);
                }

            }
            foreach (int k in OddArray)
            { Console.WriteLine(k); }
        



        }

    }
    }

