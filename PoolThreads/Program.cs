using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace PoolThreads
{
    class Program
    {

        private static int acumulador = 0;

        static void Main(string[] args)
        {
            //Task

            /*Task tarea = new Task(EjecutarTarea);

            tarea.Start();*/

            //Task tarea = Task.Run (() => EjecutarTarea());

            // Task tarea2 = Task.Run (() => EjecutarOtraTarea());

            // Para no comenzar la tarea2 sin terminar la tarea1
            // Task tarea2 = tarea.ContinueWith(EjecutarOtraTarea);

            /* Task tarea2 = new Task(() =>
             {
                 for (int j = 0; j < 100; j++)
                 {
                     var miThread=Thread.CurrentThread.ManagedThreadId;

                     Thread.Sleep(1000);

                     Console.WriteLine("Tarea correspodiente al hilo: "+ miThread +
                         " ejecutándose desde el Main");

                 }
             }

             );

             tarea2.Start();*/

            //Pool Thread

            /* for(int i = 0; i < 100; i++)
             {
                 //Thread t=new Thread(EjecutarTarea);

                 //t.Start();

                 ThreadPool.QueueUserWorkItem(EjecutarTarea, i);

             }*/

            /* RealizarTodasTareas();
            */

            /*for (int i = 0; i < 100; i++)
                { 
                    RealizarTarea(i);

                    Console.WriteLine($"Acumulador vale {acumulador}. Tarea realizado por el hilo {Thread.CurrentThread.ManagedThreadId}");

                }*/

            
            // Realizacion del trabajo de forma concurrente. Parallel utiliza varios hilos o threads, el trabajo es más rápido
            
            // Para reducir código elimino o comento el método y lo implemento con el método funcion flecha dentro del método Parallel.For(************)
            Parallel.For(0, 100, dato =>
                {
                    Console.WriteLine($"Acumulador vale {acumulador}. Tarea realizado por el hilo {Thread.CurrentThread.ManagedThreadId}");

                    if ((acumulador % 2) == 0)
                    {
                        acumulador += dato;

                        Thread.Sleep(100);
                    }
                    else { acumulador -= dato; Thread.Sleep(100); }
                }
            );

        }


        //static void RealizarTodasTareas()
        /*static void RealizarTarea(int dato)
        {

            Console.WriteLine($"Acumulador vale {acumulador}. Tarea realizado por el hilo {Thread.CurrentThread.ManagedThreadId}");

            if ((acumulador % 2) == 0)
            {
                acumulador += dato;

                Thread.Sleep(100);
            }
            else { acumulador -= dato; Thread.Sleep(100); }




            /*
            // Ejecuta las Task de forma aleatoria según necesidades de nuestro procesador

            // Para ejecutas Task por ejemplo se ejecutan las dos primeras Task y cuando terminen
            // se ejecuta la tercera Task. tengo que meter en una variable las tareas.

            var tarea1 = Task.Run(() =>
            {

                EjecutarTarea();
            });

            // Hasta que no termina la Task1 no comienzan la Task2 y Task3
            // Para que las Task se ejecuten de forma consecutiva poner el Wait antes de cada tarea
            tarea1.Wait();

            var tarea2 =Task.Run(() =>
            {

                EjecutarTarea2();
            });

            tarea2.Wait();

            // WaitAll no comienza hasta que terminen las Task1 y Task2
            // WaitAny cuando termine uno de los Task1 o Task2 comienza el Task

           // Task.WaitAny(tarea1, tarea2);

            var tarea3 =Task.Run(() =>
            {

                EjecutarTarea3();
            });




            // Ejecuta todas tareas de forma consecutiva.

            //EjecutarTarea();

            // EjecutarTarea2();

            //  EjecutarTarea3();

            
        }*/



       // static void EjecutarTarea(Object o)

       /* static void EjecutarTarea()
        {
            // Task

            //Console.WriteLine("Esta es la tarea");

            for(int i = 0; i < 5; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;

                Thread.Sleep(1000);

                // Console.WriteLine("Esta vuelta de bucle corresponde al Thread: "+ miThread);
                Console.WriteLine("Esta vuelta de bucle corresponde a la tarrea 1");

            }





            // Pool Threads

            /*int nTarea = (int)o;

            Console.WriteLine($"Thread número: {Thread.CurrentThread.ManagedThreadId} ha comenzado la tarea número "+ nTarea);

            Thread.Sleep(1000);

            Console.WriteLine($"Thread número: {Thread.CurrentThread.ManagedThreadId} ha terminado la tarea "+ nTarea);
            

        }*/

        /*static void EjecutarTarea2()
        {
            // Task

            //Console.WriteLine("Esta es la tarea");

            for (int i = 0; i < 5; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;

                Thread.Sleep(500);

                Console.WriteLine("Esta vuelta de bucle corresponde a la tarrea 2");


            }


        }

        static void EjecutarTarea3()
        {
            // Task

            //Console.WriteLine("Esta es la tarea");

            for (int i = 0; i < 5; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;

                Thread.Sleep(500);

                Console.WriteLine("Esta vuelta de bucle corresponde a la tarrea 3");


            }


        }



        // Para pasar a la siguiente tarea hay que pasar un parámetro Task de tipo objeto
        /* static void EjecutarOtraTarea(Task obj)
         {
             // Task

             //Console.WriteLine("Esta es la tarea");

             for (int i = 0; i < 10; i++)
             {
                 var miThread = Thread.CurrentThread.ManagedThreadId;

                 Thread.Sleep(1000);

                 Console.WriteLine("Esta es otra tarea y esta vuelta de bucle corresponde al Thread: " + miThread);


             }


         }*/

    }
}