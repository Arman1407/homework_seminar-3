﻿// Сбор черники
// (Время: 1 сек. Память: 16 Мб Сложность: 17%)
// В фермерском хозяйстве в Карелии выращивают чернику. Она растет на круглой грядке, причем кусты высажены только по окружности. 
// Таким образом, у каждого куста есть ровно два соседних. Всего на грядке растет N кустов.

// Эти кусты обладают разной урожайностью, поэтому ко времени сбора на них выросло различное число ягод – на i-ом кусте выросло ai ягод.

// В этом фермерском хозяйстве внедрена система автоматического сбора черники. Эта система состоит из управляющего модуля и нескольких собирающих 
// модулей. Собирающий модуль за один заход, находясь непосредственно перед некоторым кустом, собирает ягоды с этого куста и с двух соседних с ним.

// Напишите программу для нахождения максимального числа ягод, которое может собрать за один заход собирающий модуль, находясь перед некоторым кустом
// заданной во входном файле грядки.

// Входные данные
// Первая строка входного файла INPUT.TXT содержит целое число N (3 ≤ N ≤ 1000) – количество кустов черники. Вторая строка содержит 
// N целых положительных чисел a1, a2, ..., aN – число ягод черники, растущее на соответствующем кусте. Все ai не превосходят 1000.

// Выходные данные
// В выходной файл OUTPUT.TXT выведите ответ на задачу.

// Примеры
// №	                INPUT.TXT	         OUTPUT.TXT
// 1	                  4
//                       1 2 3 4	             10

// 2	                  3
//                       1 2 3	                 6

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);              // 3 <= N <= 1000; Как указать этот интервал?
int[]array = new int[n];
for (int i = 0; i <= n; i++);
    array[i] = int.Parse(Console.ReadLine()!);                       

Console.WriteLine($"[{string.Join(", ", array)}]");  
int max_summa = 0;
for (int i = 0; i < array.Length; i++)                         // i <= 1000    Как указать этот предел?
{
    Console.WriteLine($"{i} {(i + 1) % n} {(i + 2) % n}");
    if (max_summa < array[i] + array[(i + 1) % n] + array[(i + 2) % n])
        max_summa = array[i] + array[(i + 1) % n] + array[(i + 2) % n];
}
Console.WriteLine(max_summa); 



/*
// Console.ReadLine()! = Console.Write($"{ i} ");
string number = Console.ReadLine(($"{i} "))!;        // Почему i не  существует?
int summa = 0;
for (int i = 0; i < number.Length; i++)
Console.WriteLine("Всего ягод: ");
summa = summa + Convert.ToInt32(number[i].ToString());
Console.WriteLine(summa);



Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);ad   
Console.WriteLine($"Сумма от 1 до {n}: {((n + 1) / 2.0) * n}");

Console.WriteLine($"Всего ягод: {i}");                // Почему i не  существует?
*/