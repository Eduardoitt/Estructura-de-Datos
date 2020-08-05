using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estructura de Datos
            // Unidad 6 Metodos de busqueda
            // 16210519 Escobedo Diaz Jesus Eduardo
            // Programa 1 busqueda secuencial

            //capturar 30 numeros de control 
            //realizar la busqueda 
            //si se encuentra imprimirlo y la posicion donde se encontraba
            int n=30,Top=0,buscar;
            //int dato;
            int [] ncont=new int[n];
            Console.WriteLine("");
            Console.WriteLine("Ingresar 30 numeros de control");
           
            for (int r = 0; r < n; r++)
            {
                ncont[r] = int.Parse(Console.ReadLine());
                Top = Top + 1;
            }
                Console.WriteLine("\n=========================================================\n");
            Console.Write("De el numero de control que desea buscar : ");
            buscar=int.Parse(Console.ReadLine());
            //Busqueda del dato
            for (int x = 0; x < n;x++ )
            {
                if (buscar == ncont[x])
                {
                    Console.WriteLine();
                    Console.WriteLine("La busqueda ha sido un exito");
                    Console.WriteLine();
                    Console.WriteLine("Posicion : {0} "+" Numero de control : {1}\n",x+1,ncont[x]);
                }
            }
            //arerglo impreso
            Console.WriteLine("Numeros de control capturados en la lista\n");
            for (int i = 0; i <n; i++)
            {
                Console.WriteLine(ncont[i]);
            }
            Console.WriteLine("\n\nPresione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
