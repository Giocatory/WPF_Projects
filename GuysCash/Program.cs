namespace GuysCash
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var joe = new Guy()
            {
                Name = "Джо",
                Cash = 50
            };
            var bob = new Guy("Боб", 100);

            while (true)
            {
                // Вызовите методы WriteMyInfo для каждого объекта Guy
                joe.WriteMyInfo();
                bob.WriteMyInfo();

                Console.Write("Введите сумму: ");
                string? howMuch = Console.ReadLine();

                if (howMuch == "") return;
                // Используйте метод int.TryParse для преобразования строки howMuch в int
                // (как это было сделано ранее в этой главе)
                if (int.TryParse(howMuch, out int cash))
                {
                    Console.Write("Кто должен давать деньги: ");
                    string? whichGuy = Console.ReadLine();
                    if (whichGuy == "Джо")
                    {
                        // Вызовите метод GiveCash объекта joe и сохраните результат
                        joe.GiveCash(cash);
                        // Вызовите метод ReceiveCash объекта bob с сохраненным результатом
                        bob.ReceiveCash(cash);
                    }
                    else if (whichGuy == "Боб")
                    {
                        // Вызовите метод GiveCash объекта bob и сохраните результат
                        bob.GiveCash(cash);
                        // Вызовите метод GiveCash объекта joe с сохраненным результатом
                        joe.ReceiveCash(cash);
                    }
                    else
                    {
                        Console.WriteLine("Пожалуйста, введите 'Джо' или 'Боб'");
                    }
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите сумму (или пустую строку для выхода).");
                }
            }
        }
    }
}