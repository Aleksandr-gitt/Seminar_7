// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int[,] FillArray()
{
    int[,] SomeNumbers = new int[10,10];

    for(int i = 0; i < 10; i++)
    {
        for(int j = 0; j < 10; j++)
        {
            SomeNumbers[i, j] = new Random().Next(1, 101);
            Console.Write($"{SomeNumbers[i, j]} ");
        }
        Console.WriteLine();
    }
    return SomeNumbers;
}
void FindNumber(int num)
{
    int [,] massive = FillArray();
    int findNum = 0;
    for(int i = 0; i < 10; i++)
    {
        for(int j = 0; j < 10; j++)
        {
            if(massive[i, j] == num) findNum = 1; 
        }
    }
    if(findNum == 1) Console.Write($"{num} - такое число в массиве есть");
    else Console.Write($"{num} - такое число в массиве отсутствует");
}

Console.WriteLine("Введите искомое число от 1 до 100:");
int MyNumber = Convert.ToInt32(Console.ReadLine());

FindNumber(MyNumber);
