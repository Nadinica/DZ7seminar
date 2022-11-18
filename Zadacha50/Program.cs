//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

//1. Создать и напечатать двуменрный массив;
//2 Объявить искомые переменные;
//3 проверить наличие введенного индекса;
//4 вывести результат на консоль;

void FillandPrint(int[,] matrix)
{
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 20);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите параметры искомой позиции через Enter ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] matr = new int[10, 10];
FillandPrint(matr);

if (x <= matr.GetLength(0) - 1)
{
    if (y <= matr.GetLength(1) - 1)
    {
        Console.Write("Значение искомого элемента = ");
        Console.WriteLine(matr[x, y]);
    }
    else
    {
        Console.WriteLine("такого элемента нет, искомый элемент находится вне границ массива.");
    }
}
else
{
    Console.WriteLine("такого элемента нет, искомый элемент находится вне границ массива.");
}
