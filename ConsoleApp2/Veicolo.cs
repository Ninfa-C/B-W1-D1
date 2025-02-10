using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Veicolo
    {
        // Proprietà
        public string Marca { get; set; }
        public string Modello { get; set; }
        public int Anno { get; set; }
        public string Color { get; set; }

        //Costruttore 
        public Veicolo(string marca, string modello, int anno, string color)
        {
            Marca = marca;
            Modello = modello;
            Anno = anno;
            Color = color;
        }

        //Metodo di console

        public void Show()
        {
            Console.WriteLine("Auto: Marca:" + Marca + " Modello:" + Modello + " Anno:" + Anno + " Color:" + Color);
        }
    }
}
