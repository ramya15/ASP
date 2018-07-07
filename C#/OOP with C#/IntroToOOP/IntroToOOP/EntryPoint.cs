using System;

class EntryPoint
{
    static void Main(string[] args)
    {
        User user = new User("Aaron");  //GET
        user.Password = 5;              //SET

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
