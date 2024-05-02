// using System.Reflection.Metadata.Ecma335;
// using System.Security.Cryptography;
// using Day3.Classes;

// namespace Day3;

// public class ClassBasics
// {
//   public static void Main(string[] args)
//   {
//     ExampleClass exampleClass = new ExampleClass();

//     exampleClass.Age = 55;


//     //Person Class Example

//     Person personA = new Person();

//     Console.WriteLine(personA.GetFirstName());
//     Console.WriteLine(personA.GetLastName());
//     Console.WriteLine(personA.GetEmail());
//     Console.WriteLine(personA.GetAge());
//     Console.WriteLine(personA.GetOnHoliday());


//     Person personB = new Person();
//     personB.SetFirstName("New");
//     personB.SetLastName("Person");
//     personB.SetEmail("abd@cdefg.com");
//     personB.SetAge(25);
//     personB.SetOnHoliday(false);

//     Console.WriteLine(personB.GetFirstName());
//     Console.WriteLine(personB.GetLastName());
//     Console.WriteLine(personB.GetEmail());
//     Console.WriteLine(personB.GetAge());
//     Console.WriteLine(personB.GetOnHoliday());



//     Person personC = new Person("Jane", "Smith", "janesmith@janesmith.com", 30, true);  //invoking the parameterized constructor

//     Console.WriteLine(personC.GetFirstName());
//     Console.WriteLine(personC.GetLastName());
//     Console.WriteLine(personC.GetEmail());
//     Console.WriteLine(personC.GetAge());
//     Console.WriteLine(personC.GetOnHoliday());

    
  
//     List<Person> people = new List<Person>();

//     people.Add(personA);
//     people.Add(personB);
//     people.Add(personC);

//     foreach (Person whateveryouwanttocallit in people)
//     {
//       Console.WriteLine(whateveryouwanttocallit);
//     }

//   }
// }

