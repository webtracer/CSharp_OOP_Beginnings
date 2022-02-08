using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Intro
{
    //blueprint for a datatype
    class Human
    {
        //member variable
        //if you do not put "public" in front of the variable you cannot manipulate it from outside the class without a constructor.  firstName changed to private due to constructor
        // assigning a value here assigns it to every call unless specifically changed outside this
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        //default constructor
        public Human()
        {
            Console.WriteLine("Constructor called, object created");
        }

        //parameterized constructor
        // contructor - if it is not public you cannot use it
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            //without "this." the variables above would have to be different than the globals
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public Human(string firstName, string lastName, string eyeColor)
        {
            //without "this." the variables above would have to be different than the globals
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        public Human(string firstName, string lastName, int age)
        {
            //without "this." the variables above would have to be different than the globals
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        //member method - public makes it accessible from outside the class
        public void IntroduceMyself()
        {
            if(age != 0 && eyeColor != null && lastName != null && firstName != null)
            {
                // constructor with all data was used
                Console.WriteLine($"Hi, I'm {firstName} {lastName}.  My eyes are {eyeColor} and I am {age} years old");
            }
            else if(eyeColor != null && lastName != null && firstName != null)
            {
                // constructor without the age was used
                Console.WriteLine($"Hi, I'm {firstName} {lastName}.  My eyes are {eyeColor}.");
            }
            else if(lastName != null && firstName != null)
            {
                // constructor without eyecolor was used
                Console.WriteLine($"Hi, I'm {firstName} {lastName}. I am {age} years old");
            }
            else if (age != 0 && lastName != null && firstName != null)
            {
                // constructor without the age was used
                Console.WriteLine($"Hi, I'm {firstName} {lastName}.  My eyes are {eyeColor}.");
            }
            else
            {
                // constructor with only the first name was used
                Console.WriteLine($"Hi, I'm {firstName}.");
            }
        }


    }
}
