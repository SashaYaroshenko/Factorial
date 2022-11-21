using System;

public static class Kata
{
    public static int Factorial(int n)
    {
        if (n < 0 || n > 12)
        {
            throw new Exception("ArgumentOutOfRangeException");
        }
        return n * Factorial(n - 1);
    }
}