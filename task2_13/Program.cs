// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// // 645 -> 5

// // 78 -> третьей цифры нет

// // 32679 -> 6

Console.WriteLine("Write number:");
        int number = Convert.ToInt32(Console.ReadLine());
        string Number = Convert.ToString(number);
        
        if (Number.Length > 2)
        {
            Console.WriteLine("Third digit of this number is: " + Number[2]);
        }
        else 
        {
            Console.WriteLine("There is no third digit (!)");
        }