namespace Ch06Ex02Inheritance;

public class Square : Shape
{
    public Square(double lado)
    {
        Height = lado;
        Width = lado;
        Area = lado * lado;
    }
}
