namespace StringsAndChars;

class Program
{
    static void Main(string[] args)
    {
        // char[] hello_chars = { 'H', 'e', 'l', 'l', 'o' };
        // string hello_string = new string(hello_chars);
        // Console.WriteLine(hello_string);


        // string world_string = "World";
        // char[] world_chars = world_string.ToCharArray();
        // // Console.WriteLine(world_chars);


        //string methods
        // Console.WriteLine("Enter a word");
        // string new_word = Console.ReadLine();
        // Console.WriteLine("Your word is");
        // Console.WriteLine(new_word);

        // // string new_word_upper = new_word.ToUpper();
        // // Console.WriteLine(new_word_upper);

        // // Console.WriteLine(new_word_upper.ToLower());


        // // foreach (char c in new_word)
        // // {
        // //     Console.WriteLine(c);
        // // }

        // // for(int i = 1; i < new_word.Count(); i++)
        // // {
        // //     Console.WriteLine(new_word[i]);
        // // }

        // Console.WriteLine(new_word.Substring(0, 6));

        // {
        //     Console.WriteLine("Enter a name");
        //     string name = Console.ReadLine();

        //     if (name.ToLower().Contains("brad"))
        //     {
        //         Console.WriteLine("Hi Brad");
        //     }
        //     else
        //     {
        //         Console.WriteLine("You are not that guy");
        //     }
        // }

        Console.WriteLine("Enter a word");
        String word = Console.ReadLine().Trim();
        Console.WriteLine("your word is");
        Console.WriteLine(word);

    }
}
