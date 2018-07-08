using System;

class User
{
    #region Fields

    //Static fields
    public static int currentID;

    //2different kind of constants: const and read-only
    /* const: value hardcoded in the code
     * const must get its value the moment it is created
     * const will be static by default */
    public const int HEIGHT = 100;

    public readonly int height;

    //readonly: value assigned at runtime through code-logic. 
    public readonly int ID;

    //Fields - camelCase
    private string userName;
    private int password;

    public Race race;

    #endregion

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

    //Default constructor
    public User()
    {
        currentID++;
        ID = currentID;
    }

    public User(string uname)
    {
        currentID++;
        ID = currentID;
        this.userName = uname;
    }

    public User(string userName, Race race)
    {
        currentID++;
        ID = currentID;
        //"this" keyword is mostly used when there is conflict of names
        this.userName = userName;
        this.race = race;

        if (this.race == Race.Earthling)
            height = 100;
        else if (this.race == Race.Mersian)
            height = 180;

    }

    #endregion
}