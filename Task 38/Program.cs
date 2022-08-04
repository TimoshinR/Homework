// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Clear();

double[] array = getArray(5, 1, 10);

double[] getArray(int size, int min, int max)  
{
    double[] result = new double[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}   
foreach (double i in array)
{
    Console.Write(i + " "); 
}
Console.WriteLine();

double DifMaxMin(double[] array)
{
    double min = array[0];
    double max = array[0];
    double dif = 0;
    for (int i = 0; i<array.Length; i++ )
    {
        if (max < array[i])
            {
                max = array[i];
            }
            if (min > array[i])
                {
                    min = array[i];
                }
    } 
    dif = max - min;  
    return dif; 
}   

double Dif = DifMaxMin(array);
Console.WriteLine($"Разница между максимальным и минимальным значениями элементов массива: {Dif}");
Console.WriteLine();
