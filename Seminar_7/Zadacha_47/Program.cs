﻿// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк: ");
int lines = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double [lines, column];
Random random = new Random();

for (int i = 0; i < lines ; i++)
{
    for (int j = 0; j < column; j++)
    {
        matrix[i,j] = random.NextDouble() * 100;
        Console.Write(Math.Round(matrix[i, j], 2)+ "\t");
    }
    Console.WriteLine();
}
Console.Write("Для продолжения нажмите любую клавишу >");
Console.Read();
