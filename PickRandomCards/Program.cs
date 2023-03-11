namespace PickRandomCards
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите количество карт: ");
            string? line = Console.ReadLine();

            int numberOfCards = int.TryParse(line, out int _) ? Convert.ToInt32(line) : 0;

            if (numberOfCards == 0)
            {
                Console.WriteLine("Вы ввели 0 или неправильное значение!");
            }
            else
            {
                string[] cards = CardPicker.PickSomeCards(numberOfCards);
                foreach (string card in cards)
                {
                    Console.WriteLine($"{card};");
                }
            }
        }
    }
}