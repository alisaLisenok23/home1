/* Задание: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
// Решение:

Console.WriteLine ("введите число 1");
int a, b; 
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите число 2");
b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine( "max = " + a); 
}
else if (a < b)
{
    Console.WriteLine( "max = " + b);
} 
else if (a == b)
{
    Console.WriteLine("числа равны ");
}
*/
/*
 Задание: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/ 
 /*//Решение 
Console.WriteLine ("Максимальное число из 3\n Введите первое число");
int a,b,c;
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Ввод число2");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Ввод число 3");
c = Convert.ToInt32(Console.ReadLine());
if (a > b & a > c)
{
    Console.WriteLine("max = " + a);
}
else if (b > a & b > c)
{
  Console.WriteLine("max = " + b);
}
else if (c > b & c > a)
{
    Console.WriteLine("max = " + c);
}
else 
Console.WriteLine("числа равны");*/
/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
Решение:*/

Console.Write("Ввод числа ");
//int (number)
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.Write("четное число");
}
else {
    Console.Write("не четное число");
}