using BradProjectOne.PresentationLayer;

namespace BradProjectOne;

class Program
{
    static void Main(string[] args)
    {
        var mainMenu = new MainMenu(); //creating an instance of the main menu
        mainMenu.StartMenu();//calling the start menu method
    }
}
