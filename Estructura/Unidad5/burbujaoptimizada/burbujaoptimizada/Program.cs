using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burbujaoptimizada
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estructura de Datos
            // Unidad 5 Metodos de ordenamiento
            // 16210519 Escobedo Diaz Jesus Eduardo
            // Programa 2 burbuja mejorada
            //Burbuja optimizada 
            //ordena 30 sueldos de forma descendente
            int tam = 30, i = 0;
            string ordenado = "si";
            int[] sueldo = new int[tam];
            Console.WriteLine("ingresar 30 sueldos");
            for (int r = 0; r < tam; r++)
            {
                sueldo[r] = int.Parse(Console.ReadLine());
            }
            //ordenamiento
            do
            {
                i = i + 1;
                ordenado = "si";
                for (int j = 0; j < tam - i; j++)
                {
                    if (sueldo[j] < sueldo[j + 1])
                    {
                        ordenado = "no";
                        int temp = sueldo[j];
                        sueldo[j] = sueldo[j + 1];
                        sueldo[j + 1] = temp;
                    }
                }
            } while (i < tam || ordenado == "no");
            Console.WriteLine("");
            Console.WriteLine("==============");
            Console.WriteLine("Sueldos ordenados descendentemente");
            for (int x = 0; x < tam; x++)
            {
                Console.WriteLine(sueldo[x]);
            }
            Console.ReadKey();
        }
    }
}
