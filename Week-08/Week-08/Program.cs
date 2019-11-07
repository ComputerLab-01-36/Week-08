using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab08
{
    class Program
    {
        static void Main(string[] args)
        {
            string sprovide, lsprovide = null;
            string snumpost, lsnumpost = null;
            int numpost;

            Hashtable Provide = new Hashtable();


            StreamReader fprovide = null;
            StreamReader fnumpost = null;

            try
            {
                fprovide = new StreamReader("./provide.txt");//file form folder bin
                fnumpost = new StreamReader("./numpost.txt");
                while (((sprovide = fprovide.ReadLine().ToString()) != "...") && ((snumpost = fnumpost.ReadLine().ToString()) != "..."))
                {
                    if (snumpost.Equals(lsnumpost))
                    {
                        continue;
                    }
                    else
                    {
                        Provide.Add(snumpost, sprovide);
                        //Console.WriteLine($"{sprovide} => {snumpost}");
                        //lsprovide = sprovide;
                        lsnumpost = snumpost;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        insert:
            try
            {
                Console.Write("Enter Postcode : ");
                numpost = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                goto insert;
            }

            foreach (DictionaryEntry dicprovide in Provide)
            {
                if (dicprovide.Key.Equals(numpost.ToString()))
                    Console.WriteLine(dicprovide.Key + "   -   " + dicprovide.Value);
            }
            Console.ReadKey();
        }
    }
}