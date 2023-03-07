// Задаем двумерный массив. Находим элементы у которых оба индекса четные и
// заменяем эти элементы на их квадраты!

int firstLength = ReadInt("First Length");
int secondLength = ReadInt("Second Length");

int[,] newArr = CreatTwoDimensionArray(firstLength, secondLength);
int[,] func = GetevenIndex(newArr);
Console.WriteLine(TwoDimensionArray(newArr));
Console.WriteLine(TwoDimensionArray(func));




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
  int[,] result = new int[firstLength, secondLength];

  for (int i = 0; i < firstLength; i++)
  {
    for ( int j = 0; j < secondLength; j++)
    {
      result[i,j] = i + j;
    }
  }
  
  return result;
}

int[,] GetevenIndex(int [,] array) // меняем четные на их квадрат
{
  int[,] newResult = new int[array.GetLength(0), array.GetLength(1)];

  for (int i = 0; i < newResult.GetLength(0); i++)
  {
    for (int j = 0; j < newResult.GetLength(1); j++)
    {
      if ((i + 1) % 2 == 0 && (j + 1) % 2 == 0)
      {
        newResult[i, j] = array[i, j] * array[i, j];
      }
      else
      {
        newResult[i, j] = array[i,j];
      }
    }
    
  }

 return newResult; 
}

string TwoDimensionArray(int[,] array) // Печатаем массив (метод)
{
  string result = string.Empty; // равновисильно: ""; , создаем пустую строку

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      result += $"{array[i,j]} "; 
    }
    
    result += Environment.NewLine; // "\n"; перенос строки на следующую позицию, позвляет заполнять строки и столбцы 
  }

  return result;
}
