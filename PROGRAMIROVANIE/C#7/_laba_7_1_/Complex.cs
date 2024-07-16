using static System.Math;
namespace Gang
{
    class Complex
    {
        private double first;
        private double second;
        public Complex()
        {
            First = 0;
            Second = 0;
        }
        public Complex( double newFirst , double newSecond )
        {
            First = newFirst;
            Second = newSecond;
        }
        public override string ToString()
        {
            return $"{First} + i * {Second}";
        }
        public double First
        {
            get => first;
            set => first = value;
        }
        public double Second
        {
            get => second;
            set => second = value;
        }
        public double Modal()
        {
            return First * First + Second * Second;
        }
    // operators
        // two complex
        public static Complex operator +( Complex compFirst , Complex compSecond )
        {
            return new Complex( compFirst.First + compSecond.First , compFirst.Second + compSecond.Second );
        }
        public static Complex operator -( Complex compFirst , Complex compSecond )
        {
            return new Complex( compFirst.First - compSecond.First , compFirst.Second - compSecond.Second );
        }
        public static Complex operator *( Complex compFirst , Complex compSecond )
        {
            return new Complex( compFirst.First * compSecond.First - compFirst.Second * compSecond.Second , compFirst.First * compSecond.Second + compFirst.Second * compSecond.First );
        }
        public static Complex operator /( Complex compFirst , Complex compSecond )
        {
            return new Complex( ( compFirst.First * compSecond.First + compFirst.Second * compSecond.Second ) / ( compSecond.First * compSecond.First + compSecond.Second * compSecond.Second ) , ( - compFirst.First * compSecond.Second + compFirst.Second * compSecond.First ) / ( compSecond.First * compSecond.First + compSecond.Second * compSecond.Second ) );
        }
        // complex and double
        public static Complex operator +( Complex compFirst , double numSecond )
        {
            return new Complex( compFirst.First + numSecond , compFirst.Second );
        }
        public static Complex operator -( Complex compFirst , double numSecond )
        {
            return new Complex( compFirst.First - numSecond , compFirst.Second );
        }
        public static Complex operator *( Complex compFirst , double numSecond )
        {
            return new Complex( compFirst.First * numSecond , compFirst.Second * numSecond );
        }
        public static Complex operator /( Complex compFirst , double numSecond )
        {
            return new Complex( compFirst.First / numSecond , compFirst.Second / numSecond );
        }
        // bool gang
        public static bool operator ==( Complex compFirst , Complex compSecond )
        {
            return compFirst.Modal() == compSecond.Modal();
        }

        public static bool operator !=( Complex compFirst , Complex compSecond )
        {
            return compFirst.Modal() != compSecond.Modal();
        }
        public static bool operator >=( Complex compFirst , Complex compSecond )
        {
            return compFirst.Modal() >= compSecond.Modal();
        }

        public static bool operator <=( Complex compFirst , Complex compSecond )
        {
            return compFirst.Modal() <= compSecond.Modal();
        }
        public static bool operator <( Complex compFirst , Complex compSecond )
        {
            return compFirst.Modal() < compSecond.Modal();
        }
        public static bool operator >( Complex compFirst , Complex compSecond )
        {
            return compFirst.Modal() > compSecond.Modal();
        }
        public static bool operator true( Complex comp )
        {
            return comp.First != 0 || comp.Second != 0;
        }
        public static bool operator false( Complex comp )
        {
            return comp.First == 0 && comp.Second == 0;
        }
        // conv
        public static explicit operator double( Complex comp )
        {
            return Math.Sqrt( comp.Modal() );
        }
        public static implicit operator Complex( double d )
        {
            return new Complex( d , 0 );
        }
    };
}