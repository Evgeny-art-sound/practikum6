// Задать двумерный массив следующим правилом: Aₘₙ = m+n
void FullArrayAnm (int [,] array)
{
    for (int m = 0;m < array.GetLength(0);m++)
    {
        for(int n = 0;n < array.GetLength(1);n++)
        {
            array[m,n] = m + n;
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
Console.Write("Enter the number of rows in the array: ");
int m = int.Parse(Console.ReadLine()??"");
Console.Write("Enter the number of columns in the array: ");
int n = int.Parse(Console.ReadLine()?? "");
int[,]array = new int[m,n];
Console.WriteLine("fill array with rule Amn = N + M :");
FullArrayAnm(array);
PrintArray(array);