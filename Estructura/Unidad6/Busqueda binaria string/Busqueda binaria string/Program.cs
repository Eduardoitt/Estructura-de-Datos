using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_binaria_string
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estructura de Datos
            // Unidad 6 Metodos de busqueda
            // 16210519 Escobedo Diaz Jesus Eduardo
            // Programa 2 busqueda binaria string
            int n=30;
            int tam = n, mitad = 0, control = 0, pos = 0;
            string Dato;
            string [] vec=new string[n];
            Console.WriteLine("Ingresar 30 ciudades:");
             for (int x = 0; x < n; x++)
            {
                vec[x] = Console.ReadLine();
            }
            for (int i = 1; i < n; i++)
            {
                for (int r = 0; r < n - 1; r++)
                {
                    if (string.Compare(vec[r], vec[r + 1]) > 0)
                    {
                        string Temp = vec[r];
                        vec[r] = vec[r + 1];
                        vec[r + 1] = Temp;
                    }
                }
            }
            //Busqueda
            Console.Write("Ingrese la ciudad que desea buscar: ");
            Dato = Console.ReadLine();
            while (pos <= tam && control == 0)
            {
                mitad = (pos + tam) / 2;
                if (vec[mitad] == Dato)
                {
                    control = 1;
                    //posicion = posicion + 1;
                }
                if (vec[mitad].CompareTo(Dato) > 0)
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
                Console.WriteLine("Posicion : {0}",(mitad+1));
            }
            else
            {
                Console.WriteLine("No se encontro la calificacion");
            }
            for (int f = 0; f < n; f++)
            {
                Console.WriteLine((f+1)+") "+vec[f]);
            }
            Console.ReadKey();
        }   
    } 
}

