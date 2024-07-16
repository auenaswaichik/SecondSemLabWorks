using Gang;

Complex a = new Complex( 1 , 2 );
Complex b = new Complex( 3 , 3 );

Console.WriteLine( "a == " + a );
Console.WriteLine( "b == " + b );

Console.WriteLine( "a + b == " + ( a + b ) );
Console.WriteLine( "a - b == " + ( a - b ) );
Console.WriteLine( "a / b == " + ( a / b ) );
Console.WriteLine( "a * b == " + ( a * b ) );

Console.WriteLine( "a + 2 == " + ( a + 2 ) );
Console.WriteLine( "a - 2 == " + ( a - 2 ) );
Console.WriteLine( "a / 2 == " + ( a / 2 ) );
Console.WriteLine( "a * 2 == " + ( a * 2 ) );

Console.WriteLine( "a == b - " + ( a == b ) );
Console.WriteLine( "a != b - " + ( a != b ) );
Console.WriteLine( "a >= b - " + ( a >= b ) );
Console.WriteLine( "a <= b - " + ( a <= b ) );
Console.WriteLine( "a > b - " + ( a > b ) );
Console.WriteLine( "a < b - " + ( a < b ) );

if( a )
    Console.WriteLine( "a is true" );
else
    Console.WriteLine( "a is false" );

if( b )
    Console.WriteLine( "b is true" );
else
    Console.WriteLine( "b is false" );

Console.WriteLine( "( double )a: " + ( double )a );
Console.WriteLine( "( double )a: " + ( double )b );
Console.WriteLine( "( Complex )13: " + ( Complex )13 );

