// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2





// var matrix = new int[5, 5];
//             var rnd = new Random();
 
//             for (int i = 0; i < matrix.GetLength(0); i++)
//             {
//                 for (int j = 0; j < matrix.GetLength(1); j++)
//                 {
//                     matrix[i, j] = rnd.Next(12, 45);
//                     Console.Write(matrix[i, j] + " ");
//                 }
//                 Console.WriteLine();
//             }
//             Console.WriteLine();
 
//             var arr = matrix.Cast<int>().OrderByDescending(a => a).ToArray();
 
//             int c = 0;
//             for (int j = 0; j < matrix.GetLength(0); j++)
//             {
//                 for (int k = 0; k < matrix.GetLength(1); k++)
//                 {
//                     matrix[j, k] = arr[c];
//                     Console.Write(matrix[j, k] + " ");
//                     c++;
//                 }
//                 Console.WriteLine();
//             }
//             Console.ReadKey();










Console.WriteLine("Первоначальный массив: ");
//int [,] matrix = new int[new Random().Next(1,10), new Random().Next(1,10)];
int [,] matrix = new int[5,5];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(1,10);
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();

}
Console.WriteLine("Преобразованный массив:");
int [,] arrey = new int [5,5];
int max = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
       if (matrix[i, j] > max)
       {
        max = matrix[i, j];
        matrix[i, j]=arrey[i, j];
        arrey[i, j]=max;
        
       }
       Console.Write(matrix[i, j]+ "\t");
    }
    
    Console.WriteLine();

}
Console.ReadKey();









// using System;
// namespace BabbleSort
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             int colCount = 6;//m
//             int rowCount = 6;//n
//             int[,] arr = GenerateArray(rowCount, colCount);
//             Console.WriteLine("Исходный массив");
//             PrintArray(arr);
//             Console.WriteLine("Сортировка по строкам: ");
//             int[] row = new int[colCount];
//             for (int i = 0; i < rowCount; i++)
//             {
//                 for (int j = 0; j < colCount; j++)
//                     row[j] = arr[i, j];
//                 BubbleSort(row);
//                 Insert(true, i, row, arr);
//             }
//             PrintArray(arr);
//         }
//         public static void Insert(bool isRow, int dim, int[] source, int[,] dest)
//         {
//             for (int k = 0; k < source.Length; k++)
//             {
//                 if (isRow)
//                     dest[dim, k] = source[k];
//                 else
//                     dest[k, dim] = source[k];
//             }
//         }
//         public static int[,] GenerateArray(int t, int i)
//         {
//             int[,] table = new int[t, i];
//             Random random = new Random();
//             for (int a = 0; a < t; a++)
//             {
//                 for (int b = 0; b < i; b++)
//                 {
//                     table[a, b] = random.Next(0, 9);
//                 }
//             }
//             return table;
//         }
//         public static void PrintArray(int[,] array)
//         {
//             for (int a = 0; a < array.GetLength(0); a++)
//             {
//                 for (int b = 0; b < array.GetLength(1); b++)
//                 {
//                     Console.Write(array[a, b] + " ");
//                 }
//                 Console.WriteLine();
//             }
//         }
//         static void BubbleSort(int[] inArray)
//         {
//             for (int i = 0; i < inArray.Length; i++)
//                 for (int j = 0; j < inArray.Length - i - 1; j++)
//                 {
//                     if (inArray[j] > inArray[j + 1])
//                     {
//                         int temp = inArray[j];
//                         inArray[j] = inArray[j + 1];
//                         inArray[j + 1] = temp;
//                     }
//                 }
//         }
//     }
// }










// Задача 56: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку
//  с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Задача 60. ...Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя 
// индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, 
// которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// Задача 61: Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника
