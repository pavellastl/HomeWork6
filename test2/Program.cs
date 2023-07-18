Console.Clear();
int[] GetArray(int size, int minvalue, int maxvalue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minvalue, maxvalue + 1);
    }
    return res;
}
int[] CopyArray(int[]array)
{
int[] arr = new int[array.Length];

for (int i = 0; i < array.Length; i++)
{
    
    arr[i] = array[i];
}
return arr;
}
int[] ar = GetArray(5, 0, 20);
Console.WriteLine(string.Join("", ar));
int[] copy = CopyArray(ar);
Console.WriteLine(string.Join("", copy));