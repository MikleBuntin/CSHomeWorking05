//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

// Вернее было бы написать: "стоящих на позициях с нечётным индексом. Т.к. позиция начинается с 1й, а с 0го начинается индекс.

int[] array = new int[new Random().Next(2, 40)];

void FloodArray(int[] array)
{
    int i = 0;
    while(i < array.Length)
    {
        array[i] = new Random().Next(-1000, 1000);
        i++;
    }
}

int ArrayNechSum(int[] array)
{
    int sumNech = 0;
    int i = 1;
    while(i < array.Length)
    {
        sumNech = sumNech + array[i];
        i = i + 2;
    }
    return sumNech;
}

void PrintArray(int[] array)
{
    int i = 0;
    Console.Write($"[");
    while(i < array.Length -1)
    {
        Console.Write(array[i] + $", ");
        i++;
    }
    Console.WriteLine(array[i] + $"]");
}
FloodArray(array);
PrintArray(array);
Console.WriteLine("Сумма элементов, стоящих на позициях с нечётным индексом: " + ArrayNechSum(array));