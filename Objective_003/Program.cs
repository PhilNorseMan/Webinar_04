/* Написать программу, выводящую массив из 8 элементов, заполненный нулями и единицами в случайном порядке*/

void FillArray(int[] arr) 
{
    int length = arr.Length;
    int index = 0;
    while (index < length)
    {
        arr[index] = new Random().Next(0, 2); 
        index++; 
    }
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    int position = 0; 
    while (position < count)
    {
        Console.Write(arr[position] + " | "); 
        position++;         
    }
}

int[] array = new int[10];

FillArray(array);

PrintArray(array);

