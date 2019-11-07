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

            string[] month = {
                "January",
                "February",
                "March",
                "Aprill",
                "May",
                "June",
                "July",
                "August",
                "September",
                "November",
                "December",
            };
            //ข้อ a
            Console.WriteLine("little size : " + Array.Find(month, element => element.Length == 3));
           
            //ข้อ c
            Console.WriteLine("start of J : " + string.Join(",", Array.FindAll(month, element => element.StartsWith("J", StringComparison.Ordinal))));
            Console.ReadLine();

            Console.ReadLine();
        }
    }
    
}
