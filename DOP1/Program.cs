// Задайте двумерный массив из целых чисел. Определите, есть ли в массиве
// столбец, сумма которого больше суммы элементов, расположенных в четырех углах

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

int cornerSum = array[0, 0] + array[0, array.GetLength(1) - 1] + array[array.GetLength(0) - 1, 0] + array[array.GetLength(0) - 1, array.GetLength(1) - 1];
Console.WriteLine($"Сумма угловых элементов: {cornerSum}");

if(IsSumColMoreCorn(array, cornerSum)) 
    Console.WriteLine($"В массиве есть столбец, сумма элеметов которого больше суммы угловых элементов.");
else
     Console.WriteLine($"В массиве нет столбца, сумма элеметов которого больше суммы угловых элементов.");


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

bool IsSumColMoreCorn(int[,] arr, int sumCorn)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
            sum += arr[i, j];
        if (sum > sumCorn)
            return true;
    }
    return false;
}