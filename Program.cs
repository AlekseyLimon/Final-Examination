
void PrintArray(string[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]}   ");
    }
    Console.WriteLine();
}