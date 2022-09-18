//Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.

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

int GCDNumbers(int a, int b)
{
    if (b == 0)
    {
        return a;
    }
    else return GCDNumbers(b, a % b);
}

Console.Clear();
Console.WriteLine("Нахождение НОД");
Console.WriteLine(GCDNumbers(ReadNumber("M"), ReadNumber("N")));