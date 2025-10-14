using System;

public class LAB1N4
{
    public int FindFirst(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
                return i;
        }
        return -1;
    }

    public int MaxAbs(int[] arr)
    {
        int max = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (Math.Abs(arr[i]) > Math.Abs(max))
                max = arr[i];
        }
        return max;
    }

    public int[] Add(int[] arr, int[] ins, int pos)
    {
        if (pos < 0 || pos > arr.Length)
            throw new ArgumentException("Неверно указана позиция");

        int[] result = new int[arr.Length + ins.Length];

        for (int i = 0; i < pos; i++)
            result[i] = arr[i];

        for (int i = 0; i < ins.Length; i++)
            result[pos + i] = ins[i];

        for (int i = pos; i < arr.Length; i++)
            result[ins.Length + i] = arr[i];

        return result;
    }

    public int[] ReverseBack(int[] arr)
    {
        int[] result = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            result[i] = arr[arr.Length - 1 - i];
        }
        return result;
    }

    public int[] FindAll(int[] arr, int x)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
                count++;
        }

        int[] result = new int[count];
        int index = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
                result[index++] = i;
        }
        return result;
    }
}