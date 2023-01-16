/*
//Task 34: Create random array with three-digit positive numbers. Return the quantity of even numbers in array.
//[345, 897, 568, 234] -> 2
int[] CreateRandomThreeDigitArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
        array[i] = new Random().Next(100, 1000);
    return array;

}

void ArrayToConsole(int[] array)
{
    Console.Write("Your array is [");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    Console.Write($"{array[array.Length - 1]}]");
    Console.WriteLine();
}

int CountEvenInArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;
    return count;
}

Console.Write("Please input array length ");
int length = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomThreeDigitArray(length);
ArrayToConsole(newArray);

Console.WriteLine($"The total quantity of even numbers in array above is  {CountEvenInArray(newArray)} ");
*/


/*
//Task 36: Create random array. Return sum of all elements at odd positions (odd indexes) 
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int[] CreateRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;

}

void ArrayToConsole(int[] array)
{
    Console.Write("Your array is [");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    Console.Write($"{array[array.Length - 1]}]");
    Console.WriteLine();
}

int CountSumOddIndex(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;
}

Console.Write("Please input array length ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input array minValue ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input array maxValue ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, minValue, maxValue);
ArrayToConsole(newArray);
int res = CountSumOddIndex(newArray);
Console.WriteLine($"The sum of all numbers at odd position in array is {res} ");
*/
/*
//Task 38: Create random array filled with double numbers. Return the difference between max and min value of elements.
//[3 7 22 2 78] -> 76

double[] CreateRandomDoubleArray(int length, int minValue, int maxValue)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
        array[i] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
    return array;
}
void DoubleArrayToConsole(double[] array)
{
    Console.Write("Your array is [");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    Console.Write($"{array[array.Length - 1]}]");
    Console.WriteLine();
}

double MaxMinDif(double[] array)
{
    double max = array[0], min = array[0] ;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= max) max = array[i];
        else if(array[i]<=min) min = array[i];
    }
    return max - min;
}


Console.Write("Please input array length ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input array minValue ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input array maxValue ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[] newArray = CreateRandomDoubleArray(length, minValue, maxValue);
DoubleArrayToConsole(newArray);

Console.WriteLine($"The difference between Max and Min value in array is {MaxMinDif(newArray)} ");

*/
