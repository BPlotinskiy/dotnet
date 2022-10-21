// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.Write("Введите Число: ");
int n;
n = int.Parse(Console.ReadLine());
int x =1;
int Cub=0;
while (n>=x)
{
    Cub = x*x*x;
    Console.Write(Cub+", ");
    x = x+1;
}
