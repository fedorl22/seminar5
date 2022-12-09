//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и 
// положительных элементов массива. Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма 
// отрицательных равна -20.

int[] array = new int[12];
int sumpositiv = 0;
int sumnegative = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);

    if (array[i] > 0)
    {
        sumpositiv = sumpositiv + array[i];
        i++;
    }
    else
    {
        sumnegative = sumnegative + array[i];
        i++;
    }


}
Console.WriteLine($"Сумма отрицательных элементов массива {sumnegative}");
Console.WriteLine($"Сумма положительных элементов массива {sumpositiv}");
PrintArray(array);


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

(int, int) GetSumPositiveAndNegative(int[] array)
{
    int sumPositiv = 0;
    int sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumPositiv += array[i];
        }
        else
        {
            sumNegative += array[i];
        }
    }
    return (sumPositiv, sumNegative);
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

const int SIZE = 12;
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;
int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(", ", arr));
(int sumP, int sumN) = GetSumPositiveAndNegative(arr);
Console.WriteLine($"Сумма отрицательных элементов массива {sumN},cумма положительных элементов массива {sumP} ");




