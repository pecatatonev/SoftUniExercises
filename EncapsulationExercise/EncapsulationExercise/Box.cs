using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExercise
{
    public class Box
    {
        private const string PropertyValueExceptionMessage = "{0} cannot be zero or negative.";
        public Box(double lenght, double width, double height) 
        { 
            this.Length = lenght;
            this.Width = width;
            this.Height = height;
        }
		private double length;

		public double Length 
		{
			get { return length; }
			set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(PropertyValueExceptionMessage, nameof(Length)));
                }
                this.length = value;
            }
		}

        private double width;

        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(PropertyValueExceptionMessage,nameof(Width)));
                }
                this.width = value;
            }
        }

        private double height;

        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException (string.Format(PropertyValueExceptionMessage, nameof(Height)));
                }
                this.height = value;
            }
        }

        public double SurfaceArea() 
        {
            return 2* Length * Width + LateralSurfaceArea();
        }

        public double LateralSurfaceArea() 
        {
            return 2 * Length * Height + 2 * Width * Height;
        }

        public double Volume()
        {
            return Length * Width * Height;
        }
    }
}
