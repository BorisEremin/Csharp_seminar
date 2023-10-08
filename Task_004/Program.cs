﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.
//5->2, 4
//8->2, 4, 6, 8

Console.WriteLine("Введите целое число");
int Number = Convert.ToInt32(Console.ReadLine());
int M = 2;

while(M <= Number)

{
    System.Console.WriteLine(M);
    M += 2;
}