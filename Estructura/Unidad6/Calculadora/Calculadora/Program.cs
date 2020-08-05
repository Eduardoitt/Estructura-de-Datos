using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, r, tab;
            Console.Write("leer tabla: ");
            Console.Write("");
            tab = int.Parse(Console.ReadLine());
            for (n = 1; n <= 10; n++)
            {
                r = n * tab;
                Console.WriteLine(tab+" * "+ n+" = "+r);
            }
            Console.ReadKey();
        }
    }
}
