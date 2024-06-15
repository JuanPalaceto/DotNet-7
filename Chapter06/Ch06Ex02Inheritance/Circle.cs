namespace Ch06Ex02Inheritance;

public class Circle : Shape
{
    public double Radio { get; set; }

    public Circle(double radio)
    {
        Height = radio * 2;
        Width = radio * 2;
        Radio = radio;
        Area = Math.PI * (radio * radio);
    }
}
