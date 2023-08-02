// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Enter the first number:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number:");
int number2 = Convert.ToInt32(Console.ReadLine());

void NumberIsValid() // Реализация функции проверки на негативное число.
{
    if (number1 < 1 || number2 < 1)
    {
        Console.WriteLine("Need to be a positive number.");
        Environment.Exit(0);
    }
}

NumberIsValid(); // Вызов функции проверки на негативное число.

int PrintNumber(int start, int end)
{
    if (start == end)
    {
        return start;
    }
    return (start + PrintNumber(start + 1, end));
}

Console.WriteLine(PrintNumber(number1, number2));