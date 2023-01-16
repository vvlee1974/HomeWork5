/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

/*
АЛГОРИТМ
1. Метод получения  чисел
2. Метод инициализации массива
3. Метод печати массива
4. кортеж для определения max[i] и min[i] массива
*/

int GetIntNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Введено не число");
        }
    }

    return result;
}

int[] InitArray(int dimensin, int rightBound, int leftBound)
{
    int[] result = new int[dimensin];
    Random rnd = new Random();

    for (int i = 0; i < dimensin; i++)
    {
        result[i] = rnd.Next(leftBound, rightBound);
    }

    return result;
}

void PrintArray(int[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

(int, int) FindMinMaxNumber(int[] array)
{
    int min = array[0];
    int max = array[0];

    //int diff = max - min;

    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] >= max) 
            max = array[i];
        else if(array[i] <= min)
            min = array[i];
           
    }

    return (min, max);
}


int dimensin = GetIntNumber("Введите размерность массива: ");
int rightBound = GetIntNumber("Введите правую границу массива: ");
int leftBound = GetIntNumber("Введите левую границу массива: ");

int[] arr = InitArray(dimensin, rightBound, leftBound);

PrintArray(arr);

(int min, int max) =  FindMinMaxNumber(arr);

Console.WriteLine($"max = {max}, min = {min}");
Console.WriteLine($"max - min = {max - min}");