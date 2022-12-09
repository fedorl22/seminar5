// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


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
int arraySumOdd(int[] array)
{
    int sumOddNumber = 0;
    for (int i = 1; i < array.Length; i=i+2)
    {
            sumOddNumber=sumOddNumber+array[i];
    }
    return sumOddNumber;
}
Console.WriteLine("Введите размер рандомного массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите нижнюю границу рандомного диапазона: ");
int LEFTRANGE = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхнюю границу рандомного диапазона: ");
int RIGHTRANGE = Convert.ToInt32(Console.ReadLine());
int[] arr = GetRandomArray(size, LEFTRANGE, RIGHTRANGE);
PrintArray(arr);
int sumOdd = arraySumOdd(arr);
Console.WriteLine($"Сумма элементов массива стоящих на нечетных позициях равна {sumOdd}");