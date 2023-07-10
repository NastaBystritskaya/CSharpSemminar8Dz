/*

Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/


int[,] GetArray() {
    int[,] array = new int[4,4];
    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            array[j, i] = new Random().Next(1, 11);
        }
    }
    return array;
}

void PrintArray(int[,] array) {
    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            System.Console.Write(array[j, i] + " "); 
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int lowSumRowIndex(int[,] array) {
    int lowSum = 0;
    int lowRowNum = 0;
    for (int j = 0; j < array.GetLength(0); j++) {
        int sum  = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            sum += array[j, i]; 
            if(j == 0) {
                lowSum = sum;
            }
        }
        if(lowSum > sum) {
            lowSum = sum;
            lowRowNum = j;
        }
    }

    return lowRowNum;
}

void Main() {
    int[,] arr = GetArray();
    PrintArray(arr);
    int low = lowSumRowIndex(arr);
    System.Console.WriteLine(low + 1);
}

Main();