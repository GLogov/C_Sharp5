/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */


int[] array = GenerateArray(5);
PrintArray(array);
Console.Write($"Четных чисел в массиве - {CounterEven(array)}");

int CounterEven(int[] array) // возвращает количество четных чисел в указанном массиве
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            counter ++;
        }
    }
    return counter;
}


int[] GenerateArray(int length) // Генерирует случайный массив указанной длинны
{
    int[] array = new int[length];
    Random random = new Random();
    for (var i = 0; i < length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array) // Печатает указанный массив
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}