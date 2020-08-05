using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Tarea3
{
    class Program
    {
        static void Main(string[] args)
        {
            int F=0,dato,Ma,Me;
            string otro,ot;
            Queue <int> cola=new Queue<int>(200);
            do
            {
                if(F>=199)
                {
                    Console.WriteLine("Cola llena");
                }
                else
                {
                    Console.Write("Ingresar sueldo ");
                    cola.Enqueue(dato=int.Parse(Console.ReadLine()));
                    F=F+1;
                }
                Console.WriteLine("Desea ingresar otro sueldo si/no");
                otro=Console.ReadLine();
            }while(otro!="no");
            //Detarmina el mayor y menor de los sueldo
            Me = cola.Min();
            Ma = cola.Max();
            //Imprime
            foreach(var item in cola)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Sueldo mayor " + Ma + ", " + "Sueldo menor " + Me);
            do
            {
                if (cola.Count > 0)
                {
                    cola.Dequeue();    
                }
                else
                {
                    Console.WriteLine("Cola vacia");
                }
                Console.WriteLine("Desa eliminar un dato si/no");
                ot = Console.ReadLine();
            } while (ot != "no");
            Console.ReadKey();
        }
    }
}
