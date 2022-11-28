// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Write 3-digit number:");
        int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
        string stringNumber = Convert.ToString(threeDigitNumber);
        Console.WriteLine("Second digit of this number is: "+stringNumber[1]);

    }
}