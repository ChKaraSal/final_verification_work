Console.WriteLine ("Final Work: ");
string[] array1 = new string[4] {"1234", "1567", "-2", "computer sciense"};
string[] array2 = new string[array1.Length];

void GetArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}
GetArray(array1, array2);
PrintArray(array2);