class CatalogueAppareils
{
    public Dictionary<string, Appareil> dictAppareils;

    public Dictionary<string, Appareil> GetDictAppareils()
    {
        return dictAppareils;
    }
    public void SetDictAppareils(Dictionary<string, Appareil> dictAppareils)
    {
        this.dictAppareils = dictAppareils;
    }

    public CatalogueAppareils( Dictionary<string, Appareil> dictAppareils)
    {
        this.dictAppareils = dictAppareils;
    }
    public CatalogueAppareils()
    {
        dictAppareils = new Dictionary<string, Appareil>();
    }

    public void AjouterAppareil(Appareil appareil)
    {
        try
        {
            dictAppareils.Add(appareil.GetModele(), appareil);
        }
        catch (ArgumentException)
        {
            Console.WriteLine($"Le modèle '{appareil.GetModele()}' existe déjà dans ce maghifique et carismatique catalogue.");
        }
    }

    public void AfficherApppareil(string modele)
    {
        try
        {
            Console.WriteLine(dictAppareils[modele]);
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine($"Le modèle '{modele}' ne se trouve pas dans le jolie petit catalogue.");
        }
    }

}