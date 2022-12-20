// Задача 50. Напишите программу, которая на вход принимает индексы элемента в 
// двумерном массиве и возвращает значение этого элемента или указание,
// что такого элемента нет.

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
Console.WriteLine("Исходный массив: ");
PrintArray(array);

Console.Write("Введите номер строки элемента: ");
int nIndex = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца элемента: ");
int mIndex = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Значение элемента [{nIndex}, {mIndex}] : {ReturnValueArr(array, nIndex, mIndex)}");

int ReturnValueArr(int [,] arr, int i, int j)
{
    if(i>arr.GetLength(0)-1||j>arr.GetLength(1)-1)
    {
        Console.WriteLine("Такого элемента нет!");
        return 0;
    }
    else
        return arr[i,j];
}

int[,] FillArray(int arrayRows, int arrayColumns, int minValue, int maxValue)
{
    int[,] filledArray = new int[arrayRows, arrayColumns];
    Random random = new Random();

    for (int i = 0; i< arrayRows; i++)
        for (int j = 0; j < arrayColumns; j++)
            filledArray[i, j] = random.Next(minValue, maxValue + 1);
    return filledArray;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i< inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if(inputArray[i, j]>=0) 
                Console.Write(" " + inputArray[i, j] + " ");
            else
                Console.Write(inputArray[i, j] + " ");        
        }
        Console.WriteLine();
    }
}
