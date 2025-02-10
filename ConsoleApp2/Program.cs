using ConsoleApp2;
var atleta1 = new Atleta() { Age = 29, Name = "Carolina", Surname = "Topotip", Sport = "Ballet" };
var Dipendente1 = new Dipendente() { Age = 29, Name = "Martina", Surname = "Princess", Role = "Junior" };
var animale1 = new Animale() { Breed = "Aegean", Diet = "onmivorous", Specie = "Cat", Weight = 5 };

var Auto1 = new Veicolo("Toyota", "Yaris", 2025, "RoseGold");


Console.WriteLine(atleta1);
Console.WriteLine(Dipendente1);
Console.WriteLine(animale1);
Auto1.Show();