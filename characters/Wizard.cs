namespace ElenarRPG
{
    class Wizard
    {
        Random rng = new ();

        public string name;
        public string favoriteSpell;
        private int spellSlots;
        private float experience;

        public static int Count;

        public Wizard(string _name, string _favoriteSpell)
        {
            name = _name;
            favoriteSpell = _favoriteSpell;
            spellSlots = 2;
            experience = 0f;

            Count++;
        }

        public void CastSpell()
        {
            if (spellSlots > 0){
                Console.WriteLine(name + " casts " + favoriteSpell);
                spellSlots--;
                experience += 0.3f;
            } else {
                Console.WriteLine(name + " is out of Spell slots!");
            }
        }

        public void Meditate()
        {
            Console.WriteLine(name + " meditates and regains spell slots!");
            spellSlots = 2;
        }

    }
}