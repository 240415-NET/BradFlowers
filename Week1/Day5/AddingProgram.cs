namespace Day5;

class AddingProgram
{
    static void Main(string[] args)
    {
        //This is just a flag for demo, that will be set to true if we catch an exception
        //and enter our CATCH block of code
        bool exceptionCaught = false;


        
        do
        
        // the code we want to sure doesn't crash our application
        try
        {

        //We call a method by referencing it's name.
        //Arguments for that method are separated by a comma
        //These arguments can be fields (or even other methods
        //Since method being called is within this program, it isn't necessary to use the class name(but this is an example)

        int firstnum = 0;
        int secondnum = 0;

        Console.WriteLine("Please enter your first number");
        firstnum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter your second number");
        secondnum = Convert.ToInt32(Console.ReadLine());

        int sum = AddingProgram.AddTwoNumbers(firstnum, secondnum);

        exceptionCaught = false;
        
        //Be mindful of scope. Because the try/catch/finally blocks all have their own individual scope, variables 
        //declared within them are not accessible outside of them
        //We have to keep track of of what line inside of where.  Here I have my numbers declared inside of my try block, 
        //so Main doesn't have access to them

        Console.WriteLine($"The sum of {firstnum} and {secondnum} is {sum}");

        }

        //catching a potentional exception, doing something with it
        catch(Exception Bradexception)
        {
            //I can print the exception's message to the user, in this case with an interpolated string
            Console.Clear();
            Console.WriteLine("An error occured");
            Console.WriteLine($"{Bradexception.StackTrace}");
            Console.WriteLine($"{Bradexception.Message}");
            Console.WriteLine("Please make sure to enter a number.  Try again.");

            exceptionCaught = true;

            
        
        }

        
        //this is optional. This code will excecute regardless of an exception running or not
        finally 
        {
            if(exceptionCaught)
            {
                Console.WriteLine("Program finished but had excpetions");
            } else
            {
                Console.WriteLine("Program finished without exceptions");
            }
        }
      while(exceptionCaught == true);


    }//end main scope

    //access modifier - return type - method name - arguments are give a type and a name like a field
    static int AddTwoNumbers(int num1, int num2)
    {
        //I can access arguments passed to the method
        int sum = num1 + num2;

        //return allows us to return something to where the method is called
        return sum; 
    }// end AddTwoNumbers scope

}
