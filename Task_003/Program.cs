﻿// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
//4-->да
//-3-->нет
//7-->нет

Console.WriteLine("Введите целое число");
int Number = Convert.ToInt32(Console.ReadLine());

if(Number%2 == 0)

{
    System.Console.WriteLine(Number + " Является четным");
}

else

{
    System.Console.WriteLine(Number + " Не является четным");
}