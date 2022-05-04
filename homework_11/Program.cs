/*

int Transfer(string twin, int num = 0)
{
    int x = twin.Length;
    for (int i = 0; i < x; i++) num = num + Convert.ToInt32(Convert.ToString(twin[i]))* Convert.ToInt32(Math.Pow(2, (x-1-i)));
    return num;
}

int[] TransferSystem(int[] data, int[] info, int a = 0)
{
    int b = info[0];
    int[] transArray = new int[info.Length];
    for (int i = 0; i < info.Length; i++)
    {
        string twin = string.Empty;
        if(a >= data.Length) break;

        for (int j = a; j < b; j++)
        {
            if(b > data.Length) b = data.Length; 
            twin = twin + Convert.ToString(data[j]);
        }
        transArray[i] = Transfer(twin);
        if((i + 1) == info.Length) break;
        a = a + info[i];
        b = b + info[i+1];
    }
    Console.WriteLine("[{0}]", string.Join(", ",transArray));
    return transArray;
}


Console.WriteLine("Введите количество элементов массива data:");
int datalong = Convert.ToInt32(Console.ReadLine());
int[] data = new int[datalong];
Console.WriteLine("Заполните массив :");
for (int i = 0; i < datalong; i++) data[i] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("[{0}]", string.Join(", ", data));
Console.WriteLine("Введите количество элементов массива info:");
int infolong = Convert.ToInt32(Console.ReadLine());
int[] info = new int[infolong];
Console.WriteLine("Заполните массив:");
for (int j = 0; j < infolong; j++) info[j] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("[{0}]", string.Join(", ", info));
TransferSystem(data, info);

*/