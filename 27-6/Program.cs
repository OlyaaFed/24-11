int n = Convert.ToInt32(Console.ReadLine());
int summ = 0;

for (int i = 0; i < n; i++)
{
    int time = Convert.ToInt32(Console.ReadLine());
    summ += time;
}

Console.WriteLine(summ);
