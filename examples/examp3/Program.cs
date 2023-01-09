﻿/*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

Console.WriteLine("Даны два числа");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());

int Accerman(int n, int m)
{
    if(n == 0)
    {
       return m + 1;
    }
    if(m == 0)
    {
        return Accerman(n - 1, 1);
    }
    return Accerman(n - 1, Accerman(n, m - 1));
}
Console.WriteLine(Accerman(n, m));