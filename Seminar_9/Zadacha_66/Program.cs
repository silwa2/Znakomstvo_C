// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите число M: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int b = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int PrintFromMtoN(int a, int b)
{
if (a > b)
{
if (a == b) return a;
return sum = a + PrintFromMtoN(a - 1, b);
}
else
{
if (a == b) return a;
return sum = a + PrintFromMtoN(a + 1, b);
}
}
Console.Write(PrintFromMtoN(a,b));