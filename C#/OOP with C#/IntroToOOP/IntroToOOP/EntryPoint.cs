class EntryPoint
{
    static void Main(string[] args)
    {
        Point point = new Point
        {
            x = 5,
            y = 10
        };

        System.Console.WriteLine(point.x);
        System.Console.WriteLine(point.y);

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
