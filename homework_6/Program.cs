/*

//Task 1:

int method(int casual)
{
    int result = 0;
    for (int i = 1; i <= casual; i++)
    {
        Console.WriteLine($"Введите число {i} ");
        int n = Convert.ToInt32(Console.ReadLine());
        if(n > 0) result++;
    }
    Console.WriteLine($"Количество чисел больше нуля равно: {result} ");
    return result;
}

 Console.WriteLine("Введите желаемое количество чисел: ");
 int random = Convert.ToInt32(Console.ReadLine());
 method(random);



//Task 2:

void method(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0 || i == matrix.GetLength(0)-1) matrix[i, j] = 1;
            if (j == 0 || j == matrix.GetLength(1)-1) matrix[i, j] = 1;
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количестов строк: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] matr = new int[a,b];
method(matr);

*/
