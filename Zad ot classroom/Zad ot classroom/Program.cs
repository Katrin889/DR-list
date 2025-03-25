using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_ot_classroom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers: ");
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            Console.Write("Enter 3 numbers: ");
            var nums3 = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            if (nums3.Count == 3)
            {
                List<double> newList = new List<double>();
                for (int i = 0; i < nums3[0]; i++)
                {
                    newList.Add(nums[i]);
                }
                Console.WriteLine(string.Join(" ", newList));
                for (int i = 0; i < newList.Count/2; i++)
                {
                    if (i <= ((newList.Count/2) - nums3[1]))
                    {
                        newList.RemoveAt(i);
                        i--;
                    }
                }
                Console.WriteLine(string.Join(" ", newList));
                if (newList.Count == nums3[2])
                    Console.WriteLine("YES Uspqh!");
                else
                    Console.WriteLine("NO ne moga");
            }
            else
                Console.WriteLine("Error! Too much or not enough numbers entered!");
        }
    }
}
