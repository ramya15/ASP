using System;

class EntryPoint
{
    static void Main(string[] args)
    {
        User user = new User("Aaron");  //GET
        user.Password = 5;              //SET
        Console.WriteLine(user.UserName);
        
        User user2 = new User();
        
        User user3 = new User();

        //Static fields can be accessed directly from a class without instantiating it. 
        //Value of a static field is not dependent on class instance.
        //It is shared among all instances of class and they can modify/access it internally.
        user.Id = 100;
        Console.WriteLine(user.Id);         //o/p: 100
        Console.WriteLine(user2.Id);        //o/p: 2
        Console.WriteLine(user3.Id);        //o/p: 3
        Console.WriteLine(User.currentID);  //o/p: 3
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
