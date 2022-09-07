Console.WriteLine();
Console.Write("Введите натуральное число N: ");
int number_N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int number_M = 1;

int NaturalNumber(int num_M, int num_N)
{
    if (num_M == num_N)
        return num_N;
    else
        Console.Write($"{NaturalNumber(num_M, num_N - 1)}, ");
    return num_N;
}

Console.WriteLine(NaturalNumber(number_M, number_N));
