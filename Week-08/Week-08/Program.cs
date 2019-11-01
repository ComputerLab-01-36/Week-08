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
            Console.WriteLine("\r\n------ Input Values ------\r\n");
            for (int i = 0; i <= 10; i++)
            {
                Console.Write("Input value index[" + i + "] : ");
                
            }
            int[] data = new int[10];
            data[0] = 0;
            data[1] = 1;
            data[2] = 2;
            data[3] = 3;
            data[4] = 4;
            data[5] = 5;
            data[6] = 6;
            data[7] = 7;
            data[8] = 8;
            data[9] = 9;

            Console.WriteLine(data[0]+ data[1] + data[2] + data[3] + data[4] + data[5] + data[6] + data[7] + data[8] + data[9]);

            Console.ReadLine();
        }
    }
    
}
