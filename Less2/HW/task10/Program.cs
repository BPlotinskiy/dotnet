//Напишите метод, который принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите число : ");
int n;
n = int.Parse(Console.ReadLine());

if (n > 100 && n < 999)
{
Console.Write(Metod(n));
}
else
{
Console.Write("Вы ввели не трехзначное число"); 
};

int Metod(int n)
{
    
    int result = ((n / 10) % 10);
    return result;
}