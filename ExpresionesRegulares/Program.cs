using System;
using System.Text.RegularExpressions;

namespace ExpresionesRegulares
{
    class Program
    {
        static void Main(string[] args)
        {

            // Regex , Match, 
            //string frase = "Mi nombre es juan y mi nº de tlno es (+44)754-69-43-77 y (+34)639-23-55-69 y mi código postal es 28710";
            string frase = "Mi web es http://pildorasinformaticas.es";

            //string patron = "[J]";
            // string patron = @"\d{3}-\d{2}-\d{2}-\d{2}";
            //string patron = @"\+34|\+44";
            string patron = "https?://(www.)?pildorasinformaticas.es";

            Regex miRegex=new Regex(patron);

            MatchCollection elMatch=miRegex.Matches(frase);

            if (elMatch.Count > 0) Console.WriteLine("Se ha encontado Web");
            else Console.WriteLine("No se ha encontrado Web");

        }
    }
}