// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
NaturNumber(n);

void NaturNumber(int num)
{
    Console.Write($"{num} ");
    num = num -1;
    if (num > 0) NaturNumber(num);
}