using System.Globalization;

namespace myClass
{

    public class DateServise
    {

        private bool CheckDate( string yearString , string monthString , string dayString )
        {
            int day, month, year;
         
            bool rightInputYear = int.TryParse( yearString , out year );
         
            if (rightInputYear)
            {
         
                year = int.Parse( yearString );

                if (year < 0 || year > 3000) 
                    return false;
         
            }
            else
            {

                return false;

            }

            bool rightInputMonth = int.TryParse( monthString , out month );

            bool rightInputDay = int.TryParse( dayString , out day );

            if (rightInputMonth && rightInputDay && rightInputYear)
            {
                month = int.Parse( monthString );

                day = int.Parse( dayString );

                if (month < 1 || month > 12) 
                    return false;
                
                if ( month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12 )
                    if (day < 1 || day > 31) 
                        return false;
                else if (month == 2)
                {

                    if ( year % 4 == 0  )
                    {

                        if (day < 1 || day > 29) 
                            return false;
                    
                    }
                    else
                    {
                    
                        if (day < 1 || day > 28) 
                            return false;
                    
                    }

                }
                else
                {
                   
                    if (day < 1 || day > 30) 
                        return  false;
                
                }
            
            }

            return ( rightInputMonth && rightInputDay && rightInputYear );

        }

        public string GetDay( string yearString , string monthString , string dayString )
        {

            if( CheckDate( yearString , monthString , dayString ) )
            {

                try
                {
                    string Date = yearString + "-" + monthString + "-" + dayString;
                    return Date;
                }
                catch( System.FormatException )
                {

                    return "0";

                }
            }
            else
            {

                return "0";

            }

        }

        public double GetDaySpan( string yearString , string monthString , string dayString )
        {

            if( CheckDate( yearString , monthString , dayString ) )
            {

                try
                {
                
                    int year = int.Parse( yearString );
                    int month = int.Parse( monthString );
                    int day = int.Parse( dayString );

                    DateTime currentDay = DateTime.Now;
                    DateTime enteredDay = new DateTime( year , month , day );

                    TimeSpan timeSpan = enteredDay - currentDay;

                    return Math.Abs( timeSpan.Days );

                }
                catch( System.ArgumentOutOfRangeException )
                {

                    return -1;

                }

            }
            else
            {

                return -1;

            }

        }

    }

}