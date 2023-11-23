int n =Convert.ToInt32(Console.ReadLine());
int a = Convert.ToInt32(Console.ReadLine());
int k = 0;
while (a !=-1)
{
    a=Convert.ToInt32(Console.ReadLine());
    if (a ==1)
    {
        k += 1;
    }
}
if (k==n)
{ Console.WriteLine("NO"); }
else
{
    Console.WriteLine("YES");
}
