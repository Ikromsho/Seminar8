// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int GetNum(string message = "")
{
    System.Console.Write($"Введите число {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] GetMatrix(int rows, int columns, int minValue = 0, int maxValue = 99)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void Exchange(int[,] matrix)
{
    int rows = 0;
    int columns = 0;
    if(matrix.GetLength(0) == matrix.GetLength(1))
    {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            rows = matrix[i, j];
            columns = matrix[j, i];
            matrix[i, j] = columns;
            matrix[j, i] = rows;
        }
    }
    }
    else
    {
        System.Console.WriteLine("Длина строк и столбцов не совпадает, изменение массива невозможно.");
    }
}

int rows = GetNum("rows");
int columns = GetNum("columns");

int[,] matrix = GetMatrix(rows, columns);
PrintMatrix(matrix);
System.Console.WriteLine();
Exchange(matrix);
PrintMatrix(matrix);
