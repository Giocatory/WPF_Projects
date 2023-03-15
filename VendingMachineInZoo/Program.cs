namespace VendingMachineInZoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vendingMachine = new AnimalFeedVendingMachine();
            Console.WriteLine(vendingMachine.Dispense(2.0M));

        }
    }
}