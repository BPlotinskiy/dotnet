//  Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.Write("Введите Число: ");
int n;
n = int.Parse(Console.ReadLine());
void sum (int n)
{
int sum = 0;
   while (n>0)
   {
     int dig = n%10;
     sum = sum + dig;
     n = n/10;
   }
   Console.WriteLine(sum);
}
sum(n);
