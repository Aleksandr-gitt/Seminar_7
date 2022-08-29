// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();

int[,] FillArray()
{
    int[,] SomeNumbers = new int[4, 4];

    for(int i = 0; i < 4; i++)
    {
        for(int j = 0; j < 4; j++)
        {
            SomeNumbers[i, j] = new Random().Next(1, 11);
            Console.Write($"{SomeNumbers[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return SomeNumbers;
}

void Average()
{
    int[,] mass = FillArray();
    Console.Write("Среднее арифметическое каждого столбца: ");
    
    for(int i = 0; i < mass.GetLength(0); i++)
    {
        int sum = 0; 
        for(int j = 0; j < mass.GetLength(1); j++)
        {
            sum = sum + mass[j, i];
        }
        double AveNum = (double)sum/mass.GetLength(0);
        Console.Write($"{AveNum} ");
    }
    
}

Average();