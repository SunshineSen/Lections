// в массиве array из n элементов нвйти элемент массива равный find
int[] array = { 1, 2, 3, 4, 6, 8, 4, 15, 40 };

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{

    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}