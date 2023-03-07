// Задаем двумерный массив (m на n), 1-й и 2 элемент массива задаются рандомом.
// Остальные элеменнты - суумированием предыдущих.
// Выводим полученный массив на экран.
// 

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
  Random rnd = new Random();

  array[0,0] = rnd.Next(0, 11); // первые два числа рандом от 0 до 10 включительно
  array[0,1] = rnd.Next(0, 11); //
  int sum = array[0,0] = array[0,1];
  int firstJ = 2;

  for (int i = 0; i < firstLength; i++)
  {
    for (int j = firstJ; j < secondLength; j++)
    {
      array[i,j] = sum;
      sum += array[i,j];
    }
    firstJ = 0;
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
