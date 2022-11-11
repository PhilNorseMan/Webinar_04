/* Написать программу, принимающую на вход число и выдает количество цифр в числе*/

int GetCountOfNumberInN (int n)
{
    n = Math.Abs(n);
    int result = 0;
    do
    {
        n /= 10;
        result++;
    }
    while (n > 0);
    
    return result;
}

Console.WriteLine("Please, enter number:");
int number = int.Parse(Console.ReadLine()!);

int result = GetCountOfNumberInN(number);


Console.WriteLine("Sum of numbers is: " + result);