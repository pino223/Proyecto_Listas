using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Listas
{
    internal class Lista
    {
        Nodo inicio;
        public Lista()
        {
            inicio = null;
        }
        //Teclear nodo a insertar
        //Valor del nodo:
        public void Teclear_Nodo(int num)
        {

            Nodo nuevoNodo = new Nodo(num);
            if (inicio == null)
            {
                inicio = nuevoNodo;
            }
            else
            {
                Nodo act = inicio;   //act apunta al primer nodo de la lista
                while (act.sig != null)
                {
                    act = act.sig;
                }
                act.sig = nuevoNodo;
            }
            Console.WriteLine($"Nodo con valor {num} insertado.");
        }
        //por ejemplo
        //la lista tiene 7 nodos
        //la lista esta vacia si no hay nada
        public void Imprimir_Tamaño()
        {
            int contador = 0;
            Nodo act = inicio;
            while (act != null) //recorre toda la lista hasta llegar al ultimo nodo
            {
                contador++;
                act = act.sig;
            }
            if (contador == 0)   //si la lista sigue en 0 pues no hay nada XD
            {
                Console.WriteLine("La lista está vacía.");
            }
            else     //si encuentra mas de 1 pues te dice la cantidad de nodos que tiene
            {
                Console.WriteLine($"La lista tiene {contador} nodos.");
            }
        }
        //Dame la posicion:
        //El valor es:
        public void Buscar_Nodo(int posicionBuscar)
        {
            Nodo act = inicio;
            int contador = 0;   //cuando yo le de la posicion buscara en un bucle
            while (act != null && contador < posicionBuscar)   //si el contador es menor a la posicion dada
            {
                act = act.sig;
                contador++;
            }   

            if (act == null) 
            {
                Console.WriteLine("Posición no encontrada.");
            }
            else //te busca la posicion y te da el valor al ser encontrado
            {
                Console.WriteLine($"El nodo en la posición {posicionBuscar} tiene el valor {act.valor}.");
            }
        }
        //Dame la posicion:
        //Nodo eliminado o no encontrado
        public void Borrar_Nodo(int posicionBorrar)
        {
            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            if (posicionBorrar == 0)
            {
                inicio = inicio.sig;  //actualiza el inicio y se pasa al siguiente que es el segundo
                Console.WriteLine("Nodo en la posición 1 eliminado.");
                return;
            }

            Nodo act = inicio;
            for (int i = 0; act != null && i < posicionBorrar - 1; i++) //busca un nodo anterior al que vamos a eliminar
            {
                act = act.sig;
            }

            if (act == null || act.sig == null) 
            {
                Console.WriteLine("Posición no encontrada.");
                return;
            }

            Nodo siguiente = act.sig.sig; //siguiente apunta al nodo que está después del nodo que se va a eliminar
            act.sig = siguiente;  //se actualiza el actual para que apunte al siguiente
            Console.WriteLine($"Nodo en la posición {posicionBorrar} eliminado.");
        }
        //Dame la posicion:
        //Dame nuevo valor:
        //nodo modificado exitosamente
        //si no se encontro el mensaje sera no modificado
        public void Modificar_Nodo(int posicionModificar, int nuevoValor)
        {
            Nodo act = inicio;
            int contador = 0;
            while (act != null && contador < posicionModificar) //busca desde 0 la posicion que le di
            {
                act = act.sig;
                contador++;
            }// se acaba cuando llega a la posicion que di

            if (act == null)
            {
                Console.WriteLine("Posición no encontrada.");
            }
            else
            {
                act.valor = nuevoValor; //se catualiza con el nuevo valor del nodo
                Console.WriteLine($"Nodo en la posición {posicionModificar} modificado exitosamente al valor {nuevoValor}.");
            }
        }
        //Dame el valor:
        //El nodo esta en la posicion:
        //si no lo encuentra se mostrara no se encuentra la posicion
        public void Buscar_Valor(int valorBuscar)
        {
            Nodo act = inicio;
            int posicion = 0;
            while (act != null)
            {
                if (act.valor == valorBuscar)
                {
                    Console.WriteLine($"El valor {valorBuscar} se encuentra en la posición {posicion}.");
                    return;
                }
                act = act.sig;  //si no es encontrado se pasa al siguiente nodo y se suma la posicion para ser encontrado
                posicion++;
            }
            Console.WriteLine("El valor no se encuentra en la lista.");
        }
        public void Imprimir_Lista()
        {
            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo act = inicio;
            Console.WriteLine("Valores de la lista:");
            while (act != null)
            {
                Console.Write($"{act.valor} ");
                act = act.sig;
            }
            Console.WriteLine(); 
        }
    }
}
