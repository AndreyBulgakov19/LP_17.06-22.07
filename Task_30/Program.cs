// Задача 30: Напишите программу, которая выводит
// массив из 8 элементов, заполненный нулями и
// единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];
int[] array1 = {3, 5, 8, 8};

int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();


int index = 0;
var rnd = new Random();

while (index < array.Length)
{
    array[index] = int.Parse(Console.ReadLine());
    index++;
}

for (int i = 0; i < nums.Length; i++)
{
    if (i == 0) Console.Write("[");
    if (i < nums.Length - 1) Console.Write(nums[i] + ",");
    else Console.Write(nums[i] + "]");
}

