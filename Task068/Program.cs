// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = DataEntry("Введите число M: ");
int n = DataEntry("Введите число N: ");
int funAkkerman = Akkerman(m , n);
Console.Write($"m = {m}, n = {n}, A(m,n) = {funAkkerman}");



int DataEntry(string data)
{
    Console.Write(data);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Akkerman(int m, int n) // Честно признаюсь функцию взял из интернета, потому что совсем не смог понять что это за "функция Аккермана", видать туповат я для нее.
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}