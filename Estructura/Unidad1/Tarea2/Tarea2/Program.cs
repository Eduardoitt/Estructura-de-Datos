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
            //Escobedo Díaz Jesús Eduardo 16210519
            //Unidad 1. Introducción a las estructuras de datos
            //Programa que borra el numero que se encuentra en la lista e imprime  la listamodificada

            //Recibe 30 numeros y si un numero es igual al de la variable 0 modifica la lista
            int [] lista = new int[30];
            int [] modificada= new int[30];
            int numero, r;
            Random aleatorio = new Random();

            
            //Introduce 30 numeros
            for ( r=0; r < 30; r++)
            {
                lista[r] = aleatorio.Next(1,50);
            }

            //Impresion del vector original
            Console.WriteLine("Lista original: ");
            for (r = 1; r < 30; r++)
            {
                Console.WriteLine(lista[r]);
            }

            Console.WriteLine("Intruducir el numero que desee borrar de la lista: ");
            numero = int.Parse(Console.ReadLine());

            //trapaso de datos del vector original 
            for (r = 0; r < 30;r++ )
            {
                modificada[r] = lista[r];
            }

            //Comparacion de numeros
            for (r = 0; r < 30;r++ )
            {
                if (modificada[r] == numero)
                {
                    modificada[r] = 0;
                }
            }

            

            //impresion de la lista modificada
            Console.WriteLine("Lista modificada: ");
            for (r = 0; r < 30;r++ )
            {
                Console.WriteLine(modificada[r]);
            }

            Console.ReadKey();
            

            
        }
    }
}
