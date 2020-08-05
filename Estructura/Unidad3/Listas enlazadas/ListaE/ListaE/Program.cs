using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaE
{
    class Program
    {
        public class Persona
        {
            int boleto;
            string nombre, sexo;
            public Persona(){}
            public Persona(int boleto, string nombre, string sexo)
            {
                this.boleto = boleto;
                this.nombre = nombre;
                this.sexo = sexo;
            }
            public int Boleto
            {
                get { return boleto; }
            }
            public string Nombre
            {
                get { return nombre; }
            }
            public string Sexo
            {
                get { return sexo; }
            }
            public void Mostrar()
            {
                Console.WriteLine("Ingrese boleto");
                boleto = int.Parse(Console.ReadLine());
                Console.WriteLine("Nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("Sexo");
                sexo = Console.ReadLine();
            }

        }
        public class Vagon
        {
            int codigo;
            Persona first, last;
            public Vagon siguiente;
            public Vagon(int codigo)
            {
                this.codigo = codigo;
                first = last = null;
                siguiente = null;
            }
            public int Codigo
            {
                get { return codigo; }
            }
            public void Insertar(Persona nuevo)
            {
                if (first == null)
                {
                    first = nuevo;
                }
                else
                {
                    last.siguiente = nuevo;
                    last = nuevo;
                }
            }
            public void Mostrar()
            {
                if (first != null)
                {
                    Persona actual = first;
                    while (actual != null)
                    {
                        actual.Mostrar();
                        actual = actual.siguiente;
                    }
                }
                else
                {
                    Console.WriteLine("El vagon esta vacio", codigo);
                }
            }
            public void MostrarVagon()
            {
                Console.WriteLine("Vagon", codigo);
            }
            public Persona Buscar(int n)
            {
                Persona actual = first;
                while (actual != null)
                {
                    if (actual.Boleto == n)
                    {
                        return actual;
                        actual = actual.siguiente;
                    }
                }
                return null;
            }
            public void Eliminar(int n)
            {
                if (first != null)
                {
                    Persona actual, padre;
                    padre = BuscarPadre(n);
                }
                if(padre==last)
                {
                    Console.WriteLine("Pasajero no encontrado");
                }
                if (padre == null)
                {
                    actual = first;
                    first = first.siguiente;
                    padre = first;
                }
                else
                {
                    actual = padre.siguiente;
                    padre.siguiente = actual.siuiente;
                }
                actual = null;
                if (padre == null || padre.siguiente == null)
                {
                    last = padre;
                    Console.WriteLine("Pasajero bajado del vagon");
                }
                else
                {
                    Console.WriteLine("No existe ningun pasajero");
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
