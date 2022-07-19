// Задача 23
//Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите целое число");
int number = int.Parse(Console.ReadLine());

double Result(int i) 
{
     return Math.Pow(i, 3);
}
for (int i = 1; i <= number; i++)
{
    Console.WriteLine(Result(i));
}
