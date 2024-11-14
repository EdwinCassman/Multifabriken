class Car
{
    public string RegNumber {get;}
    public string CarColor {get;}
    public string CarBrand {get;}

    public Car(string regNumber, string carColor, string carBrand)
    {
        RegNumber = regNumber;
        CarColor = carColor;
        CarBrand = carBrand;
    }

    public override string ToString()
    {
        return $"Bil - Registreringsnummer: {RegNumber}, Färg: {CarColor}, Märke: {CarBrand}";
    }
}