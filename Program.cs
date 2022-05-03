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

        while (whenToEnd = true)
        {
            Console.WriteLine("Type in your next number");
            newNumber = Convert.ToInt32(Console.ReadLine());
        }

        Console.ReadKey();
    }
    public int cal(int num01, int num02)
    {
        int answer = 1;

        return answer;
    }
}