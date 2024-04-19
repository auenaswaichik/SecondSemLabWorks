namespace _C__laba_2_2
{
    internal class Program
    {
        private static void Main()
        {

            double x, y;

            string s;

            long checkNum;

            while( true ){

                Console.WriteLine("Enter value of X:");                
                x = GetIfNum();

                Console.WriteLine("\nEnter value of Y:");                
                y = GetIfNum();        
 
                if( x * x + y * y < 100.0 && x * x > y * y ){

                    checkNum = 0;

                }else if( x * x + y * y == 100 || ( x * x + y * y < 100 && x * x == y * y ) ){

                    checkNum = 1;

                }else{

                    checkNum = 2;

                }

                switch( checkNum ){

                    case 0:
                        {

                            Console.WriteLine( "It is inside shape" );
                            break;

                        }
                    case 1:
                        {

                            Console.WriteLine( "It is on the border of the shape" );
                            break;

                        }
                    case 2:
                        {

                            Console.WriteLine( "It is outside shape" );
                            break;

                        }

                }

                Console.WriteLine( "\nDo you want to continue?[Y/n]" );
                s = Console.ReadLine();
                if( s != "Y" && s != "y" ){

                    break;

                }

                Console.WriteLine();

            }

        }

        private static double GetIfNum()
        {
            double num;

            while ( !double.TryParse(Console.ReadLine(), out num ))
            {

                Console.WriteLine("Incorrect input. Try again:)");

            }

            return num;
        }


    }
}