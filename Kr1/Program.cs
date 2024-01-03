using System;
using System.Linq;

class Program
{
    static void Main()// Задаем массив и выводим его
    {
        string[] stringArray = { "Hello", "World", "123", "456", "C#" };
        ProcessAndDisplayArray(stringArray);
    }

        static T[] FilterByLength<T>(T[] originalArray, int maxLength)// метод для фильтрации содержимого по длинне
    {
        var result = originalArray.Where(item => item != null && item.ToString().Length <= maxLength).ToArray();
        return result;
    }

  
    static void DisplayArray<T>(T[] array)//Отображение в консоли
    {
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }

    
    static void ProcessAndDisplayArray<T>(T[] originalArray)// преобразование и отображение массива до и после фильтрации
    {
        while (true)
        {
            T[] newArray = FilterByLength(originalArray, 3);

            Console.WriteLine("Начальный массив:");
            DisplayArray(originalArray);

            Console.WriteLine("\nНовый массив:");
            DisplayArray(newArray);

            Console.WriteLine("Введите q для выхода из программы");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
            {
                break;
            }
        }
    }
}