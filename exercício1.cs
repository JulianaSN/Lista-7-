using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************** MULTIPLOS DE 7 - 0 Á 1000 ******************");

            for(int i = 0; i <= 1000; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(+ i);
                }
            }

            Console.ReadKey();

        }
    }
}
