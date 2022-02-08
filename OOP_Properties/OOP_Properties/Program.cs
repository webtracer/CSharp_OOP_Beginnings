using System;

namespace OOP_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a Box object
            Box box = new Box(3,4,5);
            // with a constructor in place variable setting not necessary like this
            //box.length = 3;  // setting
            //box.SetLength (4);
            //box.height = 4;
            //box.Height = -4;  // using properties of the member class
            //box.width = 5;
            //box.Width = 5;


            Console.WriteLine($"Box length is {box.GetLength()}");  // getting
            box.Width = 10;
            Console.WriteLine($"Boxes width is {box.Width}");
            Console.WriteLine($"Boxes volume is {box.Volume}");
            Console.WriteLine($"The front surface of the box is {box.FrontSurface}");
            box.DisplayInfo();




            Console.WriteLine("Hello World!");
        }
    }
}
