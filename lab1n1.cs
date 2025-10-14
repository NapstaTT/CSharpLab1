using System;

public class LAB1N1
{
    public double Fraction(double x)
    {
        return x - (int)x;
    }

    public int CharToNum(char x)
    {
        return x - '0';
    }

    public bool Is2Digits(int x)
    {
        return x >= 10 && x <= 99;
    }

    public bool IsInRange(int a, int b, int num)
    {
        return (num >= Math.Min(a, b) && num <= Math.Max(a, b));
    }

    public bool IsEqual(int a, int b, int c)
    {
        return a == b && b == c;
    }
}