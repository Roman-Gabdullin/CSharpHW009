// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = DataEntry("Введите число M: ");
int n = DataEntry("Введите число N: ");
int result = SummNaturNumber(m , n);
Console.Write($"Сумма натуральных чисел от M до N = {result}");

int DataEntry(string data)
{
    Console.Write(data);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SummNaturNumber(int m, int n)
{
    int sum = 0;
    while (m >= n)
    {
        sum+= m;
        m--;
    }
    return sum;
}