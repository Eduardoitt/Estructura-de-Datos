using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla_de_multiplicar
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            // Estructura de datos
            // Unidad 2 Recursividad
            // 16210519 Escobedo Díaz Jesús Eduardo
            // Problema 3

            int Tabla;
            //Pide el numero de la tabla 
            Console.WriteLine("De la tabla de multiplicar que desee:");
            Tabla = int.Parse(Console.ReadLine());
            //Llama al metodo y envia los parametros
            Multiplica(Tabla,1);

            
            

        }

        static void Multiplica(int Tabla,int r)
            { int i,Resultado;
            i=r;
           //Condicion
                if(i<13)
                {
                    Resultado=Tabla*r;
                    //Despliegue de la tabla
                    Console.WriteLine(Tabla+ "x" + i+ "=" + Resultado);
                    
                    r = r + 1;
                    Multiplica(Tabla, r);
                    Console.ReadKey();
                }
                
            }
    }
}
