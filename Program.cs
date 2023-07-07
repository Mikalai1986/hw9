/*//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}
void PrintNumbers(int start)
{
    if (start <= 0) return;
    Console.Write(start + " ");
    PrintNumbers(start-1);

}
int num = InputNum("Введите целое число N: ");
PrintNumbers(num);
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}
int SumNumbers(int M, int N)
{
    if (M > N) return 0;
    
    return M + SumNumbers(M+1, N);

}
int num1 = InputNum("Введите целое число M: ");
int num2 = InputNum("Введите целое число N: ");

int S = SumNumbers(num1, num2);
Console.WriteLine($"сумма чисел = {S}");
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}
int AccFunc(int M, int N)
{
    if (M == 0) return N + 1;
    else if (N == 0) return AccFunc(M - 1, 1);
    return AccFunc(M - 1, AccFunc(M, N - 1));

}
int num1 = InputNum("Введите целое положительное число m: ");
int num2 = InputNum("Введите целое положительное число n: ");

int S = AccFunc(num1, num2);
Console.WriteLine($"A({num1}, {num2}) = {S}");