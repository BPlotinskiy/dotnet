//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.Write("Введите пятизначное число: ");
int n;
n = int.Parse(Console.ReadLine());
if (n >=10000 && n <=99999)
{
int num =n;
int rev = 0;
    while (n>0)
    {
       int r = n % 10;
       rev = rev * 10 + r;
       n = n / 10;
    }
    {if (num == rev) 
       {
        Console.Write("является палиндромом");
       }
       else
       {
        Console.Write(" Не является оно палиндромом"); 
       }
    }  
}
else
{
Console.Write("Вы ввели не пятизначное число"); 
};
