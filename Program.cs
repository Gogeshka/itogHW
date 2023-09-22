string[] arrayA = new string[5] {"111", "2222", "3", "44", "55555"};
string[] arrayB = new string[arrayA.Length];
void SArray(string[] arrayA, string[] arrayB)
{
    int count = 0;
    for (int i = 0; i < arrayA.Length; i++)
    {
    if(arrayA[i].Length <= 3)
        {
        arrayB[count] = arrayA[i];
        count++;
        }
    }
}
void PrA(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SArray(arrayA, arrayB);
PrA(arrayB);