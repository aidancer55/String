using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] array = s.Split();
            int a = 0;
            int b = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length > a)
                {
                    a = array[i].Length;
                    b = i;
                }
            }
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
