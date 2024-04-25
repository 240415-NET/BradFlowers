using System.Diagnostics;

namespace codetesting;

class Program
{
    static void Main(string[] args)
    // {   

    //     string example = "Brad";
    //     string declare;
    //     declare = "Calling it later";
    //             Console.WriteLine("Hello");
    //             Console.WriteLine(example);
    //             Console.WriteLine(declare);
    
        

 
    // {

    //     string name;

    //     Console.WriteLine("what is your name?");
    //     name = Console.ReadLine();
    //     Console.WriteLine("Hello " + name);
    // }
    

    // {

    //     //(IF - ELSE) AND (IF - ELSE IF -ELSE) STATEMENTS

    //     Console.WriteLine("Please enter a number");

    //     int newInt = Convert.ToInt32(Console.ReadLine());

    //     if (newInt == 4)
    //     {
    //         Console.WriteLine("newInt equals 4");
    //     }
        
    //     else if (newInt >= 8)
    //     {
    //         Console.WriteLine("newInt is greater than or equal to 8");
    //     }
        
    //     else if (newInt < 0)
    //     {
    //         Console.WriteLine("newInt is negative!");
    //     }
        
    //     else
    //     {
    //         Console.WriteLine("newInt is a number");
    //     }
   
    // }
    // // }
    
    //We can address the above logic in a cleaner manner using a SWITCH statement

    // Console.WriteLine("Please enter a number for the SWITCH:");
    // int switchInt = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("Please enter a number");
    // int newInt = Convert.ToInt32(Console.ReadLine());


    // switch(switchInt)

    // {
    //     case 1 or 2:  //If switchInt is equal to 1 or 2, run the code below until we hit the break statement
       
    //     Console.WriteLine("switchInt is equal to 1 or 2!");
    //        break;
    //     case >= 8 and <= 15:
    //     Console.WriteLine("switchInt is greater than 7 and less than 16!");
    //         break;
    //     case < 0:
    //     Console.WriteLine("switchInt is negative!");
    //         break;
    //     default:
    //     Console.WriteLine("switchInt is a number");
    //         break;

    // }
    // if (newInt >3 && switchInt >3)
    // {
    //     Console.WriteLine("Both variables are greater than 3");
    // }
    // else if (newInt < -2 && !(newInt == 5 || switchInt == 2))
    // {
    //     Console.WriteLine("This is a complicated condition!");
    // }
    // else
    // {
    //     Console.WriteLine("This is the end of the block");    
    // }
    // }


    //loops

    // int bradsloop =  5;
    
    // for(int i = 0; i < bradsloop; i++)
    // {
    //     //This code will run as long as the above condition is met
    //     //Here, we use string concatentation for i+1 to our string formatting

    //     Console.WriteLine((i+1 + ". This is coming from my for loop"));
    // }
    

    //while loop
    //while loop check a condition THEN runs the code
    // int newInt = 5;


    // while(newInt > 0)
    // {Console.WriteLine(newInt);
        
    //     //all of these are options to decrement the value of newInt
    //     //newInt = newInt -1;
    //     //newInt--;
    //     newInt -= 1;
    // }




    //do-while loop
    //do-while loop runs the code THEN checks the condition
    //It will always run  AT LEAST once
    // {
    // int newerInt = 2;
    
    // do
    // {
    //     Console.WriteLine("this is from inside my do-while loop");
    // newerInt = newerInt -1;
    // }

    // while
    // (newerInt > 0);
       
    // }

        {
        int Bradsnumber = 50;

        do
        {Console.WriteLine("This is " + Bradsnumber);
        Bradsnumber = Bradsnumber - 5;
        }

        while (Bradsnumber > 0);
        {
            Console.WriteLine("The end");
            ;
        }
        
    }


}






