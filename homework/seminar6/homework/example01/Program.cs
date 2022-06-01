// Показать двумерный массив размером mXn заполненный вещественными числами
Console.Clear();
void FullArray(double[,] array)
{
    Random rnd = new Random();
    int rowsLength = array.GetLength(0);
    int columnsLength = array.GetLength(1);
    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
        {
            array[i, j] = rnd.NextDouble();
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
            Console.Write(" {0:F8} ", array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine() ?? "");
double[,] array = new double[rows, columns];
FullArray(array);
PrintArray(array);