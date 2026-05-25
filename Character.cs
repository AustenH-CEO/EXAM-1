// Character file should set character information
using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterFile
{
    public class Character
    {
        public string CharacterName;
        public string CharacterClass;
        public int CharacterHealth;

        public Character(string Name,  string Class)
        {
            this.CharacterName = Name;
            this.CharacterClass = Class;
            Enum.TryParse(Class, out ClassHealth CharClass);
            switch(CharClass)
            {
                case ClassHealth.Warrior:
                    CharacterHealth = (int)CharClass;
                    break;
                case ClassHealth.Mage:
                    CharacterHealth = (int)CharClass;
                    break;
                case ClassHealth.Rogue:
                    CharacterHealth = (int)CharClass;
                    break;
            }
        }
        public Character(string Class)
        {
            this.CharacterClass = Class;
            Enum.TryParse(Class, out ClassHealth CharClass);
            switch (CharClass)
            {
                case ClassHealth.Warrior:
                    CharacterName = "John Doe";
                    CharacterHealth = (int)CharClass;
                    break;
                case ClassHealth.Mage:
                    CharacterName = "Jane Smith";
                    CharacterHealth = (int)CharClass;
                    break;
                case ClassHealth.Rogue:
                    CharacterName = "Long Johnson";
                    CharacterHealth = (int)CharClass;
                    break;
            }
        }
        public void DamageCharacter (Character character, int damage)
        {
            character.CharacterHealth -= damage;
        }
    }
    enum ClassHealth
    {
        Warrior = 80,
        Mage = 45,
        Rogue = 65
    }
}
