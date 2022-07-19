// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("введите xa");
int xa = int.Parse(Console.ReadLine());
Console.WriteLine("введите ya");
int ya = int.Parse(Console.ReadLine());
Console.WriteLine("введите za");
int za = int.Parse(Console.ReadLine());
Console.WriteLine("введите xb");
int xb = int.Parse(Console.ReadLine());
Console.WriteLine("введите yb");
int yb = int.Parse(Console.ReadLine());
Console.WriteLine("введите zb");
int zb = int.Parse(Console.ReadLine());
double Distance (int xa, int ya, int za, int xb, int yb, int zb)
{
    double Dis = Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb - ya),2) + Math.Pow((zb - za),2));
    return Dis;
}
Console.Write("Distanc - ");
Console.WriteLine(Distance (xa, ya, za, xb, yb, zb));
