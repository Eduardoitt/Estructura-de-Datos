using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Captura nombres en 2 arreglos y en un tercero generarlo con los datos de los 2 arreglos anteriores
            int r;
            string[] Nom = new string[10];
            string[] Nom2 = new string[5];
            string[] Nom3 = new string[15];

            Console.WriteLine("Introducir 10 nombres: ");

            for (r = 0; r < 10; r++)
            {
                Nom[r] = Console.ReadLine();
            }
            Console.WriteLine("Introducir 5 nombre:");
            for (r = 0; r < 5; r++)
            {
                Nom2[r] = Console.ReadLine();
            }
            //Asignacion de los valores del arreglo 1 al arreglo 3
            for (r = 0; r < 10; r++)
            {
                Nom3[r] = Nom[r];
                
            }
            //Asignacion del arreglo 2 al arreglo 3
           for (r = 10; r < 15; r++)
            {
                if (r == 10)
                {
                    Nom3[r] = Nom2[0];
                }
                else
                {
                    if (r == 11)
                    {
                        Nom3[r]=Nom2[1];
                    }
                    else
                    {
                        if (r == 12)
                        {
                            Nom3[r] = Nom2[2];
                        }
                        else
                        {
                            if (r == 13)
                            {
                                Nom3[r] = Nom2[3];
                            }
                            else
                            {
                                if (r == 14)
                                { 
                                    Nom3[r]=Nom2[4];
                                }
                            }
                        }
                    }
                }

            }

            

                Console.WriteLine("Nombres de la lista 1: ");
            for (r = 0; r < 10; r++)
            {
                Console.WriteLine(Nom[r]);
            }
            Console.WriteLine("Nombres de la lista 2: ");
            for(r=0;r<5;r++)
            {
                Console.WriteLine(Nom2[r]);
            }

            Console.WriteLine("Nombres de la tercera lista generada por las 2 listas anteriores: ");
            for (r = 0; r < 15; r++)
            {
                Console.WriteLine(Nom3[r]);
            }

            Console.ReadKey();
        }
    }
}
