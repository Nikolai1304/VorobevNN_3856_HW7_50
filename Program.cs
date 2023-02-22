// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int numRows = SetNumber("Rows ");
int numColumns = SetNumber("Columns ");

int numMaxValue = SetNumber("Max number ");
int numMinValue = SetNumber("Min number ");

var matrix = GetMatrix(numRows, numColumns, numMinValue, numMaxValue);
Print(matrix);
IndexMatrix(matrix);

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int [,] GetMatrix (int rows, int columns, int min, int max)
{
    int [,] matrix = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix [i, l] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void Print(int [ , ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            System.Console.Write(matrix[i, l] + " ");
        }
        System.Console.WriteLine();
    }
}

void IndexMatrix(int[,]matrix)
{
    int indexk = SetNumber("строка");
    int indext = SetNumber("столбец");
    if (indexk>matrix.GetLength(0)||indext>matrix.GetLength(1))
    System.Console.WriteLine("Такого элемента в массиве нет");
    else
    {
        System.Console.WriteLine($"На указанной позиции стоит число {matrix[indexk, indext]}");
    }
}