using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenamientoshell
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estructura de Datos
            // Unidad 5 Metodos de ordenamiento
            // 16210519 Escobedo Diaz Jesus Eduardo
            // Programa 1 ordenamiento shell
            //odenamiento por metodo shell ascendente
            int n = 12, cal = 0, promedio;
            int sw = n, auxi = 0, e = 0, salto = n / 2;
            int[] califiaciones = new int[n];
            Console.WriteLine("Ingresar sus calificaciones de las materias cursasdas(materias curzando actualmente)");
            Console.WriteLine("Calificaciones del primer semestre");
            for (int r = 0; r < n; r++)
            {
                if (r == 6)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Calificaciones de segundo semestre");
                    Console.WriteLine("");
                }
                califiaciones[r] = int.Parse(Console.ReadLine());
                cal = cal + califiaciones[r];
            }

            promedio = cal / n;

            Console.WriteLine("");
            Console.WriteLine("Promedio general");
            Console.WriteLine(promedio);
            Console.WriteLine("");
            //ordenado ascendente
            Console.WriteLine("");
            Console.WriteLine("Calificaciones ordenadas de forma ascendente");
            Console.WriteLine("");
            while (salto > 0)
            {
                sw = 1;
                while (sw != 0)
                {
                    sw = 0;
                    e = 1;
                    while (e <= (n - salto))
                    {
                        if (califiaciones[e - 1] > califiaciones[e - 1 + salto])
                        {
                            auxi = califiaciones[e - 1 + salto];
                            califiaciones[e - 1 + salto] = califiaciones[e - 1];
                            califiaciones[e - 1] = auxi;
                            sw = 1;
                        }
                        e = e + 1;
                    }
                }
                salto = salto / 2;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(califiaciones[i]);
            }
            Console.ReadKey();
        }
    }
}
