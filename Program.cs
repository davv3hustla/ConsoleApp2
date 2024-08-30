// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program begin");

        int sum = 0;

        // Loop för att beräkna summan
        for (int i = 0; i < 4; i++)
        {
            sum += i; // Lägg till värdet av i till summan
            Console.WriteLine($"i = {i}");
            Console.WriteLine($"sum = {sum}");

            // Särskilt meddelande när i = 2
            if (i == 2)
            {
                Console.WriteLine("We have now the magical sum of 3");
            }
        }
    }
}