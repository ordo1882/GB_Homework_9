// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

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

int AckermannFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AckermannFunc(m - 1, 1);
    }
    else
    {
        return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
    }
}

Console.WriteLine(AckermannFunc(number1, number2));