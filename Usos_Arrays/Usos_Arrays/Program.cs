using System;

namespace Usos_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primeros Arrays
            /*
            int[] edades;

            edades = new int[4];

            edades[0] = 15;
            edades[1] = 27;
            edades[2] = 19;
            edades[3] = 80;*/

            //Otra forma iniciaar Arrays

            //int[] edades = { 15, 27, 19, 80 };

            // int[] edades = new int[4] { 15, 27, 19, 80 };

            /*for (int i = 0; i <= edades.Length; i++) {

                Console.WriteLine(edades[i]);

            }*/

            //array implicito

            //var datos = new[] { "Juan", "Diaz", "España" };
            //var datos = new[] { "Juan", "Diaz", 30 }; ERROR

            var valores = new[] { 15, 28, 35, 75.5, 30.30, 90, 101.45 }; // todo a double


            //arrays de objetos

            Empleados Ana = new Empleados("Ana", 27);

            Empleados[] arrayEmpleados = new Empleados[3];

            arrayEmpleados[0] = new Empleados("Sara", 37);

            arrayEmpleados[1] = Ana;

            arrayEmpleados[2] = new Empleados("Manuel", 22);


            // arrays de tipos o clases anónimos

            var personas = new[]
            {
                new{Nombre="Juan", Edad=19},
                new{Nombre="Maria", Edad=49},
                new{Nombre="Diana", Edad=35}
            };


            //for(int i=0; i<=4 ; i++)
            // int contador = 0;

            //for(int i=15; i>=11; i--)
            /* for(int i=0; i < valores.Length; i++)
             {
                 Console.WriteLine(valores[i]);
                 //contador++;
             }*/

            /*for (int i = 0; i < arrayEmpleados.Length; i++)
            {
                Console.WriteLine(arrayEmpleados[i].getInfo());
            }*/

            /*foreach (Empleados variable in arrayEmpleados)
            {
                Console.WriteLine(variable.getInfo());
            }*/

            /*foreach(double variable in valores)
            {
                Console.WriteLine(variable);
            }*/

            foreach(var variable in personas)
            {
                Console.WriteLine(variable);
            }
        }
    }

    class Empleados
    {

        public Empleados(String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public String getInfo()
        {
            return "Nombre del empleado: " + nombre + ", Edad: " + edad;
        }

        private String nombre;

        private int edad;

    }
}
