using System;
using System.Text;

public static class MyAlgorithms
{
    public static int ReverseInt(int x)
    {
        long result = 0;
        while (x != 0)
        {
            result = result * 10 + x % 10;
            x /= 10;
        }

        return (int)result;
    }

    public static string IntToRoman(int num)
    {
        int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        var result = new StringBuilder();
        for (int i = 0; i < values.Length; i++)
        {
            while (num >= values[i])
            {
                result.Append(symbols[i]);
                num -= values[i];
            }
        }

        return result.ToString();
    }

    public static long Factorial(int n)
    {
        long result = 1;
        for (int i = 1; i <= n; i++)
            result *= i;
        return result;
    }

    public static long Fibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        long a = 0, b = 1, fib = 0;
        for (int i = 2; i <= n; i++)
        {
            fib = a + b;
            a = b;
            b = fib;
        }
        return b;
    }

    public static bool IsPalindrome(long n)
    {
        if (n < 0) return false; //Обычно отрицательные числа не считаются палиндромами
        long original = n, rev = 0;
        while (n > 0)
        {
            rev = rev * 10 + n % 10;
            n /= 10;
        }
        return original == rev;
    }

    public static bool IsPrime(long n)
    {
        if (n <= 1) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;
        for (long i = 3; i * i <= n; i += 2)
            if (n % i == 0)
                return false;

        return true;
    }

    public static int SubstringIndex(string text, string sub)
    {
        int pos = text.IndexOf(sub);
        return pos != -1 ? pos + 1 : -1;
    }
 
    public static long SortDigits(long n)
    {
        char[] digits = n.ToString().ToCharArray();
        int length = digits.Length;
        for (int i = 0; i < length - 1; i++)
        {
            for (int j = 0; j < length - i - 1; j++)
            {
                if (digits[j] > digits[j + 1])
                {
                    char temp = digits[j];
                    digits[j] = digits[j + 1];
                    digits[j + 1] = temp;
                }
            }
        }
        string sortedStr = new string(digits);
        return long.Parse(sortedStr);
    }

}
