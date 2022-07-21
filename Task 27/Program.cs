// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


int getSumNums(int number)
{
    int count = Convert.ToString(number).Length;
    int temporary = 0;
    int sum = 0;

    for (int i = 0; i < count; i++)
    {
        temporary = number - number % 10;
        sum = sum + (number - temporary);
        number = number / 10;
    }
    return sum;
}

Console.Write("Введите число- ");
int num = int.Parse(Console.ReadLine());

int result = getSumNums(num);
Console.WriteLine("Сумма цифр = " + result);
