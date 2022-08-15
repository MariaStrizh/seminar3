//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите число");
string X=Convert.ToString(Console.ReadLine());
int y=Convert.ToInt32(X);

char[] arr = X.ToCharArray();
Array.Reverse(arr);
X = new String(arr);
int a = Convert.ToInt32(X);
if (a==y)
{
Console.WriteLine ($"перевернули {a}");
}
else
{
    Console.WriteLine ("Не полином");
}