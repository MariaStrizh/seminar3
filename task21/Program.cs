// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты по Х первой точки");
double X1=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты по Y первой точки");
double Y1=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты по Х второй точки");
double X2=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты по Y второй точки");
double Y2=Convert.ToDouble(Console.ReadLine());

double res=Math.Sqrt(Math.Pow(X1-X2,2)+Math.Pow(Y1-Y2,2));
Console.WriteLine($"{res:f2}");
