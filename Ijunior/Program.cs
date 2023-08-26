int[] numbers = new int[] { 1, 3, 5, 7, 11, 13, 17 };

Console.WriteLine("Квадраты чисел");
Console.WriteLine();
Console.WriteLine("Дан ряд чисел:");

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

//

Console.WriteLine();
Console.WriteLine("Квадраты этих чисел:");

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] *= numbers[i];
}

foreach (int num in numbers)
{
    Console.WriteLine(num);
}

//