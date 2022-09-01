// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int [N];

for(int i = 0; i <= N; i++)
{
    numbers[i] =  new Random(). Next(0, 100);
    if(i != N-1) Console.Write($"{numbers[i]}, ");
    else Console.Write($"{numbers[i]}    ");
}