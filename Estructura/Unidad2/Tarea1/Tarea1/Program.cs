using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estructura de Datos
            // Unidad 2 Recursividad
            // 16210519 Escobedo Díaz Jesús Eduardo
            // Programa 1
            string palabra, pal2;
            Console.WriteLine("Ingrese una frase");
            palabra = Console.ReadLine();
            pal2= Invertir(palabra);
            Console.WriteLine("Frase invertidaa");
            Console.WriteLine(pal2);
            Console.ReadKey();
            
        }
        public static string Invertir(string palabra)
        {
            char[] charArray = palabra.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
