// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int EnterNumber(string message) // Метод получения числа от пользователя из консоли
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int FindSumNumbersFromMtoN(int m, int n) // Метод вывода чисел от M до N
{
    if (m < n) return m + FindSumNumbersFromMtoN(m + 1, n);
    else return n;
}

int m = EnterNumber("Введите число M: ");
int n = EnterNumber("Введите число N: ");
if (n > m) Console.WriteLine(FindSumNumbersFromMtoN(m, n));
else Console.WriteLine("N должно быть больше M");
