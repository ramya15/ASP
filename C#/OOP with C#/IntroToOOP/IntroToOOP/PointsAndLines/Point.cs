class Point
{
    //Fields - camelCase
    private int x;
    private int y;
    public int z;

    //Properties - PascalCase
    //ShortCut: prop + Tab + Tab
    public int X
    {
        get
        {
            return x;
        }
        set
        {
            x = value;
        }
    }

    public int Y
    {
        get => y;
        set => value = y;
    }

    public Point() {}   //Default constructor
    public Point(int x, int y)
    {
        //this is mostly used when there is conflict of names
        this.x = x;
        this.y = y;
        z = y;
    }
}