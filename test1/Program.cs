// Не знаю что не так


Console.Clear();
Console.WriteLine("Введите любое целые числа через пробел(отрицательные и положительные)");
string[] st = (Console.ReadLine().Split(' '));
Console.WriteLine(string.Join("", st));
int arr = GetArrayFromString(st);
int pos = Positive(arr);
Console.WriteLine(arr);

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ");
    int[] res = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}
int Positive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
