// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Clear();

int[] array = getArray(4, -9, 9);

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

int SumNum(int[] array)
{
    int sum = 0;
    for (int i = 0; i<array.Length; i++ )
    {
        if (i % 2 != 0)
            {
                sum = sum + array[i];
            }
    }
    return sum;
}

int sum = SumNum(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях в массиве: {sum}");

