using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Last
{
    class Program
    {
        static void Main(string[] args)


        {
            //Console.WriteLine("Enter a word please");
            //string word = Console.ReadLine();
            //word = "jughkju";
            /*char x = word[0];
            char y = word[word.Length - 1];*/
            /*string z = word.Substring(1,word.Length-2);
            string newword = y + z + x;
            Console.WriteLine(newword);*/
            /* StringBuilder word = new StringBuilder(Console.ReadLine());
             char x = word[0];
             word[0] = word[word.Length - 1];
             word[word.Length - 1] = x;
             word.Append("loveyou");


             Console.WriteLine(word);

             string y = "";
             y = y + "loveyou";*/
            string word = "Christ+Varsik = Automatin QA";

            Console.WriteLine(word);
            char x = word[1];
            char y = word[word.Length - 1];
            string z = word.Substring(1,word.Length - 2);
            string newword = y + z + x;
            Console.WriteLine(newword);

            Console.ReadKey();
        }
    }
}
