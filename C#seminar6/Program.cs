//Task 41: user should enter m numbers. return count of numbers >0. code without using array
//1, -7, 567, 89, 223-> 3

int CountPositiveInput(int totalInput)
{
    int count=0;
    for(int i =1; i <= totalInput; i++)
    {
        Console.Write("Please input your number " + i + ": ");
        if(Convert.ToInt32(Console.ReadLine())>0) count++; 
    }
    return count;
}

Console.Write("Hi! how many numbers you would like to enter? : ");
int totalInput = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"You've entered {CountPositiveInput(totalInput)} positive numbers");




//Task 43:  There are two lines y = k1 * x + b1, y = k2 * x + b2; return coordinates (x,y) of lines crossing.
// the values b1, k1, b2 and k2   you should ask from user.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)