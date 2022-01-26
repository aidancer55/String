using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] reverse = str.ToCharArray();
            Array.Reverse(reverse);
            string nstr = new string(reverse);
            int result = string.CompareOrdinal(str, nstr);
            if (result == 0)
            {
                Console.WriteLine("Палиндром");
            }
            else
            {
                Console.WriteLine("Не палиндром");
            }
            Console.ReadKey();
        }
    }
}
