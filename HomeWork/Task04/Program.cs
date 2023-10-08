// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int[,] GetMatrix (int row, int column)
{
    int[,] matrix = new int [row, column];
    matrix[0, 0] = 1;
    int count = 1;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            matrix[i, j] = count++;
    }
    return matrix;
}

int[,] Spiral (int[,] matrix)
{
    int count = 1;
    int startRow = 0;
    int startColumn = 0;
    int endRow = matrix.GetLength(0) - 1;
    int endColumn = matrix.GetLength(1) - 1;
    while (startRow <= endRow && startColumn <= endColumn)
    {
        for (int i = startColumn; i <= endColumn; i++)
            matrix[startRow, i] = count++;
        startRow++;
        for (int i = startRow; i <= endRow; i++)
            matrix[i, endRow] = count++;
        endColumn--;
        for (int i = endColumn; i >= startColumn; i--)
            matrix[endRow, i] = count++;
        endRow--;
        for (int i = endRow; i >= startRow; i--)
            matrix[i, startColumn] = count++;
        startColumn++;
    }
    return matrix;
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}\t");
        Console.WriteLine();
    }
}

int[,] matrix = GetMatrix(4, 4);
PrintMatrix(matrix);
Console.WriteLine();
Spiral(matrix);
PrintMatrix(matrix);