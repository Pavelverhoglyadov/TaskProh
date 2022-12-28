
string[] array = { "Hello", "2", "world", ":-)" };
int maxnum = 3;

string[] FillArray(string[] array)
{
    
    string[] result = new string[array.Length];
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxnum)
        {
            result[count] = array[i];
            count++;
        }
    }
    return result;
}

void PrintArray(string[] array)
{
    foreach (string el in array)
        Console.Write($"{el}  ");
    Console.WriteLine();
}

string[] NewArray = FillArray(array);
PrintArray(NewArray);