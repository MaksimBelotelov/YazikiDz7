// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.

Console.Clear();

Console.Write("Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов двумерного массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(rows, columns, min, max);
PrintArray(array);

Console.Write("Средние арифметические столбцов: ");

for (int j = 0; j < array.GetLength(1); j++)
    Console.Write(string.Format("{0:F2}; ", AvgInColumn(array, j)));


int[,] FillArray(int arrayRows, int arrayColumns, int minValue, int maxValue)
{
    int[,] filledArray = new int[arrayRows, arrayColumns];
    Random random = new Random();

    for (int i = 0; i < arrayRows; i++)
        for (int j = 0; j < arrayColumns; j++)
            filledArray[i, j] = random.Next(minValue, maxValue + 1);
    return filledArray;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if (inputArray[i, j] >= 0)
                Console.Write(" " + inputArray[i, j] + " ");
            else
                Console.Write(inputArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

double AvgInColumn(int[,] arr, int column)
{
    double avg = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
        avg += arr[i, column];
    avg /= arr.GetLength(0);

    return avg;
}