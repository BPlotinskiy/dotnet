//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] array = new int[8];

static void massivarray( int [] array)
{
for(int i = 0; i < array.GetLength(0); i++)
{
 Console.WriteLine(string.Format("Введите {0}й элемент массива:",i+1));
array[i] = Convert.ToInt32(Console.ReadLine());
}
}

void bolshe (int [] array)
{
int sum = 0;
for(int i = 0; i < array.GetLength(0); i++)
{
    if (array[i]>0) sum=sum+1;
}
Console.WriteLine(sum);    
}

massivarray(array);
Console.WriteLine(String.Join(", ", array));
bolshe(array);