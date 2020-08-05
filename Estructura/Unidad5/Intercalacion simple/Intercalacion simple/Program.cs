using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intercalacion_simple
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estructura de Datos
            // Unidad 5 Metodos de ordenamiento
            // 16210519 Escobedo Diaz Jesus Eduardo
            // Ordenamiento intercalacion simple
            int N = 50, auxi, i;
            bool bandera = false;
            int[] vector = new int[N];
            Random ale = new Random(80);
            for (int x = 0; x < N; x++)
            {
                vector[x] = ale.Next(1,80);  
            }
            Console.WriteLine("Impresion datos");
            for (int h = 0; h < N; h++)
            {
                Console.WriteLine(vector[h]);
            }
                Console.WriteLine("");
            for (int k = 1; k < N; k++)
            {
                auxi = vector[k];
                i = k - 1;
                bandera = false;
                while (i >= 0 && !bandera)
                {
                    if (auxi < vector[i])
                    {
                        vector[i + 1] = vector[i];
                        i--;
                    }
                    else
                    {
                        bandera = true;
                    }
                }
                vector[i + 1] = auxi;
            }
            Console.WriteLine("Datos ordenados");
            for (int r = 0; r <N; r++)
            {
                Console.WriteLine(vector[r]);
            }
            Console.ReadKey();
        }
    }
}
