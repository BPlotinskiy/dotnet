// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
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
    arra [i] = new Random().Next(10,100);

} 
}
void Raznic (int [] arra)
{
    int raznica = 0;
    int max = arra [0];
    int min = arra [0];
    for (int i = 0; i<arra.GetLength(0); i=i+1)
    {
        if ( max < arra[i]) max = arra [i];
        if ( min > arra[i]) min = arra [i];
    }
    raznica = max-min;
    Console.WriteLine(raznica);
}
int [] array = new int [4];
FillArray (array);
PrinArray (array);
Raznic (array);