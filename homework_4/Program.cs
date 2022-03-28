/*

//Task 1:

int degree(int A, int B)
{
    int value = 1;

    for (int i = 0; i < B; i++)
    {
        value *= A;
    }
    return value;
}

Console.Write("Введите натуральное число : ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень : ");
int power = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("{0} ^ {1} = {2}", number, power, degree(number, power));



//Task 2:

int amount(int numero)
{
    int sum = 0;
    while (numero > 0)
    {
        sum += numero % 10;
        numero = numero / 10;
    }
    return sum;
}

Console.Write("Введите натуральное число : ");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 0) Console.WriteLine("Вы ввели ненатуральное число ");
else Console.WriteLine("Сумма чисел = " + amount(number));




//Task 3:


void array()
{
    int[] numbers = new int[8] { 3, 12, 22, 34, 46, 57, 62, 11 };

    for (int i = 0; i < numbers.Length; i++) Console.Write(" {0} " ,numbers[i]);
}
array();

*/