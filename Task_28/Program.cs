
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

int res = 1;
int start = 1;

while (start <= n)
{
    checked
    {
        res *= start; // res = res * start
        start++;
    }
}

Console.WriteLine(res);