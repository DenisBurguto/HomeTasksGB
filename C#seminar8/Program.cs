/*
//Task 54:  Create 2d array. Output modified array with descending sorting of each row.
// for example, initial array:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//final array:
//7 4 2 1
//9 5 3 2
//8 4 4 2

int[,] CreateRandom2dArray()
{
    Console.Write("Please input array rows:  ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please input array columns:  ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please input array minValue:  ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please input array maxValue:  ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}
void Show2DArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void DescendingSort2dArrayRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int count = 0;
        while (count < array.GetLength(1) - 1)
        {
            for (int j = count; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j + 1] > array[i, count])
                {
                    int temp = array[i, count];
                    array[i, count] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
            }
            count++;
        }
    }
}
int[,]testArray = CreateRandom2dArray();
Console.WriteLine("Here is your initial array:");
Show2DArray(testArray);
DescendingSort2dArrayRows(testArray);
Console.WriteLine("Here is your  array after descending sorting of each row:");
Show2DArray(testArray);
 
 */


//Task 56: Create 2d array. Output the row with minimum sum of elements.
//for example, our array:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
// output row number 1 (not row index, but user friendly number )

int[,] CreateRandom2dArray()
{
    Console.Write("Please input array rows:  ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please input array columns:  ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please input array minValue:  ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please input array maxValue:  ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}
void Show2DArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int RowNumMinSum2dArray(int[,] array){
    

}






int[,]testArray = CreateRandom2dArray();
Console.WriteLine("Here is your initial array:");
Show2DArray(testArray);


//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18




//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)
//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07