using System;

class EntryPoint
{
    static void Main(string[] args)
    {
        User user = new User("Aaron");  //GET
        user.Password = 5;              //SET

        Console.WriteLine(user.UserName);
        //Static fields can be accessed directly from a class without instantiating it. 
        Console.WriteLine(user.Id);

        User user2 = new User();
        //Value of a static field is not dependent on class instance.
        //It is shared among all instances of class and they can modify/access it internally.
        Console.WriteLine(user2.Id);

        User user3 = new User();
        Console.WriteLine(user3.Id);
        Console.WriteLine(User.currentID);
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
