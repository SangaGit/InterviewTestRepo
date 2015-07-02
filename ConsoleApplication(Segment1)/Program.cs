using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Segment1_
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + " - Support Training");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " - Support");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " - Training");
                }

                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
