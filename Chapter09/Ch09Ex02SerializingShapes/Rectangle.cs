using Packt.Shared;

public class Rectangle : Shape
{
    public override double Area => Height * Width;

    //Equivalente a lo de arriba
    //public override double Area
    //{

    //    get
    //    {
    //        return Height * Width;
    //    }
    //}

    public double Height { get; set; }
    public double Width { get; set; }
}