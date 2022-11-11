// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекоменндуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры: ["Hello", "2", "World", ":-)"] -> ["2", ":-)"];  ["1234", "1567", "-2", "computer science"] ->["-2"];  ["Russia", "Denmark", "Kazan"] -> [].

Console.Clear();

int limit = 3;
Console.Write("Введите нужное количество элементов исходного массива: ");
int num = int.Parse(Console.ReadLine()!);
if (num < 1)
{
    Console.WriteLine("Введите корректное число элементов!");
}
else
{
    string[] array = new string[num];
    int finArrLen = 0;
    FillArray(array);
    Console.Write("Исходный массив: ");
    PrintArray(array);
    LengthOfFinalArray(array);
    if (finArrLen == 0)
    {
        Console.Write($"В исходном массиве нет элементов длиной меньше " + limit + " символов!");
    }
    else
    {
        string[] finalArray = new string[finArrLen];
        FillFinalArray(array, finalArray);
        /* Console.WriteLine("Длина итогового массива: " + finArrLen); */
        Console.Write("Итоговый массив: ");
        PrintArray(finalArray);
    }

    void FillArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Введите данные:");
            array[i] = Console.ReadLine()!;
        }
    }

    void PrintArray(string[] arr)
    {
        int count = arr.Length;
        Console.Write("[");
        for (int i = 0; i < count; i++)
        {
            Console.Write($"\"" + arr[i] + "\"");
            if (i == count - 1)
                Console.WriteLine("]");
            else
                Console.Write(", ");
        }
    }

    void LengthOfFinalArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= limit)
            {
                finArrLen++;
            }
        }
    }

    void FillFinalArray(string[] arr1, string[] arr2)
    {
        int i = 0;
        int j = 0;

        while (j < arr2.Length)
        {
            if (arr1[i].Length <= limit)
            {
                arr2[j] = arr1[i];
                j++;
                i++;
            }
            else
            {
                i++;
            }
        }
    }
}
