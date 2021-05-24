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
    else if (choice == 5 || choice == 6)
    {
        int firstnum = singlenumber();
        int secondnum = firstnum;
        Caculator(choice, firstnum, secondnum);
    }
    else
    {
        int[] choices = twonumbers();
        

        Caculator(choice, choices[0], choices[1]);

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
5) Square of Number
6) Square Root of Number
0) Exit
    ");
        string pick = Console.ReadLine();

        if (int.TryParse(pick, out int firstchoice) && firstchoice >= 0 && firstchoice < 7)
        {
            return firstchoice;
        }
    }
}

int[] twonumbers()
{
    while (true)
    {
        Console.Write($"Please enter two numbers with a space in between:  ");
        string entry = Console.ReadLine();
        string[] numbers = entry.Split(' ');
        
        return Array.ConvertAll(numbers, int.Parse);
        

    }
}

int singlenumber()
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

    else if (selection == 3)
    {
        int result = firstnum * secondnum;
        Console.WriteLine($"The result of multiplying {firstnum} and {secondnum} is {result}.");
        System.Threading.Thread.Sleep(3000);
        Inputfield();
    }
    else if (selection == 5)
    {
     double result = Math.Sqrt(firstnum);
        Console.WriteLine($"The result of squaring {firstnum} is {result}.");
        System.Threading.Thread.Sleep(3000);
        Inputfield();   
    }
     else if (selection == 6)
    {
     int result = firstnum * secondnum;
        Console.WriteLine($"The square root of {firstnum} is {result}.");
        System.Threading.Thread.Sleep(3000);
        Inputfield();   
    }
    else
    {
        
        try
        {
            int test = firstnum / secondnum;
        }
        catch (System.DivideByZeroException)
        {
            Console.Write("Error dividing by 0");
            System.Threading.Thread.Sleep(3000);
            Inputfield();
        }
        int result = firstnum / secondnum;
        Console.WriteLine($"The result of dividing {firstnum} and {secondnum} is {result}.");
        System.Threading.Thread.Sleep(3000);
        Inputfield();
    }
}