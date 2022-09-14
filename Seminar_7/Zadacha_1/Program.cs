// Console.Write("Сколько чисел вы хотите ввести? ");
// int numb = Convert.ToInt32(Console.ReadLine());

// int[] array = new int [numb];

// int PositiveCount(int count)
// {
//     int countOfPositive = 0;
//     for(int i = 0; i < count;i++)
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine());
//         if (array[i] > 0)
//         {
//             countOfPositive+=1;
//         }
//         Console.WriteLine("[{0}]",string.Join(",", array));
//     }
//     return countOfPositive;
// }
// int posCount = PositiveCount(numb);
// Console.Write($"количество положительных чисел = {posCount}");



// Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// int rows  = Convert.ToInt32(Console.ReadLine()); // int rows = int.Parse(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());

// double [,] matrix = new double [rows,columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(1,11);
//         Console.Write(matrix[i,j] + "\t");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine();

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if(i%2==0 && j%2==0)
//         {
//             matrix[i,j] = Math.Pow(matrix[i,j],2);
//         }
//         Console.Write(matrix[i,j] + "\t");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine();

// int columns = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();
// int [,] matrix = new int [rows,columns];

// for(int i =0; i<matrix.GetLength(0); i++)
// {
//     for(int j =0; j<matrix.GetLength(1); j++)
//     {   
//         matrix[i,j] = new Random().Next(0,11);
//         Console.Write(matrix[i,j]+ "\t"); // вместо пробела " " можно поставить "\t"
//     }
//     Console.WriteLine();
// }


// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Console.WriteLine("Введите число строк: ");
// int rows  = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine();
// Console.WriteLine("Введите число столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int [,] matrix = new int [rows,columns];

// for(int i =0; i<matrix.GetLength(0); i++)
// {
//     for(int j =0; j<matrix.GetLength(1); j++)
//     {   
//         matrix[i,j] = i+j;
//         Console.Write(matrix[i,j]+ "\t");
//     }
//     Console.WriteLine();
// }


// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows,columns];

// for(int i=0; i<rows; i++)
// {
// 	for(int j=0; j<columns; j++)
// 	{
// 		array[i,j]=i+j;
// 		Console.Write(array[i,j] + "\t");

// 	}
// 	Console.WriteLine();
// }



// Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.


// int rows = int.Parse(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());

// double [,] matrix = new double [rows,columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(1,11);
//         Console.Write(matrix[i,j] + "\t");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine();

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if(i%2==0 && j%2==0)
//         {
//             matrix[i,j] = Math.Pow(matrix[i,j],2);
//         }
//         Console.Write(matrix[i,j] + "\t");
//     }
//     Console.WriteLine();
// }



// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали
//  (с индексами (0,0); (1;1) и т.д.


int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int[rows, columns];
int sum = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        if (i == j)
        {
            sum +=matrix[i,j] ;
        }
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine($"Сумма = {sum}");
