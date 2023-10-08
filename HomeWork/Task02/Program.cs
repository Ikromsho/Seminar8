// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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


int[] GetArray(int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[i] += matrix[i, j];
        }
    }
    return arr;
}

void MinRowSum(int[,] matrix, int[] arr)
{
    int min = 0;
    for (int j = 1; j < matrix.GetLength(0); j++)
    {
        if (arr[j] < arr[min])
            min = j;
    }
    Console.WriteLine($"Строка с наименьшей суммой чисел {min + 1}");         
}
int rows = GetNum("rows");
int columns = GetNum("columns");

int[,] matrix = GetMatrix(rows, columns, 0, 9);
PrintMatrix(matrix);
System.Console.WriteLine();
int[] array = GetArray(matrix);
Console.WriteLine(string.Join(", ", array));
MinRowSum(matrix, array);
