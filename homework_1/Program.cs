/*

//First task:

int a = new Random().Next(1, 10);
Console.WriteLine(a);
int b = new Random().Next(1, 10);
Console.WriteLine(b);

    if (a > b)
    {
        Console.WriteLine("первое число больше ");
    }
    if (a < b)
    {
        Console.WriteLine("второе число больше ");
    }
    if (a == b)
    {
        Console.WriteLine("числа равны ");
    }



//Second task:

Console.WriteLine("Нажмите Enter ");
Console.ReadLine();

int a = 10;
Console.Write(a + ",");
int b = 20;
Console.Write(b + ",");
int c = 30;
Console.WriteLine(c + " ");

Console.WriteLine("Вывести максимальное из трех чисел? ");

Console.ReadLine();

{
    if (a > b && a > c)
    {
        Console.WriteLine("ошибка ");
    }
    if (b > a && b > c)
    {
        Console.WriteLine("ошибка ");
    }
    if (c > a && c > b)
    {
        Console.WriteLine("30 - максимальное число ");
    }
}


//Third task:

int number1 = new Random().Next(1, 1000);
Console.WriteLine(number1);
Console.WriteLine("Нажмите Enter, чтобы узнать четное число или нет ");
Console.ReadLine();

int number2 = 2;
int div = (number1 / number2);
Console.WriteLine(div);

{
    if(div * number2 == number1)
    {
        Console.WriteLine("Число четное (делится на 2 без остатка) ");
    }
    else
    {
        Console.WriteLine("Число не четное ");
    }
}



//Task Fourth:

Console.WriteLine("Введите число ");

int a = Convert.ToInt32(Console.ReadLine());
int even = 2;

Console.WriteLine("Показать все четные числа? ");
Console.ReadLine();

while(even <= a)
{
    Console.Write(even + " ");
    even+=2;
}

*/