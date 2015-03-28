using System;

namespace Problem01Shapes
{
    public abstract class Shape
    {
        private double width;
        private double height;
        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Cannot be zero or negative");
                }
                this.width = value;
            }
        }
        public double Height
        {
            get { return this.height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Cannot be zero or negative");
                }
                this.height = value;
            }
        }
        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public abstract double CalculateSurface();
    }
}
