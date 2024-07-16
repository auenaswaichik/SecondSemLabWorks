namespace LIL_YACHTY;

public class OLED : ITelevision
{

    public string Name{ get; set; }
    public string Type{ get; set; }
    public OLED( string name, string description )
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

    public static void CameraInfo()
    {

        Console.WriteLine( "Camera is available" );

    }

    public static void BluetoothInfo()
    {

        Console.WriteLine( "Bluetoothe is not available" );

    }

}