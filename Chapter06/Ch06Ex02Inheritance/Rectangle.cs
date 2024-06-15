namespace Ch06Ex02Inheritance;

public class Rectangle : Shape
{
    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;
        Area = height * width;
    }
}
