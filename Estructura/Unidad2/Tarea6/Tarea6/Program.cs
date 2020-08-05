using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estructura de Datos
            // Unidad 2 Recursividad
            // 16210519 Escobedo Díaz Jesús Eduardo
            // Programa 6
            string palabra,pal2;
            
            Console.WriteLine("Ingrese una palabra");
            palabra = Console.ReadLine();
            pal2 = Invertir(palabra);
            Console.WriteLine("Palabra invertidad: "+pal2);
            Invertir(palabra);
            Console.ReadKey();

        }
        public static string Invertir(string palabra)
        {

            char[] cadena = palabra.ToArray();
            Array.Reverse(cadena);
            return new string(cadena);
        }
    }
}
