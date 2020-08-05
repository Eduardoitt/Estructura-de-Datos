using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        const int tam=0;  
        static void Main(string[] args)
        {
            char []palabra;
            string s;
            int tam;
            bool pal;
            Console.WriteLine("Ingrese una frase");
            s = Console.ReadLine();
            palabra=new char[s.Length];
            tam = palabra.Length;
            pal = palindromo(palabra, 0,tam-1);
            if (pal == true)
            {
                Console.WriteLine("La palabra es palindromo");
            }
            else
            {
                Console.WriteLine("La palabra no es palindromo");
            }
            Console.ReadKey();
        }
        public static bool palindromo(char[] palabra, int ini, int fin)
        {
            ini = 0;
            fin = tam-1 ;
            if (ini > fin)
            {
                return true;
            }
            if (palabra[ini] == palabra[fin])
            {
                return palindromo(palabra, ini + 1, fin - 1);
            }
            else
            {
                return false;
            }
            
        
        }
    }
}
