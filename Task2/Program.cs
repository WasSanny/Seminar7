// Задаем двумерный массив (m на n), каждый элемент в массиве
// задается по формуле А(mn) = m + n. Выводим полученный массив на экран.
// 
// m = 3, n = 4  (пример выводимого массива)
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int firstLength = ReadInt("First Length");
int secondLength = ReadInt("Second Length");

int[,] newArray = CreatTwoDimensionArray(firstLength, secondLength); // запускаем

PrintTwoDimensionArray(newArray);

int ReadInt(string argument) // метод читающий число и проверяющий, что введено именно число
{
  Console.Write($"Input {argument}: ");
  int result = 0;

  while (!int.TryParse(Console.ReadLine(), out result))
  {
    Console.WriteLine("Try again");
  }

  return result;
}

int[,] CreatTwoDimensionArray(int firstLength, int secondLength)
{
  int[,] array = new int[firstLength, secondLength];

  for (int i = 0; i < firstLength; i++)
  {
    for ( int j = 0; j < secondLength; j++)
    {
      array[i,j] = i + j;
    }
  }
  
  return array;
}

void PrintTwoDimensionArray(int[,] array)
{
    
  for (int i = 0; i < array.GetLength(0); i++)
    {
      for ( int j = 0; j < array.GetLength(1); j++)
      {
        Console.Write($"{array[i,j]} ");
      }

    Console.WriteLine(" ");
    }
}
