using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Tarea4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estructura de Datos
            // Unidad 3 Estructuras lineales
            // 16210519 Escobedo Diaz Jesus Eduardo
            // Programa 4
            Stack pila = new Stack(100);
            int opciones;
            do
            {
                opciones=menu();
                switch(opciones)
                {
                    case 1:
                        insertar(ref pila);
                        break;
                    case 2:
                        eliminar(ref pila);
                        break;
                    case 3:
                        vaciarp(ref pila);
                        break;
                    case 4:
                        cuantos(ref pila);
                        break;
                    case 5:
                        siguiente(ref pila);
                        break;
                    case 6:
                        imprimir(ref pila);
                        break;
                    case 7:
                        break;
                }
                Console.WriteLine();
            }while(opciones!=7);
        }
        //insertar
        static void insertar(ref Stack pila)
        {
            string animal,otro;
            do
            {
                Console.WriteLine("Ingresar un nombre de animal");
                animal = Console.ReadLine(); 
                pila.Push(animal);
                Console.WriteLine("Desea ingresar otro nombre si/no");
                otro=Console.ReadLine();
            }while(otro!="no");
            
        }
        static void eliminar(ref Stack pila)
        {
            string eliminado;
            if (pila.Count > 0)
            {
                eliminado = (string)pila.Pop();
                mensaje("Se ha eliminador " + eliminado + " de la pila");
            }
        }
        static void mensaje(String texto)
        {
            if (texto.Length > 0)
            {
                Console.WriteLine("\n    =======================================================");
                Console.WriteLine(" {0}", texto);
                Console.WriteLine(" =======================================================");
                Console.ReadKey();
            }
        }
        static void vaciarp(ref Stack pila)
        {
            pila.Clear();
        }
        static void imprimir( ref Stack pila)
        {
            if (pila.Count > 0)
            {
                Console.WriteLine(" ");
                foreach (string dato in pila)
                {
                    Console.WriteLine("{0}",dato);
                }
            }
            else
            {
                Console.WriteLine("Pila vacia");
            }
        }
        static void cuantos(ref Stack pila)
        {
            Console.WriteLine("La pila contiene " + pila.Count+ " nombres");
        }
        static void siguiente(ref Stack pila)
        {
            Console.WriteLine("El siguiente elemento en la fila es "+ pila.Peek());
        }
        static int menu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1 ) Insertar elementos en la pila");
            Console.WriteLine("2 ) Elimina elementos de la pila ");
            Console.WriteLine("3 ) Elimina todos los elementos de la pila");
            Console.WriteLine("4 ) Muestra cuantos elementos contiene la pila");
            Console.WriteLine("5 ) Muestra el siguiente elementos en la pila");
            Console.WriteLine("6 ) Imprime la pila");
            Console.WriteLine("7) Salir");
            Console.WriteLine("Elija una opcion");
            int op;
            try
            {
                op = int.Parse(Console.ReadLine());
                return op;
            }
            catch
            {
                return 0;
            }
        }
    }
}
