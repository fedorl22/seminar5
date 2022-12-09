// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2



int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}| ");
    }
    Console.WriteLine();
}
int arraySumEven(int[] array)
{
    int sumEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sumEven=sumEven+1;
        }
    }
    return sumEven;
}
Console.WriteLine("Введите размер рандомного массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = GetRandomArray(size, 100, 999);
PrintArray(arr);
int sum = arraySumEven(arr);
Console.WriteLine($"Количество четных элементов массива {sum}");


