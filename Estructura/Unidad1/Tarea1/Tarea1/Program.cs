using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escobedo Díaz Jesús Eduardo 16210519
            //Unidad 1. Introduccion a las estructuras de datos
            //Programa que separa un cadena string
            char[] Delimitar = { ' ', ',', '.', ':', '\t' };

            string Datos = "Nombre completo, Edad y Carrera";
            System.Console.WriteLine("Introducir: '{0}'", Datos);
            Datos = Console.ReadLine();

            string[] palabraseparada = Datos.Split(Delimitar);
            System.Console.WriteLine("Datos: ", palabraseparada.Length);

            foreach (string s in palabraseparada)
            {
                System.Console.WriteLine(s);
            }


            System.Console.ReadKey();
        }
    }
}
