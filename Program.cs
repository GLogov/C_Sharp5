/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */


int[] array = GenerateArray(6);
PrintArray(array);
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях = {FindSumEvenElements(array)}");


int FindSumEvenElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int[] GenerateArray(int length) // Генерирует рандомный массив указанной длинны
{
    int[] array = new int[length];
    Random random = new Random();
    for (var i = 0; i < length; i++)
    {
        array[i] = random.Next(-99, 100);
    }
    return array;
}

void PrintArray(int[] array) // Печатает массив
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}