using myClass.Services;

SolveFunct solveFunct = new SolveFunct();

Console.Write( "Enter first num again( please ):\n" );
var firstNumNew = Console.ReadLine();

Console.Write( "Enter second num again( please ):\n" );
var secondNumNew = Console.ReadLine();

if( !solveFunct.Solve( firstNumNew , secondNumNew ) )
{

    Console.Write( "ERROR" );

}
else
{
    
    double firstNum, secondNum;

    bool rightFirstNum = double.TryParse( firstNumNew , out firstNum );  
    bool rightSecondNum = double.TryParse( secondNumNew, out secondNum );

    double x;

    if( secondNum < 1 )
    {

        x = firstNum * Math.Pow( secondNum , 3 );
        Console.Write( "Path is k * z ^ 3\n" );

    }
    else
    {

        x = secondNum * ( secondNum + 1 );
        Console.Write( "Path is z * ( z + 1 )\n" );

    }

    Console.WriteLine( "Result of this function is: " + Math.Pow( Math.Log( 1 + Math.Pow( x , 2 ) ) + Math.Cos( x + 1 ) , Math.Exp( x * firstNum ) ) );

}