using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maksimalna_poredica_ednakvi_chisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи числа: ");
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int max = 0;
            int repeating = 0;
            for (int p = 0; p < list.Count; p++)
            {
                int current = 0;
                for (int j = p; j < list.Count; j++)
                {
                    if (list[p] == list[j])
                        current++;
                }
                if (current > max)
                {
                    repeating = list[p];
                    max = current;
                }
            }
            for (int p = 0; p < max; p++)
                Console.Write(repeating + " ");
        }
    }
}
