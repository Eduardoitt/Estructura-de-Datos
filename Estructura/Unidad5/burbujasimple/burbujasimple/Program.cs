using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burbujasimple
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estructura de Datos
            // Unidad 5 Metodos de ordenamiento
            // 16210519 Escobedo Diaz Jesus Eduardo
            // Programa 1 burbuja siemple
            int max=30,Temp;
            int [] vector = new int [max];
            Console.WriteLine("Capturar 30 calificaciones");
            for(int i=0; i<max;i++)
            {
                vector[i]=int.Parse(Console.ReadLine());
            }
            //Ordenamiento descendente mayor a menor
            for(int z=1;z<max;z++)
            {
                for(int v=0;v<max-1;v++)
                {
                    if(vector[v]<vector[v+1])
                    {
                        Temp=vector[v];
                        vector[v]=vector[v+1];
                        vector[v+1]=Temp;
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Calificaciones de forma descendente");
            for(int i=0;i<max;i++)
            {
                Console.WriteLine(vector[i] );
            }
            Console.ReadKey();
        }
    }
}
