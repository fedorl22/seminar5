// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число 
// в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

//Массивы к задачам 32 и 33 можно сделать рандомными. В задаче 33 на экран выводится ТОЛЬКО одно сообщение: либо "да", либо "нет".

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
Console.WriteLine("Введите искомое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
PrintArray(arr);
isNumberInArray(arr, N);
bool result = isNumberInArray(arr,N);
if(result==true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

bool isNumberInArray(int[] array, int findNumber)
{
    bool res =false; // изначально полагаем, что элемента в массиве нет.
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]==N)
        {
        res = true;
        break; 
         }
    
    }
 return res;
}
