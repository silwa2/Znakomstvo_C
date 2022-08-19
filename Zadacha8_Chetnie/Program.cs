
int number = 1;

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

while (number <= n)
{if (number % 2 == 0)
    {
        Console.Write(number);
        Console.Write(", ");
    }
        number = number + 1;
}

