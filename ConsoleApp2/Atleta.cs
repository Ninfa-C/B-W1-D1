using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Atleta(string name, string surname, int age, string sport)
    {
        //private string name;
        //private string surname;
        //private int age;

        public string Name { get; set; } = name;
        public string Surname { get; set; } = surname;
        public int Age { get; set; } = age;
        public string Sport { get; set; } = sport;

        //console  
        public void Show()
        {
            Console.WriteLine(Name + " " + Surname + " " + Age + " anni, " + Sport);
        }


    }
}
