using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estructura de Datos
            // Unidad 2 Recursividad
            // 16210519 Escobedo Díaz Jeús Eduardo
            // Programa 4

            string [] nombres= new string [20];
            int i=0;
            Console.WriteLine("Ingresar 20 nombres:");
            for(i=0;i<20;i++)
            {
                nombres[i] = Console.ReadLine();
            }

            Imprimir(nombres,19);
            
            
        }

        static void Imprimir(string [] nombres,int r)
        {
            Console.WriteLine("Lista de nombres inversas ");   
            if (r >-1)
            {
                Console.WriteLine("{0}",nombres[r]);
                r = r - 1;
                Imprimir(nombres, r);
                
            }
            
            Console.ReadKey();
        }
        
    }
}
