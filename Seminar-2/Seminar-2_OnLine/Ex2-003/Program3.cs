int[] arr = { 13, 8, 35, 546, 7568, 8, 6, 53, 86, 888 };

int n = arr.Length;
int find = 8;

int index = 0;

while (index < n)
{
    if (arr[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
