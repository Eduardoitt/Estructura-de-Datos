using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burbujamejorada
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estructura de Datos
            // Unidad 5 Metodos de ordenamiento
            // 16210519 Escobedo Diaz Jesus Eduardo
            // Programa 2 burbuja mejorada
            int N = 30,i=0;
            string ordenado = "no";
            string[] nombres = new string[N];
            Console.WriteLine("Ingresar 30 nombres");
            for (int x = 0; x < N; x++)
            {
                nombres[x] = Console.ReadLine();
            }
            //ordenamiento de forma ascendente
            while (i < N && ordenado == "no")
            {
                i = i + 1;
                ordenado = "si";
                for (int j = 0; j < N - i; j++)
                {
                    if (string.Compare(nombres[j], nombres[j + 1]) > 0)
                    {
                        ordenado = "no";
                        string temp = nombres[j];
                        nombres[j] = nombres[j + 1];
                        nombres[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("=====================");
            Console.WriteLine("nombres en forma ascendente");
            for (int r = 0; r < N; r++)
            {
                Console.WriteLine(nombres[r]);
            }
            Console.ReadKey();
        }
    }
}
