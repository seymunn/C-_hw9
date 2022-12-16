// Задача 68: 
//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите первое число:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberN = Convert.ToInt32(Console.ReadLine());

int Ackermann(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    else
    {
        if ((num1 != 0) && (num2 == 0))
        {
            return Ackermann(num1 -1, 1);
        }
        else return Ackermann(num1 - 1, Ackermann(num1, num2 -1));
    }
}
int result = Ackermann(numberM, numberN);
Console.WriteLine($"M = {numberM}, N = {numberN} -> A(m,n) = {result}");