using System;

class User
{
    //Static fields
    public static int ID;

    //Fields - camelCase
    private string userName;
    private int password;

    #region Properties - PascalCase
    //ShortCut: prop + Tab + Tab
    public string UserName
    {
        //Read Only
        get
        {
            return "The username is " + userName;
        }
    }

    public int Password
    {
        //Write Only
        //get => password;
        set
        {
            if (value >= 4 && value <= 10)
                password = value;
            else
                Console.WriteLine("Please enter password between 4 and 10");

        }
    }
    #endregion

    #region Constructors

    public User() {}   //Default constructor
    public User(string userName)
    {
        //this is mostly used when there is conflict of names
        this.userName = userName;
    }

    #endregion
}