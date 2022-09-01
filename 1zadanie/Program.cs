//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int DegreeOf()
{
    Console.WriteLine("Введите число A: ");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B: ");
    int B = Convert.ToInt32(Console.ReadLine());
    int Deg = 1;

    for(int i =1; i<=B; i++) Deg = Deg * A;
    return Deg;
}
Console.WriteLine(DegreeOf());
