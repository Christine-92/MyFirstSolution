using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> SumFiftyNumbers = new List<int>() { 0, 1,2,3, 16, 20, 25, 34,47,48, 50, 100 };

            for (int i = 0; i < SumFiftyNumbers.Count-1; i++)
            {

                for (int j = SumFiftyNumbers.Count-1; j >0 ; j--)
                {
                    bool check = false;
                    while (i != j)
                    {

                        if (SumFiftyNumbers[i] + SumFiftyNumbers[j] > 50)
                        {                          
                            j--;
                           
                            check = false;
                        }
                        else if (SumFiftyNumbers[i] + SumFiftyNumbers[j] < 50)
                        {
                            i++;                          
                            check = true;
                        }
                        else
                        { 
                            Console.WriteLine("Index i = " + i + " j = " + j + " = " + 50);
                            if (check)
                            {
                                i++;
                            }
                            else
                            {
                                j--;
                            }
                        }

                        if (i<0 || j < 0 || i < j)
                        {
                            break;
                        }
                    }
                }
               }
           }
        
    }
   
}
         

