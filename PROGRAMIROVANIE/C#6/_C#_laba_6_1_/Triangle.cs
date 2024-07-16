
namespace Figure
{

    sealed class Triangle : Figure
    {

        private long side{ get; set; }

        public Triangle( string newColor , long newSide ) : base( newColor )
        {

            side = newSide;

        }

        public override void WhatFigure()
        {

            Console.WriteLine( "This is Triangle" );

        }

    }

}