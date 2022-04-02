/*

//Task 1:

void method(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
    
    int counter = 0;
    for(int i = 0; i < array.Length; i ++)
    {
        if (array[i] % 2 == 0) counter ++;
    }
    if (counter > 0) Console.WriteLine($"Количество элементов массива, числа которого являются четными : {counter} ");
    else Console.WriteLine("В массиве нет элементов с четными числами ");
}
int[] arra = new int[4];
method(arra);



//Task 2:


void method(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10,31);
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
    int summa = 0;
    for (int i = 1; i < array.Length; i+=2) summa = summa + array[i];
    Console.WriteLine($"Сумма элементов нечетных позиций массива равна: {summa}" );
}
int[] arra = new int[6];
method(arra);



//Task 3:

void method(double[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,50);
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();

    double max = array[4];
    double min = array[4];

    for (int j = 0; j < array.Length; j++)
    {
        if(array[j] > max) max = array[j];
        if(array[j] < min) min = array[j];
    }
    double result = max - min;
    Console.WriteLine("Разница между максимальным и минимальным элементами массива равна " + result);
}
double[] arra = new double[5];
method(arra);

*/
