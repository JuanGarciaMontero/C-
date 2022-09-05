using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado Juan = new Empleado("Juan");

            Juan.SALARIO = 1200;

            Juan.SALARIO += 500;

            Console.WriteLine("El salario del empleado es: " + Juan.SALARIO);

            Juan.SALARIO = -1999;

            Console.WriteLine("El salario del empleado es: " + Juan.SALARIO);

            //A//Juan.setSalario(1200);

            //B//double nuevoSalario = Juan.getSalario() + 700;

            //A//Console.WriteLine("El salario del empleado es: " + Juan.getSalario());

            //B//Console.WriteLine("El nuevo salario del empleado es: " + nuevoSalario);




        }
    }

    class Empleado
    {
        public Empleado(string nombre)
        {
            this.nombre = nombre;
        }

        /*public void setSalario(double salario)
        {
            if (salario < 0)
            {
                Console.WriteLine("El salario no puede ser negativo. Se asignará 0 como salario");

                this.salario = 0;

            }
            else
            {
                this.salario = salario;
            }
        }

        public double getSalario()
        {
            return salario;
        }
        */

        // Con Properties. METODO DE CONTROL

        private double evaluaSalario(double salario)
        {
            if (salario < 0) return 0;

            else return salario;
        }

        // CREACIÓN DE PROPIEDAD

       /* public double SALARIO
        {
            get { return this.salario; }

            set { this.salario=evaluaSalario (value); }

        }*/

        // Properties reduccion de código

        public double SALARIO
        {
            get => this.salario;

            set => this.salario = evaluaSalario(value);

        }

        // Properties de solo lectura o solo escritura
        // Solo Escritura comentando get...
        // Solo Lectura comentando set...(ej:contraseñas)

        private double salario;

        private string nombre;
    }
}