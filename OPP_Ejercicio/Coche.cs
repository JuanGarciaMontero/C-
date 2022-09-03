using System;
using System.Collections.Generic;
using System.Text;

namespace Vehiculo
{
    class Coche: Vehiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("Acelerando Coche");
        }

        public void Frenar()
        {
            Console.WriteLine("Frenando Coche");
        }

        public override void Conducir()
        {
            // base.Conducir();

            Console.WriteLine("Tomando las curvas con decisión y destreza");
        }
    }
}
