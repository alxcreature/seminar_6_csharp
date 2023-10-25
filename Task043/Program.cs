/* Задача 43. Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями y = k1 * x + 
b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются 
пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -
> (-0, 5; -0,5) */

void InputValue(ref double value, string nameValue = "")
{
    Console.Write($"Введите {nameValue}: ");
    value = Convert.ToDouble(Console.ReadLine());

}

double b1 = 0;
double b2 = 0;
double k1 = 0;
double k2 = 0;

InputValue(ref b1, "b1");
InputValue(ref b2, "b2");
InputValue(ref k1, "k1");
InputValue(ref k2, "k2");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

System.Console.WriteLine($"{x},{y}");