using System;

class Pentagon
{
    private double sideLength;

    public Pentagon(double sideLength)
    {
        this.sideLength = sideLength;
    }

    public double GetPerimeter()
    {
        return 5 * sideLength;
    }

    public double GetArea()
    {
        return (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * Math.Pow(sideLength, 2)) / 4;
    }

    public void Display()
    {
        Console.WriteLine("-------------------------");
        Console.WriteLine($"Side length: {sideLength}");
        Console.WriteLine($"Perimeter: {GetPerimeter():F3}");
        Console.WriteLine($"Area: {GetArea():F3}");
    }
}

    class RunPentagon
    {
        public static void Main()
    {
        Pentagon pentagon1 = new Pentagon(0);
        Console.WriteLine("Pentagon p1");
        pentagon1.Display();
        Console.WriteLine();

        Pentagon pentagon2 = new Pentagon(5);
        Console.WriteLine("Pentagon p2");
        pentagon2.Display();
    }
}
