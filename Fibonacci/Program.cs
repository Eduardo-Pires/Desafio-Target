using System;

class Program
{
    public static bool IsInFibonacci(int n)
    {
        int x = 1, y = 0, temp;

        while (x < n)
        {
            temp = x;
            x += y;
            y = temp;
        }

        return x == n;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Exercício 1: Esse número está na sequência de Fibonacci?");	
        Console.Write("Digite um número: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (IsInFibonacci(n))
        {
            Console.WriteLine("Sim, o número está na sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine("Não, o número não está na sequência de Fibonacci.");
        }
    }
}

