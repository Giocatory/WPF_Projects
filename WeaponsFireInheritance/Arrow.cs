namespace WeaponsFireInheritance
{
    internal sealed class Arrow : Weapon
    {
        public Arrow(string title, string description) : base(title, description)
        {
        }

        public string FireVoice()
        {
            return "пиу пиу";
        }

        public string WeaponDamage()
        {
            return "30HP";
        }
    }
}