using ElenarRPG;

namespace ElenarRPG
{
    class Player
    {
        //Random rng = new ();

        public string name;
        public string race;
        public string profession;
        public string diety;

//Ill change back but for example: 

        // Inventory 
        public int gold = 0;
        public int health = 100;
        public int experience = 0;
        public int armorClass = 0;
        public int spellSlots = 0;
        public int healthPotions = 0;
        public int weaponDamage = 1;
        public int bagSpace = 2;
        // race

        // Stats
        public int skillAcrobatics = 0;
        public int skillAgility = 0; 
        public int skillCharisma = 0; 
        public int skillDexterity = 0; 
        public int skillIntelligence = 0; 
        public int skillPerception = 0; 
        public int skillStrength = 0; 
        public int skillWisdom = 0;

        public Weaponary weaponEquiped{get; private set;}

        public void SwitchWeapon(Weaponary weapon){
            this.weaponEquiped = weapon;
        }

    }
    
}

