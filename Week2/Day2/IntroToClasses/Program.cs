namespace IntroToClasses;

class Program
{
    static void Main(string[] args)
    {
        //Here we are creating an object of class Dog.  Puppy is the object(pick whatever name), Dog is the class
        //new Dog() is the constructor of the class Dog
        Dog Puppy = new Dog();

        Console.WriteLine("What is the dog's name?");
        //Here we are setting the name field of the object Puppy
        Puppy.name = Console.ReadLine();

        //Here we can an instance method - this method needs an object of class Dog to be called
        Puppy.Noise();

        Dog.WhatIsADog();






    }
}
