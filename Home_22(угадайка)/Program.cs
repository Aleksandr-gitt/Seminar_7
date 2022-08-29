// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// !!!УГАДАЙКА!!!


void FillAndFind(int num, int row, int col)
{
    int[,] SomeNumbers = new int[10,10];

    for(int i = 0; i < 10; i++)
    {
        for(int j = 0; j < 10; j++)
        {
            SomeNumbers[i, j] = new Random().Next(0, 2);
            Console.Write($"{SomeNumbers[i, j]}|");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    if(SomeNumbers[row, col] == num) Console.WriteLine("В заданом пересечении строки и столбца есть искомое число");
    else Console.WriteLine("В заданом пересечении строки и столбца нет искомого числа");
}

Console.WriteLine("Угадай число от 0 до 1:");
int MyNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите строку для поиска(с 1 по 10):");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец для поиска(с 1 по 10):");
int column = Convert.ToInt32(Console.ReadLine());

FillAndFind(MyNumber, row, column);
