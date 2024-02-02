using System;
namespace RectangleCalculator
{
	public class Rectangle
	{
        private int width;
        private int length;

        public Rectangle()
		{
			this.width = 1;
			this.length = 1;
		}

		public Rectangle(int width, int length)
		{
			this.width = width;
			this.length = length;
		}

		public int GetLength()
		{
			return this.length;
		}

        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }

        public int GetWidth()
        {
            return this.width;
        }

        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }

        public int GetPerimeter()
        {
            return (this.length + this.width) * 2;
        }

        public int GetArea()
        {
            return this.length * this.width;
        }

    }
}

