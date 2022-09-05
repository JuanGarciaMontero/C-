using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado(1200, 250);

            empleado1.cambiaSalario(empleado1, 100);

            Console.WriteLine(empleado1);
        }
    }

    //public class Empleado // Memoria Heap. 
              // Variable dentro de un método estan accesible,
             //durante toda la ejecución del programa, normalmente.(Acceso a memoria un poco más lento que Stack) 
             //Entra en el método. Class almacenamiento en memoria Heap. El nombre de la clase se almacena en Stack
             // pero hace referencia a cada nuevo objeto que se almacena en la memoria Heap.
             // Cambios en la estructura por eso cambia.
    public struct Empleado // Memoria Stack. 
                                    // Variable dentro de un metodo se eliminan despues de usarse.
                                   //(Acceso Rápido a la memoria)// No entra en el método.//
                                  //Struct almacenamiento en memoria Stack (como variables primitivas),
                                 //Se realiza copia de Struct por cada objeto Struct generado.
                                // No cambia la estructura solo cambia el objeto empleado.
    {
        public double salarioBase, comision;
        public Empleado(int salarioBase, int comision)
        {
            this.salarioBase = salarioBase;

            this.comision = comision;
        }

        public override string ToString()
        {
            return String.Format("Salario y comisión del empleado ({0},{1})", this.salarioBase, this.comision);
        }

        public void cambiaSalario(Empleado emp, double incremento)
        {
            emp.salarioBase+=incremento;

            emp.comision += incremento;
        }
    }
}