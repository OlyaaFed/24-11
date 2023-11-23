string[] a = Console.ReadLine().Split();
string[] b = Console.ReadLine().Split();
int kadr = int.Parse(a[0]);
int razr = int.Parse(a[1]) * int.Parse(a[2]);
int kadrlight = 0;
int kadrdark = 0;
for (int i = 0; i < b.Length; i++)
{
    int tmp = int.Parse(b[i]);
    if (tmp == 1 || tmp == 2)
    {
        kadrlight += 1;
    }
    else
    {
        kadrdark += 1;
    }
}
if (Math.Abs(kadrlight / razr - Math.Abs(kadrdark / razr)) > 0.2)
{
    if (kadrdark < kadrlight)
    { Console.WriteLine("засвечен");}
    else
    {
        Console.WriteLine("затемнен");
    }
}
else
{
    Console.WriteLine(" Фильм снят ");
}
