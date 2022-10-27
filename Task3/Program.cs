/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
пример из 5 элементов:
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
получить все 8 чисел за одно нажатие Enter от пользователя.подсказка: использовать метод Split();
*/

Console.WriteLine("Введите 8 чисел: ");
string s = Console.ReadLine();
int count = 8;
string[] Array = s.Split(", ", count, StringSplitOptions.RemoveEmptyEntries);

Console.Write("[");
for(int i = 0; i < Array.Length; i++)
{
    if(i < Array.Length -1) Console.Write($"{Array[i]}, ");
    else Console.WriteLine($"{Array[i]}]");
}
