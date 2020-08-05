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
            // Estructura de Datos
            // Unidad 3 Estructuras lineales
            // 16210519 Escobedo Diaz Jesus Eduardo
            // Programa 2
            int Top=0;
            string nom,otro;
            string[] pila = new string[50];
            do
            {
                Console.WriteLine("Nombre");
                nom = Console.ReadLine();
                if (Top >= 50)
                {
                    Console.WriteLine("Pila llena");
                }
                else
                {
                    pila[Top] = nom;
                    Top = Top + 1;
                }
                Console.WriteLine("Desea ingresar mas nombres si/no");
                otro = Console.ReadLine();
            } while (otro != "no");
            Console.WriteLine("   =====================================");
            Console.WriteLine("Datos en la pila");
            mostrar(pila,Top,0);
            Console.WriteLine("   =====================================");
            Console.WriteLine("Pila");
            imprimir(pila,Top);
        }
        //Datos de la pila en general
        static void mostrar(string[] pila, int Top,int i)
        {
            for (i = 0; i <= Top; i++)
            {
                Console.WriteLine(pila[i]);
            }
        }
        //Pila
        static void imprimir(string [] pila,int Top)
        {
            for (int i = Top - 1; i > -1; i--)
            {
                Console.WriteLine(pila[i]);
            }
            Console.ReadKey();
        }
    }
}
