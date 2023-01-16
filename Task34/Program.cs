/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

/*
АЛГОРИТМ

1. Метод получения чисел с консоли
2. Метод инициализации массива рандомом
3. Метод печати массива
4. Метод подсчёта чётных чисел в полученном массиве
*/

//Метод получения чисел с консоли
int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Введено не число. ");
        }
    }
    return result;
}

//Метод инициализации массива
int[] InitArray(int dimension, int rightBound, int leftBound)
{
    int[] result = new int[dimension];
    
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        result[i] = rnd.Next(leftBound, rightBound);
    }
    return result;
}

//Метод печати массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//Метод подсчёта чётных чисел в полученном массиве
int GetElemNumber(int[] array)
{
    int count = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0)
            count++;
    }
    return count;
}

int dimension = GetNumber("Введите размер массива: ");
int rightBound = GetNumber("Введите правую границу массива: ");
int leftBound = GetNumber("Введите левую границу массива: ");

int[] arr = InitArray(dimension, rightBound, leftBound);

PrintArray(arr);

int countEN = GetElemNumber(arr);

Console.WriteLine($"Число чётных чисел в массиве: {countEN} ");