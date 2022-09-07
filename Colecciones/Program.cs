using System;
using System.Collections;
using System.Collections.Generic;

namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Utilización de Dictionary

            Dictionary<string, int> edades = new Dictionary<string, int>();

            // Rellenar el diccionario

            edades.Add("Juan", 18);

            edades.Add("Diandra", 35);

            edades["María"] = 25;

            edades["Antonio"] = 29;

            // Recorrer el didccionario

            foreach(KeyValuePair<string, int> persona in edades)
            {

                //Console.WriteLine("Nombre: " + persona.Key + "; Edad: " + persona.Value);

                Console.WriteLine("Nombre: {0} Edad: {1}", persona.Key, persona.Value);


            }




        // Utilizacion de Stacks

           /* Stack<int> numeros = new Stack<int>();

            foreach (int numero in new int[5] { 2, 4, 6, 8, 10 })
            {
                numeros.Push(numero);
            }

            Console.WriteLine("Recorriendo el Queue");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }


            Console.WriteLine("Eliminando elementos: ");

            numeros.Pop();

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }*/




            // Utilizacion de Queue (Colas) Primero en entrar primero en salir.

            /* Queue<int> numeros = new Queue<int>();

             // Rellenando o agregando elementos a la cola

             foreach (int numero in new int[5] {2, 4, 6, 8, 10 })
             {
                 numeros.Enqueue(numero);
             }

             // Recorriendo la cola o queue

             Console.WriteLine("Recorriendo el Queue");

             foreach(int numero in numeros)
             {
                 Console.WriteLine(numero);
             }

             // Eliminando elementos del Queue

             Console.WriteLine("Eliminando elementos: ");

             numeros.Dequeue();

             foreach (int numero in numeros)
             {
                 Console.WriteLine(numero);
             }*/


            // Utilizacion de LinkedList<T>

            /*  LinkedList<int> numeros = new LinkedList<int>();

              foreach(int numero in new int[] { 10, 8, 6, 4, 2, 0 })
              {
                  numeros.AddFirst(numero); //Añade cada número a la primera posicion así que el primero es el último en mostrarse

                  //numeros.AddLast(numero); //Añade cada número a la posicion final ásí que se muestra segun se vé.
              }

              // numeros.Remove(6);

              LinkedListNode<int> nodoImportante = new LinkedListNode<int>(15);

              numeros.AddFirst(nodoImportante);

               //Recorro el LinkedList numeros desde el array numero.
               foreach(int numero in numeros)
                      {
                          Console.WriteLine(numero);
                      }

              for(LinkedListNode<int> nodo=numeros.First; nodo!=null; nodo = nodo.Next)
              {
                  int numero = nodo.Value;

                  Console.WriteLine(numero);
              }
              */



            // Utilizacion de List<T>

            /* List<int> numeros = new List<int>(); // Declarar una lista (coleccion de tipo lista)

            Console.WriteLine("Introduce elemento en la colección (0 para salir");

            int elem = 1;

            while (elem != 0)        
            {
                elem = Int32.Parse(Console.ReadLine());

                numeros.Add(elem);
            }

            numeros.RemoveAt(numeros.Count -1);

            Console.WriteLine("Elementos introducidos: ");

            foreach(int elemento in numeros)
            {
                Console.WriteLine(elemento);
            }*/


            /*  Console.WriteLine("¿Cuántos elementos quieres introducir?");

              int elem =Int32.Parse(Console.ReadLine());

              for( int i=0;i<elem; i++)
              {
                  numeros.Add(Int32.Parse(Console.ReadLine()));
              }

              Console.WriteLine("Elementos Introducidos: ");

              for(int i = 0; i < numeros.Count; i++)
              {
                  Console.WriteLine(numeros[i]);
              }*/



            //numeros.Add(5);

            // numeros.Add(7);

            //numeros.Add(9);

            /*int[] listaNumeros = new int[] { 3, 6, 8, 10, 50 };

            for(int i=0; i < 5; i++)
            {
                numeros.Add(listaNumeros[i]);
            }

            for(int  i=0; i<5; i++)
            {
                Console.WriteLine(numeros[i]);
            }*/





        }
    }
}