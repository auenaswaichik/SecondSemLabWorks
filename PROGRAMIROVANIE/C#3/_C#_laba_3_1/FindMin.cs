using System;

namespace myClass
{

    public class FindMin
    {

        public bool Find( string firstNumStr , string secondNumStr )
        {

            int firstNum, secondNum;

            bool rightFirstNum = int.TryParse( firstNumStr , out firstNum );  
            bool rightSecondNum = int.TryParse( secondNumStr , out secondNum );

            if( rightFirstNum && rightSecondNum )
            {

                return true;

            }
            else
            {

                return false;

            }


        }

        public int FindMIN( int x , int y )
        {

            return x > y ? y : x;

        }

    }

}