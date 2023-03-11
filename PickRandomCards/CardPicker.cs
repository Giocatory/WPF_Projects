namespace PickRandomCards
{
    internal class CardPicker
    {
        private static readonly Random random = new Random();

        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            return random.Next(1, 5) switch
            {
                1 => "Пики",
                2 => "Черви",
                3 => "Крести",
                _ => "Бубны"
            };
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            return value switch
            {
                1 => "Туз",
                11 => "Валет",
                12 => "Дама",
                13 => "Король",
                _ => value.ToString()
            };
        }
    }
}