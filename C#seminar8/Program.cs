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

/*

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

int RowNumMinSum2dArray(int[,] array)
{
    int rowMinSum = 0;
    int minSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];

        }
        if (i == 0) minSum = sum;
        if (sum < minSum)
        {
            minSum = sum;
            rowMinSum = i;
        }
    }
    return rowMinSum + 1; // from index into user friendly numeration
}

int[,] testArray = CreateRandom2dArray();
Console.WriteLine("Here is your initial array:");
Show2DArray(testArray);
Console.WriteLine($"I found the row number {RowNumMinSum2dArray(testArray)} has minimal sum of elements in it.");
*/
/*
//Task 58: Create two matrices (2d arrays) A and B. Output multiply of A and B ( A*B)
//For example, below two matrices:
//2 4 | 3 4
//3 2 | 3 3
//Result of multiply is:
//18 20
//15 18

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

int[,] MultiplyTwoMatrices(int[,] matrixA, int[,] matrixB)
{
    int[,] resultMultiply = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int j = 0; j < resultMultiply.GetLength(1); j++)
    {
        for (int i = 0; i < resultMultiply.GetLength(0); i++)
        {
            for (int i2 = 0, j2 = 0; i2 < matrixB.GetLength(0); i2++, j2++)

                resultMultiply[i, j] += matrixA[i, j2] * matrixB[i2, j];
        }
    }
    return resultMultiply;
}

Console.WriteLine("Let's create our first matrix");
int[,] matrixA = CreateRandom2dArray();
Console.WriteLine("Let's create our second matrix");
int[,] matrixB = CreateRandom2dArray();
Console.WriteLine("Here is your first matrix: ");
Show2DArray(matrixA);
Console.WriteLine("Here is your second matrix:");
Show2DArray(matrixB);

if (matrixA.GetLength(1)!= matrixB.GetLength(0)) 
    Console.WriteLine("It's impossible to multiply these matrices because columns quantity in A must be equal to rows quantity in B");
else
{
    Console.WriteLine("Good, let's try to multiply our matrices");
   int[,] resMultiply = MultiplyTwoMatrices(matrixA,matrixB);
   Console.WriteLine("Here is our final matrix: ");
   Show2DArray(resMultiply);
}
*/


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