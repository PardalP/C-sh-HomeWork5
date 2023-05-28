Console.Clear();

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// void FillArray(int[] array){
//     for (int i =0; i<array.Length; i++){
//         array[i] = new Random().Next(100,1000);
//     }
// }

// int EvenNums(int[] numbers)
// {
//     int count = 0;

//     foreach (int number in numbers)
//     {
//         if (number % 2 == 0)
//         {
//             count++;
//         }
//     }

//     return count;
// }
// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//     {
//         Console.Write($"{item}, ");
//     }
// }

// int[] numbers = new int[4];
// FillArray(numbers);
// int evenCount = EvenNums(numbers);
// PrintArray(numbers);
// System.Console.WriteLine();

// Console.WriteLine($"Количество четных чисел: {evenCount}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-50, 100);
    }
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item}, ");
    }
}

static int SumNumbers(int[] numbers)
{
    int sum = 0;

    for (int i = 1; i < numbers.Length; i += 2) 
    {
        sum += numbers[i];
    }

    return sum;
}

int[] numbers = new int[6];
FillArray(numbers);
PrintArray(numbers);
System.Console.WriteLine();

int sum = SumNumbers(numbers);

Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");