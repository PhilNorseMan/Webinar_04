/*Написать программу, принимающую на вход число, и выдающую произведение чисел от 1 до указанного числа*/

// факториал

int FindFactorial (int num)
{
    int count = 0;
    int fact = 1;

    while (count < num)
    {
        count++;
        fact = fact * count;
    }

    return fact;
}

Console.WriteLine("Please, enter number:");
int number = int.Parse(Console.ReadLine()!);

int result = FindFactorial(number);

Console.WriteLine("Factorial for your number is: " + result);