// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""



Console.Write("Введите число M: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int b = Convert.ToInt32(Console.ReadLine());

string PrintFromMtoN(int a, int b)
{
if (a > b)
{
if (a == b) return Convert.ToString(a);
return a + " " + PrintFromMtoN(a - 1, b);
}
else
{
if (a == b) return Convert.ToString(a);
return a + " " + PrintFromMtoN(a + 1, b);
}
}
Console.Write(PrintFromMtoN(a,b));