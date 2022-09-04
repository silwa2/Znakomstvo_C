// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int [] array = new int [5];
int max = 0, min = 110, numArray = 0;

for (int i = 0; i < array.Length; i++)
{
    numArray = new Random().Next(0,100);
    Console.Write(" " + numArray);
    
    if (numArray > max)
    {
        max = numArray;
    }
    if (numArray < min)
    {
        min = numArray;
    }
}
Console.Write ("->" + (max - min));
Console.ReadKey();


