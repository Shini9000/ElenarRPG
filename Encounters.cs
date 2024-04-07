using System;
using ElenarRPG;


namespace ElenarRPG
{
    class Encounters
    {

        static Random numberGen = new Random();
        // Encounter generic


        // Encounters
        public static void FirstEncounter()
        {
            Console.WriteLine("The shadow is getting closer... closer... closer. \n"
                            + "a rat lunges at you, you manage to doge out the way!!");
            Console.ReadKey();
            Combat(false, "rat", 1, 10);
        }



        // Encounter tools
        public static void Combat(bool random, string name, int power, int health)
        {

            string n = "";
            int p = 0;
            int h = 0;

            if(random)
            {

            }
            else
            {
                n = name;
                p = power;
                h = health;

            }

            while (h>0)
            {
                Console.WriteLine("=====================");
                Console.WriteLine("| (A)ttack (D)efend |");
                Console.WriteLine("| (S)pells (P)otion |");
                Console.WriteLine("=====================");
                Console.WriteLine("Health: " + Program.pC.health + "  |  " + "Health potions: " + Program.pC.healthPotions);
                string input = Console.ReadLine();
                if(input.ToLower() == "a" || input.ToLower() == "attack") 
                {
                    // attack
                    Console.WriteLine("You attack!" + n + " strikes you in retaliation!");
                    int damage = p - Program.pC.armorClass;
                    // weaponary class link
                    int attack = numberGen.Next(0, Program.pC.weaponDamage) + Program.pC.skillStrength;
                    Console.WriteLine("You deal " + attack + " points of damage");
                    Console.WriteLine("You were attacked taking " + damage + " points of damage!");

                    Program.pC.health -= damage;
                    h -= attack;
                }
                else if(input.ToLower() == "d" || input.ToLower() == "defend") 
                {
                    // defend
                } 
                else if(input.ToLower() == "s" || input.ToLower() == "spells") 
                {
                    // spells
                } 
                else if(input.ToLower() == "p" || input.ToLower() == "potion") 
                {
                    // escape
                }

                Console.ReadKey();
            }
        }

    }
}