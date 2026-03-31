class Smartphone : Appareil
{
    private int nbCapteursPhoto;

    public int GetNbCapteursPhoto()
    {
        return nbCapteursPhoto;
    }
    public void SetNbCapteursPhoto(int nbCapteursPhoto)
    {
        this.nbCapteursPhoto = nbCapteursPhoto;
    }

    public Smartphone(string marque, string modele, DateTime dateFabrication, int nbCapteursPhoto) : base(marque, modele, dateFabrication)
    {
        this.marque = marque;
        this.modele = modele;
        this.dateFabrication = dateFabrication;
        this.nbCapteursPhoto = nbCapteursPhoto;
    }
    public Smartphone() : base()
    {
        this.marque = "Inconnu";
        this.modele = "Inconnu";
        this.dateFabrication = DateTime.Now;
        this.nbCapteursPhoto = 0;
    }

    public override string ToString()
    {
        return $"Marque : {marque} - Modèle : {modele} - Date de fabrication : {dateFabrication} - Nombre de capteurs photo : {nbCapteursPhoto}";
    }

    public override void AfficherGarantie()
    {
        Console.WriteLine("une petite garentie de 3 mois... 3 mois ? c'est tout !? c'est vraimant honteux !"); 
    }

    public override void AfficherInfo()
    {
        Console.WriteLine($"Marque : {marque}");
        Console.WriteLine($"Modèle : {modele}");
        Console.WriteLine($"Date de fabrication : {dateFabrication}");
        Console.WriteLine($"Nombre de capteurs photo : {nbCapteursPhoto}");
        Console.WriteLine($"ancièneté : {DateTime.Now.Year - dateFabrication.Year} ans");
    }

    public override void CalculerAnciennete()
    {
        Console.WriteLine($"Le smartphone a {DateTime.Now.Year - dateFabrication.Year} ans");
    }
}