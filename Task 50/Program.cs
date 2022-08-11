//Задача 50. 
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.\n");

int[,] array = new int[m, n];

GetArray(array);

WriteArray(array);

Console.WriteLine();

void GetArray(int[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().Next(0, 10);
    }
  }
}

void WriteArray (int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            int num = array[i, j];
            Console.Write(num + " ");
        }
    Console.WriteLine();
    }
}

Console.Write("Введите координаты позиции элемента, разделенных запятой: ");
string posNumbers = Console.ReadLine();

int[] pos = Selection(posNumbers);

if(pos[0] <= m && pos[1] <= n && pos[0] >= 0 && pos[1] >= 0) 
{
  int result = array[pos[0], pos[1]];
  Console.Write($"Значение элемента: {result}\n");
}
else Console.Write($"Заданного элемента в массиве нет.\n");

int[] Selection(string input)
{
  int count = 1;
  for (int i = 0; i < input.Length; i++)
  {
      if (input[i] == ',')
          count++;
  }

  int[] inArray = new int[count];
  int index = 0;

  for(int i = 0; i < input.Length; i++)
  {
    string str = String.Empty;

    while (input[i] != ',')
    {
      str += input[i].ToString();
      if (i >= input.Length - 1)
        break;
      i++;
    }
    inArray[index] = Convert.ToInt32(str);
    index++;
  }
  return inArray;
}
