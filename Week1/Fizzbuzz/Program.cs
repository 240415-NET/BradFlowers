namespace Fizzbuzz;

class Program
{
    static void Main(string[] args)
    {
        int bradsnumber = 100;

        for (int num = 1; num <=  bradsnumber; ++num)
        {
            if (num % 5 == 0 && num % 3 == 0)
            {
                Console.WriteLine("Fizzbuzz");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine(num);
            }
        }
    }

}