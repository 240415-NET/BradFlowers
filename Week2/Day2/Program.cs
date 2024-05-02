namespace Day2;

class Program
{
    static void Main(string[] args)
    {
        //Lists are dynamically sized collection of objects of a single data type

        List<string> bradslist = new();

        bradslist.Add("North Liberty");
        bradslist.Add("Coralville");
        bradslist.Add("Iowa City");
        bradslist.Add("Solon");



        foreach (string city in bradslist)
        {
            Console.WriteLine(city);
        }


        Dictionary<string, string> bradsdictionary = new();

        bradsdictionary.Add("IA", "Iowa");
        bradsdictionary.Add("IL", "Illinois");
        bradsdictionary.Add("MN", "Minnesota");
        bradsdictionary.Add("WI", "Wisconsin");
        bradsdictionary.Add("MO", "Missouri");

        //This is an example of of implicit typing using "var" in C#
        foreach (var StateAbbreviation in bradsdictionary)
        {
            Console.WriteLine("The state abbreviation " + StateAbbreviation.Key + " " + "is for the state of " + StateAbbreviation.Value);

        }

        // foreach (KeyValuePair<string, string> StateAbbreviation in bradsdictionary)
        // {
        //     Console.WriteLine("The state abbreviation " + StateAbbreviation.Key + " " + "is for the state of " + StateAbbreviation.Value);

        // }



    }
}



