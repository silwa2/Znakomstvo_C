// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] array = new int [10];
int posiziya = 0, numArray = 0;

for (int i = 0; i < array.Length; i++)
{
    numArray = new Random().Next(0, 10);
    Console.Write(" " + numArray);

    if (i%2 == 1)
    {
     posiziya += numArray;
    }
}
Console.Write ("->" + posiziya);
Console.ReadKey();