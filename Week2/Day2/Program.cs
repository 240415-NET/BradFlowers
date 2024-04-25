namespace Day2;

class Program
{
    static void Main(string[] args)
    {

    //    //Dynamically sized collection of objects of a single type.
    //    List<string> cityList = new List<string>();

    //    cityList.Add("Miami");
    //    cityList.Add("Tampa");
    //    cityList.Add("Sarasota");
    //    cityList.Add("Chicago");
    //    cityList.Add("Clearwater");

    //     //
    //    foreach(string city in cityList)
    //    {
    //        Console.WriteLine(city);
    //    }

        //Dictionary - This is dynamically sized collection that holds key-value pairs
        //keys must be unique
        //keys can also be any type - as long as it fits the type of the dictionary
        //This is an example of shortend object initializer, this and the above initializer for the list are equivalent
        
        // Dictionary<string, List<string>> petDictionary =new();

        // petDictionary.Add("Jonathan", new List<string>(){"Pancake", "Ellie"});
        // petDictionary.Add("Ross", new List<string>(){"Brody"});
        // petDictionary.Add("Mike", new List<string>(){"Carl"});
        // petDictionary.Add("Mike", new List<string>(){"Ziggie","Luna", "Amelia", "Pyewhacket", "Love Muffin"});

        // foreach(var person in petDictionary.Keys)
        // {
        //     foreach(var pets in petDictionary.Values);
      
        // }
        
        Dictionary<string, string> simplePets = new Dictionary<string, string>();
        simplePets.Add("Jonathan", "Pancake");
        simplePets.Add("Ross", "Brody");
        simplePets.Add("Mike", "Carl");
        simplePets.Add("Marcus", "Ziggie");

        foreach (var owner in simplePets)
        {
           //Console.Write(owner.GetType());
            Console.WriteLine(owner.Key + " owns " + owner.Value);
            
        }
        }

    }



