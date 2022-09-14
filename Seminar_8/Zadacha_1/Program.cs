// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами 
// первую и последнюю строку массива.


// Console.WriteLine("Первоначальный массив:");
// int[,] array = new int[new Random().Next(1, 10), new Random().Next(1, 10)];

// for(int i=0; i<array.GetLength(0); i++)
// {
// 	for(int j=0; j<array.GetLength(1); j++)
// 	{
// 		array[i, j] = new Random().Next(0, 10);
// 		Console.Write(array[i, j] + "\t");
		
// 	}
// 	Console.WriteLine();
// }

// int[] temp = new int[array.GetLength(1)];

// for(int k=0; k<array.GetLength(1); k++)
// {
// 	temp[k]=array[0, k];
// 	array[0, k]= array[array.GetLength(0)-1, k];
// 	array[array.GetLength(0)-1, k] = temp[k];
// }

// Console.WriteLine("Новый массив:");

// for(int i=0; i<array.GetLength(0); i++)
// {
// 	for(int j=0; j<array.GetLength(1); j++)
// 	{
// 		Console.Write(array[i, j] + "\t");
		
// 	}
// 	Console.WriteLine();
// }


// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна 
// вывести сообщение для пользователя.


// int[,] array = new int[new Random().Next(1, 10), new Random().Next(1, 10)];

// int[,] array = new int[3, 3];

// Console.WriteLine("Первоначальный массив:");
// for(int i=0; i<array.GetLength(0); i++)
// {
// 	for(int j=0; j<array.GetLength(1); j++)
// 	{
// 		array[i, j] = new Random().Next(0, 10);
// 		Console.Write(array[i, j] + "\t");
		
// 	}
// 	Console.WriteLine();
// }

// Console.WriteLine("Новый массив:");
// if (array.GetLength(0)== array.GetLength(1))
// {
// 	for(int i=0; i<array.GetLength(0); i++)
// 	{
// 		for(int j=0; j<array.GetLength(1); j++)
// 		{
// 			Console.Write(array[j, i] + "\t");
// 		}
// 		Console.WriteLine();
// 	}
// }
// else Console.WriteLine("Невозможно сделать замену.");



// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7


// int rows = 3;
// int columns = 3;
 
// int[,] matrix = new int[rows, columns];
 
// int minValue = int.MaxValue; 
// int minIndexRows = 0;        
// int minIndexColumns = 0;   
 
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(11);
//         Console.Write(matrix[i, j] + "\t");
//         if (minValue > matrix[i, j])
        
//         {
//             minValue = matrix[i, j];
//             minIndexRows = i;
//             minIndexColumns = j;
//         }
 
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Минимум:" + minValue);
// System.Console.WriteLine("Результат:");
// for (int i = 0; i < rows; i++) // rows = GetLength(0)
// {
//     if (i != minIndexRows)
//     {
//         for (int j = 0; j < columns; j++) //columns - GetLength(1)
//         {
//             if (j != minIndexColumns)
//             {
//                 Console.Write(matrix[i,j] + "\t");
 
//             }
//         }
//         System.Console.WriteLine();
//     }
// }


