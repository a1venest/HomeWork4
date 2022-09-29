int ImputNumber()
{
    Console.WriteLine("Введите число 1:");
    return Convert.ToInt32(Console.ReadLine());
}

int ImputNumberTwo()
{
    Console.WriteLine("Введите число 2:");
    return Convert.ToInt32(Console.ReadLine());
}

int A = ImputNumber();

int Multi(int N)
{
    int multi = A;
    // for (double i = 1; i <= N; i++)
    // {
    //     //multi = Math.Pow(A,i);
    //     //Console.WriteLine(A + " в степени " + i + " равно: " + multi);
    // }
    int i = 1;
    while (i <= N)
    {
        
        multi = multi * A;
        i++;
    }

    return multi;
}


int N = ImputNumberTwo();
Console.WriteLine(Multi(N));
