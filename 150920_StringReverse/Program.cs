using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _150920_StringReverse
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide a string to reverse.");
            string text = Console.ReadLine();
            
            for (int i = (text.Length - 1); i >= 0; i--)
            {
                Console.Write(text[i]);
            }


        }
    }
}
