﻿// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int [] array = new int [10];
int positivNum = 0;

for (int i = 0; i < array.Length; i++)
{
int num = new Random().Next(100, 1000);
Console.Write(" " + num);
if (num%2 == 0)
    {
        positivNum ++;
    }
    
}

Console.Write ("->" + positivNum);
Console.ReadKey();
