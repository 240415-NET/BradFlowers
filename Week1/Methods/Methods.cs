﻿namespace Method;

class AddingProgram
{
    static void Main(string[] args)
    {   
        //This is just a flag for our demo, that will be set to true, if we catch an exception
        //and enter our catch block of code
        bool caught = false;


        try //the code we want to make sure doesn't crash our application
        {   
            //We call a method by referencing it's name.
            //Arguments for that method are separated by a comma.
            //These arguments can be fields (or even other methods!)
            Console.WriteLine("Please enter a number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter another number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());


            //Be mindful of scope! Because the try/catch/finally blocks all have their own individual scopes
            //We have to keep track of what lives inside of where. Here I have my numbers declared inside
            //of my try block, so Main doesn't have access to them.

            Console.WriteLine($"The sum of {firstNum} and {secondNum} is: {AddTwoNumbers(firstNum, secondNum)}");
        }
        catch (FormatException myException) //We can have multiple catches, but we want to make sure we go from More Specific to Least Specific
        {
            
        }
        catch (Exception myException) //catching a potential exception, doing something if/when we do
        {
            //I can print the exception's message to the use, in this case with an interpolated string
            Console.Clear();
            Console.WriteLine($"{myException.Message}");
            Console.WriteLine($"{myException.StackTrace}");
            Console.WriteLine("Please make sure you enter an integer value!");

            caught = true;
        }
        finally //this is optional, this code will execute regardless of an exception running or not
        {
            if(caught)
            {
                Console.WriteLine("Program successfully finished despite the exception!");
            }else
            {
                Console.WriteLine("Program ran without exceptions! ");
            }
        }

        //int sum = AddingProgram.AddTwoNumbers(firstNum, secondNum);

        //This is an example of string interpolation using $
        //We can call methods within the curly braces as well!
        


    }//end Main scope

    //(access modifier) (return type) (arguments) - arguments are given a type, and a name like a field
    static int AddTwoNumbers(int num1, int num2)
    {

        if(num1 == num2)
        {   
            //I can access arguments passed into my method within the method's block of code
            return num1 * 2;
        }else{
            //return allows us to return something (value, object, etc) to where this method was called
            return num1 + num2;
        }

        //This code is unreachable - nothing will break but why did we write this code?
        Console.WriteLine("");
        
        //int sum = num1 + num2;

        
        
    
    }//end AddTwoNumbers scope

}