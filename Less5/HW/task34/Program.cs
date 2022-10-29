// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void PrinArray ( int [] arra)
{
for (int i = 0; i<arra.GetLength(0); i++)
{
Console.WriteLine(arra[i]);
} 
}
void FillArray(int [] arra)
{
    for (int i = 0; i<arra.GetLength(0); i++)
{
    arra [i] = new Random().Next(100,999);

} 
}
void Summ (int [] arra)
{
    int sum = 0;
    for (int i = 0; i<arra.GetLength(0); i++)
    {
        if ((arra[i]%2) ==0)
        sum = sum+1;

    }
    Console.WriteLine(sum);
}
int [] array = new int [5];
FillArray (array);
PrinArray (array);
Summ (array);