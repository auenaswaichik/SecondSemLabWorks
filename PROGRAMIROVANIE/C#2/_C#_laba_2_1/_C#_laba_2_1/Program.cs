namespace _C__laba_2_1
{
    internal class Program
    {

        private static void Main()
        {

            long x;
            string s;

            while( true ){

                Console.WriteLine("Enter value of X:");                
                x = GetIfNum();

                switch( x % 2 )
                {

                    case 0:
                        {

                            Console.WriteLine( "X is even number" );
                            break;

                        }

                    default:                        
                        {

                            Console.WriteLine( "X is odd number" );
                            break;

                        }

                }

                Console.WriteLine( "\nDo you want to continue?[Y/n]");
                s = Console.ReadLine();
                if( s != "Y" && s != "y" ){

                    break;

                }

                Console.WriteLine();

            }

        }

        private static int GetIfNum()
        {
            int num;

            while ( !int.TryParse(Console.ReadLine(), out num ))
            {

                Console.WriteLine("Incorrect input. Try again:)");

            }

            return num;
        }

    }
}