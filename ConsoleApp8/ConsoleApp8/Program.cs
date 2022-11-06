int summa = Convert.ToInt32(Console.ReadLine());
if (summa > 200)
{
    Console.WriteLine(summa*1.1);
}
else
{
    if (100 < summa && summa < 200)
    {
        Console.WriteLine(summa * 1.07);
    }
    else
    {
        if (0 < summa && summa < 100)
        {
            Console.WriteLine(summa * 1.05);
        }
        else
        {
            Console.WriteLine("Ваша сумма меньше 1, вы не можете начислить процент.");
        }
    }
}