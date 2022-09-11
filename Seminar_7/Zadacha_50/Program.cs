// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите количество строк: ");
int lines = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());


int [,] matrix = new int [lines, column];

for (int i = 0; i < lines ; i++)
{
    for (int j = 0; j < column; j++)
    {
        matrix[i,j] = new Random().Next(10, 100);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.Write("Введите номер строки: ");
int numberLines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int numberColumn = Convert.ToInt32(Console.ReadLine());

if (lines < numberLines || column < numberColumn)
{
    Console.WriteLine("Такой позиции в массиве нет");
}
else 
Console.WriteLine(matrix[numberLines-1, numberColumn-1]);


Console.Write("Для продолжения нажмите любую клавишу >");
Console.Read();


