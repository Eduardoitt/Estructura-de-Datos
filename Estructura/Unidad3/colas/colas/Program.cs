using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace colas
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,Frente=0,Dato;
            string otro;
            Console.Write("Ingrese el tamaño de la cola: ");
            N = int.Parse(Console.ReadLine());
            //Final = N;
            Queue<int> cola = new Queue<int>(N);
            do
            {
                if (Frente <= N)
                {
                    Console.Write("ingresar un numero: ");
                    Dato= int.Parse(Console.ReadLine());
                    cola.Enqueue(Dato);
                }
                else
                {
                    Console.WriteLine("Cola llena");
                }
                Frente = Frente + 1;
                Console.WriteLine("Desea otra insercion si/no");
                otro = Console.ReadLine();
            } while (otro != "no");
            Console.WriteLine("Eliminar dato");
            do
            {
                Console.WriteLine("Desea eliminar");
                string pregunta = Console.ReadLine();
                if (pregunta == "si")
                {
                    if (cola.Count > 0)
                    {
                        cola.Enqueue(Frente);
                        
                    }
                    else
                    {
                        Console.WriteLine("Cola vacia");   
                    }
                }
                //Final = Final - 1;
                Console.WriteLine("Desea otro eliminacion si/no");
                otro=Console.ReadLine();
            }while(otro!="no");

            Console.WriteLine("Siguiente en la cola {0} ",cola.Peek());
            Console.WriteLine("Cantidad de elementos que contiene la cola {0}", cola.Count);
            Console.WriteLine("Vaciar cola");
            Console.WriteLine("Si desea vaciar cola presionar 1, para salir 2");
            int ob =int.Parse(Console.ReadLine());
            switch(ob)
            {
                case 1:
                    cola.Clear();
                    Console.WriteLine("Cola vacia");
                    break;
                case 2:
                    break;

            
            }
            Console.ReadKey();

        }
    }
}
