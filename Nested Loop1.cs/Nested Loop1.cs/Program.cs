using System;

class Program
{
    public static void Nested1(int n)//user defined method

    {
        int Sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Sum = Sum + i;
        }
        Console.WriteLine(Sum); 
    }
     public static void Main(string[] args)
     { 
         int n;
         Console.WriteLine("Enter the limit");
         n=Convert.ToInt32(Console.ReadLine());
         Nested1(n);

     }
}


