//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] matrix = new int[3, 4];
void PrintArray (int [,] matr)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
 for (int j = 0; j <matrix.GetLength(1); j++)
 {
 Console.Write($"{matrix[i, j]} ");
 }
Console.WriteLine();
}
}
void FillArray(int[,] matr)
{
 for (int i = 0; i < matr.GetLength(0); i++)
 {
 for (int j = 0; j < matr.GetLength(1); j++)
 {
 matr[i,j] = new Random().Next(1,10);
 }
 }
}
void Summ(int[,] matr)
{
int Sum = 0;

 for (int i = 0; i < matr.GetLength(0); i++)
 {
 
 for (int j = 0; j < matr.GetLength(1); j++)
 {
 Sum = Sum + matr[i, j];
 
 }
 Console.Write($"{ Sum / matr.GetLength(0)} ");
 }
}
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Summ(matrix);