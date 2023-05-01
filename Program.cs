// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrix1 = Generate2DArray(2, 2);
int[,] matrix2 = Generate2DArray(2, 2);
int[,] prodMatrix = MatrixMultiplication(matrix1, matrix2);
Console.WriteLine("Матрица 1:");
PrintArray(matrix1);
Console.WriteLine("Матрица 2:");
PrintArray(matrix2);
Console.WriteLine("Произведение матриц:");
PrintArray(prodMatrix);


int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2) // Умножение матриц
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (var i = 0; i < matrix1.GetLength(0); i++)
    {
        for (var j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix3[i, j] = 0;

            for (var k = 0; k < matrix1.GetLength(1); k++)
            {
                matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrix3;
}

int[,] Generate2DArray(int m, int n) // Создает двумерный массив
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(1, 4);
        }
    }

    return array;
}

void PrintArray(int[,] array) // Печатает двумерный массив
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"<{array[i, j]}>");
            Console.Write(" ");
        }

        Console.WriteLine();
    }
}