using System;

public class LAB1N2
{
    public int Abs(int x)
    {
        return x < 0 ? -x : x;
    }

    public bool Is35(int x)
    {
        return (x % 3 == 0 || x % 5 == 0) && !(x % 3 == 0 && x % 5 == 0);
    }

    public int Max3(int x, int y, int z)
    {
        return Math.Max(x, Math.Max(y, z));
    }

    public int Sum2(int x, int y)
    {
        int sum = x + y;
        return (sum >= 19 || sum <= 10) ? 20 : sum;
    }

    public string Day(int x)
    {
        switch (x)
        {
            case 1: return "Понедельник";
            case 2: return "Вторник";
            case 3: return "Среда";
            case 4: return "Четверг";
            case 5: return "Пятница";
            case 6: return "Суббота";
            case 7: return "Воскресенье";
            default: return "Это не день недели";
        }
    }
}
