using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Properties
{
    class Box
    {
        // member variables
        private int length = 3;  //every box will have a length of x
        private int height;
        //public int width;
        private int volume;

        public int FrontSurface
        { //this is ReadOnly because there is no Set{}
            get
            {
                return height * length;
            }

            //can also be get { return height * length; } 
        }

        // setting the property of a member variable
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }    
            }
        }

        //setting the property without a member variable
        // type "prop" and double tab and it will setup a default property
        public int Width { get; set; }  // does the same as below for Length but w/o member variable

        //constructor
        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            Width = width;  // "this" not required for a property
        }

        // encapsulation - allows control of how/when an objects variables and data is accessed
        public void SetLength(int length)
        {
            if(length < 0)
            {
                throw new Exception("Length should be higher than zero");
            }
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }

        public int GetVolume()
        {
            return this.length * this.Width * this.height;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Length is {length}, height is {height} and width is {Width} and volume is {volume = length*Width*height}.");

        }

        public int Volume
        {
            get
            {
                return this.length * this.Height * this.Width;
                //return volume;
            }
            /*set
            {
                this.volume = value;
            }*/
        }

    }
}
