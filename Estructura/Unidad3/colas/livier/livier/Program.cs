using System;
using System.Collections.Concurrent;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace cola_3
{
    public string nom;
    class Program
    {
        
        static void Main(string[] args)
        {
            // Estructura de Datos
            // Unidad 3 Estructuras lineales
            // 16210519 Escobedo Diaz Jesus Eduardo
            // Programa 4
            int n = 50;
            Queue<string> nombres = new Queue<string>(n);
            Queue<int> edades = new Queue<int>(n);
            insertar(nombres, edades, n);
        }
        //insercion
        static void insertar(Queue<string> nombres, Queue<int> edades, int n)
        {
            int F = 0, ed;
            string otro, nom;
            do
            {
                if (F >= n)
                {
                    Console.WriteLine("Cola llena");
                }
                else
                {

                    Console.Write("Ingresar nombre: ");
                    nom = Console.ReadLine();
                    nombres.Enqueue(nom);
                    Console.Write("Ingresar edad: ");
                    ed = int.Parse(Console.ReadLine());
                    edades.Enqueue(ed);
                    F = F + 1;
                }
                Console.WriteLine("Desea otra insercion si/no");
                otro = Console.ReadLine();
            } while (otro != "no");
            Mayor(nombres, edades, F, n);
        }
        //persona mayor
        static void Mayor(Queue<string> nombres, Queue<int> edades, int F, int n)
        {
            int mayor = 0; string nom;
            int[] copiedad = new int[n];
            edades.CopyTo(copiedad, 0);
            string[] copinom = new string[n];
            nombres.CopyTo(copinom, 0);
            for (int i = 0; i < n; i++)
            {
                if (copiedad[i] > mayor)
                {
                    mayor = copiedad[i];
                    nom = copinom[i];
                }
            }

            NomyEdad(copiedad, copinom, n, nombres, edades, F, mayor);

        }
        //impresion de nombres y edades
        static void NomyEdad(int[] copiedad, string[] copinom, int n, Queue<string> nombres, Queue<int> edades, int F, int mayor)
        {
            for (int i = 0; i < F; i++)
            {
                Console.WriteLine("Nombre " + copinom[i] + " edad " + copiedad[i]);
            }
            Eliminar(nombres, edades, F, mayor);
        }
        //eliminacion
        static void Eliminar(Queue<string> nombres, Queue<int> edades, int F, int mayor)
        {
            int I = 0;
            string otro, ot;
            do
            {
                Console.WriteLine("Desea hacer una eliminacion si/no");
                ot = Console.ReadLine();
                if (ot != "no")
                {
                    if (edades.Count == -1 && nombres.Count == -1)
                    {
                        Console.WriteLine("Cola vacia");
                    }
                    else
                    {
                        Console.WriteLine("Datos eliminados");
                        Console.WriteLine("Nombre: " + nombres.Dequeue() + " edad: " + edades.Dequeue());
                        I = I + 1;
                        if (I == F)
                        {
                            edades.Dequeue();
                            nombres.Dequeue();
                            I = -1; F = -1;
                        }
                    }
                }
                Console.WriteLine("Desea eliminar un dato si/no");
                otro = Console.ReadLine();
            } while (otro != "no");
            ImpNyE(mayor);
        }
        //persona mayor impresa
        static void ImpNyE(int mayor)
        {
            Console.WriteLine("La persona con mayor edad es {0}", nom + mayor);
            Console.ReadKey();
        }
    }
}
