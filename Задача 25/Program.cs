﻿//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (без использования Math.Pow)
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите число A");
int a =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b =  Convert.ToInt32(Console.ReadLine());
int c = a;
for(int i = 2; i<=b;i++)
{
    a=c*a;
}    
Console.WriteLine(a);