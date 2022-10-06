//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int a=155;
int b=8;
int c = 10;
int max=a;
if (a>max) max=a;
if (b>max) max=b;
if (c>max) max=c;
Console.Write("max = ");
Console.WriteLine(max);
Console.ReadLine();