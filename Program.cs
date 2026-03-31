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

        List<Appareil> appareils = new List<Appareil>();
        appareils.Add(new Ordinateur("Lenovo", "ThinkPad", DateTime.Now, 15.6));
        appareils.Add(new Smartphone("Samsung", "Galaxy S21", DateTime.Now, 3));
        appareils.Add(new Ordinateur("Dell", "XPS 13", new DateTime(2020, 5, 15), 13.3));
        appareils.Add(new Smartphone("Apple", "iPhone 13", DateTime.Now, 3));
        appareils.Add(new Ordinateur("HP", "Spectre x360", new DateTime(2019, 10, 1), 14.0));
        appareils.Add(new Smartphone("Google", "Pixel 5", new DateTime(2021, 1, 1), 2));
        appareils.Add(new Smartphone("OPPO", "Find X3 Pro", new DateTime(2021, 3, 11), 4));
        appareils.Add(new Ordinateur("ASUS", "ROG Zephyrus G14", new DateTime(2020, 7, 1), 14.0));

        foreach (Appareil appareil in appareils)
        {
            appareil.Allumer();
            appareil.AfficherType();
            appareil.AfficherGarantie();
            appareil.AfficherInfo();
        }
    }
}
