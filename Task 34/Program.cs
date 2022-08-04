// Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();

int[] array = getArray(4, 100, 1000);

int[] getArray(int size, int min, int max)  
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}   
foreach (int i in array)
{
    Console.Write(i + " "); 
}
Console.WriteLine(); 

int Pos(int[] array)
{
    int pos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            pos++;
        }
    }
    return pos;
}
int pos = Pos(array);
Console.WriteLine($"Количество четных чисел в массиве: {pos}");  
  
  
  
  