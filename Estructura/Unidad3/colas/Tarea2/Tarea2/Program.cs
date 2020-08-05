using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
        {
            // Estructura de Datos
            // Unidad 3 Estructuras lineales
            // 16210519 Escobedo Diaz Jesus Eduardo
            // Programa 1
            int[] cola = new int[50];
            int valor,F=0,I=0,Auxi,prom,sum=0;
            string insertar,elimina;
            do
            {
                Console.Write("Ingresar calificacion : ");
                valor=int.Parse(Console.ReadLine());
                if(F>=50)
                {
                    Console.WriteLine("Cola llena");
                }
                else
                {
                    F=F+1;
                    cola[F]=valor;
                    if(F>50)
                    {
                        F=0;
                    }
                }
                if(I==-1)
                {
                    I=0;
                }
                Console.Write("Desea otra insercion si/no: ");
                insertar=Console.ReadLine();
            }while(insertar!="no");
            for (int i = 0; i <= F; i++)
            {
                sum = sum + cola[i];
            }
            prom = sum / F;
            Console.WriteLine("El promedio es " + prom);

            Console.WriteLine("Calificaciones ingresadas");
            for (int i = 0; i <= F; i++)
            {
                if(cola[i]!=0)
                Console.WriteLine(" Calificacion {0}", cola[i]);
            }
            do
            {
                if (I == -1)
                {
                    Console.WriteLine("Cola vacia");
                }
                else
                {
                    Auxi = cola[I];
                    if (Auxi != 0)
                    { Console.WriteLine("Se ha eliminado " + Auxi); }
                    cola[I] = 0;
                    I = I + 1;
                    if (I == F)
                    {
                        Auxi = cola[I];
                        cola[I] = 0;
                        I = -1; F = -1;
                    }
                }
                Console.WriteLine("Desea realizar una eliminacion: si/no");
                elimina = Console.ReadLine();
            } while (elimina != "no");
            Console.ReadKey();
        }
            int I=0, F=0;
            string Auxi=null;
            string[] cola = new string[500];
            Insercion(cola, F, I);
            //Mostrar(cola, F);
            //Eliminar(cola, F, I,Auxi);
        }
        static void Insercion(string[] cola, int F, int I)
        {
            string dato,otro;
            do
            {
                Console.Write("Ingresar nombre: ");
                dato = Console.ReadLine();
                if (F >= 500)
                {
                    Console.WriteLine("Cola llena");
                }
                else
                {
                    F = F + 1;
                    cola[F] = dato;
                    if (F > 500)
                    {
                        F = 0;
                    }
                }
                if (I == -1)
                {
                    I = 0;
                }
                Console.WriteLine("Desa otra insercion si/no");
                otro = Console.ReadLine();
            }
            while (otro != "no");
            Mostrar(cola, F);
        }
        static void Mostrar(string[] cola, int F)
        {
            int I = 1;
            string Auxi = null;
            Console.WriteLine("Nombres en la cola");
            for (int i = 0; i <= F; i++)
            {
                Console.WriteLine(cola[i]);
            }
            Eliminar(cola, F, I, Auxi);
        }
        static void Eliminar(string[] cola, int F, int I, string Auxi)
        {
            string otro;
            do
            {
                if(I==-1)
                {
                    Console.WriteLine("Cola vacia");
                }
                else
                {
                    Auxi=cola[I];
                    if (Auxi != "")
                    { Console.WriteLine("Se a eliminado " + Auxi); }
                    cola[I]=" ";
                    I=I+1;
                    if(I==F)
                    {
                        Auxi=cola[I];
                        cola[I]="";
                        I=-1; F=-1;
                    }
                }
                Console.WriteLine("Desea realizar una eliminarcion si/no");
                otro=Console.ReadLine();
            }while(otro!="no");
        }
    }
}
