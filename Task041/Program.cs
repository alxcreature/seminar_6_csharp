/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

using System.Xml.XPath;

void FillArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());

    }
}

void PrintArray(int[] array)
{
    Console.Write($"{string.Join(", ", array)}");
}

int CheckGreaterThanZero(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++) if (array[i] > 0) result++;

    return result;

}

int M = new Random().Next(2, 10);
int[] myArray = new int[M];

FillArray(myArray);
PrintArray(myArray);
Console.WriteLine($" -> {CheckGreaterThanZero(myArray)}");