namespace tp_classe_abstraite;

class Program
{
    static void Main(string[] args)
    {
        Appareil ordi1 = new Ordinateur("Lenovo", "ThinkPad", DateTime.Now, 15.6);

        ordi1.Allumer();
        ordi1.AfficherType();
        ordi1.AfficherGarantie();
        ordi1.AfficherInfo();
        Console.WriteLine(ordi1);

        Smartphone phone1 = new Smartphone("Apple", "iPhone 13", DateTime.Now, 3);
        phone1.Allumer();
        phone1.AfficherType();
        phone1.AfficherGarantie();
        phone1.AfficherInfo();

        Ordinateur ordi2 = new Ordinateur("Dell", "XPS 13", new DateTime(2020, 5, 15), 13.3);
        Ordinateur ordi3 = new Ordinateur("HP", "Spectre x360", new DateTime(2019, 10, 1), 14.0);

        ordi2.CalculerAnciennete();
        ordi3.CalculerAnciennete();
    }
}
