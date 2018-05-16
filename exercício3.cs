using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class exercício3
    {
        static void Main(string[] args)
        {
            int num;
            int count = 0, countPos = 0;

            do
            {
                count++;
                Console.WriteLine(count + " - Digite um número: ");
                num = Convert.ToInt16(Console.ReadLine());

                if (num > 0)
                {
                    countPos++;

                }

            } while (num != 0);

                Console.WriteLine("count: " + count);
                Console.WriteLine("countPos: " + countPos);

                Console.ReadKey();
            
        }
    }
}
