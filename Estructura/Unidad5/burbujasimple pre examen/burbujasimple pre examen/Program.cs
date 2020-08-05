using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burbujasimple_pre_examen
{
    class Program
    {
        static void Main(string[] args)
        {
            //15 numeros de forma desendente
            Random ale = new Random(50);
            int n=15;
            int [] vec=new int [n];
            for (int i = 0; i < 15;i++ )
            {
                vec[i] = ale.Next(1,50);
            }
            Console.Write("numeros ordenados de mayor a menor ");
            for (int x = 1; x < n; x++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (vec[j] < vec[j + 1])
                    {
                        int Temp = vec[j];
                        vec[j] = vec[j+1];
                        vec[j + 1] = Temp;
                    }
                }
            }
            for (int i = 0; i <vec.Length; i++)
            {
                Console.Write(vec[i]+" ");
            }
            Console.ReadKey();
        }
    }
}
