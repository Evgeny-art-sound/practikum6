// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
void FullArray(int[,] array)
{
    Random rnd = new Random();
    int rowsLength = array.GetLength(0);
    int columnsLength = array.GetLength(1);
    for(int i = 0;i < rowsLength;i++)
       for(int j = 0;j < columnsLength;j++)
          array [i,j] = rnd.Next(-100,100);

}
void PrintArray(int[,]array)
{
    int rowsLength = array.GetLength(0);
    int columnsLength = array.GetLength(1);
    for(int i = 0;i < rowsLength;i++)
    {
        for(int j = 0;j < columnsLength;j++)
            Console.Write(array[i,j] + " ");
    
      Console.WriteLine();
      }
}
void ReplacementOfElements(int[,]array)
{
   int rowsLength = array.GetLength(0);
   int columnsLength = array.GetLength(1);
   for(int i = 0; i < rowsLength;i++)
   {
       if (i % 2 == 0)
       {
           for(int j = 0;j < columnsLength;j++)
           {
               if(j % 2 == 0)
               {
                   array[i,j] = array [i,j] * array[i,j]; 
               }
           }
       }
   }
}
Console.WriteLine("Enter number of columns:  ");
int rows = int.Parse(Console.ReadLine()?? "");
Console.WriteLine("Enter the number of columns:  ");
int columns = int.Parse(Console.ReadLine()?? "");
int [,] array = new int [rows,columns];
FullArray(array);
PrintArray(array);
Console.WriteLine("We replace elements with two even indices and draw the conclusion: ");
Console.WriteLine();
ReplacementOfElements(array);
PrintArray(array);