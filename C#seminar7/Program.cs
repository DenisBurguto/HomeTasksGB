/*
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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] testArray = CreateRandom2dArray();
Show2DArray(testArray);

//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.

//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты
int[,] EvenItemToSquare(int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i += 2)
    {
        for (int j = 0; j < array.GetLength(1); j += 2)
        {
            array[i, j] = array[i, j] * array[i, j];
        }

    }
    return array;
}
EvenItemToSquare(testArray);
Show2DArray(testArray);

//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int SumOfMainDiagonal(int[,] array)
{
    int sum = 0;
    int rows = array.GetLength(0);
    int  columns  = array.GetLength(1);
    int border = rows > columns ? columns : rows; // less value needed
    for (int i = 0; i < border; i++)
        sum += array[i, i];
    return sum;

}

Console.WriteLine("The sum of 45 degree main diagonal is {0} " , SumOfMainDiagonal(testArray));

*/
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


//Task 50. Input - two numbers as possible  indexes [rows, columns] in 2d array, output the element value if it exists or  information or inform if it doesn't.
// for example:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> there is no element with such index in array




//Task 52. Create 2d array  m×n filled with random integer numbers. output the arithmetic average of each column.
//for example:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//arithmetic average of each column : 4,6; 5,6; 3,6; 3.