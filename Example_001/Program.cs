/* Написать программу принимающую на вход число и выдающую сумму чисел от 1 до заданного числа */

int GetSumFrom1ToN (int n)
{
    int result = 0;
    int count = 0;

    while(count < n)
    {
        count++;
        result += count;
    }

    return result;
}

Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine()!);

int result = GetSumFrom1ToN(number);

Console.Write("Sum from 1 till your number is: ");
Console.WriteLine(result);
