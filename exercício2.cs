using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class exercício2
    {
        static void Main(string[] args)
        {
            int soma = 0;

            Console.WriteLine("******** Número pares entre 85-907 ********");

            for (int i = 85; i <= 907; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(+i);
                    soma += i;
                }
            }
            Console.WriteLine("A soma de todos eles é:{0}", soma);
            Console.ReadKey();
        }
    }
}
