// This program will create a character manager
// Austen Hernandez
// 5/23/26

using System.ComponentModel.Design;
using System.Net.Http.Headers;
using CharacterFile;
using CharacterManagerFile;

namespace ProgramFile
{

    public class Program
    {
        public static void Main()
        {
            CharacterManager CharManager = new CharacterManager();
            Character Warrior = new Character("Joe", "Warrior");
            CharManager.AddCharacter(Warrior);
            Character Mage = new Character("Jeblko", "Mage");
            CharManager.AddCharacter(Mage);
            Character Rogue = new Character("Naomi", "Rogue");
            CharManager.AddCharacter(Rogue);
            Console.WriteLine("Character Manager");
            bool exit = false;
            do
            {
                Console.WriteLine("(1) Display Characters, (2) Search By Name, (3) Add Character, (4) Damage By Name, (0) Exit");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int Choice))
                {
                    switch (Choice)
                    {
                        case (int)MenuOptions.DisplayCharacters:
                            CharManager.DisplayCharacters();
                            break;
                        case (int)MenuOptions.SearchByName:

                            break;
                        case (int)MenuOptions.AddCharacter:

                            break;
                        case (int)MenuOptions.DamageByName:

                            break;
                        case (int)MenuOptions.Exit:
                            Console.WriteLine("Exiting");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Choose 0, 1, 2, or 3");
                            break;
                    }
                }
            } while (!exit);
            
        }
    }
    enum MenuOptions
    {
        Exit,
        DisplayCharacters,
        SearchByName,
        AddCharacter,
        DamageByName,
    }
}