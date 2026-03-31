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
    }
}
