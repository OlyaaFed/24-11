int a = int.Parse(Console.ReadLine());
bool b = true;
int c = 1;
for (int i = 1; i <= a; i++)
{
    string tmp = Console.ReadLine();
    if (i == Math.Pow(2, c))
    {
        if (tmp != "+")
        {
            b = false;
            break;
        }
        c++;
    }
}
if (b)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
