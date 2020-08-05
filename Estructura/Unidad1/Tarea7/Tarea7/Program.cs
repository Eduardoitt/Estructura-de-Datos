using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Perimetro y area de un rectangulo
            float largo, ancho, area, perimetro;

            Console.WriteLine("Largo:");
            largo = float.Parse(Console.ReadLine());

            Console.WriteLine("Ancho:");
            ancho = float.Parse(Console.ReadLine());

            area = largo * ancho;
            perimetro=(2*largo)+(2*ancho);

            Console.WriteLine("El area es: {0}", area);
            Console.WriteLine("El perimetro es: {0} ",perimetro);
            Console.ReadKey();
        }
    }
}
