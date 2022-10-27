/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/


// с этим кодом почему-то подчеркивается int в 58 строке с сообщением "обнаружен недостижимый код". Не смогла понять, почему.
// int GetNumber(string message)
// {
//     int userNumber;
//     while (true)
//     {
//         Console.Write(message);

//         if (int.TryParse(Console.ReadLine(), out int number))
//         {
//             userNumber = number;
//             break;
//         }
//         else
//         {
//             Console.WriteLine($"{number} не является числом, повторите ввод.");
//         }
//     }
//     return userNumber;

int GetNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int NumberLength(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SumDigits(int n, int length)
{
    int summ = 0;
    for (int i = 1; i <= length; i++)
    {
        summ += n % 10;
        n /= 10;
    }
    Console.WriteLine($"Сумма цифр в введенном числе равна {summ}");
}

int num = GetNumber("Введите число: ");

int length = NumberLength(num);
SumDigits(num, length);
