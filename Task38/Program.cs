//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным
//элементами массива.
//[3 7 22 2 78] -> 76

int[] arr = new int[new Random().Next(0, 100)];

void FloodArr(int[] array)
{
    int i = 0;
    while(i < arr.Length)
    {
        arr[i] = new Random().Next(0, 1000);
        i++;
    }
}

void PrintArr(int[] arr)
{
    int i = 0;
    Console.Write($"[");
    while(i < arr.Length -1)
    {
        Console.Write(arr[i] + $", ");
        i++;
    }
    Console.WriteLine(arr[i] + $"]");
}

int DifMinMax(int[] arr)
{
    int i = 0;
    int minIndex = 0;
    while(i < arr.Length)
    {
        if(arr[i] < arr[minIndex]) minIndex = i;
        i++;
    }

    i = 0;
    int maxIndex = 0;
    while(i < arr.Length)
    {
        if(arr[i] > arr[maxIndex]) maxIndex = i;
        i++;
    }
    
    Console.WriteLine("min = " + arr[minIndex]);
    Console.WriteLine("max = " + arr[maxIndex]);
    int dif = arr[maxIndex] - arr[minIndex];
    return dif;
}


FloodArr(arr);
PrintArr(arr);

Console.WriteLine("Разница между минимальным и максимальным элементами массива = " + DifMinMax(arr));