using System;

class User
{
    //Static fields
    public static int currentID;

    //Fields - camelCase
    private string userName;
    private int password;
    private int id;

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

    public int Id
    {
        get
        {
            return id;
        }
        set
        {
            id = value;
        }
    }
    #endregion

    #region Constructors

    //Default constructor
    public User()
    {
        currentID++;
        id = currentID;
    }

    public User(string userName)
    {
        currentID++;
        id = currentID;
        //"this" keyword is mostly used when there is conflict of names
        this.userName = userName;
    }

    #endregion
}