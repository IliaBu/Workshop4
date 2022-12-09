/* Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (Не использовать Math.Pow)

3, 5 -> 243 (3⁵)
2, 4 -> 16

*/

//-------------------------------------------------------вариант 1--------------------------------------------
int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");
ToDegree(numberA, numberB);

// Функция возведения в степень
void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(a + ", " + b + " -> " + result);
}

// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}




//-------------------------------------------------------вариант 2--------------------------------------------
/*
Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = numberA;

for (int i = 1; i < numberB; i++)
{
    result = result * numberA;
}
Console.WriteLine(numberA + ", " + numberB + " -> " + result);

*/