using System;

namespace Clases_Abstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Caballo miBabieca = new Caballo("Babieca");

            ISaltoConPatas ImiBabieca = miBabieca;

            Humano miJuan = new Humano("Juan");

            Gorila miCopito = new Gorila("Copito");

            Mamiferos[] almacenAnimales = new Mamiferos[3];

            almacenAnimales[0] = miBabieca;

            almacenAnimales[1] = miJuan;

            almacenAnimales[2] = miCopito;


            for (int i = 0; i < 3; i++)
            {
                almacenAnimales[i].pensar();
            }

            Mamiferos miMamifero = new Mamiferos("");

            miMamifero.respirar();
            */
            /*
             * miJuan.getNombre();
             * miBabieca.getNombre();
             * miCopito.getNombre();
             */
            /*
            Ballena miWally = new Ballena("Wally");

            miWally.nadar();

            Console.WriteLine("Patas utilizadas en el salto de Babieca: " + ImiBabieca.numeroPatas());
            */

            Lagartija Juancho = new Lagartija("Juancho");

            //Juancho.respirar();
            Juancho.getNombre();

            Humano Juan = new Humano("Juan");

            //Juan.respirar();
            Juan.getNombre();

        }
    }

    interface IMammiferosTerrestres
    {
        int numeroPatas();
    }

    interface IAnimalesYDeportes
    {
        string tipoDeporte();

        Boolean esOlimpico();
    }

    interface ISaltoConPatas
    {
        int numeroPatas();
    }


    abstract class Animales
    {
        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public abstract void getNombre();


    }

    class Lagartija : Animales
    {
        public Lagartija(String nombre)
        {
            nombreReptil = nombre;
        }

        public override void getNombre()
        {
            Console.WriteLine("El nombre del reptil es: " + nombreReptil);
        }

        private String nombreReptil;
    }

    class Mamiferos:Animales
    {
        public Mamiferos(String nombre)
        {
            nombreSerVivo = nombre;
        }


        public virtual void pensar()
        {
            Console.WriteLine("Pensamiento básico instintivo");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crías hata que se valgan por si solas.");
        }

        public override void getNombre()
        {
            Console.WriteLine("El nombre del mamífero es: " + nombreSerVivo);
        }

        private String nombreSerVivo;

    }

    class Ballena : Mamiferos
    {
        public Ballena(string nombreBallena) : base(nombreBallena)
        {

        }


        public void nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }


    }

    class Humano: Mamiferos
    {
        public Humano(string nombreHumano) : base(nombreHumano)
        {

        }

        //public sealed override void pensar()
        // con seale impides al método pensar() pueda heredarse
        public override void pensar()
        {
            Console.WriteLine("Soy capaz de pensar ¿?");

        }

    }

   /* class Adolescente : Humano
    {
        public Adolescente(string nombreAdolescente) : base(nombreAdolescente)
        {

        }

        public override void pensar()
        {
            Console.WriteLine("Las hormonas me impiden pensar con claridad");
        }
     
    }*/

    class Caballo : Mamiferos, IMammiferosTerrestres
    {
        public Caballo(string nombreCaballo) : base(nombreCaballo)
        {

        }

        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }

        public int numeroPatas()
        {
            return 4;
        }
    }

    //sealed class Gorila: Mamiferos, IMammiferosTerrestres
    //  con sealed impides que tenga herencia Gorila
    class Gorila : Mamiferos, IMammiferosTerrestres
    {
        public Gorila(string nombreGorila) : base(nombreGorila)
        {

        }

        public override void pensar()
        {
            Console.WriteLine("Pensamiento instintivo avanzado");
        }

        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }

        public int numeroPatas()
        {
            return 2;
        }
    }




}