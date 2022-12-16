//Task2. Two integer numbers as input, comparison, max and min as output.
/*
Console.Write("Welcome! Please input first number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Thank you! Please input second number ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
    Console.Write($"My pleasure to inform you that {num1} is maximum and {num2} is minimum"); // {} we can miss here
else
    Console.Write($"My pleasure to inform you that {num2} is maximum and {num1} is minimum"); // {} we can miss here
*/


//Task4. Input- three integer numbers, max as output.
/*
Console.Write("Welcome! Please input first number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Thank you! Please input second number ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Finally, please input third number ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.Write($"My pleasure to inform you that {max} is maximum ");
*/
//Task4*. The same as above,but with Array, just to try 
/*
Console.WriteLine("Welcome! Please input three numbers separated with comma");
string inputNumbers = Console.ReadLine();
var num = inputNumbers.Split(',').Select(Int32.Parse).ToArray();
int max = num[0];

if (num[1] > max) max = num[1];
if (num[2] > max) max = num[2];

Console.Write($"My pleasure to inform you that maximum is {max}");
*/

//Task 6. Input integer number, output if it even or odd
/*
Console.Write("Welcome! Please input number ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) Console.Write("Inputted number is even");
else Console.Write("Inputted number is odd");
*/

//Task6. Input number n, output - all even numbers in range 1 to n
/*
Console.Write("Hello, please enter number ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 1)
{
    int evenNum = 2;
    while (evenNum <= num)
    {
        Console.Write(evenNum +" ");
        evenNum += 2;
    }
}
else if (num < 1)
{
    int evenNum = 0;
    while (evenNum >= num)
    {
     Console.Write(evenNum +" ");
    evenNum -= 2;
    }
}
else Console.Write("Hm, nice try");
*/