// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= number; i++)
// {
//     sum += i;

//     if (i < number) Console.Write($"{i} + ");
//     else Console.Write($"{i} = ");
// }

//Console.WriteLine($"{sum}");

int Sum(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

int sum = Sum(number);
int sum1 = Sum(5);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sum}");
Console.WriteLine(sum1);

// int n = 12345; // 123.45
// int s = n / 100;
// Console.WriteLine(s);

// int n = 12345; // 12345 => 5
// int s = n % 10;
// Console.WriteLine(s);
