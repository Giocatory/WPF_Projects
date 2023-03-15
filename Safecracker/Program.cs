namespace Safecracker
{
    internal class Program
    {
        private static void Main()
        {
            SafeOwner owner = new();
            Safe safe = new();
            JewelThief jewelThief = new();
            jewelThief.OpenSafe(safe, owner);
            Console.ReadKey(true);
        }
    }
}