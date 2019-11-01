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

            string[] changwad = new string[78];

            Console.WriteLine("\r\n------ changwad ------\r\n");
            for (int i = 0; i < changwad.Length; i++)
            {
                Console.Write("chandwat[" + i + "] : ");
                changwad[i] = Console.ReadLine().ToString();
            }


        }
    }
}
