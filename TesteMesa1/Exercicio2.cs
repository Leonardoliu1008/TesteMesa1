using System;

public static class Exercicio2
{
    public static void Run()
    {
        int a = 2;
        int[] v = new int[10];

        while (a < 6)
        {
            v[a] = 10 * a;
            Console.WriteLine(v[a]);
            a += 1;
        }
    }
}
