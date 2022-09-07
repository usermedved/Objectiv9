Console.WriteLine();
Console.Write("Введите число М: ");
int number_M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int number_N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int CountNaturalSum(int number_M, int number_N)
{
    if (number_M == number_N)
        return number_N;
    return number_N + CountNaturalSum(number_M, number_N - 1);
}
Console.WriteLine($"Сумма элементов от {number_M} до {number_N} = {CountNaturalSum(number_M, number_N)}");
