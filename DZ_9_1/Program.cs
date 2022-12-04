// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string ListNto1(int a, int b)
{
if (a <= b) return ListNto1(a + 1, b) + $"{a} ";
else return String.Empty;
}

System.Console.WriteLine("Введите значение N:");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(ListNto1(1, N)); // 10 9 8 7 6 5 4 3 2 1   


