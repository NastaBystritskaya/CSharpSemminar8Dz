/*

Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

*/

int[,] GetArray() {
    int[,] array = new int[3,4];
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
            System.Console.Write(array[j, i]); 
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] Sort(int[,] array) {
    
    for (int j = 0; j < array.GetLength(0); j++) {
        int[] temp = new int[array.GetLength(1)];
        for (int i = 0; i < array.GetLength(1); i++)
        {
            temp[i] = array[j, i];  
        }
        Array.Sort(temp);
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array[j, k] = temp[k];
        }
    }

    return array;
}

void Main() {
    int[,] arr = GetArray();
    PrintArray(arr);
    int[,] sorted = Sort(arr);
    PrintArray(sorted);
}

Main();