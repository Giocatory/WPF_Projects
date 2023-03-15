namespace WeaponsFireInheritance
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Arrow smallArrow = new Arrow("Маленький лук", "дальний бой");
            Sword claymore = new Sword("Двуручный меч", "Ближний бой");

            Console.WriteLine($"{smallArrow.GetType().Name} ({smallArrow.Title}) - {smallArrow.Description}. Звук: {smallArrow.FireVoice()}. Damage - {smallArrow.WeaponDamage()}");
            Console.WriteLine($"{claymore.GetType().Name} ({claymore.Title}) - {claymore.Description}. Звук: {claymore.FireVoice()}. Damage - {claymore.WeaponDamage()}");
        }
    }
}