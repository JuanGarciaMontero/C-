using System;

namespace GenericoRestricciones
{
    class Program
    {
        static void Main(string[] args)
        {

            AlmacenEmpleados<Secretaria> empleados = new AlmacenEmpleados<Secretaria>(3);

            empleados.agregar(new Secretaria(4500));

            empleados.agregar(new Secretaria(1500));

            empleados.agregar(new Secretaria(2500));


            // Clase generica con restricciones ya que no tiene el declarado el método salario
            // obligado de la interface, (tampoco tiene Estudiante heradado la Interface)
            // Da error en el momento de compilación.

            AlmacenEmpleados<Estudiante> empleados = new AlmacenEmpleados<Estudiante>(3);

            empleados.agregar(new Estudiante(4500));

            empleados.agregar(new Estudiante(1500));

            empleados.agregar(new Estudiante(2500));


        }
    }

    class AlmacenEmpleados<T> where T: IparaEmpleado
    {

        public AlmacenEmpleados(int z)
        {
            datosEmpleado = new T[z];
        }

        public void agregar(T obj)
        {
            datosEmpleado[i] = obj;

            i++;
        }

        public T getEmpleado(int i)
        {
            return datosEmpleado[i];
        }

        private int i = 0;

        private T[] datosEmpleado;
    }

    class Director: IparaEmpleado
    {

        public Director(double salario)
        {
            this.salario = salario;
        }

        private double salario;

        public double getSalario()
        {
            return salario;
        }
    }

    class Secretaria:IparaEmpleado
    {
        public Secretaria(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return salario;
        }

        private double salario;


    }

    class Electricista:IparaEmpleado
    {
        public Electricista(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return salario;
        }

        private double salario;

    }

    class Estudiante
    {
        public Estudiante(double edad)
        {
            this.edad = edad;
        }

        public double getEdad()
        {
            return edad;
        }

        private double edad;
    }


    interface IparaEmpleado
    {
        double getSalario();
    }
}