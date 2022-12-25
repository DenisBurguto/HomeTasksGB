
// Task 19. Input integer number. Check if number is palindrome or not
bool Palindrome(long number)
{
    long testNum = number, mirrorNum = 0;
    while (testNum != 0)
    {
        mirrorNum = mirrorNum * 10 + testNum % 10;
        testNum = testNum / 10;
    }
    return mirrorNum == number;
}

Console.Write("Please input number ");
long num = Convert.ToInt64(Console.ReadLine());

if (Palindrome(num)) Console.Write("Amazing, it's palindrome! ");
else Console.Write("just number, not palindrome");


/*
// Task 21. Input - coordinates of two dots in 3D space and find the distance between them. 

double DistanceAB(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)+ Math.Pow(z1 - z2, 2)), 2);
}

Console.WriteLine("Hi! Please input x1 coordinate ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please input y1 coordinate ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please input z1 coordinate ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please input x2 coordinate ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please input y2 coordinate ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please input z2 coordinate ");
double z2 = Convert.ToDouble(Console.ReadLine());


Console.Write($"The distance between two dots is {DistanceAB(x1, y1, z1, x2, y2, z2)} ");
*/
/*
// Task 23. Input number N, output - cubs of all integer numbers between 1 and N

void CubsNums(int num)
{
    int count = 1;
    if (num >= count)
    {
        while (count <= num)
        {
            Console.Write(Math.Pow(count, 3) + " ");
            count++;
        }
    }
    else
    {
        while (count >= num)
        {
            Console.Write(Math.Pow(count, 3) + " ");
            count--;
        }
    }
}

Console.WriteLine("Hi! Please input number N ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write(" Cubs or all  integer numbers between 1 and inputted N are ");
CubsNums(num);
*/