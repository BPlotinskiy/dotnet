// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
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
    arra [i] = new Random().Next(1,10);

} 
}
void Summ (int [] arra)
{
    int sum = 0;
    for (int i = 1; i<arra.GetLength(0); i=i+2)
    {
        sum = sum+arra[i];
    }
    Console.WriteLine(sum);
}
int [] array = new int [4];
FillArray (array);
PrinArray (array);
Summ (array);
