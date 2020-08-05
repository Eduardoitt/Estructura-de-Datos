using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindromo
{
    
    class Program
    {
        int tam;
        static void Main(string[] args)
        {
            char []palabra=new char [50] ;
            int tam;
            bool pal;
            Console.WriteLine("Ingrese una frase");
            Console.ReadLine(palabra[50]);
            tam = palabra.Length;
            pal = palindromo(palabra,0,tam-1);
            if (pal == true)
            {
                Console.WriteLine("La palabra es palindromo");
            }
            else
            {
                Console.WriteLine("La palabra no es palindromo");
            }
        }
        public bool palindromo(char palabra,int ini ,int fin)
        {
            ini = 0;
            fin = tam - 1;
            if (ini > fin)
            {
                return true;
            }
            if (palabra[ini] == palabra[fin])
            {
                palindromo(palabra, ini + 1, fin - 1);
            }
            else
            {
                return false;
            }
        }
    }
}
