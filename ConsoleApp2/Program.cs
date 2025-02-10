using ConsoleApp2;
var atleta1 = new Atleta("Alessando", "Del Piero", 50, "ex calciatore");
var animale1 = new Animale() { Breed = "Aegean", Diet = "onmivorous", Specie = "Cat", Weight = 5 };
var Auto1 = new Veicolo("Toyota", "Yaris", 2025, "RoseGold");
var dip2 = new Dipendente("Laura", "Versace", 30, "Senior");


Console.WriteLine(animale1);
Auto1.Show();
dip2.Show();
atleta1.Show();