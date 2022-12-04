// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumRec(int m, int n)
{
if (n < m+1) return m;
else return n + SumRec(m, n-1);
}

System.Console.WriteLine("Введите значение M:");
int M = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите значение N:");
int N = int.Parse(Console.ReadLine()!);


if (M < N)
{
   System.Console.Write($"Сумма натуральных чисел от {M} до {N} - ");
   Console.WriteLine(SumRec(M, N)); // 55  
}
else
{
   System.Console.Write($"Сумма натуральных чисел от {N} до {M} - ");
   Console.WriteLine(SumRec(N, M)); // 55  
}
  