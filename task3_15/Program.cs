// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Write number of a week day:");
int number = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int number)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("This is the day off");
    }
    else if (number < 1 || number > 7)
    {
        Console.WriteLine("This is not the day of the week");
    }
    else Console.WriteLine("This is the work day, not the day off");
}
CheckingTheDayOfTheWeek (number);
