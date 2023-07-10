/*

Задача 60. ...Сформируйте трёхмерный массив из двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

*/

int[, ,] GetArray() {
    int[, ,] array = new int[2, 2, 2];
    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for(int k = 0; k < array.GetLength(2); k++) {
                array[j, i, k] = new Random().Next(10, 100);
            }
        }
    }
    return array;
}

void PrintArray(int[, ,] array) {
    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for(int k = 0; k < array.GetLength(2); k++) {
                System.Console.Write($"{array[j, i, k]} ({j}, {i}, {k}) "); 
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void Main() {
    int[, ,] array = GetArray();
    PrintArray(array);
}

Main();