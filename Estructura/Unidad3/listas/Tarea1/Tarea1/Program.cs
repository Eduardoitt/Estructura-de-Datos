using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Tarea1
{
    class Program
    {

        static void Main(string[] args)
        {
            // Estructura de Datos
            // Unidad 3 Estructuras lineales
            // 16210519 Escobedo Diaz Jesus Eduardo
            // Programa 1
            int Num, Top=0;
            string otro;
            int[] numeros = new int[30];
            //insercion
            do
            {
                try
                {
                    Console.WriteLine("Insertar un numero");
                    Num = int.Parse(Console.ReadLine());
                    if (Top >= Num)
                    {
                        Console.WriteLine("Pila llena");
                    }
                    else
                    {
                        numeros[Top] = Num;
                        Top = Top + 1;
                    }
                }
                catch 
                {
                    Console.WriteLine("Error no respondio si desea otra insercion");
                }
                Console.WriteLine("Desea otra insercion? si/no");
                otro = Console.ReadLine();
            } while (otro != "no");
            Console.WriteLine("==================================");
            Console.WriteLine("Numeros de la pila multiplos de 5");
            Multiplo(numeros, 0, Top);
            Console.WriteLine("==================================");
            Console.WriteLine("Pila");
            imprimir(numeros,Top);
        }

        static void Multiplo(int [] numeros,int i,int Top)
          {
              //multiplo
              for (i = 0; i <= Top; i++)
              {
                  if(numeros[i]!=0)
                  {
                      if (numeros[i] % 5 == 0)
                      {
                          Console.WriteLine("{0} ", numeros[i]);
                      }
                  } 
              }
            
          }
        static void imprimir(int[] numeros, int Top)
        {
            
            for (int i = Top-1; i > -1;i-- )
            {
                if (Top != 0)
                { Console.Write("\n\t|{0}|\n\t", numeros[i]); }
            }
            Console.ReadKey();
        }
      }
    
}
