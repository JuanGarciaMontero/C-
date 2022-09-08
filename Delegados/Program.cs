using System;
using System.Collections.Generic;

namespace Delegados
{
    class Program
    {
        static void Main(string[] args)
        {

            // LAMBDAS

            // Compara dos Personas. ¿Tienen la misma edad?

            Personas F1 = new Personas();
            F1.Nombre = "Juana";
            F1.Edad = 2;

            Personas F2 = new Personas();
            F2.Nombre = "María";
            F2.Edad = 9;

            ComparaPersonas comparaEdad = (persona1, persona2) => persona1 == persona2;

            Console.WriteLine(comparaEdad(F1.Edad, F2.Edad));

            // Uso del EXPRESIONES LAMBDA

            //OperacionesMatematicas operacion = new OperacionesMatematicas(Cuadrado);
                                                                        // Expresion Lambda
            OperacionesMatematicas operacion = new OperacionesMatematicas(num => num * num);

            Console.WriteLine(operacion(4));


            //OperacionesMatematicas2 operacion2 = new OperacionesMatematicas2(Suma);

            OperacionesMatematicas2 operacion2 = new OperacionesMatematicas2((num1, num2) => num1 +num2);

            Console.WriteLine(operacion2(54,68));



            // Encontrar los pares de una lista dada de números con función lambda
            // Se reduce mucho el código

            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> numerosPares = numeros.FindAll(i => i % 2 == 0);

            // foreach (int numero in numerosPares) Console.WriteLine(numero);

            numerosPares.ForEach(numero => {  Console.WriteLine("El número par es: "); Console.WriteLine(numero); });




            // PREDICADOS

            // Ejemplo 2.

            List<Personas> gente=new List<Personas>();

                    Personas P1 = new Personas();
                    P1.Nombre = "Juana";
                    P1.Edad = 2;

                    Personas P2 = new Personas();
                    P2.Nombre = "María";
                    P2.Edad = 9;

                    Personas P3 = new Personas();
                    P3.Nombre = "Ana";
                    P3.Edad = 17;
                    
                    gente.AddRange(new Personas[] {P1, P2, P3 });

                    Predicate<Personas> elPredicado = new Predicate<Personas>(ExiteJuan);

                    bool exite = gente.Exists(elPredicado);

                    if (exite) Console.WriteLine("Hay personas que se llaman Juan");
                    else Console.WriteLine("No hay personas que se llaman Juan");


                    Predicate<Personas> elPredicador = new Predicate<Personas>(ExistenMayoresEdad);

                    bool exite2 = gente.Exists(elPredicador);

                    if (exite2) Console.WriteLine("Hay personas mayores de edad");
                    else Console.WriteLine("No hay personas mayores de edad");



            // Ejemplo 1.

            // Creo una lista de números donde voy a guardar los números a evaluar

            List<int> listaNumeros = new List<int>();

                    // Añado a mi lista un array de números. Cargo la lista con un array de números

                    listaNumeros.AddRange(new int[] {1,2,3,4,5,6,7,8,9,10});

                    // Declaramos delegado predicado

                    Predicate<int> elDelegadoPred = new Predicate<int>(DamePares);

                    // Creo una lista donde guardo con el método FindAll la lista de números con las condiciones del predicado "elDelegadoPred"

                    List<int> numPares=listaNumeros.FindAll(elDelegadoPred);

                    // Recorro la lista cargada

                    foreach(int num in numPares)
                    {
                        Console.WriteLine(num);
                    }



                


            // DELEGADOS

                // Creación del objeto delegado apuntando a MensajeBienvenida

                    // ObjetoDelegado ElDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);

                ObjetoDelegado ElDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);

                // Utilización del delegado para llamar al método saludoBienvenida

                ElDelegado("Hola acabo de llegar");

                //  ElDelegado = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);

                ElDelegado = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);

                ElDelegado("Hola ya me voy");


            
        }

        // Definición del objeto delegado
        delegate void ObjetoDelegado(string msj);


        // Para Predicados
        static bool DamePares(int num)
        {
            if (num % 2 == 0) return true;
            else return false;
        }

        // Ejemplo 2. Otro Ejemplo Delegado Predicado

        static bool ExiteJuan(Personas persona)
        {
            if (persona.Nombre == "Juan") return true;
            else return false;
        }

        static bool ExistenMayoresEdad(Personas persona)
        {
            if (persona.Edad >= 18) return true;
            else return false;
        }

        // Métodos de Lambda

        public delegate int OperacionesMatematicas(int numero);

        public delegate int OperacionesMatematicas2(int numero1, int numero2);

        /* public static int Cuadrado(int num)
         {
             return num *num;
         }*/

        /* public static int Suma(int num1, int num2)
         {
             return num1 + num1;
         }*/


        // EXPRESION LAMBDA. CREACION METODO DELEGATE PARA CLASE PERSONAS

        public delegate bool ComparaPersonas(int edad1, int edad2);

    }

    // Ejemplo 2 Delegado Predicado

    class Personas
    {

        private string nombre;

        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }





    // CLASES PARA EJEMPLO DE DELEGADOS

    class MensajeBienvenida
    {
        public static void SaludoBienvenida(string msj)
        {
            // Console.WriteLine("Hola acabo de llegar. Que tal?");

            Console.WriteLine("Mensaje de bienvenida: {0}", msj);
        }
    }

    class MensajeDespedida
    {
        public static void SaludoDespedida(string msj)
        {
            //Console.WriteLine("Hola ya me marcho. Hasta luego.");

            Console.WriteLine("Mensaje de despedida: {0}", msj);
        }
    }

}