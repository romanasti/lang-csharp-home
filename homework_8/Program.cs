/*

//Task 1:

void FeelArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 10);
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void ArrangeNumbers(int[,] matr)
{
    int tempo;
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1) -1; j++)
        {
            for (int k = j; k < matr.GetLength(1); k++)
            {
                if (matr[i,j] > matr[i,k])
                {
                    tempo = matr[i,j];
                    matr[i,j] = matr[i,k];
                    matr[i,k] = tempo;
                }
            }
            Console.Write(matr[i,j] + " ");
        }
        Console.Write(matr[i, (matr.GetLength(1)-1)] + " ");
        Console.WriteLine();
    }
}


Console.WriteLine("Введите количество строк: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[a, b];
FeelArray(numbers);
Console.WriteLine();
ArrangeNumbers(numbers);



//Task 2:

void FeelArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Нажмите ввод, чтобы посчитать сумму каждой строки ");
    Console.ReadLine();
}

void SumOfElements(int[,] matr)
{
    int min = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int summa = 0;
        for (int j = 0; j < matr.GetLength(1); j++) summa = summa + matr[i, j];
        if (summa < min || i == 0) min = summa;
        Console.WriteLine($"{summa} ");
    }
    Console.WriteLine($"Минимальная сумма элементов --> {min}");
    Console.WriteLine();
}

Console.WriteLine("Введите количество строк: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[a, b];
FeelArray(numbers);
Console.WriteLine();
SumOfElements(numbers);



// Task 3:

void ThreeDimArray(int [,,] matrix)
{
    int tmpry = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i,j,k] = tmpry; tmpry++;
            }
        }
    }
}

void ShowArray(int [,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine("Задайте размер трехмерного массива: x, y, z : ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());
int [,,] numbers = new int[x,y,z];
ThreeDimArray(numbers);
ShowArray(numbers);



//Task 4:

void FeelArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) Console.Write("{0,3} ", matrix[i, j]);
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SnailArray(int side)
{
    int[,] matr = new int[side, side];
    int number = 1, col = side, line = side, col1 = 0, line1 = 0;
    while (col1 < col)
    {
        for (int i = col1; i < col; i++)
        {
            matr[line1, i] = number++;
        }
        col--;
        for (int j = line1 + 1; j < line; j++)
        {
            matr[j, line - 1] = number++;
        }
        line--;
        for (int k = col - 1; k >= col1; k--)
        {
            matr[col, k] = number++;
        }
        for (int l = line - 1; l > line1; l--)
        {
            matr[l, col1] = number++;
        }
        col1++;
        line1++;
    }
    FeelArray(matr);
}

Console.WriteLine("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
SnailArray(a);

*/