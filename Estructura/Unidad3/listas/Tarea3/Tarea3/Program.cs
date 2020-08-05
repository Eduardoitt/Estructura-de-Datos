using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Tarea3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estructura de Datos
            // Unidad 3 Estructuras lineales
            // 16210519 Escobedo Diaz Jesus Eduardo
            // Programa 3
            int[] pila = new int[40];
            string otro;
            int Top = 0, N,num=40;
            //insercion
            do
            {
                Console.WriteLine("Ingrese un sueldo");
                N = int.Parse(Console.ReadLine());
                if (Top >= num)
                {
                    Console.WriteLine("Pila llena");
                }
                else
                {
                    pila[Top] = N;
                    Top = Top + 1;
                }
                Console.WriteLine("Desea agregar otro sueldo si/no");
                otro = Console.ReadLine();
            } while (otro != "no");
            Console.WriteLine("==================================");
            Console.WriteLine("Datos que contiene la pila");
            mostrar(pila,Top,0);
            Console.WriteLine("==================================");
            Console.WriteLine("Pila ");
            imprimir(pila,Top);
            Console.WriteLine("==================================");
            Console.WriteLine("Promedio de los sueldos");
            promedio(pila,Top,0,0);
            Console.WriteLine("==================================");
            Console.WriteLine("Sueldo mayor y menor");
            mayor(pila,Top,0);
            Console.WriteLine("==================================");
            Console.WriteLine("Eliminacion de datos de la pila");
            eliminacion(pila,Top);
        }
        //Se muestran los datos de la pila
        static void mostrar(int[] pila, int Top, int i)
        {
            for (i = 0; i <= Top; i++)
            {
                if (pila[i] != 0)
                {
                    Console.WriteLine(pila[i]);
                }
            }
        }
        //Se imprimen los datos en forma de pila
        static void imprimir(int[] pila, int Top)
        {
            for (int i = Top - 1; i > -1; i--)
            {
                if (Top != 0)
                {
                    Console.WriteLine("{0}", pila[i]);
                }
            }
        }
        //Premedio de los sueldos
        static void promedio(int[] pila, int Top, int i,int sum)
        {
            int pro;
            for (i = 0; i <= Top; i++)
            {
                sum=sum+pila[i];
            }
            pro = sum / Top;
            Console.WriteLine("El promedio de los sueldo es "+pro);
        }
        //Determina cual es el sueldo mayor y menor
        static void mayor(int [] pila,int Top,int i)
        {
            int tmayor=0,tmenor=0;
            tmenor = pila[0];
            do
            {
                if (pila[i] != 0)
                {
                    if (pila[i] > tmayor)
                    {
                        tmayor = pila[i];
                    }
                    else
                    {
                        if (tmenor > pila[i])
                        {
                            tmenor = pila[i];
                        }
                    }
                }
                i = i + 1;
            } while (i <= Top);
            Console.WriteLine("Sueldo mayor {0}",tmayor);
            Console.WriteLine("Sueldo menor {0}",tmenor);
        }
        //Eliminacion de datos 
        /*static void eliminacion(int[] pila, int Top)
        {
            int [] auxi=new int [40];
            string otro;
            do
            {
                if(Top<=0)
                {
                    Console.WriteLine("Pila vacia");
                }
                else
                {
                    Top=pila[Top];
                    auxi[Top] = 0;
                    Top=Top+1;
                }
                Console.WriteLine("Desea eliminar otro elemento si/no");
                otro=Console.ReadLine();
            }while(otro!="no");
            Console.ReadKey();
        }*/
        static void eliminacion(int [] pila, int Top)
        {
            string otro,ot; int i=0;
            do
            {
                Console.WriteLine("Desea eliminar un elemento si/no");
                ot = Console.ReadLine();
                if (ot == "si")
                {
                    Console.WriteLine("Se elimino {0}",pila[Top-1]);
                    pila[i] = 0;
                }
                Console.WriteLine("Desea liminar otro elemento si/no");
                otro = Console.ReadLine();
                Top = Top - 1;
                i=i+1;
            }while(otro!="no");
        }
    }
}
