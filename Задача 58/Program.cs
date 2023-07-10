/*

Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3

Результирующая матрица будет:
18 20
15 18

*/


int[,] GetArray() {
    int[,] array = new int[2,2];
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

int[,] doMatrixMult(int[,] m1, int[,] m2) {
    int[,] res = new int[m1.GetLength(0), m2.GetLength(1)];
    for(int j = 0; j < res.GetLength(0); j++) {
        for (int i = 0; i < res.GetLength(1); i++)
        {
             for (int k = 0; k < m2.GetLength(1); k++)
            {
                res[j,i] += m1[j,k] * m2[k,i];
            }
        }
    }

    return res;
}

void Main() {
    //int[,] a = GetArray();
    int[,] a = 
    { 
        { 2 , 4 },
        { 3 , 2 } 
    };
    System.Console.WriteLine("Матрица 1:");
    PrintArray(a);

    //int[,] b = GetArray();

    int[,] b = 
    { 
        { 3 , 4 },
        { 3 , 3 } 
    };
    System.Console.WriteLine("Матрица 2:");
    PrintArray(b);

    int[,] c = doMatrixMult(a, b);
    System.Console.WriteLine("Результат:");
    PrintArray(c);
}

Main();