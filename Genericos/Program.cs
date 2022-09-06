using System;
using System.ComponentModel.DataAnnotations;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {

            // AlmacenObjetos archivos = new AlmacenObjetos(4);

            //AlmacenObjetos<Empleado> archivos = new AlmacenObjetos<Empleado>(4);

            // AlmacenObjetos<String> archivos = new AlmacenObjetos<String>(4);

            AlmacenObjetos<DateTime> archivos = new AlmacenObjetos<DateTime>(4);

            archivos.agregar(new DateTime());

            archivos.agregar(new DateTime());

            archivos.agregar(new DateTime());

            archivos.agregar(new DateTime());

            /*archivos.agregar("Juan");

            archivos.agregar("Elena");

            archivos.agregar("Antonio");

           /* archivos.agregar("Sandra");


            /*archivos.agregar(new Empleado(1500));

            archivos.agregar(new Empleado(2500));

            archivos.agregar(new Empleado(3500));

            archivos.agregar(new Empleado(4500));*/


            //String nombrePersona = (String)archivos.getElemento(2);

            //Empleado salarioEmpleado = (Empleado)archivos.getElemento(2);


            /*Empleado salarioEmpleado = archivos.getElemento(2);

            Console.WriteLine(salarioEmpleado.getSalario());*/

            
            /*String nombrePersona = archivos.getElemento(2);

            Console.WriteLine(nombrePersona);*/

            DateTime nombrePersona = archivos.getElemento(2);

            Console.WriteLine(nombrePersona);

            
    }
    }

    class AlmacenObjetos<T>
    {
        public AlmacenObjetos(int z)
        {
            datosElemento = new T[z];
        }

        public void agregar( T obj)
        {
            datosElemento[i] = obj;

            i++;
        }

        public T getElemento(int i)
        {
            return datosElemento[i];
        }

        private T [] datosElemento;

        private int i = 0;
    }

    /*class AlmacenObjetos
    {
        public AlmacenObjetos(int z)
        {
            datosElemento = new object[z];
        }

        public void agregar(Object obj)
        {
            datosElemento[i] = obj;

            i++;
        }

        public Object getElemento(int i)
        {
            return datosElemento[i];
        }

        private Object[] datosElemento;

        private int i = 0;
    }*/

    class Empleado
    {
        public Empleado(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return salario;
        }

        private double salario;
    }
}