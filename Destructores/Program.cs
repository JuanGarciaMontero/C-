using System;
using System.IO;

namespace Destructores
{
    class Program
    {
        static void Main(string[] args)
        {

            ManejoArchivos miarchivo = new ManejoArchivos();

            miarchivo.mensaje();
              
        }
    }

    class ManejoArchivos
    {
        StreamReader archivo = null;

        int contador = 0;

        string linea;

        public ManejoArchivos()
        {
            archivo = new StreamReader(@"c:\texto.txt");

            while ((linea = archivo.ReadLine()) != null)
            {
                Console.WriteLine(linea);

                contador++;
            }
        }

        public void mensaje()
        {
            Console.WriteLine("Hay {0} lineas", contador);
        }

        // Destructor de Archivos. ~ = ALT+126

        ~ManejoArchivos()
        { 
            archivo.Close();
        }




    }
}