// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
//1) объявить переменные: длину строк и столбцов;
//2) сгенирировать и напечатать матрицу;
//3) посчитать сумму элементов в каждом столбце;
//4) разделить сумму на обявленую переменную длина строки.

Console.WriteLine("Введите размер матрицы через Enter ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[x, y];
Random rnd = new Random();
void fillandPrintMatrix(int[,] matrix) //метод создания и печати
{
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            matrix[i, j] = rnd.Next(0, 20);
            Console.Write(matrix[i, j] + "\t");

        }
        Console.WriteLine();
    }
}
Console.WriteLine();
fillandPrintMatrix(matrix);
Console.WriteLine("среднее арифметическое элементов в каждом столбце =");

for (int j = 0; j < matrix.GetLength(1); j++)
{
    double summ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        summ += matrix[i, j];
    }
    summ = summ / x;
    Console.Write($"{summ:f1}" + "\t");
}







