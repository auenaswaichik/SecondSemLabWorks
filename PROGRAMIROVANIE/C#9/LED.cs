namespace LIL_YACHTY;

public class LED : ITelevision
{

    public string Name{ get; set; }
    public string Type{ get; set; }
    public LED( string name, string description )
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

    public static void OtherDeviceInfo()
    {

        Console.WriteLine( "You can connect other devices to this TV" );

    }

}