class Pipe
{
    public double Diameter {get;}
    public double PipeLength {get;}

    public Pipe(double diameter, double pipeLength)
    {
        Diameter = diameter;
        PipeLength = pipeLength;
    }

    public override string ToString()
    {
        return $"Rör - Diameter: {Diameter}cm, Längd: {PipeLength}m";
    }
}