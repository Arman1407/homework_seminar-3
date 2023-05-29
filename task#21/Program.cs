// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Clear();
Console.Write("Координату X(1): ");
double x1 = double.Parse(Console.ReadLine()!);
Console.Write("Координату Y(1): ");
double y1 = double.Parse(Console.ReadLine()!);
Console.Write("Координату Z(1): ");
double z1 = double.Parse(Console.ReadLine()!);
Console.Write("Координату X(2): ");
double x2 = double.Parse(Console.ReadLine()!);
Console.Write("Координату Y(2): ");
double y2 = double.Parse(Console.ReadLine()!);
Console.Write("Координату Z(2): ");
double z2 = double.Parse(Console.ReadLine()!);


double S = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние равно {Math.Round(S, 3)}");
