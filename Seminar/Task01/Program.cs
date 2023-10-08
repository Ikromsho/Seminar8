// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

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

void FormatingMatrix(int[,] matrix)
{
    int temp = -1;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0)-1, i];
        matrix[matrix.GetLength(0)-1, i] = temp;
    }
}

int rows = GetNum("rows");
int columns = GetNum("columns");

int[,] matrix = GetMatrix(rows, columns);
PrintMatrix(matrix);
System.Console.WriteLine();
FormatingMatrix(matrix);
PrintMatrix(matrix);
