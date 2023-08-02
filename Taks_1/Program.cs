// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Enter the number:");
int number = Convert.ToInt32(Console.ReadLine());

void NumberIsValid() // Реализация функции проверки на негативное число.
{
    if (number < 1)
    {
        Console.WriteLine("Need to be a positive number.");
        Environment.Exit(0);
    }
}

NumberIsValid(); // Вызов функции проверки на негативное число.

string PrintNumbers(int num)
{
    if (num == 1)
    {
        return num.ToString();
    }
    return (num + " " + PrintNumbers(--num));
}

Console.WriteLine(PrintNumbers(number));