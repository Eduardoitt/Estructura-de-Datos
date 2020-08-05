using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radix_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estructura de Datos
            // Unidad 5 Metodos de ordenamiento
            // 16210519 Escobedo Diaz Jesus Eduardo
            // Ordenamiento Radix sort
            
                int j = 32;
                int[] arreglo = new int[100];
                int[] fal = new int[100];
                Random ale = new Random(99);
                for (int a = 0; a < arreglo.Length; a++)
                {

                    arreglo[a] = ale.Next(1, 99);
                    fal[a] = arreglo[a];
                }
               
                int r = 4, b = 32;
                int[] contador = new int[j << r];
                int[] preferente = new int[j << r];
                int[] t = new int[arreglo.Length];
                int grupo = (int)Math.Ceiling((double)b / (double)r);
                int mascara = (1 << r) - 1;
                for (int c = 0, shift = 0; c < grupo; c++, shift += r)
                {
                    for (int z = 0; z < contador.Length; z++)
                    {
                        contador[z] = 0;
                    }
                    for (int i = 0; i < arreglo.Length; i++)
                    {
                        contador[(arreglo[i] >> shift) & mascara]++;
                    }
                    preferente[0] = 0;
                    for (int i = 1; i < contador.Length; i++)
                    {
                        preferente[i] = preferente[i - 1] + contador[i - 1];
                    }
                    for (int i = 0; i < arreglo.Length; i++)
                    {
                        t[preferente[(arreglo[i] >> shift) & mascara]++] = arreglo[i];
                    }
                    t.CopyTo(arreglo,0);
                }
                Console.WriteLine("Datos ordenados  Datos desordenados");
                for (int a = 0; a < arreglo.Length; a++)
                {
                    Console.WriteLine("\t"+arreglo[a]+ "\t\t"+fal[a] );

                }
                Console.ReadKey();
        }
    }
}
