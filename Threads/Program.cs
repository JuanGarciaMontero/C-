using System;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            /* // Acabamos de crear un nuevo hilo o thread
             Thread t = new Thread(MetodoSaludo);
             // Comienzo del hilo
             t.Start();
             // Sincronizar hilos
             t.Join();

             Thread t2 = new Thread(MetodoSaludo);
             t2.Start();
             t2.Join();

             Console.WriteLine("Hola desde thread 1 (o hilo 1)");

             Thread.Sleep(500);// Imprime cada medio segundo

             Console.WriteLine("Hola desde thread 1 (o hilo 1)");
             Thread.Sleep(500);
             Console.WriteLine("Hola desde thread 1 (o hilo 1)");
             Thread.Sleep(500);
             Console.WriteLine("Hola desde thread 1 (o hilo 1)");
             Thread.Sleep(500);
             Console.WriteLine("Hola desde thread 1 (o hilo 1)");
             Thread.Sleep(500);
             Console.WriteLine("Hola desde thread 1 (o hilo 1)");*/


            // Cuenta Bancaria
            /*

            CuentaBancaria CuentaFamilia = new CuentaBancaria(2000);

            Thread[] hilosPersonas = new Thread[15];

            for(int i= 0; i < 15; i++)
            {
                Thread t = new Thread(CuentaFamilia.VamosRetirarEfectivo);

                t.Name = i.ToString();

                hilosPersonas[i] = t;

            }

            // Esta todo sincronizado
            for (int i = 0; i < 15; i++) { hilosPersonas[i].Start(); hilosPersonas[i].Join(); }
            */

            var tareaTerminada=new TaskCompletionSource<bool>();


            var hilo1 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Hilo 1");

                    Thread.Sleep(1000);

                }
                tareaTerminada.TrySetResult(true);
            });

            var hilo2 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Hilo 2");

                    Thread.Sleep(1000);

                }
                tareaTerminada.TrySetResult(true);
            });

            var hilo3 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Hilo 3");

                    Thread.Sleep(1000);

                }
            });

            hilo1.Start();

            //var resultado = tareaTerminada.Task.Result;

            hilo2.Start();

            var resultado = tareaTerminada.Task.Result;

            hilo3.Start();

        }
        /*
        static void MetodoSaludo()
        {
            Console.WriteLine("Hola desde thread 2 (o hilo 2)");

            Thread.Sleep(500);// Imprime cada medio segundo

            Console.WriteLine("Hola desde thread 2 (o hilo 2)");
            Thread.Sleep(500);
            Console.WriteLine("Hola desde thread 2 (o hilo 2)");
            Thread.Sleep(500);
            Console.WriteLine("Hola desde thread 2 (o hilo 2)");
            Thread.Sleep(500);
            Console.WriteLine("Hola desde thread 2 (o hilo 2)");
            Thread.Sleep(500);
            Console.WriteLine("Hola desde thread 2 (o hilo 2)");
        }*/
    }
    /*
    class CuentaBancaria
    {
        private Object bloqueaSaldoPositivo= new object();

        double Saldo { get; set; }

        public CuentaBancaria(double Saldo)
        {
            this.Saldo = Saldo;

        }

        public double RetirarEfectivo(double cantidad)
        {
            if ((Saldo - cantidad) < 0)
            {
                Console.WriteLine($"Lo siento queda {Saldo} euro en la cuenta. Hilo: {Thread.CurrentThread.Name}");

                return Saldo;
            }

            // Acceso Bloqueado
            //lock(bloqueaSaldoPositivo)
            //{
                if (Saldo >= cantidad)
                {
                    Console.WriteLine("Retirado {0} y queda {1} en la cuenta. Hilo: {2}", cantidad, (Saldo - cantidad), Thread.CurrentThread.Name);

                    Saldo -= cantidad;
                }
           // }

            return Saldo;
        }

        public void VamosRetirarEfectivo()

        {

            Console.WriteLine("Está sacando dinero el hilo: {0}", Thread.CurrentThread.Name);

           for(int i=0;i<4;i++) RetirarEfectivo(500);
        }

    
    }
        */



}