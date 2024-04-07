namespace ElenarRPG
{
    class Weaponary
    {
       static Random numberGen = new Random();

        private int baseDamage;
        public string weaponName {get; private set;}

        public Weaponary(int baseDamage, string weaponName){
            this.baseDamage = baseDamage;
            this.weaponName = weaponName;
        }

        public int AttackDamage(){
            return baseDamage * numberGen.Next(0, 3);
        }
    }
}