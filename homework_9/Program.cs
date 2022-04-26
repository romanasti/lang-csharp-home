/*

//Task 2:

int[,] CreateTriangle (int size)
{
    int[,] triangle = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }
    for (int i = 2; i < size; i++)
    {
        for (int j = 1; j < i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
    return triangle;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <= array.GetLength(1) - i; j++)  Console.Write(" ");
        for (int k = 0; k <= i; k++)
        {
            Console.Write(" ");
            Console.Write(array[i,k]);
        }
        Console.WriteLine();
    }
}
PrintMatrix(CreateTriangle(5));

*/
