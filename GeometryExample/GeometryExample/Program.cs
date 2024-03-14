using GeometryExample;

class Program
{
    static void Main(string[] args)
    {
        // Prompt user to input dimensions
        Console.WriteLine("Enter the dimensions of the cylinder:");
        Console.Write("Radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        Console.Write("Height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Create Cylinder object
        Cylinder cylinder = new Cylinder(radius, height);

        // Process and display the results
        cylinder.Process();
        cylinder.Result();
    }
}
}
