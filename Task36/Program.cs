/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

/*
АЛГОРИТМ
1. Метод ввода чисел с консоли
2. Метод инициализации массива
3. Метод печати массива
4. Метод суммы чисел с нечётными индексами в массиве
*/

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Введено не число.");
        }
    }

    return result;
}

int[] InitArray(int dimension, int rightBound, int leftBound)
{
    Random  rnd = new Random();
    int[] result = new int [dimension];

    for (int i = 0; i < dimension; i++)
    {
        result[i] = rnd.Next(leftBound, rightBound);
    }

    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int GetNumberOddIndex(int[] array)
{
    int sum = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 > 0)
        sum += array[i];
    }

    return sum;
}

int dimension = GetNumber("Введите размер массива:");
int rightBound = GetNumber("Введите правую границу массива: ");
int leftBound = GetNumber("Введите левую границу массива: ");

int[] arr = InitArray(dimension, rightBound, leftBound);

PrintArray(arr);

Console.WriteLine($"Сумма элементов массива c нечётными индексами = {GetNumberOddIndex(arr)}");