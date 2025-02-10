using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Dipendente
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Age { get; set; }
        public string? Role { get; set; }

        //costruttore

        public Dipendente(string name, string surname, int age, string role)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Role = role;
        }

        //console log per scrivere e far vedere qualcosa inserito in una funzione void

        public void Show()
        {
            Console.WriteLine("Dipendente " + Name + " " + Surname + " di anni " + Age + " lavora presso l'azienda X sotto il ruolo di " + Role);
        }

    }
}
