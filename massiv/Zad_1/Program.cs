
Console.Write ("Введите первое число: ");
int number1 = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите второе число: ");
int number2 = Convert.ToInt32 (Console.ReadLine());

if (number1 > number2)
{
    Console.Write ("Большее число: " + number1);
}
else
{
    if (number2 > number1)
    {
        Console.Write ("Большее число: " + number2);
    }
    else
    {
     Console.Write ("Числа равны: " + number1);   
    }
}