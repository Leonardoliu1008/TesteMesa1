using System;

public static class Exercicio3
{
    public static void Run()
    {
        int a = 7;
        int b = a - 6;
        int[] v = new int[10];

        while (b < a)
        {
            v[b] = b + a;
            Console.WriteLine(v[b]);
            b += 2;
        }
    }
}
