using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_function
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Ener a number");//arajin qani prime tveri gumary hasvi ed numbern a
            string input = Console.ReadLine();
            int x = Convert.ToInt32(input);
            int z = Prime(x);
                Console.WriteLine("Tere are " +z+ "prime numbers");


        }

        static int IsPrime(int x)
        {
            int count = 0;
            for (int j = 2; j <= x / 2; j++)
            {
                if (x % j == 0)
                {
                    count++;
                }


            }
            if (count==0)
            {
                return x;
            }
            return 0;
        }

        static int Prime(int x)
        {
            int primecount = 2;
            for (int i = 3; i < x; i++)
            {
                int y = i, count = 0;
                for (int j =2; j <= y / 2; j++)
                {
                    if (y % j ==0)
                    {
                        count++;
                    }

                }
                if (count==0)
                {
                    primecount++;
                }
               

            }

            if (x % 2 == 0)
            {
                primecount--;
            }
            return primecount;
        } 

    } }
