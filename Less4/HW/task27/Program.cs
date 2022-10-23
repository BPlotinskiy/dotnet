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

int[] array = new int[8];
static void massivarray( int [] array)
{
for(int i = 0; i < array.Length; i++)
{
 Console.WriteLine(string.Format("Введите {0}й элемент массива:",i+1));
array[i] = Convert.ToInt32(Console.ReadLine());
}
}
massivarray(array);