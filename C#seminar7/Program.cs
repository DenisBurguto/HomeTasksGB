/*
//Task 47. Create 2d array  m×n filled with random double numbers.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

double[,] CreateRandom2dDoubleArray()
{
    Console.WriteLine("Please input array rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input array columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    
    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(-100, 100) +  new Random().NextDouble(); // double in range (-100, 100)
        }

    }
    Console.WriteLine();
    return array;
}

void Show2dDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write("{0:0.00 \t}", array[i, j]);

        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] doubleRandomArray = CreateRandom2dDoubleArray();
Show2dDoubleArray(doubleRandomArray);
*/

/*
//Task 50. Input - two numbers as possible  indexes [rows, columns] in 2d array, output the element value if it exists or  information or inform if it doesn't.
// for example:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> there is no element with such index in array

int[,] CreateFullRandom2dArray()
{
    int rows = new Random().Next(2, 15);
    int columns = new Random().Next(2, 15);

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(-10, 11);
        }

    }
    return array;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void ArrayGameGuessTest(int[,] array)
{
    Console.WriteLine(" Let's play the game. Please try to guess the  row index and column index of element in  random 2D array. You have 3 attempts");
    Console.WriteLine();
    int count = 0;
    while (count < 3)
    {
        Console.Write(" please quess the  row index: ");
        int i = Convert.ToInt32(Console.ReadLine());

        Console.Write(" please guess the column index: ");
        int j = Convert.ToInt32(Console.ReadLine());

        if (array.GetLength(0) > i && array.GetLength(1) > j)
        { Console.WriteLine($"Good! you got it! this is number {array[i, j]}"); Console.WriteLine(); }
        else
        { Console.WriteLine("Sorry, there is no such element in array, maybe next time you will be lucky!"); Console.WriteLine(); }
        count++;
    }
    Console.WriteLine("By the way, here is our array: "); Console.WriteLine();

    Show2DArray(array);

}

int[,] array2d = CreateFullRandom2dArray();
ArrayGameGuessTest(array2d);
*/

/*
//Task 52. Create 2d array  m×n filled with random integer numbers. output the arithmetic average of each column.
//for example:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//arithmetic average of each column : 4,6; 5,6; 3,6; 3.

int[,] CreateRandom2dArray()
{

    Console.WriteLine("Please input array rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input array columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input array minValue: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input array maxValue: ");
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

void DoubleArrayToConsole(double[] array)
{
    Console.WriteLine();
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    Console.Write($"{array[array.Length - 1]}]");
    Console.WriteLine();
}

double[] ArithmeticAvg2dArrayColumns(int[,] array)
{

    double[] result = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        result[j] = (double)sum / array.GetLength(0);

    }
    return result;
}

int[,] arrayTest = CreateRandom2dArray();
Console.WriteLine("Here is our array: ");
Show2DArray(arrayTest);
double[] arryaArith = ArithmeticAvg2dArrayColumns(arrayTest);
Console.WriteLine("Here is arithmetic average of each column of array above: ");
DoubleArrayToConsole(arryaArith);

*/


// 