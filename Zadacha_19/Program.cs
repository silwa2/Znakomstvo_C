// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Вариант 1 серез случайное число
// Random number = new Random();
// int chislo = number.Next(9999, 100000);
// Console.WriteLine (chislo);
// string newchislo = Convert.ToString(chislo);
// if (newchislo[0]==newchislo[4] && newchislo[1]==newchislo[3])
// {
//     Console.WriteLine("Это число палиндром.");
// }
// else 
// {
//    Console.WriteLine("Это число не палиндром."); 
// }


// Вариант 2 через ввод числа пользователем

Console.WriteLine ("Введите пятизначное число: ");
string newchislo = Convert.ToString(Console.ReadLine());

if (newchislo[0]==newchislo[4] && newchislo[1]==newchislo[3])
{
    Console.WriteLine("Это число палиндром.");
}
else 
{
   Console.WriteLine("Это число не палиндром."); 
}

