// Задача 47. Задайте двумерный массив размером m*n, заполненный
// случайными вещественными числами.
Console.Clear();

Console.Write("Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов двумерного массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение: ");
double min = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите максимальное значение: ");
double max = Convert.ToDouble(Console.ReadLine());

double[,] array = FillArray(rows, columns, min, max);
PrintArray(array);

double[,] FillArray(int arrayRows, int arrayColumns, double minValue, double maxValue)
{
    double[,] filledArray = new double[arrayRows, arrayColumns];
    Random random = new Random();

    for (int i = 0; i< arrayRows; i++)
        for (int j = 0; j < arrayColumns; j++)
            filledArray[i, j] = random.NextDouble()*(maxValue-minValue)+minValue;
    return filledArray;
}

void PrintArray(double[,] inputArray)
{
    string outElement=string.Empty;

    for (int i = 0; i< inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {    
                outElement= (inputArray[i,j]>=0) ? string.Format(" {0:F2} ",inputArray[i, j]) : outElement=string.Format("{0:F2} ",inputArray[i, j]);
                Console.Write(outElement);    
        }
        Console.WriteLine();
    }
}