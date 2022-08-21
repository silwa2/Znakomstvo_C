
Console.Write ("Введите сумму вклада: ");
Double summa = Convert.ToDouble (Console.ReadLine ());

if (summa < 100)
{
    summa = summa + (summa * 0.05);
    Console.Write ("Ваш вклад составит: " + summa);
}
else
{
    if (summa >= 100 && summa < 200)
    {
        summa = summa + (summa * 0.07);
    }
    else
    {
        summa = summa + (summa * 0.1);
    }
}
Console.Write ("Ваш вклад составит: " + summa);