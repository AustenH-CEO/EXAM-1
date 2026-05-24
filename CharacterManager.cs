// Character manager should set values for each character
using System;
using System.Collections.Generic;
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
        
        /*
        public Character DisplayByName(string Name)
        {
            if (Name == "")
            Console.WriteLine("Name: " + Char.CharacterName);
            Console.WriteLine("Class: " + Char.CharacterClass);
            Console.WriteLine("Health: " + Char.CharacterHealth);
            Console.WriteLine("--------");
            return ;
        }
        */
    }
}
