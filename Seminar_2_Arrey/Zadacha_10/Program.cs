// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа

// Первое решение
Console.Write("Введите трехзначное число: ");
int numbers = Convert.ToInt32(Console.ReadLine());

if (numbers > 99 && numbers < 1000)
{
    int number1 = (numbers % 100) / 10;
    Console.WriteLine(number1);
}
else
{
    Console.WriteLine ("Вы ввели неправильное число.");
}

//второе решение
// Fri:

// Console.Write("Введите трехзначное число: ");
// int numbers = Convert.ToInt32(Console.ReadLine());

// if (numbers > 99 && numbers < 1000)
// {
// string strNumbers = Convert.ToString(numbers);
// Console.WriteLine("Вторая цифра этого числа: " + strNumbers[1]);
// }
// else
// {
// Console.WriteLine ("Вы ввели неверное число, введите заного.");
// goto Fri;
// }