using System;

class EntryPoint
{
    static void Main(string[] args)
    {
        Point point1 = new Point(5, 10);
        Point point2 = new Point
        {
            X = 1,
            Y = 2
        };

        System.Console.WriteLine(point1.X);
        System.Console.WriteLine(point1.Y);

        Console.WriteLine(point2.X);
        Console.WriteLine(point2.Y);

        Human human = new Human(10, 20);
        System.Console.WriteLine(human.Height);
        System.Console.WriteLine(human.Weight);
    }
}

//Constructor Demo
class Human
{
    public double Height;
    public double Weight;

    //Constructor
    public Human(double height, double weight)
    {
        Height = height;
        Weight = weight;
    }
}
