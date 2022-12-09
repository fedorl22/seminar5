// Сравнение двух массивов.

int[] a = { 1, 2, 3, 4, 5, 7 };
int[] b = { 1, 2, 3, 4, 5, 8 };
bool res = true; // res = true,то массивы равны, если res=false, то массивы не равны.
if (a.Length == b.Length)
{
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] != b[i])
        {
            res = false;
        }
    }
    Console.WriteLine(res);
}
Console.WriteLine(false);


// Массив палиндром?
int[] c = { 1, 2, 3, 2, 1};
bool res1 = true; // res = true,сравниваем i и c.Lengh-1-i, если res=false, то массив не полиндром.
for (int i = 0; i < c.Length/2; i++)
{
    if (c[i] != c[c.Length-1-i])
    {
        res1 = false;
    }
}
Console.WriteLine(res1);
