using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Da entrada a una palabra y la imprime al reves

            String palabra = "";
            String reves;
            Console.WriteLine("ingresa una palabra : ");
            reves = Console.ReadLine();
            int imprimir = reves.Length;
            for (int i = imprimir - 1; i >= 0; i--)
            {
                palabra = palabra + reves.Substring(i, 1);
            }
            Console.WriteLine(palabra);
            Console.ReadLine();
        }
    }
}
