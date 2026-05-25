// This program will create a character manager
// Austen Hernandez
// 5/23/26

using System.ComponentModel.Design;
using System.Net.Http.Headers;
using CharacterFile;
using CharacterManagerFile;
using GameUtitliy;

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
            Character newCharacter;
            bool exit = false;
            do
            {
                Console.WriteLine("(1) Display Characters, (2) Add Character (0) Exit");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int Choice))
                {
                    switch (Choice)
                    {
                        case (int)MenuOptions.DisplayCharacters:
                            CharManager.DisplayCharacters();
                            break;
                        case (int)MenuOptions.AddCharacter:
                            Console.WriteLine("Enter name (not required)");
                            string userName = Console.ReadLine();
                            Console.WriteLine("Enter class (required)");
                            string userClass = Console.ReadLine();
                            if (userName == "")
                            {
                                newCharacter = CharManager.CreateCharacter(userClass);
                                CharManager.DisplayCharacter(newCharacter);
                            }
                            else
                            {
                                newCharacter = CharManager.CreateCharacter(userName, userClass);
                                CharManager.DisplayCharacter(newCharacter);
                            }
                            Console.WriteLine("Damage this character? (Y/N)");
                            string damage = Console.ReadLine();
                            if (damage == "Y" || damage == "y")
                            {
                                newCharacter.CharacterHealth -= GameUtils.Damage();
                                CharManager.DisplayCharacter(newCharacter);
                            }
                            break;
                        case (int)MenuOptions.Exit:
                            Console.WriteLine("Exiting");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Please choose a valid option.");
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
        AddCharacter,
        SearchByName, //not used
        DamageByName, //not used
    }
}