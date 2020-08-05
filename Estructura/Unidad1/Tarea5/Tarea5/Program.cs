using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Suma la primera y ssegunda mitad de un vector y compara si son iguales
            int[] lista = new int[30];
            int r,sum1=0,sum2=0;
            Random aleatorio = new Random();
           
            //Asignacion de numeros
            for (r = 0; r < 30;r++ )
            {
                lista[r] = aleatorio.Next(1,50);
            }

            for (r = 0; r < 30; r++)
            {
                Console.WriteLine(lista[r]);
            }

                //Suma de la primera mitad
                for (r = 0; r < 16; r++)
                {
                    sum1 = sum1 + lista[r];
                }

            Console.WriteLine("Suma primera mitad: {0}",sum1);

            //Suma segunda mitad
            for (r = 16; r < 30; r++)
            {
                sum2 = sum2 + lista[r];
            }

            Console.WriteLine("Suma segunda mitad: {0}",sum2);

            if (sum1 == sum2)
            {
                Console.WriteLine("Las dos sumas es {0} = {1}", sum1, sum2);
            }
            else
            {
                Console.WriteLine("La suma es diferente: {0} != {1}", sum1,sum2);
            }
            Console.ReadKey();

        }
    }
}
