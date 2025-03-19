using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombichki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи числа: ");
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.Write("Коя е бомбата? ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Каква е нейната сила? ");
            int s = int.Parse(Console.ReadLine());
            int a = 0;
            int w = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == b)
                {
                    for (int j = i - s; j <= i + s; j++)
                    {
                        if (j < list.Count && j >= 0)
                            w += list[j];
                    }
                }
            }
            for (int i = 0;i < list.Count; i++)
            {
                a += list[i];
            }
            Console.WriteLine(a - w);
        }
    }
}
