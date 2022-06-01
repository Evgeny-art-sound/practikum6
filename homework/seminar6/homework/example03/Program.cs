// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
Console.Clear();
void FillArray(int[,] array)
{
    Random rnd = new Random();
    int rowsLength = array.GetLength(0);
    int columnsLength = array.GetLength(1);
    for (int i = 0; i < rowsLength; i++)
        for (int j = 0; j < columnsLength; j++)
            array[i, j] = rnd.Next(-100, 100);

}
void PrintArray(int[,] array)
{
    int rowsLength = array.GetLength(0);
    int columnsLength = array.GetLength(1);
    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
            Console.Write($"{array[i, j]}  ");

        Console.WriteLine();
    }
}
void ChangeNumbers(int[,] array)
{
    int rowsLength = array.GetLength(0);
    int columnsLength = array.GetLength(1);
    for (int i = 0; i < rowsLength; i++)
    {
        if (i % 2 == 0)
        {
            for (int j = 0; j < columnsLength; j++)
            {
                if (j % 2 == 0)
                {
                    array[i, j] = array[i, j] * array[i, j];
                }
            }
        }
    }
}
Console.Write("Введите количество строк:  ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов:  ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
Console.WriteLine("Заменим элементы с четными индексами на их квадраты: ");
Console.WriteLine();
ChangeNumbers(array);
PrintArray(array);
