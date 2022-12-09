//Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 



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

Console.WriteLine("Введите размер рандомного массива: ");
int SIZE = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите нижнюю границу диапазона: ");
int LEFTRANGE = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхнюю границу диапазона: ");
int RIGHTRANGE = Convert.ToInt32(Console.ReadLine());
int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
PrintArray(arr);
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i]* ( -1);
    }
}
PrintArray(arr);

