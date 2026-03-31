class Ordinateur : Appareil
{
    private double tailleEcran;
    public double GetTailleEcran()
    {
        return tailleEcran;
    }
    public void SetTailleEcran(double tailleEcran)
    {
        this.tailleEcran = tailleEcran;
    }

    public Ordinateur(string marque, string modele, DateTime dateFabrication, double tailleEcran) : base(marque, modele, dateFabrication)
    {
        this.marque = marque;
        this.modele = modele;
        this.dateFabrication = dateFabrication;
        this.tailleEcran = tailleEcran;
    }
    public Ordinateur() : base()
    {
        this.marque = "Inconnu";
        this.modele = "Inconnu";
        this.dateFabrication = DateTime.Now;
        this.tailleEcran = 0;
    }

    public override string ToString()
    {
        return $"Marque : {marque} - Modèle : {modele} - Date de fabrication : {dateFabrication} - Taille de l'écran : {tailleEcran} pouces";
    }

    public override void AfficherType()
    {
        Console.WriteLine("je suis un ordinateur");
    }
    public override void AfficherGarantie()
    {
        Console.WriteLine("une garentie de 122 ans, C'EST DU JAMAIS VU, DU JAMAIS PROPOSÉ, DU JAMAIS ENTENDU, DU JAMAIS...");
    }
    public override void AfficherInfo()
    {
        Console.WriteLine($"Marque : {marque}");
        Console.WriteLine($"Modèle : {modele}");
        Console.WriteLine($"Date de fabrication : {dateFabrication}");
        Console.WriteLine($"Taille de l'écran : {tailleEcran} pouces");
        Console.WriteLine($"ancièneté : {DateTime.Now.Year - dateFabrication.Year} ans");
    }

    public override void CalculerAnciennete()
    {
        Console.WriteLine($"L'ordinateur a {DateTime.Now.Year - dateFabrication.Year} ans");
    }
}