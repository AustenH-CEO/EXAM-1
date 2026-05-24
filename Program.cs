// This program will create a character manager
// Austen Hernandez
// 5/23/26

using System.ComponentModel.Design;

public class Program
{
    public static void Main()
    {
        bool exit = false;
        while (!exit)
        {
            CharacterMenu(ref exit);
        }
        Console.WriteLine("Exiting...");
    }
    static bool CharacterMenu(ref bool Exit)
    {
        string CharacterClass;
        do
        {
            Console.WriteLine("Choose a class: (1) Warrior, (2) Mage, (3) Rogue, (0) Exit");
            CharacterClass = Console.ReadLine();
            if (int.TryParse(CharacterClass, out int input))
            {
                switch (input)
                {
                    case (int)MenuChoice.Warrior:
                        Console.WriteLine("Creating Warrior...");
                        break;
                    case (int)MenuChoice.Mage:
                        Console.WriteLine("Creating Mage...");
                        break;
                    case (int)MenuChoice.Rogue:
                        Console.WriteLine("Creating Rogue...");
                        break;
                    case (int)MenuChoice.Exit:
                        Exit = true;
                        break;
                    default:
                        Console.WriteLine("Not an option");
                        break;
                }
            }  
            else
                Console.WriteLine("Please Enter a Valid Input...");
        } while (Exit == false);

        return Exit;
    }

}
enum FightingClass
{
    Warrior = 80,
    Mage = 45,
    Rogue = 65
}
enum MenuChoice
{
    Warrior = 1,
    Mage = 2,
    Rogue = 3,
    Exit = 0
}