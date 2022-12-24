// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int EnterNumber(string message) // Метод получения числа от пользователя из консоли
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int AkermanFunction(int m, int n) // Метод вычисления функции Аккермана с помощью рекурсии
{
    while (m != 0)  
    {
        if (n == 0) n = 1;
        else 
        {
            n = AkermanFunction(m, n - 1);
            m = m - 1;
        }
    } 
    return n + 1;
}

int m = EnterNumber("Введите число m: ");
int n = EnterNumber("Введите число n: ");
if (n >= 0 && m >= 0)
    Console.WriteLine(AkermanFunction(m, n));
else
    Console.WriteLine("N и M не должны быть отрицательными");
