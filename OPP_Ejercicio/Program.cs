
using System;

namespace Vehiculo
{
    class Program
    {
        static void Main(string[] args)
        {

           Console.WriteLine("Probando el avión");

           Avion miAvion = new Avion();

             miAvion.ArrancaMotor("tracatratractar");

             miAvion.Despegar();

             miAvion.Conducir();

             miAvion.Aterrizar();

             miAvion.PararMotor("plooooof");


            Console.WriteLine("");


            Console.WriteLine("Probando el coche");

            Coche miCoche = new Coche();

              miCoche.ArrancaMotor("grrrum grrrrrummmm");

              miCoche.Acelerar();

              miCoche.Conducir();

              miCoche.Frenar();

              miCoche.PararMotor("bluuuuuuuuf");


            Console.WriteLine("");

            Console.WriteLine("Polimorfismo en acción!");

            Vehiculo miVehiculo = miCoche;

            miVehiculo.Conducir();

            miVehiculo = miAvion;

            miVehiculo.Conducir();





            
        }
    }
}