using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estructura de Datos
            // Unidad 2 Recursividad
            // 16210519 Escobedo Díaz Jeús Eduardo
            // Programa 5

            //Caracol sale de un pozo
            double pozo, sube, desciende;
            pozo = 7;
            sube = 2;
            desciende = 0.005;
            //int dias = 1;
            Console.WriteLine("Profundidad del pozo: {0} metros", pozo);
            Console.WriteLine("Sube por dia: {0} metros" ,sube);
            Console.WriteLine("Desciende por la noche {0} metros",desciende);
            Calculo(pozo, sube, desciende,1);
        }
        static void Calculo(double pozo, double sube, double desciende, int dias)
        {
            
            
                if (pozo >= 0)
                {
          
                    dias = dias + 1;
                    
                    pozo = pozo - (sube - desciende);
                    if (pozo <= 0)
                    {
                        Console.WriteLine("El caracol tardo en salir: {0} ", dias + " dias");
                    }
                    
                    Calculo(pozo, sube, desciende,dias);
                    
                    

                }
                
                Console.ReadKey();
           
        }
    }
}
