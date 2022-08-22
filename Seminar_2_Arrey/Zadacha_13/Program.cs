// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write ("Введите число: ");
int numbers = Convert.ToInt32(Console.ReadLine());
string numbersText = Convert.ToString(numbers);

if (numbersText.Length > 2)
{
    Console.Write("Третья цифра числа: " + numbersText[2]);
}
else
{
    Console.WriteLine("Третьей цифры в этом числе нет.");
}