elka();
static void elka()
{
    string g;
    do
    {
        Console.WriteLine("Введите длинну строки ");
        int k = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение для Ёлочки");
        int e = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        for (int v = 0; v < k; v++)
        {

            for (int n = k - v; n <= k; n++)
            {
                Console.Write(e);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Хотите еще елочку?");
        Console.WriteLine("Введите да или нет");
        g = Console.ReadLine();
    } while (g == "да");
}
Console.WriteLine("Спасибо за ёлочку :)");