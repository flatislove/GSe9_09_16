//Задайте значения M и N. Напишите программу, которая выведет 
//все чётные натуральные числа//промежутке от M до N с помощью 
//рекурсии.

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

string NumbersRec(int a, int b)
{
    if (a <= b)
    {
        if (a % 2 == 0)
        {
            Console.Write(a + " ");
        }
        return NumbersRec(a + 1, b);
    }
    else return String.Empty;
}
Console.WriteLine(NumbersRec(ReadNumber("A(меньшее)"), ReadNumber("B(большее)")));