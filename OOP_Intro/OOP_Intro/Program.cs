using System;

namespace OOP_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an object of my class
            //an instance of Human
            Human randy = new Human("Randy", "Bitts", "Brown", 50);
            //access publc variable in a separate class
            //randy.firstName = "Randy";
            //randy.lastName = "Bitts";
            randy.IntroduceMyself();  // call methods from a separate class

            Human laura = new Human("Laura","Washburn","Green", 46);
            laura.IntroduceMyself();

            Human cooper = new Human("Cooper", "Bitts", "Blue");
            cooper.IntroduceMyself();

            Human gracie = new Human("Gracie", "Bitts");
            gracie.IntroduceMyself();

            Human mae = new Human("Mae");
            mae.IntroduceMyself();

            Human michael = new Human("Michael", "Bitts", 20);
            michael.IntroduceMyself();

            // using constructors
            // parameterized constructor usage above
            // default constructor usage below
            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();



            Console.WriteLine("Hello World!");
        }
    }
}
