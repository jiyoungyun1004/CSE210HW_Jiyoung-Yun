using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        string firstName = "Bob";
        Console.WriteLine("Hello " + firstName);
        Console.Write($"Hello Bob");
        Console.Write("This is another line\n");

        //can also do this, more modern: Console.WriteLine($"Hello {firstName}");
        //same with ConsoleWrite($Hello Bob");
        // Console.Write("This is another line\n");

        // fav_color= input("What is your favorite color?") #python
        Console.Write("What is your favorite color? ");
        string favoriteColor = Console.ReadLine();
        Console.WriteLine($"{firstName}, your favorite color is {favoriteColor}.");

        Console.Write("How old are you? ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine($"{firstName}, you are {age} years old.");

        int a = 13;
        int b = 7;

        int c = a + b;

        Console.WriteLine($"c is {c}");
        Console.WriteLine($"a/b is {a / b}");
        Console.WriteLine($"{(double)a / b}");

        double x = 1.5;
        float y = 1.5f;

        bool isDone = false;

        if (isDone)
        {
            Console.WriteLine("All done.");
        }
        else
        {
            Console.WriteLine("Not done yet.");
        }
    }
}

 