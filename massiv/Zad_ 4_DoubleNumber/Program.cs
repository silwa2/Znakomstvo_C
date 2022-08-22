
Console.Write ("Введите двухзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int number1 = number / 10;
Console.WriteLine("Число десятков равно: " + number1);

int number2 = number % 10;
Console.WriteLine("Число единиц равно: " + number2);

Console.WriteLine("Их сумма равна: " + (number1 / number2));