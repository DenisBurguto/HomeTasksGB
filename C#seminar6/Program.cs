/*
//Task 41: user should enter m numbers. return count of numbers >0. code without using array
//1, -7, 567, 89, 223-> 3

int CountPositiveInput(int totalInput)
{
    int count = 0;
    for (int i = 1; i <= totalInput; i++)
    {
        Console.Write("Please input your number " + i + ": ");
        if (Convert.ToInt32(Console.ReadLine()) > 0) count++;
    }
    return count;
}

Console.Write("Hi! how many numbers you would like to enter? : ");
int totalInput = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"You've entered {CountPositiveInput(totalInput)} positive numbers");
*/
/*
//Task 43:  There are two lines y = k1 * x + b1, y = k2 * x + b2; return coordinates (x,y) of lines crossing.
// the values k1, b1,  k2 and b2   you should ask from user.
//k1 = 5 b1 = 2  k2 = 9 b2 = 4 -> (-0,5; -0,5)

double[] LinesCrossing(double k1, double b1, double k2, double b2)
{
    double[] cross = new double[2];
    cross[0] = (b2 - b1) / (k1 - k2);
    cross[1] = k1 * cross[0] + b1;
    return cross;
}

void DoubleArrayToConsole(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    Console.Write($"{array[array.Length - 1]}]");
    Console.WriteLine();
}

Console.WriteLine("Hi, please fill two functions describing lines in X,Y coordinates. y = k1 * x + b1, y = k2 * x + b2");

Console.Write("please input k1 coefficient: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("please input b1 coefficient: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("please input k2 coefficient: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("please input b2 coefficient: ");
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1 != k2)
{
    Console.Write("your lines are crossing at coordinates [X,Y]: ");
    DoubleArrayToConsole(LinesCrossing(k1, b1, k2, b2));
}
else if(b1 != b2) Console.WriteLine("your lines are parallel ");
else Console.WriteLine("your lines are just one line");
*/