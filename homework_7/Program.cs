/*
//Task 1:

void RealNumber(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix [i, j] = Math.Round(new Random().NextDouble(),1);
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int m = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[n, m];
RealNumber(numbers);



//Task 2:

void FillingElements(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("Введите номер строки, а затем номер столбца: ");
    int a1 = Convert.ToInt32(Console.ReadLine());
    int b1 = Convert.ToInt32(Console.ReadLine());
   
    int line = a1 - 1;
    int column = b1 - 1;
    if (line < matrix.GetLength(0) && column < matrix.GetLength(1) && line >= 0 && column >= 0)
    {
        Console.WriteLine($"В строке {line+1} , в {column+1} столбце находится элемент {matrix[line, column]}");
    }
        else Console.WriteLine("Такого элемента не существует ");

}

Console.WriteLine("Введите количество строк: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[a, b];
FillingElements(numbers);



//Task 3:


void FeelArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Нажмите ввод, чтобы расчитать среднее арифметическое всех столбцов ");
    Console.ReadLine();
}

void ArithMean(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        double arsum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            arsum = arsum + matr[j,i];
        }
        arsum = arsum / matr.GetLength(0);
        Console.WriteLine($"столбец {i+1} --> {arsum} " );
    }
}

Console.WriteLine("Введите количество строк: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[x,y];
FeelArray(numbers);
ArithMean(numbers);

*/