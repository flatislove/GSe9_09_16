//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int ReadNumber(string message)
{
    int number = 0;
    while (true)
    {
        Console.WriteLine("Введите число " + message);
        if (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Некорректный ввод");
        }
        else break;
    }
    return number;
}
int SumNumbers(int a, int b)
{
    if (a > b)
    {
        return 0;
    }
    else return b + SumNumbers(a, b - 1);
}

Console.Clear();
Console.WriteLine(SumNumbers(ReadNumber("M(меньшее)"), ReadNumber("N(большее)")));