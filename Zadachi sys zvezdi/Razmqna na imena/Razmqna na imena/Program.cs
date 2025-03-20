using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razmqna_na_imena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи имена:");
            List<string> list = Console.ReadLine().Split(',').ToList();
            list.Reverse();
            for (int i = 0; i < list.Count; i++)
            {
                string[] words = list[i].Split(' ');
                list[i] = words[1] + " " + words[0];
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
