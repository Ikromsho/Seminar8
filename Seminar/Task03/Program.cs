// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int[,] GetMatrix(int rows = 5, int columns = 5, int minValue = 1, int maxValue = 100)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = rand.Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write($"{matrix[i, l]}\t");
        }
        Console.WriteLine();
    }
}

void MinIndexELemMas(int[,] matrix, out int row, out int column)
{
    row = 0;
    column = 0;
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min > matrix[i, j])
            {
                row = i;
                column = j;
                min = matrix[i, j];
            }
        }
    }
}
int[,] GetNewMatrixDelete(int[,] matrix, int row, int column)
{
    int i1 = 0;
    int[,] array = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == row)
        {
            continue;
        }
        int j1 = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == column)
            {
                continue;
            }
            array[i1, j1] = matrix[i, j];
            j1++;
        }
        i1++;
    }
    return array;
}

int row = 0;
int column = 0;
int[,] matrix = GetMatrix();
PrintMatrix(matrix);
MinIndexELemMas(matrix, out row, out column);
int[,] arr = GetNewMatrixDelete(matrix, row, column);
Console.WriteLine();
PrintMatrix(arr);
