using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_na_obyrnati_chisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи числа: ");
            var list = Console.ReadLine().Split(' ').ToList();
            List<int> list2 = new List<int>();
            int a = 0; 
            for (int i = 0; i < list.Count; i++)
            {
                string nums = list[i];
                char[] num = nums.ToCharArray();
                char[] rev = num.Reverse().ToArray();
                list2.Add(int.Parse(string.Join("", rev)));
            }
            for (int i = 0;i < list2.Count; i++)
            {
                 a += list2[i];
            }
            Console.WriteLine(a);
        }
    }
}
