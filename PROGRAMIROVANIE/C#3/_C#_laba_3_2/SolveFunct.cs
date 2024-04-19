using System;

namespace myClass.Services
{

    public class SolveFunct
    {

            public bool Solve( string firstNumStr , string secondNumStr )
            {

                double firstNum, secondNum;

                bool rightFirstNum = double.TryParse( firstNumStr , out firstNum );  
                bool rightSecondNum = double.TryParse( secondNumStr , out secondNum );

                if( rightFirstNum && rightSecondNum )
                {

                    return true;


                }
                else
                {

                    return false;

                }


            }

    }

}