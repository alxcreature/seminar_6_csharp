/* Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

void Fib(int N){

    int [] fb = {0,1,2};
    System.Console.Write("0 1 ");
    for (int i=2; i<N; i++) {
        fb[2] = fb[0] + fb[1]; 
        System.Console.Write(fb[2] + " ");
        fb[0]=fb[1];
        fb[1]=fb[2];
        
        //System.Console.Write(fb[0] + " " + fb[1] + " ");
    }

}

System.Console.Write("Введите N: ");
int num = Convert.ToInt32(System.Console.ReadLine());
Fib(num);

/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8*/
/* void FibNums(int N)
{
    Console.Write("0 1 ");
    int num1 = 0;
    int num2 = 1;
    for (int i = 2; i < N; i++)
    {
        int result = num1 + num2;
        System.Console.Write(result + " ");
        num1 = num2;
        num2 = result;
    }
}

//===============
System.Console.WriteLine("Введите количество чисел Фибоначчи: ");
int N = Convert.ToInt32(Console.ReadLine());
FibNums(N); */