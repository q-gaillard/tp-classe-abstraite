using System.Reflection.Metadata.Ecma335;

abstract class Appareil
{
    protected string marque;
    protected string modele;
    protected DateTime dateFabrication;

    public string GetMarque()
    {
        return marque;
    }
    public string GetModele()
    {
        return modele;
    }
    public DateTime GetDateFabrication()
    {
        return dateFabrication;
    }

    public void SetMarque(string marque)
    {
        this.marque = marque;
    }
    public void SetModele(string modele)
    {
        this.modele = modele;
    }
    public void SetDateFabrication(DateTime dateFabrication)
    {
        this.dateFabrication = dateFabrication;
    }

    public Appareil(string marque, string modele, DateTime dateFabrication)
    {
        this.marque = marque;
        this.modele = modele;
        this.dateFabrication = dateFabrication;
    }
    public Appareil()
    {
        this.marque = "Inconnu";
        this.modele = "Inconnu";
        this.dateFabrication = DateTime.Now;
    }

    public void Allumer()
    {
        Console.WriteLine("L'appareil s'allume avec classe et de manière dignité...");
    }
    public virtual void AfficherType()
    {
        Console.WriteLine("je suis un appareil");
    }
    public virtual void AfficherGarantie()
    {
        Console.WriteLine("une garentie ma fois fort banale et ordinaire...");
    }

    public abstract void AfficherInfo();
    public abstract void CalculerAnciennete();
}