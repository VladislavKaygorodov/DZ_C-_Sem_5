/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

void FillArray(int [] array)
{
    for(int i = 0; i < array.Length; i++ )
    {
        array [i]= new Random(). Next(100,1000);
    }
}

int KollPosNum (int [] array)
{
    int kollNum = 0;
    for ( int i = 0; i<array.Length; i++)
    {
        if (array [i] % 2 == 0)
        {
            kollNum++;
        }
    }
    return kollNum;
}

Console.WriteLine("Введите размер создаваемого массива: ");
int ArraySize = Convert.ToInt32(Console.ReadLine());
int [] Array = new int [ArraySize];

FillArray(Array);
Console.WriteLine($"[{String.Join(";", Array)}]");

int SumNum = (KollPosNum(Array));
Console.WriteLine($"Колличество четных чисел в массиве составляет: {SumNum}");