/*
Задайте массив, заполненный случайными положительными
трехзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.
*/

// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int[] CreateArray(int size)
// {
//     return new int[size];
// }

// void FillArray(int[] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     array[i] = rnd.Next(min, max);
// }

// string PrintArray(int[] array)
// {
//     string res = String.Empty;
//     for  (int i = 0; i < array.Length; i++)
//         res +=array[i] + " ";
//         return res;
// }


// int CountEvenNumbers(int[] array)
// {
//     int res = 0;
//     for (int i = 0; i < array.Length; i++)
//     if (array[i] % 2 == 0) 
//     res++;
//     return res;
// }

// int size = InputNum("Enter array size: ");

// int[] myArray = CreateArray(size);
// FillArray(myArray, 100, 1000);
// string txt = PrintArray(myArray);
// Console.WriteLine(txt);
// int result = CountEvenNumbers(myArray);
// Console.WriteLine($"Count of even numbers in array: {result}");


/* 
Задайте одномерный массив, заполненный случайными 
числами. Найдите сумму элементов, стоящих на нечётных 
позициях.
*/

// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int[] CreateArray(int size)
// {
//     return new int[size];
// }

// void FillArray(int[] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     array[i] = rnd.Next(min, max);
// }

// string PrintArray(int[] array)
// {
//     string res = String.Empty;
//     for  (int i = 0; i < array.Length; i++)
//         res +=array[i] + " ";
//         return res;
// }

// int SumNumbers(int[] array)
// {
//     int res = 0;
//     for (int i = 0; i < array.Length; i=i+2)
//     res = res + array[i];
//     return res;
// }

// int size = InputNum("Enter array size: ");

// int[] myArray = CreateArray(size);

// int minSize = -100;
// int maxSize = 100;

// FillArray(myArray, minSize, maxSize);

// string txt = PrintArray(myArray);
// Console.WriteLine(txt);

// int result = SumNumbers(myArray);
// Console.WriteLine($"Summury of elements on not-even places: {result}");


/*
Задайте массив вещественных чисел. Найдите разницу 
между максимальным и минимальным элементов массива.
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new double[size];
}

void FillArray(double[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    Random rnd = new Random();
    double value = Random.Next(min, max + 1);
    array[i] = value;
}