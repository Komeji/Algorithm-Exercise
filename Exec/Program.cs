using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace TestOne
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime idate = System.DateTime.Now;

            Program pro = new Program();
            ArrayList inInt = new ArrayList();
            inInt = pro.FindPerfectNumber(100000);
            DateTime jdate = System.DateTime.Now;

            TimeSpan ts = jdate.Subtract(idate);
            Console.WriteLine(ts.TotalSeconds);

            foreach(var a in inInt)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }

        public ArrayList FindPerfectNumber(int number)
        {
            ArrayList inInt = new ArrayList();
            int yin = 0;
            for (int i = 1; i < number; i++)
            {
                if(yin != 0)
                {
                    yin = 0;
                }

                for (int x = 1; x < i; x++)
                {
                    if (i % x == 0)
                    {
                        yin += x;

                    }
                }
                if (i == yin)
                {
                    inInt.Add(yin);
                }

            }
            return inInt;
        }
    }

}

