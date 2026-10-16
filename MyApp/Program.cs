using System;



class Program

{

    static void Main(string[] args)

    {

        GreetUser("User");
        Console.WriteLine("Ready to work!");
        Console.WriteLine("Welcome to our application!");

    }



    static void GreetUser(string name)

    {

        Console.WriteLine($"Hello, {name}!");

    }

}