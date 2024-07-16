using System;

namespace Figure
{

    abstract class Figure
    {

        protected long figureSize{ get ; set ; } = 1;
        protected string color { get; set; }
        protected bool isSpining{ get; set; } = true;

        public Figure( string newColor )
        {

            color = newColor;

        }

        abstract public void WhatFigure();

        virtual public void WhatSize()
        {

            Console.WriteLine( "The size of the figure is " + figureSize );

        }

    }

}