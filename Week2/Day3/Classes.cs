namespace Day3.Classes
{
    public class ExampleClass
    {
        //Fields
        //Unique to each instance of a type
        //allowing individual objects to maintain distinct values

        public string exampleString;


        //Static Fields
        //Belong to the type/class itself
        //Shared across all instances of the type/class
        //Accessible only thru the type name

        public static int instanceCount;

        public readonly int maxLimit = 100;

        //Object Initializer
        //Allows properties to be initialized without calling constructors explicitly

        public string Name { get; set; }
        public int Age { get; set; }



    }


    public class Person
    {

        //These are fields
        private string FirstName = "John";
        private string LastName = "Doe";
        private string Email = "johndoe@johndoe.com";
        private int Age = 18;
        private bool OnHoliday = false;

        //Constructor
        //Constructors are special methods used to initialize a new instance of a class
        //They are called at the time an object is created and can be use to set initial values or perform any set up required before the object is used


        //This is the default constructor that is constructed for us when we run our code
        //It will do nothing more than instaniate the object

        public Person()
        {

        }


        //The Constructor is a unique method that is called when use the new keyword to create an instance of a class
        //new Person(); the new keyword invokes the constructor
        public Person(string FirstName, string LastName, string Email, int Age, bool OnHoliday)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Age = Age;
            this.OnHoliday = OnHoliday;
        }



        //Referred to as design patterns.  
        //Design patterns are repeated patterns throughout programming languages that repeated often enough that it is known by a specific name or phrase
        //Getters and Setters

        //Getters are responsible for returning the value from an object
        //Typically this is for privates fields in order to enforce encapsulation
        //If the field were to be public then could just directly update the field or get the field without going thru the getter and setter


        //The "this" keyword is used to refer to the object that has been created

        public string GetFirstName()
        {
            return this.FirstName;
        }

        public void SetFirstName(string firstName)
        {
            if (FirstName.Count() == 0)
            {
                return;
            }
            this.FirstName = firstName.Trim();
        }

        public string GetLastName()
        {
            return this.LastName;
        }

        public void SetLastName(string lastName)
        {
            if (LastName.Count() == 0)
            {
                return;
            }
            this.LastName = lastName.Trim();
        }

        public string GetEmail()
        {
            return this.Email;
        }

        public void SetEmail(string email)
        {
            this.Email = email;
        }

        public int GetAge()
        {
            return this.Age;
        }

        public void SetAge(int age)
        {
            if (Age <= 0 || Age > 100)
            {
                return;
            }
            this.Age = age;
        }

        public bool GetOnHoliday()
        {
            return this.OnHoliday;
        }

        public void SetOnHoliday(bool onHoliday)
        {
            this.OnHoliday = onHoliday;
        }

        public override string ToString()
        {
           return $"First Name: {FirstName}\nLast Name: {LastName}\nEmail: {Email}\nAge: {Age}\nOn Holiday: {OnHoliday}";
        }

        //ToString() is a method that is called when you try to convert an object to a string



    }

}