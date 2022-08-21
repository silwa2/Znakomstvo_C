
Console.Write ("Введите сумму вклада: ");
Double summa = Convert.ToDouble (Console.ReadLine ());

if (summa < 100)
{
    summa = summa + (summa * 5 / 100);
    Console.Write ("Ваш вклад составит: " + summa);
}
else
{
    if (summa >= 100 && summa < 200)
    {
        summa = summa + (summa * 7 / 100);
        Console.Write ("Ваш вклад составит: " + summa);
    }
    else
    {
        summa = summa + (summa * 10 / 100);
        Console.Write ("Ваш вклад составит: " + summa);
    }
}