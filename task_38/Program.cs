//Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

Console.WriteLine("Введите размер  массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i} элемент массива: ");
    int num = Convert.ToInt32(Console.ReadLine());
    array[i] = num;
}
Console.WriteLine(string.Join(", ", array));

int diffMaxMin(int[] array)
{
    int Max = array[0];
    int Min = array[0];
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] > Max) Max=array[i];

        if (array[i] < Min) Min=array[i];

    }
    int diff = Max - Min;  
    return diff;
}

int diff = diffMaxMin(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {diff}");
