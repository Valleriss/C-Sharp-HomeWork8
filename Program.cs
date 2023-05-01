// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int rowCount = 3;
int colCount = 4;
int[,] array = Generate2DArray(rowCount, colCount);

Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine("Сортировка по строкам:");
SortRow();
PrintArray(array);

void SortRow()
{
    int[] row = new int[colCount];
    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < colCount; j++)
            row[j] = array[i, j];
        BubbleSort(row);
        Insert(i, row, array);
    }
}

void Insert(int i, int[] source, int[,] dest) // Вставляет отсортированные значения в исходный двумерный массив
{
    for (int k = 0; k < source.Length; k++)
    {
            dest[i, k] = source[k];
    }
}

void BubbleSort(int[] array) // Сортирует одномерный массив
{
    for (int i = 0; i < array.Length; i++)
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] < array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
}

int[,] Generate2DArray(int m, int n) // Создает двумерный массив
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(0, 10);
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