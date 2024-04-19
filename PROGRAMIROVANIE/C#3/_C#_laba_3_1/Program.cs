using myClass;

FindMin findMin = new FindMin();

Console.Write( "Enter first num:\n" );
var firstNumer = Console.ReadLine();

Console.Write( "Enter second num:\n" );
var secondNumer = Console.ReadLine();

if( findMin.Find( firstNumer , secondNumer ) ==  false )
{

    Console.WriteLine( "ERROR" );

}
else
{

    int firstNum = int.Parse( firstNumer );
    int secondNum = int.Parse( secondNumer );

    Console.WriteLine( "Solution for function is: " + ( findMin.FindMIN( firstNum , 2 * secondNum + firstNum ) - findMin.FindMIN( 7 * firstNum + 2 * secondNum , secondNum ) ) );

}