// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int getExpNum(int number1, int number2)
{
    int exp = 1;
    for(int i=1; i <= number2; i++)
    {
        exp = exp * number1; 
    }
    return exp;
}

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

int result = getExpNum(num1, num2);  
Console.WriteLine("Результат = " + result);



