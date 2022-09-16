// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



void PrintArray (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1,10);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
  }
} 

int [,] newMatrix = new int[2,2];  
PrintArray(newMatrix);
int a11=newMatrix[0,0];
int a12=newMatrix[0,1];
int a21=newMatrix[1,0];
int a22=newMatrix[1,1];

Console.WriteLine("----------");

PrintArray(newMatrix);
int b11=newMatrix[0,0];
int b12=newMatrix[0,1];
int b21=newMatrix[1,0];
int b22=newMatrix[1,1];

Console.WriteLine("Произведение матриц:");

Console.Write(a11*b11+a21*b21 + "\t");
Console.Write(a11*b12+a12*b22 + "\t");
Console.WriteLine();
Console.Write(a21*b11+a22*b21 + "\t");
Console.Write(a21*b12+a22*b22 + "\t");


Console.WriteLine();

