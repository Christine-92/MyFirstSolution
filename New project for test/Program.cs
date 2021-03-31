using System;

namespace New_project_for_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep(523, 500);//do
            Console.Beep(587, 500);//re
            Console.Beep(659, 500);//mi
            Console.Beep(698, 500);//fa
            Console.Beep(784, 500);//col
            Console.Beep(880, 500);//ya
            Console.Beep(988, 500);//ci
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Hello World");
            Console.WriteLine("Hi Team");
            Console.ResetColor();
            Console.ResetColor();
            Console.WriteLine("Goodbye");


            Console.ReadKey();


        }
    }
}
