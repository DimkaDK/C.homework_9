// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

int EnterNumber(string message) // Метод получения числа от пользователя из консоли
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

string PrintNumberFromNto1(int n) // Метод вывода чисел от N до 1
{
    if (n == 1) return "1";
    else return n + ", " + PrintNumberFromNto1(n - 1);
}

int n = EnterNumber("Введите число N: ");
Console.WriteLine(PrintNumberFromNto1(n));
