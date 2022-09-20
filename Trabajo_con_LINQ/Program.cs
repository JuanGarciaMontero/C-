using System;
using System.Collections.Generic;
using System.Linq;

namespace Trabajo_con_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] valoresNumericos=new int[] {1,2,3,4,5,6,7,8,9,10};

            Console.WriteLine("Números pares:");

            /* List<int> numerosPares=new List<int>();

             foreach(int i in valoresNumericos)
             {
                 if (i %== 0)
                 {
                     numerosPares.Add(i);
                 }
             }

            // Sentencia Linq....

            IEnumerable<int> numerosPares = from numero in valoresNumericos where numero % 2 == 0 select numero;

            foreach(int i in numerosPares)
            {
                Console.WriteLine(i);
            }*/

            ControlEmpresasEmpleados ce = new ControlEmpresasEmpleados();

            //ce.getCEO();
            //ce.getEmpleadosOrdenados();
            //ce.getEmpleadosPildoras();

            Console.WriteLine("Introduce el Id de la empresa para mostrar los empleados.");

            string entrada = Console.ReadLine();

            try
            {

                int entradaId = Convert.ToInt32(entrada);

                ce.getEmpleadosEmpresa(entradaId);

            }
            catch (Exception)
            {
                Console.WriteLine("Has introducido un Id Erróneo");
            }


        }
    }

    class ControlEmpresasEmpleados
    {

        public ControlEmpresasEmpleados()
        {

            listaEmpresas = new List<Empresa>();

            listaEmpleados = new List<Empleado>();

            listaEmpresas.Add(new Empresa { Id = 1, Nombre = "Google"});

            listaEmpresas.Add(new Empresa { Id = 2, Nombre = "Píldoras Informáticas"});

            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Juan Díaz", Cargo = "CEO", EmpresaId = 2, Salario = 150000});

            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "Sergey Brin", Cargo = "CEO", EmpresaId = 1, Salario = 1500000 });

            listaEmpleados.Add(new Empleado { Id = 3, Nombre = "Larry Page", Cargo = "Co-CEO", EmpresaId = 1, Salario = 150001 });

            listaEmpleados.Add(new Empleado { Id = 4, Nombre = "Irina Shayk", Cargo = "Co-CEO", EmpresaId = 2, Salario = 1500001 });



        }

        public void getCEO()
        {
            // IMPORTANTE

            IEnumerable<Empleado> ceos = from empleado in listaEmpleados where empleado.Cargo == "CEO" select empleado;

            foreach (Empleado empleado1 in ceos)
            {
                empleado1.getDatosEmpleado();
            }

        }

        public void getEmpleadosOrdenados()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados orderby empleado.Nombre descending select empleado;

            foreach (Empleado empleado1 in empleados)
            {
                empleado1.getDatosEmpleado();
            }
        }

        public void getEmpleadosPildoras()
        {
            IEnumerable<Empleado> empleadosPildoras =
                    from empleado in listaEmpleados join empresa in listaEmpresas
                    on empleado.EmpresaId equals empresa.Id
                    where empresa.Nombre == "Píldoras Informáticas" select empleado;

            foreach (Empleado empleado1 in empleadosPildoras)
            {
                empleado1.getDatosEmpleado();
            }
        }

        public void getEmpleadosEmpresa(int Id)
        {
            IEnumerable<Empleado> empleadosEmp =
                    from empleado in listaEmpleados
                    join empresa in listaEmpresas
                    on empleado.EmpresaId equals empresa.Id
                    where empresa.Id == Id
                    select empleado;

            foreach (Empleado empleado1 in empleadosEmp)
            {
                empleado1.getDatosEmpleado();
            }
        }


        public List<Empresa> listaEmpresas;

        public List<Empleado> listaEmpleados;




    }

    class Empresa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public void getDatosEmpresa()
        {
            Console.WriteLine("Empresa {0} con Id {1}", Nombre, Id);
        }
    }

    class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Cargo { get; set; }

        public double Salario { get; set; }

        // Clave foránea

        public int EmpresaId { get; set; }

        public void getDatosEmpleado()
        {
            Console.WriteLine("Empleado {0} con Id {1}, cargo {2}, con salario {3}" +
                " pertenecinete a la empresa{4}", Nombre, Id, Cargo, Salario, EmpresaId);
        }
    }



}