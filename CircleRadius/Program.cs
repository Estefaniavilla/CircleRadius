using CircleRadius.CalculateRadiusCircle;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the radius of the circle: ");
        double EnteredRadius = Convert.ToDouble(Console.ReadLine());

        
        Circle miCircle = new Circle(EnteredRadius);

        
        Console.WriteLine($"Circle Area: {myCircle.CalculateArea()}");
        Console.WriteLine($"Circumference of the circle: {myCircle.CalculateCircumference()}");
    }
}
