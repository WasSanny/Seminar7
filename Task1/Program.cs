// Задаем двумерный массив размером m * n,
// заполненный случайными вещественными числами.

int firstLength = ReadInt("First Length");
int secondLength = ReadInt("Second Length");

double[ , ] array = CreatTwoDimensionArray(firstLength, secondLength); // запускаем

Console.WriteLine(TwoDimensionArray(array));


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

double[, ] CreatTwoDimensionArray(int firstLength, int secondLength ) // ( double [,] ) - Метод, создающий двумерный массив вещественных чисел с длиной первого измерения и второго
{
  double[ , ] result = new double[firstLength, secondLength]; // создаем пустой массив  с параметрами первого измерений и второго изверения 
  Random rnd = new Random(); // создаем рандом

  for (int i = 0; i < result.GetLength(0); i++) //проходим по циклу где, GetLength - длина, а (0) - первое измерение
  {
     for (int j = 0; j < result.GetLength(1); j++) // проходим по циклу с диной второго изверения
     {
        result[i, j] = Math.Round(rnd.NextDouble()* 10, 2); // на позицию (result[i,j]) заполняем и запоминаем случайное число!, NextDouble() создает от 0 до 1, для красоты умножаем на 10
                                                          // Math.Round( , 2), ограничиваем число двумя знаками
      }
  }

  return result;
}

string TwoDimensionArray(double[ , ] array) // Печатаем массив (метод)
{
  string result = string.Empty; // равновисильно: ""; , создаем пустую строку

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      result += $"{array[i , j]} "; 
    }
    
    result += Environment.NewLine; // "\n"; перенос строки на следующую позицию, позвляет заполнять строки и столбцы 
  }

  return result;
}
