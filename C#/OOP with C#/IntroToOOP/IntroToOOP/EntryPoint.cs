using System;

class EntryPoint
{
    static void Main(string[] args)
    {
        User user = new User("Aaron");  //GET
        user.Password = 5;              //SET

        Console.WriteLine(user.UserName);

        Console.WriteLine(User.ID); //Static fields can be accessed directly from a class without instantiating it. 
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
