// Напишите метод, который выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число : ");
int n;
n = int.Parse(Console.ReadLine());

if (n > 100 && n < 999)
{
Console.Write(Metod(n));
}
if (n<100)
{
Console.Write("Отсутствует треья цифра");     
}
if (n>999)
{
Console.Write("Вы ввели не трехзначное число");     
}
int Metod(int a)
{
    
    int result = ((a / 1) % 10);
    return result;
}
