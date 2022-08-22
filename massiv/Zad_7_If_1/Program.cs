// C1.2. Составить программу вывода любого числа любое заданное число раз 

Console.Write("Введите число вывода на экран: ");
int number = int.Parse (Console.ReadLine());

Console.Write("Введите количество раз вывода на экран: ");
int numberRaz = Convert.ToInt32(Console.ReadLine());
int index = 0;
while (index < numberRaz)
{
    Console.Write(number + " ");
    index ++;
}