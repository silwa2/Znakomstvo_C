// Задача 63: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int X = 1;

// string NaturalNum (int X,int N)
// {
// if(X<=N) return $"{X} "+ NaturalNum(X+1,N);
// else return string.Empty;
// }
// Console.WriteLine(NaturalNum(X,N));


// Задача 65: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


// string PrintFromMtoN(int a, int b)
// {
// if (a > b)
// {
// if (a == b) return Convert.ToString(a);
// return a + " " + PrintFromMtoN(a - 1, b);
// }
// else
// {
// if (a == b) return Convert.ToString(a);
// return a + " " + PrintFromMtoN(a + 1, b);
// }
// }
// Console.Write(PrintFromMtoN(1,5));



// вариант 2

// Console.WriteLine("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// string NaturalNum (int M,int N)
// {
// if(M<=N) return $"{M} "+ NaturalNum(M+1,N);
// else return string.Empty;
// }
// Console.WriteLine(NaturalNum(M,N));

// Задача 67: Напишите программу, 
// которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int SumNumber(int n)
// {
// if(n == 0) return 0;
// return (n % 10 + SumNumber(n/10));
// }


// Задача 69: Напишите программу, 
// которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int PowerNumber(int a,int n)
// {
// if(n == 0) return 1;
// return a * PowerNumber(a,n-1);
// }
// Console.WriteLine(PowerNumber(15,4));


// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29