﻿using IntroToOOP;
using System;

class EntryPoint
{
    static void Main(string[] args)
    {
        //enum
        User user = new User("Klen", Race.Mersian);
        
        #region Getter/Setter sample code
        User user1 = new User("Aaron");  //GET
        user1.Password = 5;              //SET
        Console.WriteLine(user1.UserName);
        #endregion

        #region Static fields sample code
        User user2 = new User();
        User user3 = new User();

        //Static fields can be accessed directly from a class without instantiating it. 
        //Value of a static field is not dependent on class instance.
        //It is shared among all instances of class and they can modify/access it internally.

        //No longer possible as ID can now be assigned during runtime via Constructor/during variable initialization
        //user1.ID = 100; //Modification of static field is not a good idea. Hence use: const/read-only
        Console.WriteLine(user1.ID);        //o/p: 1
        Console.WriteLine(user2.ID);        //o/p: 2
        Console.WriteLine(user3.ID);        //o/p: 3
        Console.WriteLine(User.currentID);  //o/p: 3
        Console.WriteLine(User.HEIGHT);     //CONST: 100
        #endregion

        //Static Class 
        Utilities.ColorWriteLine(user.UserName, ConsoleColor.DarkYellow);
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
