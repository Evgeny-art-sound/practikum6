// Показать двумерный массив размером mXn заполненный вещественными числами
Console.Clear();
void FillArray(double[,] array)
{
    Random rnd = new Random();
    int rowsLength = array.GetLength(0);
    int columnsLength = array.GetLength(1);
    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
        {
            array[i, j] = new Random().Next(-10000,10000);
        }
    }
}

void PrintArray(double[,] array)
{
    int rowsLength = array.GetLength(0);
    int columnsLength = array.GetLength(1);
    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
        {
            Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine() ?? "");
double[,] array = new double[rows, columns];
FillArray(array);
PrintArray(array);