
Console.Write ("Введите целое число: ");
int number = int.Parse (Console.ReadLine());

if (number % 2 == 0)
{
 Console.Write (("Число ") + number + (" делится на 2:"));
 Console.WriteLine (" остаток = " + (number % 2));
}
else
{
 Console.Write (("Число ") + number + (" не делится на 2:"));
 Console.WriteLine (" остаток = " + (number % 2));
}
