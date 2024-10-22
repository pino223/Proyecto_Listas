using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\nMenú de opciones:");
                Console.WriteLine("1. Insertar nodo");
                Console.WriteLine("2. Imprimir tamaño de la lista");
                Console.WriteLine("3. Buscar nodo por posición");
                Console.WriteLine("4. Borrar nodo por posición");
                Console.WriteLine("5. Modificar nodo por posición");
                Console.WriteLine("6. Buscar nodo por valor");
                Console.WriteLine("7. Imprimir lista");
                Console.WriteLine("8. Salir");

                Console.Write("Selecciona una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Teclear valor del nodo: ");
                        int valor = Convert.ToInt32(Console.ReadLine());
                        lista.Teclear_Nodo(valor);
                        break;

                    case 2:
                        lista.Imprimir_Tamaño();
                        break;

                    case 3:
                        Console.Write("Dame la posición del nodo a buscar: ");
                        int posicionBuscar = Convert.ToInt32(Console.ReadLine());
                        lista.Buscar_Nodo(posicionBuscar);
                        break;

                    case 4:
                        Console.Write("Dame la posición del nodo a borrar: ");
                        int posicionBorrar = Convert.ToInt32(Console.ReadLine());
                        lista.Borrar_Nodo(posicionBorrar);
                        break;

                    case 5:
                        Console.Write("Dame la posición del nodo a modificar: ");
                        int posicionModificar = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Dame el nuevo valor: ");
                        int nuevoValor = Convert.ToInt32(Console.ReadLine());
                        lista.Modificar_Nodo(posicionModificar, nuevoValor);
                        break;

                    case 6:
                        Console.Write("Dame el valor del nodo a buscar: ");
                        int valorBuscar = Convert.ToInt32(Console.ReadLine());
                        lista.Buscar_Valor(valorBuscar);
                        break;
                    case 7:
                        lista.Imprimir_Lista();
                        break;
                    case 8:
                        continuar = false;
                        Console.WriteLine("Saliendo del programa");
                        break;

                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }


            }
        }
    }
}
