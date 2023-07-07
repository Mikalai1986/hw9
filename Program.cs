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
*/
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