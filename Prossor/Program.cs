using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prossor
{
    class GuerreroZ
    {
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public char Sexo { get; set; }
        public int Ki { get; set; }
        public int Universo { get; set; }
        public bool EstaVivo { get; set; }
        public string Cargo { get; set; }
        public Planeta Planeta { get; set; }
    }

    public class Planeta
    {
        public string Nombre { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dragon Ball");
            GuerreroZ guerrero = new GuerreroZ();
            guerrero.Nombre = "Goku";
            ShorGuerrero(guerrero);
            Console.ReadKey();
        }


        static void ShorGuerrero(GuerreroZ guerrero){
            Console.WriteLine("===================");
            Console.WriteLine("Guerrero: " + guerrero.Nombre);
            Console.WriteLine("===================");
        }
    }
}
