// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и 
//проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Введите число: ");
string num = Console.ReadLine();

void Pal(string num)
{
    if (num[0]==num[4] || num[1]==num[3])
    {
        Console.WriteLine($"Число {num} - палиндром.");
    }
    else Console.WriteLine($"Число {num} - не палиндром.");
}

if (num.Length == 5)
{
    Pal(num);
}
else Console.WriteLine($"{num} - не верное число");


//Console.WriteLine("Введите число:");
//string str = Console.ReadLine();
//int prov = 0;
//for (int i = 0; i < str.Length / 2; i++)
//{
//if (str.Substring(i, 1) != (str.Substring(str.Length - 1 - i, 1)))
//{
//Console.WriteLine("Число {0} не является палиндромом", str);
//break;
//}
//else
//prov = 1;
//}
//if (prov == 1) Console.WriteLine("Число {0} является палиндромом", str);
