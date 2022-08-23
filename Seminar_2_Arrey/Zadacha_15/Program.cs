//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите день недели: ");
int den = Convert.ToInt32(Console.ReadLine());

if (den > 0 && den < 8)
{
    if (den == 6 || den == 7)
    {
        Console.WriteLine("Этот день выходной");
    }
    else
    {
        Console.WriteLine("Этот день не выходной");
    }
}
else 
{
    Console.WriteLine("Это не день недели");
}

