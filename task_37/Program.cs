// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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
int[] Mylt1Size(int size, int[] array)
{
        int[] arr1 = new int[size / 2 + size%2];

        
        for (int i = 0; i < size / 2; i++)
        {
            arr1[i] = array[i] * array[size - i-1];
        }
        if ( size % 2==1)
        {
             arr1[arr1.Length-1]=array[size / 2 ];
        }
    return arr1;
}

Console.WriteLine("Введите размер рандомного массива: ");
int SIZE = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите нижнюю границу диапазона: ");
int LEFTRANGE = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхнюю границу диапазона: ");
int RIGHTRANGE = Convert.ToInt32(Console.ReadLine());
int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
PrintArray(arr);
int[] arr1 = Mylt1Size(SIZE, arr);
PrintArray(arr1);