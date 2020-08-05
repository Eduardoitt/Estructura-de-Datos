using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_binaria
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estructura de Datos
            // Unidad 6 Metodos de busqueda
            // 16210519 Escobedo Diaz Jesus Eduardo
            // Programa 1 busqueda binaria

            //30 calificaciones, promedio
            //busqueda binaria, si se encuentra encender bandera
            //Mostrar calificacion y posicion, sino un mensaje de error 
            //desplegar lista

            Random ale = new Random();
            int n=30,prom=0;
            int tam=n, mitad=0, control=0, pos=0,Dato;
            int [] cal=new int [n];
            for (int x = 0; x < n; x++)
            {
                cal[x] = ale.Next(0,11);
                prom = prom + cal[x];
            }
            prom = prom / n;
            Console.WriteLine("Promedio :"+prom);
            for (int i = 1; i < n; i++)
            {
                for (int r = 0; r < n - 1; r++)
                {
                    if (cal[r] > cal[r + 1])
                    {
                        int Temp = cal[r];
                        cal[r] = cal[r + 1];
                        cal[r + 1] = Temp;
                    }
                }
            }
            //Busqueda
            Console.Write("Ingrese la calificion que desea buscar: ");
            Dato = int.Parse(Console.ReadLine());
            while (pos <= tam && control == 0)
            {
                mitad = (pos + tam) / 2;
                if (cal[mitad] == Dato)
                {
                    control = 1;
                    //posicion = posicion + 1;
                }
                if (cal[mitad] > Dato)
                {
                    tam = mitad - 1;
                }
                else
                {
                    pos = mitad + 1;
                }
                
            }
            if (control == 1)
            {
                Console.WriteLine("Calificacion encontrada");
                Console.WriteLine("Posicion : {0}",mitad);
            }
            else
            {
                Console.WriteLine("No se encontro la calificacion");
            }
            for (int f = 0; f < n; f++)
            {
                Console.WriteLine((f+1)+") "+cal[f]);
            }
            Console.ReadKey();
        }
    }
}
