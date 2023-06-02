// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine()!);

if (i, (i + 1) == (i + 3), (i + 4)                                          // Почему i не существует?

    Console.WriteLine("да - число является полиндромом");

else
    Console.WriteLine("нет - число не является полиндромом");



// Первый вариант решения задачи

// using System;

// class Program
// {     static void Main(string[] args)
//     {
//         Console.Write("Введите пятизначное число: ");
//         int number = int.Parse(Console.ReadLine());

//         if (IsPalindrome(number))
//         {
//             Console.WriteLine("Число является палиндромом.");
//         }
//         else
//         {
//             Console.WriteLine("Число не является палиндромом.");
//         }
//     }
//     static bool IsPalindrome(int number)
//     {
//         string numberStr = number.ToString();

//         if (numberStr.Length != 5)
//         {
//             return false;
//         }

//         for (int i = 0; i < numberStr.Length / 2; i++)
//         {
//             if (numberStr[i] != numberStr[numberStr.Length - i - 1])
//             {
//                 return false;
//             }
//         }

//         return true;
//     }
// }



//  Второй вариант решения задачи

//  bool Palindrome(int number)
//     {
//         int Number = number;
//         int reversNumber = 0;

//         while (number > 0)
//         {
//             int remainder = number % 10;
//             reversNumber = reversNumber * 10 + remainder;
//             number = number / 10;
//         }

//         return Number == reversNumber;
//     }
//      Console.WriteLine("Введите число:");
//         int number = Convert.ToInt32(Console.ReadLine());

//         if (Palindrome(number))
//         {
//             Console.WriteLine("Число является палиндромом");
//         }
//         else
//         {
//             Console.WriteLine("Число не является палиндромом");
//         }