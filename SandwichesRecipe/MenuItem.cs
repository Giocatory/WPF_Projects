using System;

namespace SandwichesRecipe
{
    internal class MenuItem
    {
        public Random Randomizer = new();

        // Белки
        public string[] Proteins = { "Жареная говядина", "Салями", "Индейка", "Ветчина", "Макароны", "Тофу" };

        // Приправы
        public string[] Condiments = { "Желтая горчица", "Коричневая горчица", "Медовая горчица", "Майонез", "Соевый соус", "Сырный соус" };

        // Хлебы
        public string[] Breads = { "Ржаной", "Белый", "Пшеничный", "Пампушка", "Багет" };

        public string Description = string.Empty;
        public string Price = string.Empty;

        public void Generate()
        {
            string randomProtein = Proteins[Randomizer.Next(Proteins.Length)];
            string randomCondiments = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];
            Description = $"{randomProtein} с {randomCondiments} на {randomBread}";

            decimal bucks = Randomizer.Next(2, 5);
            decimal cents = Randomizer.Next(1, 98);
            decimal price = bucks + (cents * .01m);
            Price = price.ToString("c"); // "с" для вывода локальной валюты
        }
    }
}