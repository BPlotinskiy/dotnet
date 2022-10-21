using System.Diagnostics.CodeAnalysis;
// опишите метод, который принимает на вход два числа (A и B) и возводит число A в целую степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
//без math.pow
Console.Write("Введите Число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите Число B: ");
int b = int.Parse(Console.ReadLine());
void step (int a, int b)
{
    int i = 1;
    int step =a;
    while (i<b)
        {
        step=step*a;
        i=i+1;
        }
    Console.WriteLine(step);

}
step(a,b);



