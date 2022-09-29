int ImputNumber()
{
    Console.WriteLine("Введите число:");
    return Convert.ToInt32(Console.ReadLine());
}

int number = ImputNumber();

int GetDigSumm(int number)
{
    int sum = 0;
    while (number / 10 > number % 10)
    {
        int num = (number / 10) % 10;
        sum = num + sum;
        number = number / 10;
        Console.WriteLine("[" + sum + "]" + "{" + number + "}");
    }
    return sum;
}

int FinalSumm(int number)
{
   int finalSum = GetDigSumm(number)+number%10;
   return finalSum;
}
Console.WriteLine("Сумма цифр в числе " + number + " равна: " + FinalSumm(number));