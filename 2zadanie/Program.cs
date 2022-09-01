// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumDigit()
{
    Console.WriteLine("Введите число: ");
    int A = Convert.ToInt32(Console.ReadLine());
    int Sum = 0;
    while(A>0)
    {
        Sum = Sum + A%10;
        A = A/10;
    }
    return Sum;
}
Console.WriteLine(SumDigit());