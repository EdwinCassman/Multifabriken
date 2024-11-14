class Candy
{
    public string Flavor {get;}
    public int Amount {get;}

    public Candy(string flavor, int amount)
    {
        Flavor = flavor;
        Amount = amount;
    }

    public override string ToString()
    {
        return $"Godis - Smak: {Flavor}, Antal: {Amount} stycken";
    }
}