using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Da entrada a nombre y fecha de nacimiento e imprime edad en dia, mes y año
            // Crear fechas
            int dia, mes, año,d,d2;
            string nombre;

            Console.WriteLine("Nombre: ");
            nombre = Console.ReadLine();
            
            Console.WriteLine("Introducir su dia de nacimietno: ");
            dia=int.Parse(Console.ReadLine());
            
            Console.WriteLine("Introducir el mes de nacimietno en formato de numero: ");
            mes=int.Parse(Console.ReadLine());
            
            Console.WriteLine("Año denacimiento: ");
            año = int.Parse(Console.ReadLine());

            DateTime nacimiento = new DateTime(año, mes, dia);
            DateTime ahora = DateTime.Now;

            // Años
            int edadAños = ahora.Year - nacimiento.Year;
            if (ahora.Month < nacimiento.Month || (ahora.Month == nacimiento.Month && ahora.Day < nacimiento.Day))
            {
                edadAños--;
            }

            // Meses
            int edadMeses = ahora.Month - nacimiento.Month;
            if (ahora.Day < nacimiento.Day)
            { 
                edadMeses--;
            }
            if (edadMeses < 0)
            {
                edadMeses += 12;
            }
            d = DateTime.Now.Day - dia;
            d2 = Math.Abs(d);


            // Mostrar
            Console.WriteLine(nombre);
            Console.WriteLine("Usted tiene: {0} años, {1} meses y {2} dias", edadAños, edadMeses, d2);

          


            Console.ReadKey();

        }
    }
}
