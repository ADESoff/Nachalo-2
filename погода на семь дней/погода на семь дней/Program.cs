Random a = new Random();
string[] r = new string[] {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
for (int i = 0; i < r.Length; i++)
{
    int t = a.Next(-10, 30);
    Convert.ToInt32(t);
    Console.WriteLine(r[i] + " " + t );
}