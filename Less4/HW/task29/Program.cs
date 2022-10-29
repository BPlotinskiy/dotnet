using System;
// Напишите метод, который задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

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
Console.WriteLine(String.Join(", ", array));
