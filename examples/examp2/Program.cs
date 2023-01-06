/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Задайте диапозон значений");
int start = Convert.ToInt32(Console.ReadLine());
int end = Convert.ToInt32(Console.ReadLine());
int Accumulate(int i, int k)
{
    if(i < k)
    {
        return i + Accumulate(i + 1, k);
    }
    return k;
}   
Console.WriteLine(Accumulate(start, end));
