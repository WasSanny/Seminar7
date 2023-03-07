// Задаем двумерный массив. Находим сумму элементов находящихся
// на главной диагонали (с индексами (0,0) (1,1) и т.д.)

int firstLength = ReadInt("First Length");
int secondLength = ReadInt("Second Length");

int[,] newArr = CreatTwoDimensionArray(firstLength, secondLength);
int func = GetSumElement(newArr);

Console.WriteLine(TwoDimensionArray(newArr));
Console.WriteLine(func);


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

int GetSumElement(int [,] array) // меняем четные на их квадрат
{
  int min = array.GetLength(0);

  if (array.GetLength(1) < min)
  {
    min = array.GetLength(1);
  }

  int sum = 0;

  for (int i = 0; i < min; i++)
  {
    sum = sum + array[i,i];
  }

  return sum; 
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