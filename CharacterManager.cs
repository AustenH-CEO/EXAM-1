// Character manager should set values for each character
using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;
using CharacterFile;
using ProgramFile;

namespace CharacterManagerFile
{
    public class CharacterManager
    {
        public List<Character> Characters = new List<Character>();
        public void AddCharacter(Character Char)
        {
            Characters.Add(Char);
        }
        public void DisplayCharacters()
        {
            Console.WriteLine("Characters:");
            foreach (Character Char in Characters)
            {
                Console.WriteLine("Name: " + Char.CharacterName);
                Console.WriteLine("Class: " + Char.CharacterClass);
                Console.WriteLine("Health: " + Char.CharacterHealth);
                Console.WriteLine("--------");
            }

        }
        public void DisplayCharacter(Character character)
        {
            Console.WriteLine("Name: " + character.CharacterName);
            Console.WriteLine("Class: " + character.CharacterClass);
            Console.WriteLine("Health: " + character.CharacterHealth);
            Console.WriteLine("--------");
        }
        public Character CreateCharacter(string Name, string Class)
        {
            Character userChar = new Character(Name, Class);
            Characters.Add(userChar);
            return userChar;
        }
        public Character CreateCharacter(string Class)
        {
            Character userChar = new Character(Class);
            Characters.Add(userChar);
            return userChar;
        }
    }
}
