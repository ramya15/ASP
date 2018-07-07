using System;

class EntryPoint
{
    static void Main(string[] args)
    {
        User user = new User
        {
            UserName = "Aaron",
            Password = 5
        };

        Console.WriteLine(user.UserName);
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
