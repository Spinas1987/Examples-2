﻿// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumOfDigits(int n) // 453 45 4 0
{
	if(n == 0) return 0;
	return n % 10 + SumOfDigits(n / 10); //453 45 4 
    // return 0 + 4 % 10 + 45 % 10 + 453 % 10 = 12

}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumOfDigits(number)); // 