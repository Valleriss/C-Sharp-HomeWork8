// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array = FillArray(4, 4);
PrintArray(array);

int[,] FillArray(int row, int col) // Спирально заполняет массив 4х4 последовательностью чисел от 1 до 16
{
    int[,] array = new int[row, col];
    int counter = 1;
    for (int i = 0; i < row; i++)
    {
        array[0, i] = counter;
        counter++;
    }
    for (int i = 1; i < col; i++)
    {
        array[i, col - 1] = counter;
        counter++;
    }
    for (int i = 2; i >= 0; i--)
    {
        array[row - 1, i] = counter;
        counter++;
    }
    for (int i = 2; i > 0; i--)
    {
        array[i, 0] = counter;
        counter++;
    }
    for (int i = 1; i < row - 1; i++)
    {
        array[1, i] = counter;
        counter++;
    }
    for (int i = 2; i >= 1; i--)
    {
        array[2, i] = counter;
        counter++;
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