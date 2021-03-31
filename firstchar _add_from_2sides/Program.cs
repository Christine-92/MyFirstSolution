using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstchar__add_from_2sides
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Please Enter a word");
            string word = Console.ReadLine();
            char x = word[0];
            Console.WriteLine(word[0]+word+word[0]);
            Console.ReadKey();
        }
    }
}
