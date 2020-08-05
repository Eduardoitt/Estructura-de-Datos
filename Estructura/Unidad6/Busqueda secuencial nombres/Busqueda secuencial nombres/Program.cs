using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_secuencial_nombres
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estructura de Datos
            // Unidad 6 Metodos de busqueda
            // 16210519 Escobedo Diaz Jesus Eduardo
            // Programa 2 busqueda secuencial

            int n = 30, Top = 0;
            string buscar;
            string[] nombres = new string[n];
            Console.WriteLine("");
            Console.WriteLine("Ingresar 30 nombres");
            for (int r = 0; r < n; r++)
            {
                nombres[r] = Console.ReadLine();
                Top = Top + 1;
            }
            Console.WriteLine("\n=========================================================\n");
            Console.Write("De el nombre que desea buscar : ");
            buscar = Console.ReadLine();
            //Busqueda del dato
            for (int x = 0; x < n; x++)
            {
                if (buscar == nombres[x])
                {
                    Console.WriteLine();
                    Console.WriteLine("La busqueda ha sido un exito");
                    Console.WriteLine();
                    Console.WriteLine("Posicion : {0} " + " Nombre : {1}\n", x + 1, nombres[x]);
                }
            }
            //arerglo impreso
            Console.WriteLine("Nombres capturados en la lista\n");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(nombres[i]);
            }
            Console.WriteLine("\n\nPresione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
