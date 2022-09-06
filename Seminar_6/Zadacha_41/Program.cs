// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите числа, нажмите <Enter>");
Console.WriteLine("После ввода последнего числа нажмите <Enter> <Ctrl+z> >");
string numbers= "";
int kol=0, num=0;
while(numbers != null)
{
    numbers = Console.ReadLine();
    num = Convert.ToInt32(numbers);
    if (num > 0)
    {
       kol++;
    }    
}
Console.WriteLine("Количество чисел больше 0 = {0}", kol);
Console.Write("Для продолжения нажмите любую клавишу >");
Console.Read();

