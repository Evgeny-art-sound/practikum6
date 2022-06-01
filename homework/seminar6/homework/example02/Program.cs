// Задать двумерный массив следующим правилом: Aₘₙ = m+n
void FillArray (int [,] array)
{
    for (int m = 0;m < array.GetLength(0);m++)
    {
        for(int n = 0;n < array.GetLength(1);n++)
        {
            array[m,n] = m + n + 2; // Первое число в первой строке 1 + 1 = 2 поправка на человеческое восприятие
        }
    }
}
void PrintArray (int [,]array)
{
    for(int m = 0;m < array.GetLength(0) ;m++)
    {
        for(int n = 0;n < array.GetLength(1);n++)
        {
            Console.Write($"{array[m,n]}  ");
        }
      Console.WriteLine(" ");
    }
}
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()??"");

Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()?? "");

int[,]array = new int[m,n];
Console.WriteLine("Заполним массив с правилом Amn = N + M :");

FillArray(array);
PrintArray(array);
