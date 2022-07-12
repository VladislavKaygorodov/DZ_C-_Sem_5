/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/



void FillArray(int [] array)
{
    for(int i = 0; i < array.Length; i++ )
    {
        array [i]= new Random(). Next(-1000,1000);
    }
}

int SumNegNum (int [] array)
{
    int kollNum = 0;
    for ( int i = 0; i<array.Length; i++)
    {
        if (array [i] % 2 == 1)
        {
            kollNum += array [i];
        }
        if (array [i] % 2 == -1)
        {
             kollNum += array [i];
        }
    }
    return kollNum;
}


Console.WriteLine("Введите размер создаваемого массива: ");
int ArraySize = Convert.ToInt32(Console.ReadLine());
int [] Array = new int [ArraySize];

FillArray(Array);
Console.WriteLine($"[{String.Join(";", Array)}]");

int SumNum = SumNegNum(Array);
Console.WriteLine($"Сумма нечетных чисел в массиве составляет: {SumNum}");