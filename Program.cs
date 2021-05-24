using System;

Inputfield();

void Inputfield()
{
    Console.Clear();

    int choice = opselection();

    if (choice == 0)
    {
        Console.Write("Goodbye!");
    }
    else
    {
        int firstnum = numberone();
        int secondnum = numbertwo();

        Caculator(choice, firstnum, secondnum);

    }
}

int opselection()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine(@"
Welcome to Calculatron 3000!
1) Add two numbers
2) Subtract two numbers
3) Multiply two numbers
4) Divide two numbers
0) Exit
    ");
        string pick = Console.ReadLine();

        if (int.TryParse(pick, out int firstchoice) && firstchoice >= 0 && firstchoice < 5)
        {
            return firstchoice;
        }
    }
}

int numberone()
{
    while (true)
    {
        Console.Write($"Please enter the first number: ");
        string first = Console.ReadLine();

        if (int.TryParse(first, out int firstchoice))
        {
            return firstchoice;
        }
    }
}

int numbertwo()
{
    while (true)
    {
        Console.Write($"Please enter the second number: ");
        string first = Console.ReadLine();

        if (int.TryParse(first, out int firstchoice))
        {
            return firstchoice;
        }
    }
}

void Caculator(int selection, int firstnum, int secondnum)
{

    if (selection == 1)
    {
        int result = firstnum + secondnum;
        Console.WriteLine($"The result of adding {firstnum} and {secondnum} is {result}.");
        System.Threading.Thread.Sleep(3000);
        Inputfield();
    }
    else if (selection == 2)
    {
        int result = firstnum - secondnum;
        Console.WriteLine($"The result of subtracting {firstnum} and {secondnum} is {result}.");
        System.Threading.Thread.Sleep(3000);
        Inputfield();
    }

    else if (selection == 2)
    {
        int result = firstnum * secondnum;
        Console.WriteLine($"The result of multiplying {firstnum} and {secondnum} is {result}.");
        System.Threading.Thread.Sleep(3000);
        Inputfield();
    }
    else
    {
        try
        {
            int test = firstnum / secondnum;
        }
        catch (System.FormatException)
        {
            Console.Write("Error dividing by 0");
            Inputfield();
        }
        int result = firstnum / secondnum;
        Console.WriteLine($"The result of dividing {firstnum} and {secondnum} is {result}.");
        System.Threading.Thread.Sleep(3000);
        Inputfield();
    }
}