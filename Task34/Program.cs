//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int n = new Random().Next(2, 20);
int[] array = new int[n];

void FloodArray(int[] array)
{
    int count = 0;
    while(count < array.Length)
    {
        array[count] = new Random().Next(100, 1000);
        count++;
    }
}

int ArrayChetNumber(int[] array)
{
    int chetNumber = 0;
    int count = 0;
    while(count < array.Length)
    {
        if(array[count] % 2 == 0) chetNumber++;
        count++;
    }
    return chetNumber;
}

void PrintArray(int[] array)
{
    int count = 0;
    Console.Write($"[");
    while(count < array.Length -1)
    {
        Console.Write(array[count] + $", ");
        count++;
    }
    Console.WriteLine(array[count] + $"]");
}

FloodArray(array);
PrintArray(array);
Console.WriteLine("Всего элементов: " + n);
int chetNumber = ArrayChetNumber(array);
Console.WriteLine("Количество чётных элементов массива: " + chetNumber);