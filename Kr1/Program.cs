using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] stringArray = { "Hello", "World", "123", "456", "C#" };
        ProcessAndDisplayArray(stringArray);
    }

        static T[] FilterByLength<T>(T[] originalArray, int maxLength)
    {
        var result = originalArray.Where(item => item != null && item.ToString().Length <= maxLength).ToArray();
        return result;
    }

  
    static void DisplayArray<T>(T[] array)
    {
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }

    
    static void ProcessAndDisplayArray<T>(T[] originalArray)
    {
        while (true)
        {
            T[] newArray = FilterByLength(originalArray, 3);

            Console.WriteLine("Original array:");
            DisplayArray(originalArray);

            Console.WriteLine("\nNew array (items with a length not exceeding 3 characters):");
            DisplayArray(newArray);

            Console.WriteLine("Press 'Enter' to continue or type 'exit' to break the loop.");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                break;
            }
        }
    }
}