/* Задача 2:* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе, которые является делителями этого числа

452 -> 6
82 -> 2  ?
9012 -> 3  ?

*/

void SumNumber(int numberN)
{
    int Sum = 0;
    while (numberN > 0)
    {
        Sum += numberN % 10;
        numberN /= 10;
    }
    Console.WriteLine("Сумма цифр в числе: " + Sum);
}

int DivisionWithoutRemainder(int number)
{
    int k = 0;
    for (int i = 1; i <= number; i++)
    {
        if (number % i == 0)
        {
            Console.WriteLine("Число {0} делится без остатка на {1}", number, i);
            k++;
        }
    }
    return k;
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
SumNumber(n);
Console.WriteLine(n + " -> " + DivisionWithoutRemainder(n));