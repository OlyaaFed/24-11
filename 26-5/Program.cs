double n=Convert.ToDouble(Console.ReadLine());
double m  = Convert.ToDouble(Console.ReadLine());
double k = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());

for (; n<m; n = n+1)
{
    k=Math.Pow(b+k,2);
}

Console.WriteLine(k);