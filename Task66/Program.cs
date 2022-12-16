//Задача 66: 
//Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N. Выполнить с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberN = Convert.ToInt32(Console.ReadLine());

void GetSumNaturalNum(int num1, int num2, int sum)
{
    if (num1 > num2)
    {
        sum += num1;
        GetSumNaturalNum(num1 - 1, num2, sum);
    }
    else if (num2 > num1)
    {
        sum += num1;
        GetSumNaturalNum(num1 + 1, num2, sum);
    }
    else Console.WriteLine(sum + num2);
}

Console.Write($"M = {numberM}; N = {numberN} -> ");
GetSumNaturalNum(numberM, numberN, 0);