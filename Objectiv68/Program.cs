Console.WriteLine();
Console.Write("Введите неотрицательное число М: ");
int number_M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число N: ");
int number_N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if(number_M < 0 || number_N < 0) Console.Write("Ввели отрицательное число");

int AkkermanNumber(int num_M, int num_N)
{
    if (num_M == 0)
    return num_N + 1;
    if(num_M > 0 && num_N == 0)    
    return AkkermanNumber(num_M - 1, 1);
    else
    return AkkermanNumber(num_M - 1, AkkermanNumber(num_M, num_N - 1));
}
Console.WriteLine($"A({number_M}, {number_N}) = {AkkermanNumber(number_M, number_N)}");
