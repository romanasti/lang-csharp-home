
/*

//Task 19

{
    int pal(int number)
    {
        int n1 = number % 10;
        int n2 = number % 100 / 10;
        int n3 = number / 100 % 10;
        int n4 = number / 1000 % 10;
        int n5 = number / 10000;
        int result = n1 * 10000 + n2 * 1000 + n3 * 100 + n2 * 10 + n5;
 
        return(result);
    }

    Console.WriteLine("Нажмите ввод ");
    Console.ReadLine();
    Console.WriteLine("Введите число из предложенных: 12821, 43567, 23432, 54645, 76321 ");
    int res = Convert.ToInt32(Console.ReadLine());
    Console.Write(pal(res));

    {
        if(pal(res) == res)
        {
            Console.WriteLine(" --> число является палиндромом ");
        }
        else
        {
            Console.WriteLine(" --> число не является палиндромом ");
        }
    }
}



//Task 21

double Getdistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double xDistance = x2 - x1;
    double yDistance = y2 - y1;
    double zDistance = z2 - z1;

    return Math.Sqrt(Math.Pow(xDistance, 2) + Math.Pow(yDistance, 2) + Math.Pow(zDistance,2));
}


double xA, yA, zA, xB, yB, zB;

Console.Write("Input X of point A: ");
xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y of point A: ");
yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Z of point A: ");
zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input X of point B: ");
xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y of point B: ");
yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Z of point B: ");
zB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Getdistance(xA,yA,zA,xB,yB,zB));



//Task 23


{   
    Console.WriteLine("Введите натуральное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int x = 0;

    while(x < number)
    {
        x++;
        double result = Math.Pow(x,3);
        Console.Write(result + " ");
    }
}

*/
