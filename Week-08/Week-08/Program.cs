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

            int[] month = { 2,5,5,1,3,6,1,4,0,2,5,0};
            string[] days =
            {
                "sun",
                "Mon",
                "Tue",
                "Wed",
                "Thu",
                "Fri",
                "Sat",
            };
            Console.Write("enter date : ");
            int date = int.Parse(Console.ReadLine());
            Console.Write("enter month:");
            int inmonth = int.Parse(Console.ReadLine());

            int day = (date + month[inmonth - 1] - 1) % 7;

            Console.WriteLine($"{date}/{month}/2561 is {days[day]}");
            Console.ReadLine();





            
        }

       
    }
}
