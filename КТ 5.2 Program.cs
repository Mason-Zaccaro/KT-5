public interface IShape
{
    double Area { get; }
    double Perimeter { get; }
}

public class Circle : IShape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double Area => Math.PI * radius * radius;
    public double Perimeter => 2 * Math.PI * radius;
}

public class Rectangle : IShape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public double Area => width * height;
    public double Perimeter => 2 * (width + height);
}

public class Triangle : IShape
{
    private double sideA;
    private double sideB;
    private double sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
    }

    public double Area
    {
        get
        {
            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }
    }

    public double Perimeter => sideA + sideB + sideC;
}

public class Program
{
    public static void Main()
    {
        IShape circle = new Circle(5);
        IShape rectangle = new Rectangle(4, 6);
        IShape triangle = new Triangle(3, 4, 5);

        Console.WriteLine($"Круг - Площадь: {circle.Area}, Периметр: {circle.Perimeter}");
        Console.WriteLine($"Прямоуголбник - Площадь: {rectangle.Area}, Периметр: {rectangle.Perimeter}");
        Console.WriteLine($"Треугольник - Площадь: {triangle.Area}, Периметр: {triangle.Perimeter}");
    }
}