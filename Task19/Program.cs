// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число");
string x = Console.ReadLine();
char[] arr = x.ToCharArray();
Array.Reverse(arr);
string x2 = new String(arr);

void Palindrom()
{
if (x == x2)
{
    Console.WriteLine(x + "->" + "Палиндром");
}
else
{
    Console.WriteLine(x + "->" + "Не палиндром");
}
}


Palindrom();
