using System.Dynamic;
using Microsoft.VisualBasic;

namespace Day3.ToDoList
{

    public class ToDoItem
    {
        //These are the fields that will make up the shape of my object
        private string Description = "Default Description";
        private bool Status = false; //false is incomplete
        private int EstimatedTime = 60; //int in minutes
        private string DueDate = "4/30/2024";

        //Constructors

                public ToDoItem()
        {
            //This is the default constructor
        }


        public ToDoItem(string Description)
        {
            this.Description = Description;
        }

        public ToDoItem(string Description, int EstimatedTime, string DueDate) : this(Description)
        {
            //this.Description = Description;
            this.EstimatedTime = EstimatedTime;
            this.DueDate = DueDate;

        }

        public ToDoItem(string Description, int EstimatedTime, string DueDate, bool Status) : this(Description, EstimatedTime, DueDate)
        {
            // this.Description = Description;
            // this.EstimatedTime = EstimatedTime;
            // this.DueDate = DueDate;
            this.Status = Status;
        }





        //My methods are how I will interact with the objects, and how the objects will interact with each other
        public string GetDescription()
        {
            return this.Description;
        }

        public void SetDescription(string Description)
        {
            this.Description = Description;
        }

        public bool GetStatus()
        {
            return this.Status;
        }

        public void SetStatus(bool Status)
        {
            this.Status = Status;
        }

        public int GetEstimatedTime()
        {
            return this.EstimatedTime;
        }

        public void SetEstimatedTime(int EstimatedTime)
        {
            this.EstimatedTime = EstimatedTime;
        }

        public string GetDueDate()
        {
            return this.DueDate;
        }

        public void SetDueDate(string DueDate)
        {
            this.DueDate = DueDate;
        }


        //Override the ToString

        public override string ToString()

        // I don't want to return the boolean value in the ToString, so I created a string representing the status
        // of the bool.  It will default to false

        //If the todo item field is set to true then this status will evaluate
        //and update CurrentStatus to "Complete"
        {
            string CurrentStatus = "Incomplete";

            if (Status)
            {
                CurrentStatus = "Complete";
            }

            return $"{Description} - {DueDate}\nEstimated Time: {EstimatedTime}\n";

        }

        // public static void Main(string[] args)
        // {
        //     //     ToDoItem item1 = new ToDoItem();
        //     //     Console.WriteLine(item1);

        //     //     ToDoItem item2 = new ToDoItem("Do the dishes", 30, "5/30/2024", false);
        //     //     Console.WriteLine(item2);

        //     //     ToDoItem item3 = new ToDoItem("Do the laundry", 60, "5/30/2024", false);

        //     List<ToDoItem> ToDoList = new List<ToDoItem>();

        //     for (int i = 0; i < 3; i++)
        //     {

        //         Console.WriteLine("Type Description: ");
        //         string newDescription = Console.ReadLine();

        //         Console.WriteLine("Type Estimated Time: ");
        //         //int newEstimatedTime = Convert.ToInt32(Console.ReadLine());
        //         int newEstimatedTime = int.Parse(Console.ReadLine());

        //         Console.WriteLine("Type Due Date: ");
        //         string newDueDate = Console.ReadLine();

        //         ToDoItem newItem = new ToDoItem(newDescription, newEstimatedTime, newDueDate, false);

        //         Console.WriteLine(newItem);

        //         ToDoList.Add(newItem);
        //     }

        //     foreach (var item in ToDoList)
        //     {
        //         Console.WriteLine(item);
        //     }

            //organizing by UI into a class
            //Adding validation and checks for userinput and saving to my object
            //Adding a way to add items individually instead of x at a time
        // }
    }
}
