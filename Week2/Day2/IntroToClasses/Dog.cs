namespace IntroToClasses
{
    public class Dog
    {
        //A class has members, which are fields(variables) and methods


        //Fields

        //We need to give our fields and methods access modifiers so we can control who can access them
        //The most common are pblic, private, and protected
        //definitions in Week 2 notes



        //Instance Fields
        public string name { get; set; }
        public string breed { get; set; }

        //Static Fields

        public static int numberOfLegs = 4;
        public static bool hasTail = true;

        public int age
        {
            get { return age; }
            set { age = value; }

        }


        public string gender { get; set; }
        public double weight { get; set; }






        //Methods   
        //This is an example of an instance method. It is called via dot notation on an instance of the class
        public void Noise()
        {
            Console.WriteLine($"{name} says Woof! Woof!");
        }

        //This is an example of a static method
        //W call it by referencing the class name, not an object of the class

        public static void WhatIsADog()

        {
            //The @ in front of the string turns it into a verbatim string.  This lets us spread a long line of code across multiple lines
            Console.WriteLine(@"An animal that walks on four legs and likes people
            blah blah blah
            blah blah blah");
        }

    }
}

