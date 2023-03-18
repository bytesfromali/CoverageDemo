// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Calculator
{
    public Calculator(int number1, int number2)
    {
        Number1 = number1;
        Number2 = number2;
    }

    public int Number1 { get; }
    public int Number2 { get; }

    public int Sum() { return Number1 + Number2; }

    public int Minus() { return Number1 - Number2; }

    public float Division() { return Number1 / Number2; }
}
