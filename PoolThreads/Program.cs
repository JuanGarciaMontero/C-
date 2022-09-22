using System;
using System.Threading;
using System.Threading.Tasks;

namespace PoolThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task

            Task tarea = new Task(EjecutarTarea);

            tarea.Start();

            Task tarea2 = new Task(() =>
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

            tarea2.Start();

            //Pool Thread

           /* for(int i = 0; i < 100; i++)
            {
                //Thread t=new Thread(EjecutarTarea);

                //t.Start();

                ThreadPool.QueueUserWorkItem(EjecutarTarea, i);

            }*/

            Console.ReadLine();

        }



       // static void EjecutarTarea(Object o)

        static void EjecutarTarea()
        {
            // Task

            //Console.WriteLine("Esta es la tarea");

            for(int i = 0; i < 100; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;

                Thread.Sleep(1000);

                Console.WriteLine("Esta vuelta de bucle corresponde al Thread: "+ miThread);


            }



            // Pool Threads

            /*int nTarea = (int)o;

            Console.WriteLine($"Thread número: {Thread.CurrentThread.ManagedThreadId} ha comenzado la tarea número "+ nTarea);

            Thread.Sleep(1000);

            Console.WriteLine($"Thread número: {Thread.CurrentThread.ManagedThreadId} ha terminado la tarea "+ nTarea);
            */

        }

    }
}