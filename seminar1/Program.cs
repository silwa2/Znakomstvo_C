//Console.WriteLine("Введите число: ");
//int number = int.Parse(Console.ReadLine());

//Console.WriteLine(number*number);



//Console.WriteLine ("Введите число 1 ");
//int number1 = Console.ReadLine();
//Console.WriteLine ("Введите число 2 ");
//int number2 = Console.ReadLine();

//if (number1 == number2 * number2 )
//{
 //   Console.WriteLine("Является квадратом");
//}
//else
//{
//   Console.WriteLine("Не является квадратом"); 
//}

Console.WriteLine ("Введите число: ");
int numberDay = Convert.ToInt32(Console.ReadLine());

if (numberDay < 1 || numberDay > 7 )
{
    Console.WriteLine("ошибка");
}
  
if (numberDay == 1)
{
    Console.WriteLine("понедельник");
}
if (numberDay == 2)
{
    Console.WriteLine("вторник");
}
if (numberDay == 3)
{
    Console.WriteLine("среда");
}
if (numberDay == 4)
{
    Console.WriteLine("четверг");
}
if (numberDay == 5)
{
    Console.WriteLine("пятница");
}
if (numberDay == 6)
{
    Console.WriteLine("суббота");
}
if (numberDay == 7)
{
    Console.WriteLine("воскресенье");
}


