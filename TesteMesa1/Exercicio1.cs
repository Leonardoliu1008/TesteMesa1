using System;

public static class Exercicio1
{
    public static void Run()
    {
        int a = 10;
        int b = 20;
        int c = (a + b) / 2;
        c = c - 40;

        int[] v = new int[10];
        v[3] = a + b + c;

        Console.WriteLine("A: " + a);
        Console.WriteLine("B: " + b);
        Console.WriteLine("C: " + c);
        Console.WriteLine("D: " + v[3]);
    }
}
