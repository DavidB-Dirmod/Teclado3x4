using System;
using System.Linq;
using System.Collections.Generic;

namespace pruebaOficina
{
    public class UnaClase
    {
            
        private string nuevaPalabra { get; set; }
        private string nuevoCaracter { get; set; }
        private string ultimo { get; set; }
        private string nuevo { get; set; }
        private string _palabra { get; set; }
        private List<Letra> _lst { get; set; }

        public UnaClase(List<Letra> lst) 
        {
            _lst = lst;
        }

        public string convertir(string palabra)
        {
            nuevaPalabra = nuevoCaracter = "";
            _palabra = palabra.ToLower();
            //Console.WriteLine(_palabra);

            foreach (char caracter in _palabra)
            {
                var a = from e in _lst
                        where e.caracter==caracter
                        select e.numero;
                
                nuevoCaracter = "" + a.First();

                //Console.WriteLine("Nuevo Caracter"+nuevoCaracter);

                if(nuevaPalabra.Length != 0)
                {
                ultimo = nuevaPalabra.Substring(nuevaPalabra.Length -1, 1);
                nuevo = nuevoCaracter.Substring(nuevoCaracter.Length -1 , 1);
                }

                //Console.WriteLine("Ultimo "+ultimo+" Nuevo "+nuevoCaracter);

                if(nuevo == ultimo && ultimo != null)
                {
                    nuevaPalabra += " ";
                }

                nuevaPalabra += nuevoCaracter;
                
                //Console.WriteLine(nuevaPalabra);
            }
            return (nuevaPalabra);
            //Console.WriteLine('\n'+palabra+" => "+nuevaPalabra+'\n');
        }

    }
}