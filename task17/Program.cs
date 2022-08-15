// Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine ("Ввердите координаты по X:");
int X=Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Ввердите координаты по Y:");
int Y=Convert.ToInt32(Console.ReadLine());

if (X>0 && Y>0)
{
    Console.WriteLine("Точка находится в 1 четверти");
}
else if (X<0 && Y>0)
{
    Console.WriteLine("Точка находится во 2 четверти");
}
else if (X<0 && Y<0)
{
    Console.WriteLine("Точка находится в 3 четверти");
}
else if (X>0 && Y<0)
{
    Console.WriteLine("Точка находится в 4 четверти");
}
else
{
    Console.WriteLine("Не можем определить в какой четверти");
}