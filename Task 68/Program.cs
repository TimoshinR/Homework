// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int AkkermanFunction(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return AkkermanFunction(m - 1, 1);
  else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}
Console.WriteLine("Функция Аккермана = " + AkkermanFunction(m, n));

