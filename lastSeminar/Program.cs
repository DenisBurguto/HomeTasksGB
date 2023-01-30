// string 
/*
string[,] table = new string[7, 9];// 2 - string(row) 3-column
table[0, 2] = "word";

void PrintStringArray(string[,] table)
{
for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        Console.Write($"|{table[i, j]}| ");
    }
Console.WriteLine();
}
}
PrintStringArray(table);
*/
/*
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
         if(matrix[i,j]==0)   Console.Write($" ");
         else Console.Write($"*");
        }
        Console.WriteLine();
    }
}

int[,] pic = new int[,] {
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
      {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
       {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
       {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
        {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
        {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
         {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
          {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
           {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
           {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
             {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
              {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};
int[,] matrix = new int[2, 3];
//PrintArray(pic);

void FillImage(int idot, int jdot)
{
    if (pic[idot, jdot] == 0)
    {
        pic[idot, jdot] = 1;
        FillImage(idot - 1, jdot);
        FillImage(idot, jdot - 1);
        FillImage(idot + 1, jdot);
        FillImage(idot, jdot + 1);
    }
}
FillImage(13, 13);
PrintArray(pic);

*/

// Factorial. Recursion.
// 0!=1
//1!=1
//5! =5*4*3*2*1
/*
double Factorial(int n)
{
    if (n == 0 || n == 1) return 1;
    else return n * Factorial(n-1) ;
}
 
for(int i =0; i<17; i++) Console.WriteLine(Factorial(i));

// Fibonacci 1, 1, 2, 3, 5, 8 ...

*/
/*
int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 10; i++)
{ Console.WriteLine(Fibonacci(i)); }

void ShowNum(int num){
    
if(num >1) ShowNum(num-1);
 Console.Write( num + " ");
               
}
ShowNum(5);
*/
/*
int SumOfDigits(int num){
    if(num !=0) return SumOfDigits(num/10)+ num%10;
    else return 0;
}

/*
Console.Write(SumOfDigits(123));
/*
//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
void ShowNum(int m, int n)
{


    if (m > n)
    {
        Console.Write(m + " ");
        ShowNum(m - 1, n);

    }
    else if (n > m)
    {
        ShowNum(m, n - 1);
        Console.Write(n + " ");
    }
    else Console.Write(n + " ");

}

Console.WriteLine();
ShowNum(10, 15);
*/

//Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B( положительное и отрицательное).

double AtoBdegree(double a, int b)
{
    if (b > 0) return AtoBdegree(a, b - 1) * a;
    else if (b < 0) return AtoBdegree(a, b + 1) * (1 / a);
    else return 1;
}

Console.WriteLine(AtoBdegree(2, -3));