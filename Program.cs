// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Hello, World!");
using System;
class Calculator
{
    static void Main()
    {
        double num1, num2, num3;
        string operation;
        double result;

        Console.WriteLine("Введите num1");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите операцию");
        operation = Console.ReadLine();

        Console.WriteLine("Введите num2");
        num2 = Convert.ToDouble(Console.ReadLine());



        switch (operation)
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine($"num1 + num2 = {result}");
                break;
            case "-":
                result = num1 - num2;
                Console.WriteLine($"num1 - num2 = {result}");
                break;
            case "*":
                result = num1 * num2;
                Console.WriteLine($"num1 * num2 = {result}");
                break;
            case "/":
                result = num1 / num2;
                Console.WriteLine($"num1 / num2 = {result}");
                break;
        } 
               
}
}
    

