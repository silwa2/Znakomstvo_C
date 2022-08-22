int x;
int y;
int z;
int a;
//Пользователь вводит 3-х значное число
Console.Write("Введите трёхзначное число,чтобы ни одна цифра не повторялась: ");
a = Convert.ToInt32(Console.ReadLine());
//Проверяем является ли введённое число трёхзначным
while ((a > 999) | (a < 100))
{
   Console.Write("Ошибка!Введите число от 100 до 999: ");
   a = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine();
}
z = a / 100;
x = (a / 10) % 10;
y = a % 10;
//Выводим ответы
Console.WriteLine($"Если переставить цифры, может получиться: {x}{y}{z}");
Console.WriteLine($"Если переставить цифры, может получиться: {x}{z}{y}");
Console.WriteLine($"Если переставить цифры, может получиться: {y}{x}{z}");
Console.WriteLine($"Если переставить цифры, может получиться: {y}{z}{x}");
Console.WriteLine($"Если переставить цифры, может получиться: {z}{x}{y}");
Console.WriteLine($"Если переставить цифры, может получиться: {z}{y}{x}");
Console.ReadKey();