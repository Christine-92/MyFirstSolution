using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  for (int i = 0; i < 7; i++)
              {
                  for (int j = 0; j < 7; j++)
                  {
                      Console.Write('*');
                      Console.Write(' ');

                  }
                  Console.Write('\n');
              }*/

            Rectangle(6, 10);
              
        }
        static void Rectangle(int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write('*');
                    Console.Write(' ');

                }
                Console.Write('\n');
            }
        }
    }

}
