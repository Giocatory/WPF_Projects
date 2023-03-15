namespace HiloGameConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Hilo game");
            Console.WriteLine($"Guess number between 1 and {HiloGame.MAXIMUM}");

            HiloGame.Hint();

            while (HiloGame.GetPot > 0)
            {
                Console.WriteLine("Press 'h' for higher, 'l' for lower, '?' to buy hint,");
                Console.WriteLine($"or any other key to quit with {HiloGame.GetPot}");

                char key = Console.ReadKey(true).KeyChar;

                switch(key)
                {
                    case 'h': 
                        HiloGame.Guess(true); break;
                    case 'l':
                        HiloGame.Guess(false); break;
                    case '?':
                        HiloGame.Hint();
                        break;
                    default:
                        return;
                }
                Console.WriteLine("The pot is empty. Bye!");
            }
        }
    }
}