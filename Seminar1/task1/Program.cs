﻿int numberA;
int numberB;

Console.WriteLine("Input numberA: ");
numberA = Convert.ToInt32( Console.ReadLine());

Console.WriteLine("Input numberB: ");
numberB = Convert.ToInt32( Console.ReadLine());
int max = numberA;

if (numberB > numberA)
{
    Console.WriteLine($" max numderB = {numberB} ");
}
else
{
    Console.WriteLine($" max numberA = {numberA} ");
}
