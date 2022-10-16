string[] arrayI = new string [4] { "333", "2", "world", ":-)" };

string[] arrayR = new string[arrayI.Length];


void ArrayStringLen(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if(arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

ArrayStringLen(arrayI, arrayR);
PrintArray(arrayI);
Console.WriteLine();
PrintArray(arrayR);
