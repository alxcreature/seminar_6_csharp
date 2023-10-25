// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
        tempArray[i] = rand.Next(leftRange, rightRange + 1);

    return tempArray;
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void Reverse(int[] array)
{
    int temp = 0;

    for (int i = 0; i < array.Length / 2; i++)
    {
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

// -------------------------------

int[] myArray = GenerateArray(6, -5, 5);
PrintArray(myArray);
Reverse(myArray);
PrintArray(myArray);