using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class RPGCharacter
    {
        private String name;
        private int strength;
        private int dexterity;
        private int intelligence;
        private int health;
        private double movement;

        public void setupCharacter(String charName, int charStrength, int charDexterity, int charIntelligence, int charHealth)
        {
            name = charName;
            strength = charStrength;
            dexterity = charDexterity;
            intelligence = charIntelligence;
            health = charHealth;
            movement = (health + dexterity) / 4;
        } 
        //Increase
        public void increaseHealth()
         {
            health++;
            movement = (health + dexterity) / 4;
        }
        public void increaseStrength()
        {
            strength++;
        }
        public void increaseDexterity()
        {
            dexterity++;
            movement = (health + dexterity) / 4;
        }
        public void increaseIntelligence()
        {
            intelligence++;
        }
        //Decrease
        public void decreaseHealth()
        {
            health--;
            movement = (health + dexterity) / 4;
        }
        public void decreaseStrength()
        {
            strength--;
        }
        public void decreaseDexterity()
        {
            dexterity--;
            movement = (health + dexterity) / 4;
        }
        public void decreaseIntelligence()
        {
            intelligence--;
        }

        public void Print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Strength: " + strength);
            Console.WriteLine("Dexterity: " + dexterity);
            Console.WriteLine("Intelligence: " + intelligence);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Movement: " + movement);
        }
    }
}
