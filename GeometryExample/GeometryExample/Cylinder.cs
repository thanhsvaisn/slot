using System;

namespace GeometryExample
{
    internal class Cylinder
    {
        private double radius;
        private double height;
        private double baseArea, lateralArea, totalArea, volume;

        // Constructor
        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        // Method to calculate cylinder characteristics
        public void Process()
        {
            baseArea = radius * radius * Math.PI;
            lateralArea = 2 * Math.PI * radius * height;
            totalArea = 2 * Math.PI * radius * (height + radius);
            volume = Math.PI * radius * radius * height;
        }

        // Method to display the calculated results
        public void Result()
        {
            Console.WriteLine("Cylinder Characteristics:");
            Console.WriteLine($"Base Area: {baseArea:F2}");
            Console.WriteLine($"Lateral Area: {lateralArea:F2}");
            Console.WriteLine($"Total Area: {totalArea:F2}");
            Console.WriteLine($"Volume: {volume:F2}");
        }
    }

    