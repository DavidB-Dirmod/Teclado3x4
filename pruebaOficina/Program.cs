using System;
using System.Collections.Generic;

namespace pruebaOficina
{
    class Program
    {
        static void Main(string[] args)
        {

            string salir;
            string palabra;
            string resultado;

            Caracteres caracteres = new Caracteres();
            UnaClase clase = new UnaClase(caracteres.lst);
            
            do
            {
            Console.Write("Por favor, introduce una palabra:  ");
            palabra = Console.ReadLine();
            

            resultado = clase.convertir(palabra);
            Console.WriteLine('\n'+palabra+" => "+resultado+'\n');

            Console.WriteLine("Para repetir presione enter, para salir presione 's'.");
            salir = Console.ReadLine();
            } while (salir!="s");
        }
    }
}