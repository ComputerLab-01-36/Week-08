﻿using System;
using System.Collections;
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
            ArrayList list1 = new ArrayList();
            list1.Add(10);
            list1.Add(20);
            list1.Add(30);
            list1.Add(40);
            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine(list1[i]);
            }
            ArrayList list2 = new ArrayList(list1);
            list2[2] = 55;
            list2[3] = 66;
            list2[4] = 77;

            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine(list2[i]);
            }
            Console.ReadLine();
        }
    }
}
