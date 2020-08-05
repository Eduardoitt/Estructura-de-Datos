using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra = " ", pal2="",leer="";
            int r, longitud;
            Console.WriteLine("Ingresar una palabra");
            palabra = Console.ReadLine();
            
            longitud = palabra.Length;

            for (r = longitud - 1; r >= 0; r--)
            {
                leer = palabra.Substring(r,1);
                pal2 = pal2 + leer;
            }
            if (palabra.Equals(pal2))
            {
                Console.WriteLine(palabra + " es palindromo");
            }
            else
            {
                Console.WriteLine(palabra+" no es palindromo");
            }
            Console.ReadKey();
            
        }
    }
}
