/*

int[] TransferSystem(int[] dataAra, int[] infoAra)
{
    int[] resultArray = new int[infoAra.Length];
    int binPos = 0;
    for (int pos = 0; pos < infoAra.Length; pos++)
    {
        int num = 0,
            pow = 0;
        for (int i = infoAra[pos] - 1; i >= 0; i--)
        {
            num += dataAra[binPos + i] * (int)Math.Pow(2, pow);
            pow++;
        }
        binPos += infoAra[pos];
        resultArray[pos] = num;
    }
    return resultArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    Console.Write($"{array[i]} ");
    Console.WriteLine($"{array[array.Length - 1]}" +" }");
}
Console.Write("{ ");

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 }, info = { 2, 3, 3, 1 };
PrintArray(TransferSystem(data, info));

*/