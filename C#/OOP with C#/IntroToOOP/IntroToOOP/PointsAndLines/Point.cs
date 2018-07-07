using System;

class User
{
    //Fields - camelCase
    private string userName;
    private int password;

    //Properties - PascalCase
    //ShortCut: prop + Tab + Tab
    public string UserName
    {
        get
        {
            return "Username is " + userName;
        }
        set
        {
            if (value.Length >= 4 || value.Length <= 10)
                userName = value;
            else
                Console.WriteLine("Oops! Please enter username within 4 to 10 characters");
        }
    }

    public int Password
    {
        get => password;
        set
        {
            if (value >= 4 && value <= 10)
                password = value;
            else
                Console.WriteLine("Please enter password between 4 and 10");

        }
    }

    public User() {}   //Default constructor
    public User(string uname, int password)
    {
        //this is mostly used when there is conflict of names
        this.userName = uname;
        this.password = password;
    }
}