using System.Reflection;

namespace HowReadPrivateFields
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HasASecret keeper = new();

            FieldInfo[] fields = keeper.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (FieldInfo field in fields)
            {
                Console.WriteLine($"Variable name: {field.Name}; Variable value: {field.GetValue(keeper)}");
            }
            // Variable name: secret; Variable value: secret phraze
            // Variable name: lengthSecretPhraze; Variable value: 5
            // Variable name: <HowManyVars>k__BackingField; Variable value: 2
        }
    }
}