/*

// Task 10:

int second(int num)
{
    int n1 = num % 100;
    int n2 = n1 / 10;
    return n2;
}

int number = new Random().Next(100,1000);

Console.WriteLine(number);
Console.WriteLine("Показать вторую цифру? ");
Console.ReadLine();
Console.WriteLine(second(number));



//Task 13:

void third(int num)
{
    int a1 = num % 10;
    {
        if(num < 1000 && num > 100)
        Console.WriteLine("третья цифра --> " + a1);
    }    
    int b1 = num % 100;
    int b2 = b1 / 10;
    {
        if(num > 999 && num < 9999)
        Console.WriteLine("третья цифра --> " + b2);
    }    
    int c1 = num % 1000;
    int c2 = c1 / 100;
    {
        if(num > 9999)
        Console.WriteLine("третья цифра --> " + c2);
    }
    int d1 = num / 100;
    {
        if(num < 100)
        Console.WriteLine("третьей цифры нет ");
    }
}

Console.WriteLine("Введите число ");

int result = Convert.ToInt32(Console.ReadLine());

third(result);



//Task 15:

void week(int number)
{
    if(number >= 1 && number <= 5)
    {
        Console.WriteLine("рабочий день ");
    }
    else
    {
        Console.WriteLine("выходной день ");
    }
}

Console.WriteLine("Введите цифру, обозначающую день недели ");

int result = Convert.ToInt32(Console.ReadLine());

week(result);

*/