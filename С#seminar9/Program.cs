/*
//Task 64: input N as positive integer  number. Output all natural numbers between N and 1 in descending order using recursion.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ShowNumsDescending(int n)
{
    Console.Write(n + ", ");
    if (n > 1) ShowNumsDescending(n - 1);
}

int n = 0;
do
{
    Console.Write("Please input positive integer number N: ");
    bool pars = int.TryParse(Console.ReadLine(), out int i);
    if (pars != true || i <= 0) Console.WriteLine("Incorrect input");
    n = i;
}
while (n <= 0);
Console.WriteLine("Here all natural numbers between N and 1 in descending order:");
ShowNumsDescending(n);
Console.WriteLine();
*/

//Task 66: input M и N. output sum of all natural numbers  between M and N both included.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int GetSumBetweenNums(int m, int n)
{
    
}







int m = -1;
do
{
    Console.Write("Please input positive integer number M: ");
    bool pars = int.TryParse(Console.ReadLine(), out int i);
    if (pars != true || i < 0) Console.WriteLine("Incorrect input");
    m = i;
}
while (m < 0);

int n = -1;
do
{
    Console.Write("Please input positive integer number N: ");
    bool pars = int.TryParse(Console.ReadLine(), out int i);
    if (pars != true || i < 0) Console.WriteLine("Incorrect input");
    n = i;
}
while (n <0);


//Task 68: input positive numbers M and N. Using recursion output Akkerman's function.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29