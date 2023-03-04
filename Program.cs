//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void InputN (int max)
{
    if (max > 1) 
    {
        Console.Write(max + ", ");
        InputN(max - 1);
    }
    else 
        Console.WriteLine("1.");
    
}

Console.Write("Enter number N: ");
InputN(Convert.ToInt32(Console.ReadLine())); */

//Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int Sum(int m, int n)
{
    if(m == n)
        return m;
    return m + Sum(m + 1, n);
}
Console.Write("Input M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The sum of natural numbers from {numberM} to {numberN} is {Sum(numberM,numberN)}");
*/

//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

int m = InputInt("Input a number M:");
int n = InputInt("Input a number N:");
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}