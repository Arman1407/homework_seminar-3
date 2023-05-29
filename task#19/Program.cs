// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine());
// int i = 0;



// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// n = Math.Abs(n);   // указывает на отрицательные числа, можно ибез неё
// // if (n < 100)
// //     Console.WriteLine("Третьей цифры нет");
// else
// {
//     while (n > 999)   // т.к. 1000 четырехзначное исло
//     {
//         n /= 10;      //  цикл до тех пор пока число не станет трехзначным
//     }                 //  также можно: n = n / 10, убирает по 1 цифре от числа
// Console.WriteLine(n % 10);  // результат, показывает последнюю цифру
// }



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

Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine());
int i = 0;

while (i != 5)
{
    return false;
}

    if (i != i - 1)
    {
        Console.WriteLine("net");
        break; // Выход из цикла
    }
    else if (i == i + 1)   
    {
        
         Console.WriteLine("da");
    }
    i++;
    return true;



