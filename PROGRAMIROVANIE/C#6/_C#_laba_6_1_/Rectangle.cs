
namespace Figure
{

    class Rectangle : Figure
    {

        private long side{ get; set; }

        public Rectangle( string newColor , long newSide ) : base( newColor )
        {

            side = newSide;

        }

        public override void WhatFigure()
        {

            Console.WriteLine( "This is Rectangle" );

        }

        public override void WhatSize()
        {

            Console.WriteLine( "The size of the rectangle is " + figureSize );

        }

    }

}