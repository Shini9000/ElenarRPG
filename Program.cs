﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Drawing;
using System.Reflection.Metadata;
using System.Timers;

namespace ElenarRPG
{
    class Program
    {
        public static Player pC = new Player();
        public static bool characterCreated = false;
        private static string[] c_Races = {"Orc", "Elf", "Human", "Dwarf"};
        private static string[] c_Classes = {"Warrior", "Hunter", "Thief", "Mage"};
        private static List<Weaponary> weapons = new List<Weaponary>();
        private static Weapons weaponsList = new Weapons();
        static void Main(string[] args)
        {
            Start();
            Console.WriteLine("The rat dropped a knife! Wonder where it stored that...");
            pC.SwitchWeapon(weapons[1]);
            Console.WriteLine("Current Weapon: " + pC.weaponEquiped.weaponName);
        }
        
        static void Start()
        {
            //All game weapons!
            for(int x = 0; x < weaponsList.weaponNames.Length -1; x++){
                weapons.Add(new Weaponary(weaponsList.weaponBaseStr[x], weaponsList.weaponNames[x]));
            }
            Console.Title = "Elenar RPG";
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Welcome to Alisa Text RPG!");
            Console.WriteLine("This is all done in C# and by Text");
            Console.WriteLine("This project is a pet project of mine");
            Console.WriteLine("It's available at Itchio and GitHub");
            Console.WriteLine("Feedback and Bugreports are welcome! Please see below!");
            Console.WriteLine("Discord: (link unavailbe)");
            Console.WriteLine("Github: \n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press any key to continue...");
            Console.ResetColor();
            Console.ReadKey();
            // check to see if characer is created
            if (characterCreated == false){
                Console.Clear();
                CharacterCreation();
            }

            // Writes the player profile after creation to show stats
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("---- Profile ----"
                        + "\nPlayername: " + pC.name 
                        + "\nRace: " + pC.race 
                        + "\nClass: " + pC.profession
                        + "\nDiety: " + pC.diety
                        + "\nGold: " + pC.gold 
                        + "\nHealth: " +  pC.health 
                        + "\nEXP: " +  pC.experience 
                        + "\nAC: " +  pC.armorClass 
                        + "\nSpell Slots: " +  pC.spellSlots 
                        + "\nHealth Potions: " +  pC.healthPotions 
                        + "\nBag: " +  pC.bagSpace
                        + "\nWeaponEquipped: " +  pC.weaponEquiped.weaponName 
                        + "\n-----------------");
            Console.WriteLine("\n----- Stats -----"
                        + "\nAcrobatics: " + pC.skillAcrobatics 
                        + "\nAgility: " + pC.skillAgility 
                        + "\nCharisma: " + pC.skillCharisma
                        + "\nDexterity: " + pC.skillDexterity
                        + "\nIntelligence: " + pC.skillIntelligence 
                        + "\nPerception: " +  pC.skillPerception 
                        + "\nStrength: " +  pC.skillStrength 
                        + "\nWisdom: " +  pC.skillWisdom
                        + "\n---- Profile ----");

            System.Threading.Thread.Sleep(3000);
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            // Start story!

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("It's dark but not light either it smells... odd. ");
            Console.Write("There is a shadow of sorts a little ways away it's making ");
            Console.Write("that sound again... a high pitched squeeking noise... almost like a...");
            Encounters.FirstEncounter();

        }

        static void CharacterCreation() // CC make character
        {
            Console.Write("Enter your name: ");
            pC.name = Console.ReadLine();
            // check to see if input name is blank
            if (pC.name == "")
            {
                Console.WriteLine("You cant remember your name?");
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
                // if input name is blank then run CC again
                CharacterCreation();
            }
            // clear console and pick a race
            Console.Clear();
            Array.Sort(c_Races);
            Console.WriteLine("Now pick a race!");
            while (pC.race is null) // if race is ""
            {
                // will list all in c_Races as 1. 2. 3. ...
                for (int i = 0; i < c_Races.Length; i++) 
                {
                    int number = i + 1;
                    Console.WriteLine(number + ". " + c_Races[i]);
                    continue;
                }
                // inputs for race
                var s_Race = Console.ReadLine();
                if (s_Race.Length == 1)
                {
                    // checks for user input as "1" or "2"..
                    int selected_race = Convert.ToInt16(s_Race);
                    Debug.WriteLine("Chosen Int");
                    switch (selected_race)
                    {
                        case 2:
                            Console.WriteLine("You chose Elf");
                            pC.race = "Elf";
                            continue;
                        case 3:
                            Console.WriteLine("You chose Human");
                            pC.race = "Human";
                            continue;
                        case 4:
                            Console.WriteLine("You chose Orc");
                            pC.race = "Orc";
                            continue;
                        case 1:
                            Console.WriteLine("You chose Dwarf");
                            pC.race = "Dwarf";
                            continue;
                        default:
                            Console.WriteLine("Int This is not a valid race or race cant be nothing!");
                            break;
                    }
                } else {
                    // checks for user input as "elf" or "orc"...
                    s_Race = char.ToUpper(s_Race[0]) + s_Race.Substring(1); // basically formats to a cap "elf" >> "Elf"
                    Debug.WriteLine("Chosen String " + s_Race);
                    switch (s_Race)
                    {
                        case "Elf":
                            Console.WriteLine("You chose Elf");
                            pC.race = "Elf";
                            continue;
                        case "Human":
                            Console.WriteLine("You chose Human");
                            pC.race = "Human";
                            continue;
                        case "Orc":
                            Console.WriteLine("You chose Orc");
                            pC.race = "Orc";
                            continue;
                        case "Dwarf":
                            Console.WriteLine("You chose Dwarf");
                            pC.race = "Dwarf";
                            continue;
                        default:
                            Console.WriteLine("String This is not a valid race or race cant be nothing!");
                            break;
                    }
                }

            }
            // clear console and pick a profession
            System.Threading.Thread.Sleep(1500);
            Console.Clear();
            Array.Sort(c_Classes);
            Console.WriteLine("Now pick a class!");
            while (pC.profession is null) 
            {
                // will list all in c_Races as 1. 2. 3. ...
                for (int i = 0; i < c_Classes.Length; i++) 
                {
                    int number = i + 1;
                    Console.WriteLine(number + ". " + c_Classes[i]);
                    continue;
                }
                // inputs for class
                var s_classes = Console.ReadLine();
                if (s_classes.Length == 1)
                {
                    int selected_race = Convert.ToInt16(s_classes);
                    Debug.WriteLine("Chosen Int");
                    switch (selected_race)
                    {
                        case 4:
                            Console.WriteLine("You chose Warrior");
                            pC.profession = "Warrior";
                            continue;
                        case 1:
                            Console.WriteLine("You chose Hunter");
                            pC.profession = "Hunter";
                            continue;
                        case 3:
                            Console.WriteLine("You chose Thief");
                            pC.profession = "Thief";
                            continue;
                        case 2:
                            Console.WriteLine("You chose Mage");
                            pC.profession = "Mage";
                            continue;
                        default:
                            Console.WriteLine("Int This is not a valid race or race cant be nothing!");
                            break;
                    }
                } else {

                    s_classes = char.ToUpper(s_classes[0]) + s_classes.Substring(1);
                    Debug.WriteLine("Chosen String " + s_classes);
                    switch (s_classes)
                    {
                        case "Warrior":
                            Console.WriteLine("You chose Warrior");
                            pC.profession = "Warrior";
                            continue;
                        case "Hunter":
                            Console.WriteLine("You chose Hunter");
                            pC.profession = "Hunter";
                            continue;
                        case "Thief":
                            Console.WriteLine("You chose Thief");
                            pC.profession = "Thief";
                            continue;
                        case "Mage":
                            Console.WriteLine("You chose Mage");
                            pC.profession = "Mage";
                            continue;
                        default:
                            Console.WriteLine("String This is not a valid race or race cant be nothing!");
                            break;
                    }
                }

            }
            
            pC.SwitchWeapon(weapons[0]);   //weapons[0] = fists.

            Console.WriteLine("CURRENT WEAPON EQUIPPED: " + pC.weaponEquiped.weaponName);


            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Character created!");
            Console.Clear();
            characterCreated = true;
        }
    }
}