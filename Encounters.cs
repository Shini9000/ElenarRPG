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
            SingleCombat(false, "Rat", 1, 10);
        }



        // Encounter tools
        public static void SingleCombat(bool random, string name, int level, int health)
        {

            string n = "";
            int l = 0;
            int h = 0;

            if(random)
            {

            }
            else
            {
                n = name;
                l = level;
                h = health;

            }

            while (h>0)
            {
                Console.WriteLine("=====================");
                Console.WriteLine("> " + n);
                Console.WriteLine("> Health: " + h);
                Console.WriteLine("> Lvl: " + l);
                Console.WriteLine("=====================");
                Console.WriteLine("| (A)ttack (D)efend |");
                Console.WriteLine("| (S)pells (P)otion |");
                Console.WriteLine("=====================");
                Console.WriteLine("Health: " + Program.pC.health + "  |  " + "Health potions: " + Program.pC.healthPotions);
                Console.Write(">> ");
                string input = Console.ReadLine();
                if(input.ToLower() == "a" || input.ToLower() == "attack") 
                {
                    // attack
                    Console.WriteLine("You attack! \n" + n + " strikes you in retaliation!");
                    int damage = l - Program.pC.armorClass;
                    // weaponary class link
                    //int attack = numberGen.Next(0, Program.pC.weaponDamage) + Program.pC.skillStrength;
                    //Attack player does to enemy. Accessed through player -> Players weapon -> AttackDamage on Weaponary.cs
                    int attack = Program.pC.weaponEquiped.AttackDamage();
                    
                    if (attack == 0){
                        Console.WriteLine(n + " managed to evade your attack!");
                    }else {
                        Console.WriteLine("You deal " + attack + " points of damage");
                    }
                    Console.WriteLine("You were attacked taking " + damage + " points of damage!");

                    Program.pC.health -= damage;
                    h -= attack;
                    Console.WriteLine("continue...");
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
/*
 But the prob is getting A weapon 
 to link to this battle and equip it to player (Not set up yet)
 ahhh
*/
    }
}