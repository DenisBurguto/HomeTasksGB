// Task 19. Input integer number. Check if number is palindrome or not


// Task 21. Input - coordinates of two dots in 3D space and find the distance between them. 

double DistanceXY(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)+ Math.Pow(z1 - z2, 2)), 2);
}

Console.WriteLine("Hi! Please input x1 coordinate ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Hi! Please input y1 coordinate ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Hi! Please input z1 coordinate ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Hi! Please input x2 coordinate ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Hi! Please input y2 coordinate ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Hi! Please input z2 coordinate ");
double z2 = Convert.ToDouble(Console.ReadLine());


Console.Write($"The distance between two dots is {DistanceXY(x1, y1, z1, x2, y2, z2)} ");


// Task 23. Input number N, output - cubs of all integer numbers between 1 and N
