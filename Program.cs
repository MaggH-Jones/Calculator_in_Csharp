// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        int firstNumber;
        string choice;
        int newNumber;
        int replaceNumber;
        int answer;
        bool whenToEnd = false;

        Console.WriteLine("Type in your first number");
        firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What will you do now?\n.+\n.-\n.*\n./");
        choice = Console.ReadLine();
        if (choice == "+")
        {
            
        }
        else if (choice == "-")
        {
        }
        else if (choice == "*")
        {
        }
        else if (choice == "/")
        {
        }
        else
        {
            Console.WriteLine(firstNumber);
            Console.ReadKey();
            Environment.Exit(0);
        }

        Console.WriteLine("Will you add anouther number?");
        string quit = Console.ReadLine();
        if (quit == "yes")
        {
            whenToEnd = true;
        }

        while (whenToEnd != true)
        {
            
            Console.WriteLine("Type in your next number");
            newNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Will you add anouther number?");
            quit = Console.ReadLine();
            if (quit == "yes")
            {
                whenToEnd = true;
            }
        }

        Console.ReadKey();
    }
    public int plus(int num01, int num02)
    {
        int answer = num01 + num02;

        return answer;
    }
    public int minus(int num01, int num02)
    {
        int answer = num01 - num02;

        return answer;
    }
    public int gange(int num01, int num02)
    {
        int answer = num01 * num02;

        return answer;
    }
    public int divider(int num01, int num02)
    {
        int answer = num01 / num02;

        return answer;
    }
}