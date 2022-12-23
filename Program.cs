// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] myArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(minValue, maxValue + 1);
//         // myArray[i] = new Random().Next(100, 999);
//     }
//     return myArray;
// }

// void ShowArray(int[] array)
// {
//     Console.WriteLine("Полученный массив ->:");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int findEven (int[] array)
// {
//     int count = 0;
//     for (int i=0; i<array.Length; i++)
//     {
//         if (array [i] % 2 == 0) count +=1;
//     }
//     return count;
// }


// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:");
// int max = Convert.ToInt32(Console.ReadLine());


// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);
// int result = findEven(newArray);
// Console.WriteLine($"количество чётных лементов массива= {result}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12, 13, 13, 13] -> 19
// [-4, -6, 89, 6] -> 0



int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return myArray;
}

void ShowArray(int[] array)
{
    Console.WriteLine("Полученный массив ->:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int findSum (int[] array)
{
    int summ = 0;
    for (int i=1; i<array.Length; i++)
    {
        summ = summ + array [i];
        i++;
    }
    return summ;
}


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение элемента массива:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива:");
int max = Convert.ToInt32(Console.ReadLine());


int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);
int result = findSum(newArray);
Console.WriteLine($"сумма элементов, стоящих на нечётных позициях = {result}");