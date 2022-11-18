//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 - 2 - 0,2
// 1 - 3,3 8 - 9,9
// 8 7,8 - 7,1 9

// matrix [0,0]  matrix [0,1]  matrix [0,2]  matrix [0,3] 
// matrix [1,0]  matrix [1,1]  matrix [1,2]  matrix [1,3] 
// matrix [2,0]  matrix [2,1]  matrix [2,2]  matrix [2,3] 


void FillMatrix(double[,] matr)
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(-19, 20) + rnd.NextDouble();
            matr[i, j] = Math.Round(matr[i, j], 1); ;
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
double[,] matrix = new double[3, 4];
FillMatrix(matrix);