void Zadacha52()
{
    Random random = new Random();
    int rows = random.Next(2,7);
    int columns = random.Next(4,10);
    int [,] array = new int [rows, columns];
    FillArray(array);
    PrintArray(array);

Console.WriteLine("Среднее арифметическое по столбцам");
for (int j = 0; j < columns; j++)
{
    double sum = 0;
    for (int i = 0; i < rows; i++)
    {
        sum += array [i, j];
    }
    Console.Write ("");
    Console.Write(sum/rows + "\t");
    
}

void FillArray(int[,] array)
{
    Random random = new Random(); 
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
        array[i, j] = random.Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива");
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i< rows; i++)
    {
        for (int j = 0; j < columns; j++ )
        Console.Write(array [i, j] + "\t");
        Console.WriteLine();
    }
}
}
Zadacha52();
