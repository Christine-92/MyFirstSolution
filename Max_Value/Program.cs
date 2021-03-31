using System;

namespace Max_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number");
            string input1 = Console.ReadLine();
            int x = Convert.ToInt32(input1);
            Console.WriteLine("Please enter the second nmber");
            string input2 = Console.ReadLine();
            int y = Convert.ToInt32(input2);
            Console.WriteLine("Please enter the third number");
            string input3 = Console.ReadLine();
            int z = Convert.ToInt32(input3);
            int max = 0;
            if (x > y)
            { max = x; }
            else
            { max = y;
            }

            if (max > z)
            {
                Console.WriteLine("Max = " + max); 
            }

            else
            {
                max = z;


                Console.WriteLine("Max = "+ max);
            }

            Console.ReadKey();

        }

}
}
