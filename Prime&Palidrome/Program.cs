using System;
using System.Collections.Generic;
using System.Net;

class Program
{
	static bool IsPrime(int number)
	{
		if (number <= 1)
		{
			return false;
		}
		if (number ==2)
		{
			return true;
		}
		if (number % 2 == 0 )
		{
			return false;
		}
		int sqrt = (int)Math.Sqrt(number);
		for (int i = 3; i <= sqrt; i+=2)
		{
			if (number%i==0)
			{
				return false;
			}

		}
		return true;
	}
	static bool Ispalindrom(int  number)
	{
		string numberstring = number.ToString();
		int L = 0;
		int R = numberstring.Length - 1;
		while (L<R)
		{
			if (numberstring[L] != numberstring[R])
			{
				return false;

			}
			L++;
			R--;
		}
		return true;
	}
	static void Main(string[] args)
	{
		Console.WriteLine("Please enter the initial number");
		int N = Convert.ToInt32(Convert.ToString(Console.ReadLine()));	

        Console.WriteLine("Please enter the last number");
		int M = Convert.ToInt32(Convert.ToString(Console.ReadLine()));

        Console.WriteLine("Prime numbers :");
        for (int i = N; i <= M; i++)
		{
            if (IsPrime(i))
			{
                Console.WriteLine(i);
            }
        }


        Console.WriteLine("Palindrome numbers :");
        for (int i = N; i <= M; i++)
		{
            if (Ispalindrom(i))
            {
                Console.WriteLine(i);

            }
        }
    }
}
