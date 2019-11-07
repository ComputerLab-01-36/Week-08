using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_08
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] gps = new float[8];
            for (int i = 0; i < gps.Length; i++)
            {
                Console.Write($"Enter GPS term{i + 1} : ");
                gps[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("about GPS");

            foreach (float j in gps)
            {
                Console.Write($"{j,0:N} ");
            }
            Console.WriteLine();

            Console.WriteLine("GPA is {0 , 0:N}", gps.Sum() / gps.Length);
            Console.ReadLine();
        }
    }
}
