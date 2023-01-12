/*
int GetSum(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i; //sum+=i
    }
    return sum;
}

Console.Write("Please input number > 1 ");
int num = Convert.ToInt32(Console.ReadLine());
int result = GetSum(num);
Console.WriteLine($" {GetSum(num)} ");

*/

//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.



//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*

int[] CreateRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;

}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }
    Console.WriteLine();
}

Console.Write("Please input array length ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input array minValue ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input array maxValue ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, minValue, maxValue);
ShowArray(newArray);
*/
/*
//task 25. input: two numbers (A и B) , output: A in a natural power B. Code without using internal Pow method.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


double MyPow(double num, int pow)
{
    double powRes = 1;
    for (int i = 1; i <= Math.Abs(pow); i++) // if without Math.Abs() - then should check if pow>=0 before using this method
        powRes *= num;
    return powRes;
}

Console.Write("Please input number A:  ");
double num = Convert.ToDouble(Console.ReadLine());
Console.Write("Please input power value B as natural number ");
int pow = Convert.ToInt32(Console.ReadLine());
//if (pow >= 0)
//{
double numPow = MyPow(num, pow);
Console.WriteLine($"The result of A ({num}) in natural B power ({Math.Abs(pow)}) is {numPow}  ");
//}
//else Console.WriteLine(" incorrect input, entered B is not natural ");

*/


