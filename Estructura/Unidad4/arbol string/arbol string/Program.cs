using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbol_string
{    
    class NodoT
    {
        public NodoT NodoIzquierdo;
        public string Informacion;
        public NodoT NodoDerecho;
        //Constructor
        public NodoT()
        {
            this.NodoIzquierdo = null;
            this.Informacion = "";
            this.NodoDerecho = null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Estructura de Datos
            // Unidad 4 Estructuras no lineales
            // 16210519 Escobedo Diaz Jesus Eduardo
            // Programa 2 arbol binario string
            Console.Title = "ARBOLES BINARIOS:By MC Claudia Negrete Sanchez";
            int Opcion = 0;
            NodoT Raiz = null;
            string Dato;
            do
            {
                Opcion = Menu(); //Llamada a la funcion menu
                switch (Opcion)
                {
                    case 1: Console.Write("Valor del Nuevo Nodo (Nombre): ");
                        Dato = Console.ReadLine();
                        if (Raiz == null)
                        {
                            NodoT NuevoNodo = new NodoT();
                            NuevoNodo.Informacion = Dato;
                            Raiz = NuevoNodo;
                        }
                        else
                        {
                            insertar(Raiz, Dato);
                        }
                        Console.Clear();
                        break;
                    //Recorrido en Pre Orden del Arbol
                    case 2: RecorridoPreorden(Raiz);
                        Console.WriteLine("Fin del Recorrido,...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    //Recorrido en Post Orden del Arbol
                    case 3: RecorridoPostorden(Raiz);
                        Console.WriteLine("Fin del Recorrido,...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    //Recorrido en In Orden del Arbol
                    case 4: RecorridoInorden(Raiz);
                        Console.WriteLine("Fin del Recorrido,...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5: Console.Write("Teclee el Dato a Buscar: ");
                        Dato = Console.ReadLine();
                        if (Raiz != null)
                        {
                            BuscarNodo(Raiz, Dato);
                        }
                        else
                        {
                            Console.WriteLine("ERROR, Arbol Vacio....");
                        }
                        Console.Clear();
                        break;
                    case 6: Console.Write("Teclee el Dato a Eliminar: ");
                        Dato = Console.ReadLine();
                        if (Raiz != null)
                        {
                            EliminarNodo(ref Raiz, Dato);
                        }
                        else
                        {
                            Console.WriteLine("ERROR, Arbol Vacio....");
                        }
                        Console.Clear();
                        break;
                    case 7: Finalizar();
                        break;
                }
            } while (Opcion != 7);

        }
        static int Menu()
        {
            int Resultado = 0;
            do
            {
                Console.WriteLine("MENU DE ARBOLES");
                Console.WriteLine("");
                Console.WriteLine("1.- Registrar un Nuevo Nodo");
                Console.WriteLine("2.- Recorrido en Pre-orden");
                Console.WriteLine("3.- Recorrido en Post-orden");
                Console.WriteLine("4.- Recorrido en In-orden");
                Console.WriteLine("5.- Buscar un Nodo");
                Console.WriteLine("6.- Eliminar un Nodo");
                Console.WriteLine("7.- Finalizar el Programa");
                Console.WriteLine("");
                Console.Write("Teclee la Opcion Deseada: ");
                Resultado = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                if (Resultado < 1 || Resultado > 7)
                {
                    Console.WriteLine("ERROR, Opcion Invalida....");
                    Console.ReadLine();
                    Console.WriteLine("");
                }
                Console.Clear();
            } while (Resultado < 1 || Resultado > 7);
            return Resultado;
        }

        static void insertar(NodoT Raiz, string Dato)
        {
            if (Dato.CompareTo(Raiz.Informacion) < 0)
            {
                if (Raiz.NodoIzquierdo == null)
                {
                    NodoT NuevoNodo = new NodoT();
                    NuevoNodo.Informacion = Dato;
                    Raiz.NodoIzquierdo = NuevoNodo;
                }
                else
                {
                    insertar(Raiz.NodoIzquierdo, Dato);//Llamada recursiva
                }
            }
            else
            {
                if (Dato.CompareTo(Raiz.Informacion) > 0)
                {
                    if (Raiz.NodoDerecho == null)
                    {
                        NodoT NuevoNodo = new NodoT();
                        NuevoNodo.Informacion = Dato;
                        Raiz.NodoDerecho = NuevoNodo;
                    }
                    else
                    {
                        insertar(Raiz.NodoDerecho, Dato);
                    }
                }
                else
                {
                    //El Nodo existe en el Arbol
                    Console.WriteLine("Nodo Existente, Imposible Insertar...");
                }
            }

        }

        //Metodo de recorrido en Pre-Orden
        static void RecorridoPreorden(NodoT Raiz)
        {
            if (Raiz != null)
            {
                Console.WriteLine("valor ,{0} ", Raiz.Informacion);
                RecorridoPreorden(Raiz.NodoIzquierdo); //Llamada recursiva
                RecorridoPreorden(Raiz.NodoDerecho); //Llamada recursiva
            }
        }

        //Metodo de recorrido en In-Orden
        static void RecorridoInorden(NodoT Raiz)
        {
            if (Raiz != null)
            {
                RecorridoInorden(Raiz.NodoIzquierdo);//Llamada recursiva
                Console.WriteLine("valor, {0}", Raiz.Informacion);
                RecorridoInorden(Raiz.NodoDerecho); //Llamada recursiva
            }
        }

        //Metodo de recorrido en Post-Orden
        static void RecorridoPostorden(NodoT Raiz)
        {
            if (Raiz != null)
            {
                RecorridoPostorden(Raiz.NodoIzquierdo);//Llamada recursiva
                RecorridoPostorden(Raiz.NodoDerecho);//Llamada recursiva
                Console.WriteLine("valor {0} ", Raiz.Informacion);
            }
        }

        //Metodo de Buscar un nodo
        static void BuscarNodo(NodoT Raiz, string Dato)
        {
            if (Dato.CompareTo(Raiz.Informacion) < 0)
            {
                //Buscar por el Sub-Arbol izquierdo
                if (Raiz.NodoIzquierdo == null)
                {
                    Console.WriteLine("ERROR, No se encuentra el Nodo...");
                }
                else
                {
                    BuscarNodo(Raiz.NodoIzquierdo, Dato);//Llamada recursiva
                }
            }
            else
            {
                if (Dato.CompareTo(Raiz.Informacion) > 0)
                {
                    //Buscar por el Sub-Arbol derecho
                    if (Raiz.NodoDerecho == null)
                    {
                        Console.WriteLine("ERROR, No se encuentra el Nodo...");
                    }
                    else
                    {
                        BuscarNodo(Raiz.NodoDerecho, Dato);//Llamada recursiva
                    }
                }
                else
                {
                    //El nodo se encontro
                    Console.WriteLine("Nodo Localizado en el Arbol...");
                    Console.ReadLine();
                }
            }
        }

        //Metodo de Eliminar
        static void EliminarNodo(ref NodoT Raiz, string Dato)
        {
            if (Raiz != null)
            {
                if (Dato.CompareTo(Raiz.Informacion) < 0)
                {
                    EliminarNodo(ref Raiz.NodoIzquierdo, Dato);//Llamada recursiva
                }
                else
                {
                    if (Dato.CompareTo(Raiz.Informacion) > 0)
                    {
                        EliminarNodo(ref Raiz.NodoDerecho, Dato);//recursivo
                    }
                    else
                    {
                        //Si lo Encontro
                        NodoT NodoEliminar = Raiz;
                        if (NodoEliminar.NodoDerecho == null)
                        {
                            Raiz = NodoEliminar.NodoIzquierdo;
                        }
                        else
                        {
                            if (NodoEliminar.NodoIzquierdo == null)
                            {
                                Raiz = NodoEliminar.NodoDerecho;
                            }
                            else
                            {
                                NodoT AuxiliarNodo = null;
                                NodoT Auxiliar = Raiz.NodoIzquierdo;
                                bool Bandera = false;
                                while (Auxiliar.NodoDerecho != null)
                                {
                                    AuxiliarNodo = Auxiliar;
                                    Auxiliar = Auxiliar.NodoDerecho;
                                    Bandera = true;
                                }
                                Raiz.Informacion = Auxiliar.Informacion;
                                NodoEliminar = Auxiliar;
                                if (Bandera == true)
                                {
                                    AuxiliarNodo.NodoDerecho = Auxiliar.NodoIzquierdo;
                                }
                                else
                                {
                                    Raiz.NodoIzquierdo = Auxiliar.NodoIzquierdo;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("ERROR, EL Nodo no se Encuentra en el Arbol...");
            }
        }

        //Metodo de Finalizacion
        static void Finalizar()
        {
            Console.WriteLine("Fin del Arbol Binario, press any key to continue,...");
            Console.ReadKey();
        }
    }

}
