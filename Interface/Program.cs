﻿using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            AvisosTrafico av1  =new AvisosTrafico();

            av1.mostrarAviso();

            AvisosTrafico av2 = new AvisosTrafico("Jefatura Provincial Madrid", "Sanción de velocidad: 300 $", "01/09/22");

            Console.WriteLine(av2.getFecha());

            av2.mostrarAviso();

        }
    }
}
