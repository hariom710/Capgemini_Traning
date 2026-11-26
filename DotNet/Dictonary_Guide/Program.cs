namespace Dictonary_Guide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            myDictionary.Add(1, "Value1");
            myDictionary.Add(2, "Value2");
            myDictionary.Add(3, "Value3");

            Console.WriteLine("Dictionary Contents:");
            foreach (var kvp in myDictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // Accessing a value by key
            string value = myDictionary[2];
            Console.WriteLine($"\nValue for 'Key2': {value}");

            // Checking if a key exists
            if (myDictionary.ContainsKey(4))
            {
                Console.WriteLine("Key4 exists in the dictionary.");
            }
            else
            {
                Console.WriteLine("Key4 does not exist in the dictionary.");
            }

            // Removing a key-value pair
            myDictionary.Remove(1);
            Console.WriteLine("\nAfter removing Key1:");
            foreach (var kvp in myDictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }
    }
}