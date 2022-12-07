// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Например:
// ["hello", "2", "world", ":-)"] -> [2, :-)]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

void PrintArray(string[] array)
{
    if (array.Length > 0)
    {
        System.Console.Write($"[{array[0]}");
        for (int i = 1; i < array.Length; i++)
        {
            System.Console.Write($", {array[i]}");
        }
        System.Console.Write("]");
    }
    else
    {
        System.Console.Write("В массиве нет элементов");
    }
}

string[] GenerateNewArray(string[] array)
{
    string[] newArray = new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Array.Resize(ref newArray, newArray.Length + 1);
            newArray[newArray.Length - 1] = array[i];
        }
    }
    return newArray;
}

void Run()
{
    string[] array = new string[] { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science" };
    System.Console.Write("Изначальный массив: ");
    PrintArray(array);
    System.Console.WriteLine();
    string[] newArray = GenerateNewArray(array);
    System.Console.Write("Новый массив: ");
    PrintArray(newArray);
}

Run();