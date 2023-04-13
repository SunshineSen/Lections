// max от 9 чисел
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

Console.Write("введите числа ");
int a1 = int.Parse(Console.ReadLine());
int a2 = int.Parse(Console.ReadLine());
int a3 = int.Parse(Console.ReadLine());
int a4 = int.Parse(Console.ReadLine());
int a5 = int.Parse(Console.ReadLine());
int a6 = int.Parse(Console.ReadLine());
int a7 = int.Parse(Console.ReadLine());
int a8 = int.Parse(Console.ReadLine());
int a9 = int.Parse(Console.ReadLine());

int max1 = Max(a1, a2, a3);
int max2 = Max(a4, a5, a6);
int max3 = Max(a7, a8, a9);
int max = Max(max1, max2, max3);

Console.WriteLine(max);
