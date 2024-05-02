namespace codeclash2;

class Program
{

    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int A = int.Parse(inputs[0]);
        int B = int.Parse(inputs[1]);

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        
        
        Console.WriteLine((A-B) + "" + (A+B));

    }
        
    }

