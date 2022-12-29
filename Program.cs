﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();

Console.WriteLine("Введите ваше пятизначное число.");
int inputNumber = int.Parse(Console.ReadLine()!);
int reverse = 0;
int c = 0;
int number = inputNumber;

if(number > 100000 || number < 9999)
{
    Console.WriteLine("Пятизначное, пожалуйста!");
}
else
{
    while (c < 5)
    {
    reverse = reverse*10;
    reverse = reverse + number%10;
    number = number/10;
    c++;
    }
    if (reverse == inputNumber)
    {
        Console.WriteLine("Число - палиндром.");
    }
    else
    {
        Console.WriteLine("Число не палиндром.");
    }
}