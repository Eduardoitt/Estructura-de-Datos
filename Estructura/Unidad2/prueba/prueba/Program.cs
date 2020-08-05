using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercisio 2


            string pal1 = "";
            //string le = "";
            int tl= 0;
            Console.Write("Ingrese una palabra: ");
            pal1 = Console.ReadLine();
            tl = pal1.Length;
            Console.ReadKey();
            
        }
        static void palindromo(string pal1, int tl)
        {
            int i=tl-1;
            string le="";
             string pal2 = "";
            if (i >= 0)
            {
                
                le = pal1.Substring(i,1);
                pal2 = pal2 + le;              
                i = tl - 1;
                palindromo(pal1,tl);
                i = tl - 1;
            }
            if (pal1.Equals(pal2))
            {
                Console.WriteLine("Es palindromo");
            }
            else
            {
                Console.WriteLine("No es palindrmo");
            }
            Console.ReadKey();
        }

    }
}
