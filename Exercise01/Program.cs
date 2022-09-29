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

double A = ImputNumber();

double Multi(double N)
{
    double multi = 0;
    for (double i = 1; i <= N; i++)
    {
        multi = Math.Pow(A,i);
        Console.WriteLine(A + " в степени " + i + " равно: " + multi);
    }
    return multi;
}


double N =ImputNumberTwo();
Multi(N);
