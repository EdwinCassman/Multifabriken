class Milk
{
    public double FatPercentage {get;}
    public double Litres {get;}

    public Milk(double fatPercentage, double litres)
    {
        FatPercentage = fatPercentage;
        Litres = litres;
    }

    public override string ToString()
    {
        return $"Havremjölk - Fetthalt: {FatPercentage}%, Liter: {Litres}L";
    }
}