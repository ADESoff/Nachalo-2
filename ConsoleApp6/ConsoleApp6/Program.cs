int one = Convert.ToInt32(Console.ReadLine());
for (int r = 0; r < 101; r++)
{
    if (r == 50) 
    {      
        continue;
    }
    Console.WriteLine(r);
    if(r == 100)
    {
        int y = 50;
        Console.WriteLine(y + one);

    }
}       