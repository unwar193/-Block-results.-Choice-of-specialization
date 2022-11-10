// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекоменндуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.Clear();

Console.Write("введите число: ");
int num = int.Parse(Console.ReadLine()!);
string[] array = new string[num];
FillArray(array);
PrintArray(array);


void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {   
        Console.WriteLine("Введите данные:");
        array[i] = Console.ReadLine()!;
    }
}

void PrintArray(string[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"\"" + array[i] + "\"");
        if (i == count - 1)
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }
}