using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            //35 valores aleatorios
            int[] nums = new int[40];
            Random ale = new Random(35);
            Console.WriteLine("Metodo de Merge Sort");
            Console.WriteLine("Cuantos longitud del vector:");
            string linea;
            Console.ReadLine();
            int cant;
            cant = int.Parse(Console.ReadLine());
            nums = new int[cant];
            for (int f = 0; f < cant; f++)
            {
                Console.WriteLine("Ingrese elemento " + (f + 1) + ": ");
                nums[f] = int.Parse(Console.ReadLine());
            }

            MergeSort(nums);
            Console.WriteLine("Vector Ordenado Ascendentemente");

            for (int i = 0; i < cant; i++)
            {
                Console.Write(nums[i] + "");
            }
            Console.ReadKey();
        }
        //Metodo portal que llama al metodo recursivo
        public static void MergeSort(int[] x)
        {
            MergeSort(x, 0, x.Length - 1);
        }
        private static void MergeSort(int[] x, int desde, int hasta)
        {
            if (desde == hasta)
            {
                return;
            }
            int mitad = desde + hasta / 2;
            MergeSort(x, desde, mitad);
            MergeSort(x, mitad + 1, hasta);
            int[] aux = Merge(x, desde, mitad, mitad + 1, hasta);
            Array.Copy(aux, 0, x, desde, aux.Length);
        }
        private static int[] Merge(int[] x, int desde1, int hasta1, int desde2, int hasta2)
        {
            int a = desde1;
            int b = desde2;
            int[] result = new int[hasta1 - desde1 + hasta2 - desde2 + 2];

            for (int i = 0; i < result.Length; i++)
            {
                if (b != x.Length)
                {
                    if (a > hasta1 && b <= hasta2)
                    {
                        result[i] = x[b];
                        b = b + 1;
                    }
                    if (b > hasta2 && a <= hasta1)
                    {
                        result[i] = x[a];
                        a = a + 1;
                    }
                    if (a <= hasta1 && b <= hasta2)
                    {
                        if (x[b] <= x[a])
                        {
                            result[i] = x[b];
                            b = b + 1;
                        }
                        else
                        {
                            result[i] = x[a];
                            a = a + 1;
                        }
                    }
                }
                else
                {
                    if (a <= hasta1)
                    {
                        result[i] = x[a];
                        a = a + 1;
                    }
                }

                return result;
            }

        }
    }
}
