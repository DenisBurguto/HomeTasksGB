
//Task10. Input - 3-digits int number and output second digit of this number
/*
int MiddleDig(int num)
{
    return (num % 100) / 10;
}

bool NumCorrect(int num)
{
    if (num / 100 != 0 && num / 1000 == 0)
        return true;
    else
        return false;

}

Console.Write("Welcome! Please input three-digits number ");
int number = Convert.ToInt32(Console.ReadLine());
if(NumCorrect(number)) Console.WriteLine($"The middle digit of the number is {MiddleDig(number)}");
else Console.Write("Wrong input ");
*/


// Task13. Input int number , output third digit ( from lett to right!!!) if it exist, or information "no such digit"
/*
int FindThirdDig(int num)
{
    int dig = 0;
    int testNum = num;
    while (testNum / 10 != 0)
    {
        testNum = testNum / 10;
        dig++;
    }
    while (dig - 3 >= 0)
    {
        num = num / 10;
        dig--;
    }
    return num % 10;
}


Console.Write("Welcome! Please input  number ");
int number = Convert.ToInt32(Console.ReadLine());
if (number / 100 != 0) Console.WriteLine($"The third digit of the number is {FindThirdDig(number)}");
else Console.Write("In the inputted number three is no third digit ");
*/

// Task15. input number corresponded to week day and output if this day is day off or not.
/*
bool DayOff(int num)
{
    if (num == 6 || num == 7) return true;
    else return false;
}
Console.Write("Welcome! Please input  week day number ");
int number = Convert.ToInt32(Console.ReadLine());
if (DayOff(number)) Console.WriteLine("This day is day off, enjoy it )");
else if (number >= 1 && number <= 5) Console.WriteLine("The inputted day is working");
else Console.Write("Wrong input ");

*/