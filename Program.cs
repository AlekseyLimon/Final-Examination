
void PrintArray(string[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]}   ");
    }
    Console.WriteLine();
}

string CreateArray(string[] OutputArray, int pos)
{
    if (pos < OutputArray.Length && OutputArray[pos].Length <= 3)
        return " " + OutputArray[pos] + CreateArray(OutputArray, pos + 1);
    else if (pos < OutputArray.Length && OutputArray[pos].Length > 3)
        return " " + CreateArray(OutputArray, pos + 1);
    else return "";
}

string[] array = { "hello_world", "2", "L0L", ":-)", "123", "^_^", "wiz" };

Console.Write("Input arrey: ");
PrintArray(array);
Console.WriteLine();
string solution = CreateArray(array, 0);
Console.WriteLine($"Output arrey: {solution}");
Console.WriteLine();