// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int temporary = m;

if (m > n) 
{
  m = n; 
  n = temporary;
}

int SumRec(int n)
{
  if(n >= m) return n + SumRec(n - 1);
  else return 0;
}
Console.WriteLine("Cумма = " + SumRec(n));