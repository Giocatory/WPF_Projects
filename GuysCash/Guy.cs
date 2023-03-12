namespace GuysCash
{
    internal class Guy
    {
        public string Name { get; set; }
        public int Cash { get; set; }

        // Цепочка констуркторов
        public Guy() : this(string.Empty, 0) { }

        public Guy(string name) : this(name, 0) { }

        public Guy(string name, int cash)
        {
            this.Name = name;
            this.Cash = cash;
        }

        /// <summary>
        /// Вывод имени и количества денег
        /// </summary>
        public void WriteMyInfo()
        {
            Console.WriteLine($"{Name} has {Cash} bucks.");
        }

        /// <summary>
        /// Выдает часть моих денег, удаляя их из кармана (или выводит на консоль
        /// сообщение о том, что денег недостаточно).
        /// </summary>
        /// <param name="amount">Выдаваемая сумма.</param>
        /// <returns>
        /// Сумма денег, взятая из кармана, или 0, если денег не хватает
        /// (или если сумма недействительна).
        /// </returns>
        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"{Name} says: {amount} isn't a valid amount");
            }
            if (amount > Cash)
            {
                Console.WriteLine($"{Name} says: I don't have enough cash to give you {amount}");
                return 0;
            }
            Cash -= amount;
            return amount;
        }

        /// <summary>
        /// Получает деньги, добавляя их в мой карман (или выводит
        /// сообщение на консоль, если сумма недействительна).
        /// </summary>
        /// <param name="amount">Получаемая  сумма.</param>
        public void ReceiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"{Name} says: {amount} isn't an amount I'll take");
            }
            else
            {
                Cash += amount;
            }
        }
    }
}