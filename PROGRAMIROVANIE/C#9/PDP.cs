namespace LIL_YACHTY;

public class PDP : ITelevision
{

    public string Name{ get; set; }
    public string Type{ get; set; }
    public PDP( string name, string description )
    {

        Name = name;
        Type = description;

    }

    public string GetInfo()
    {

        return "Name of tv is " + Name + ", type of tv is " + Type;

    }
    public void ShowConnection( IConnection connection )
    {

        connection.HowConnect();

    }

    public static void WIFIInfo()
    {

        Console.WriteLine( "Wifi is available" );

    }

}