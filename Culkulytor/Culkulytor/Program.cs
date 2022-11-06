Console.WriteLine("Введите первое число");
int p = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int v = Convert.ToInt32(Console.ReadLine());
int z;
do
{
Console.WriteLine("Введите цифру цифра-символ (1-*,2-/,3-,4-+)");
int o = Convert.ToInt32(Console.ReadLine());
    z = o;
    switch (z)
    {
        case 1: Console.WriteLine(p * v); break;
        case 2: Console.WriteLine(p / v); break;
        case 3: Console.WriteLine(p - v); break;
        case 4: Console.WriteLine(p + v); break;
    }
}
while (z <= 0 || z >= 5);