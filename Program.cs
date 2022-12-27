void CurrentArray(string[] array1, string[] array2)
{
    int k = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[k] = array1[i];
        k++;
        }
    }
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}" + " ");
    }
}

//string[] array1 = new string[4] {"Hello", "2", "world", ":-)"};
//string[] array1 = new string[4] {"1234", "1567", "-2", "computer science"};
string[] array1 = new string[3] {"Russia", "Denmark", "Kazan"};
string[] array2 = new string[array1.Length];

CurrentArray(array1, array2);
Console.Write("[");
ShowArray(array1);
Console.Write("] -> [");
ShowArray(array2);
Console.Write("]");