using System;

namespace Method1
{
    class Program
    {
        static void Main(string[] args)
        {


            /* for (int j = 0; j <= 4; j++)
              {
                  for (int i = 0; i < j; i++)
                  {
                      Console.Write('*');
                  }

                  Console.Write('\n');
              }*/

            /* for (int j = 0; j <= 4; j++)
             {
                 for (int k = 0; k < 4 - j; k++)
                 {
                     Console.Write(' ');
                 }
                 for (int i = 0; i < j; i++)
                 {
                     Console.Write('*');
                 }

                 Console.Write('\n');
             }*/
            for (int j = 0; j <= 4; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    for (int k = 0; k < j; k++)
                        Console.Write(' ');
                    Console.Write('*');
                }

                Console.Write('\n');
            }
            for (int j = 0; j <= 4; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    for (int k = 0; k < i; k++)
                        Console.Write(' ');
                    Console.Write('*');
                }

                Console.Write('\n');
            }

            /*{
             int i = 1;
             int k = 5;
             int h = 1;

             while (i <= 5)
             {
                 Console.WriteLine("");
                 while (k > i)
                 {
                     Console.Write(" ");
                     k--;
                 }
                 while (h <= i)
                 {
                     Console.Write("**");
                     h++;
                 }
                 i++;
             }
             Console.ReadLine();

         }*/

            for (int i = 0; i < 7; i++)
            {
                for (int k = 0; k < 6 - i; k++)
                {
                    Console.Write(' ');
                }

                for (int j = 0; j < i; j++)
                {
                    if (j == 0)
                    {
                        Console.Write("*");
                    }
                    else
                    { Console.Write("**"); }
                }
                Console.Write('\n');
                
            }
        }
        Console.WriteLine("A:{0},");
    }
}

    
