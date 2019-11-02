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
            //หาgpa
            int[] data = new int[8];
            data[0] = 4*3;
            data[1] = 4*3;
            data[2] = 4*3;
            data[3] = 4*3;
            data[4] = 4*3;
            data[5] = 4*3;
            data[6] = 4*3;
            data[7] = 4*1;
            
            Console.WriteLine(data[0]);
            Console.WriteLine(data[1]);
            Console.WriteLine(data[2]);
            Console.WriteLine(data[3]);
            Console.WriteLine(data[4]);
            Console.WriteLine(data[5]);
            Console.WriteLine(data[6]);
            Console.WriteLine(data[7]);
            data = data[0] + data[1] + data[2] + data[3] + data[4] + data[5] + data[5] + data[5] + data[6] + data[7];
            
            Console.ReadLine();

        }
    }
}
