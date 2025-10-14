using System;

public class LAB1N3
{
    public string ListNums(int x)
    {
        string st = "";
        for (int i = x; i >= 0; i--)
        {
            st += i.ToString();
        }
        return st;
    }

    public string Chet(int x)
    {
        string st = "";
        for (int i = 0; i <= x; i += 2)
        {
            st += i.ToString();
        }
        return st;
    }

    public int NumLen(long x)
    {
        return Math.Abs(x).ToString().Length;
    }

    public void Square(int x)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write("*\t");
            }
            Console.WriteLine();
        }
    }

    public void RightTriangle(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            for (int j = 0; j < x - i; j++)
                Console.Write("\t");

            for (int j = 0; j < i; j++)
                Console.Write("*\t");

            Console.WriteLine();
        }
    }
}
