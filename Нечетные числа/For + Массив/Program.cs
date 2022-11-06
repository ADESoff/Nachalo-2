int a = (Convert.ToInt32(Console.ReadLine()));
int b = (Convert.ToInt32(Console.ReadLine()));
if (a % 2==0 && b % 2==0)
{
    int c = b - a;
    int f = c / 2;
    Console.WriteLine(f);
}
else
{
    int h = b - a;
    int g =  h / 2 + 1;
    Console.WriteLine(g);
}