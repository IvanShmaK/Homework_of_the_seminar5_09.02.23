//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int [] CreateNewArray(int size)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array [i] = new Random().Next(100, 1000);
    }
    return array;
}

void ShowArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int NumberOfEven(int [] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            result = result + 1;
    }
    return result;
}

Console.Write("Input count of elements of array: ");
int count = Convert.ToInt32(Console.ReadLine());

if (count > 0)
{
    int [] createdArray = CreateNewArray(count);
    ShowArray(createdArray);
    int res = NumberOfEven(createdArray);
    Console.Write($"The number of even elements in array is {res}");
}
else
    Console.Write("The number of elements in array must be greater than 0!");
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*
int [] CreateNewArray(int size, int minVal, int maxVal)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal + 1);
    }
    return array;
}

void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SumOfOdd(int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
            sum = sum + array[i];
    }
    return sum;
}

Console.Write("Input count of elements of array: ");
int sizeArray = Convert.ToInt32(Console.ReadLine()); 

if (sizeArray > 0)
{
    Console.Write("Input minimal possible value of array: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input maxmal possible value of array: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    if(maxValue > minValue)
    {
        int [] created_array = CreateNewArray(sizeArray, minValue, maxValue);
        ShowArray(created_array);
        int summa = SumOfOdd(created_array);
        Console.Write($"The summa of the elements in odd positions is {summa}");
    }
    else
        Console.Write("The maximal possible value of elements in array must be greater than minimal possible value!");
}
else
    Console.Write("The number of elements in array must be greater than 0!");
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. Math.Min Math.Max не использовать
//[3.0 7.1 22.5 2.7 78.8] -> 76.1
double[] CreateNewArray(int size, int minVal, int maxVal)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round((minVal + new Random().NextDouble() * (maxVal - minVal)), 1);
    }
    return array;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double DifferenceBetweenElements(double [] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }

    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }

    double res = max - min;
    return res;
}

Console.Write("Input count of elements of array: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

if (sizeArray > 0)
{
    Console.Write("Input minimal possible value of array: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input maxmal possible value of array: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    if (maxValue > minValue)
    {
        double[] created_array = CreateNewArray(sizeArray, minValue, maxValue);
        ShowArray(created_array);
        double result = Math.Round(DifferenceBetweenElements(created_array), 1);
        Console.Write($"The difference between the maximum and minimum array elements is {result}");
    }
    else
        Console.Write("The maximal possible value of elements in array must be greater than minimal possible value!");
}
else
    Console.Write("The number of elements in array must be greater than 0!");