
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
/*

//Task 27: Input: number, output: sum of its digits.
//452 -> 11
//82 -> 10
//9012 -> 12

int SumOfDigits(int num)
{
    int result = 0, testNum = Math.Abs(num);
    while (testNum != 0)
    {
        result += testNum % 10;
        testNum /= 10;
    }
    return result;

}

Console.Write("Please input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int digitsSum = SumOfDigits(num);
Console.WriteLine($"The sum of the digits in entered number ({num}) is {digitsSum} ");
*/

/*

//Task 29: input: array length m and all array elements, output:  the array itself( to console as well)
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] GetArrayFromUser(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Please input array number with index {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ArrayToConsole(int[] array)
{
    Console.Write("Your array is [");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write($"{array[array.Length-1]}]");
    Console.WriteLine();
}

Console.Write("Please input array length ");
int length = Convert.ToInt32(Console.ReadLine());
int[] yourArray = GetArrayFromUser(length);
ArrayToConsole(yourArray);

*/

