namespace TrackMyStuff.Models;

public class Item
{
    public int userId {get; private set;}
    public int itemId {get; private set;}
    public string category {get; set;}
    public double originalCost {get; set;}
    public DateTime purchaseDate {get; set;}
    public string description {get; set;}

    
    
}