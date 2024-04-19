using myClass;
using System;
using System.Globalization;

DateServise dateServise = new DateServise();

Console.Write( "Enter year:\n" );
var yearString = Console.ReadLine();

Console.Write( "Enter month:\n" );
var monthString = Console.ReadLine();

Console.Write( "Enter day:\n" );
var dayString = Console.ReadLine(); 


if ( dateServise.GetDaySpan( yearString , monthString , dayString ) > 0 && dateServise.GetDay( yearString , monthString , dayString ) != "0" )
{

    string Date = dateServise.GetDay( yearString , monthString , dayString );
    DateTime dateTime = DateTime.Parse( Date , CultureInfo.InvariantCulture );

    Console.WriteLine( "Day is " + Date + ", it is " + dateTime.DayOfWeek );
    Console.WriteLine( "Difference between current and entered day is " + dateServise.GetDaySpan( yearString , monthString , dayString ) + " day(s)" );

}
else
{

    Console.WriteLine( "ERROR" );

}