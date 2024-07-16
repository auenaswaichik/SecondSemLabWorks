using LIL_YACHTY;

ITelevision firstTV = new OLED( "gangus" , "OLED" );
ITelevision secTV = new PDP( "echkere" , "PDP" );
ITelevision thirdTV = new LED( "vaibe" , "LED" );

Console.WriteLine( "First Tv info:\n" );
Console.WriteLine( firstTV.GetInfo() );
firstTV.ShowConnection( new SDI() );
OLED.CameraInfo();
OLED.BluetoothInfo();

Console.WriteLine( "\nSecond Tv info:\n" );
Console.WriteLine( secTV.GetInfo() );
secTV.ShowConnection( new HDMI() );
PDP.WIFIInfo();

Console.WriteLine( "\nThird Tv info:\n" );
Console.WriteLine( thirdTV.GetInfo() );
thirdTV.ShowConnection( new DVI() );
LED.OtherDeviceInfo();