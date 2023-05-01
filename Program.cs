// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] array = Generate2DArray(4, 4);
PrintArray(array);
int[] sumArray = GetSumElementsArray(array);
int minRow = FindMinElement(sumArray);
Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow + 1}");


int FindMinElement(int[] array) // Находит индекс наименьшего элемента
{
    int min = array[0];
    int index = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            index = i;
        } 
    }
    return index;
}


int[] GetSumElementsArray(int[,] array) // Создает массив сумм элементов каждой строки двумерного массива
{
    int[] sumArray = new int[array.GetLength(0)];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        int sumElements = 0;
        for (var j = 0; j < array.GetLength(1); j++)
        {
            sumElements += array[i, j];
        }
        sumArray[i] =  sumElements;
    }
    return sumArray;
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