/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

void FillArray(int [] array)
{
    for(int i = 0; i < array.Length; i++ )
    {
        array [i]= new Random(). Next(1,1000);
    }
}

int FindMAxMin (int [] array)
{
    int Max = array [0];
    int Min = array [0];
    int result = 0;
    for(int i = 0; i < array.Length; i++ )
    {
        if (array [i] > Max) Max = array [i];
        if (array [i] < Min) Min = array [i];
    }
    result = Max - Min;
    return result;
}

Console.WriteLine("Введите размер создаваемого массива: ");
int ArraySize = Convert.ToInt32(Console.ReadLine());
int [] Array = new int [ArraySize];

FillArray(Array);
Console.WriteLine($"[{String.Join(";", Array)}]");

int res = FindMAxMin(Array);
Console.WriteLine($"Разница между максимальным и минимальным числом массива составляет: {res}");