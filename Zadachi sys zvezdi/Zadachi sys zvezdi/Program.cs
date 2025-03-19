using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadachi_sys_zvezdi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи имена:");
            List<string> list = Console.ReadLine().Split(',').ToList();
            for (int i = 0; i < list.Count; i++)
            {
                string[] words = list[i].Split(' ');
                list[i] = words[0] + " " + words[1];
            }
            list.Reverse();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

        }
    }
}
