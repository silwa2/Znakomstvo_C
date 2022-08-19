int a, b, max;

Console.Write("Введите первое чило: ");
a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
b = int.Parse(Console.ReadLine());

if(a > b)
{
    max = a;
}
else
{
    max = b;
}
Console.Write("Максимальное число: ");
Console.Write(max);
